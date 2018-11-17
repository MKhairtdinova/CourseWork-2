using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Threading;

namespace Информационная_система_v2
{
    static class InformationSystem
    {
        static Doctor DoctorSearch(string login, string password, DbSet<Doctor> source)
        {
            List<Doctor> doctorResult = (from doctor in source.AsParallel()
                where doctor.Login == login && doctor.Password == password
                select doctor).ToList();

            if (doctorResult.Count != 0)
            {
                return doctorResult[0];
            }
            else
                return null;
        }

        static Patient PatientSearch(string login, string password, DbSet<Patient> source)
        {

            List<Patient> patientResult = (from patient in source.AsParallel()
                where patient.Login == login && patient.Password == password
                select patient).ToList();


            if (patientResult.Count != 0)
            {
                return patientResult[0];
            }
            else
                return null;
        }

        static Administrator AdminSearch(string login, string password, DbSet<Administrator> source)
        {
            List<Administrator> adminResult = (from administrator in source.AsParallel()
                where administrator.Login == login && administrator.Password == password
                select administrator).ToList();

            if (adminResult.Count != 0)
            {
                return adminResult[0];
            }
            else return null;
        }

        public static bool CheckLoginPassword(string login, string password, out User.UserType userType, out User user)
        {
            userType = User.UserType.defaultType;
            user = null;
        //    EntityModelContainer container = new EntityModelContainer();

            #region OldSearch
                 char type;

                   try
                   {
                       type = login[0];
                   }
                   catch (Exception)
                   {
                       return false;
                   }

                   EntityModelContainer container = new EntityModelContainer();

                   if (type == 'P')
                       // поиск по пациентам
                   {
                       Patient result = PatientSearch(login, password, container.PatientSet);

                       if (result != null)
                       {
                           userType = User.UserType.patient;
                           user = result;
                           return true;
                       }
                   }

                   if (type == 'D')
                   {
                       Doctor result = DoctorSearch(login, password, container.DoctorSet);

                       if (result != null)
                       {
                           userType = User.UserType.doctor;
                           user = result;
                           return true;
                       }
                   }

                   if (type == 'A')
                   {
                       Administrator result = AdminSearch(login, password, container.AdministratorSet);

                       if (result != null)
                       {
                           userType = User.UserType.administrator;
                           user = result;
                           return true;
                       }
                   }

#endregion

            return false;
        }

        public static Patient CreatePatient(string name, DateTime birthDate, Male male, byte height, byte weight, Doctor doctor)
        {
            Patient newPatient = new Patient();
            newPatient.FullName = name;
            newPatient.BirthDate = birthDate;
            newPatient.Male = male;
            newPatient.Height = height;
            newPatient.Weight = weight;
            
            newPatient.Login = "none";
            newPatient.Password = "none";

            return newPatient;
        }

        public static Device CreateDevice(Patient owner, DeviceFunction function)
        {
            Device newDevice = new Device();

            newDevice.OwnerCode = owner.UserCode;
            newDevice.Function = function;

            return newDevice;
        }

        public static DoctorMessage CreatePatientMessage(Doctor sender,  Patient newPatient, bool allowAccess)
        {
            DoctorMessage message = new DoctorMessage();

            message.SenderCode = sender.UserCode;
            message.RecipientCode = 1;

            message.Text = "Зарегистрирован новый пациент " + newPatient.FullName +" с кодом " + newPatient.UserCode+".";

            if (allowAccess)
            {
                message.Text += " Требуется предоставление доступа.";
                message.Title = "Запрос доступа к системе";
            }
            else
                message.Title = "Зарегистрирован новый пациент";

            message.Checked = false;
            message.Date = DateTime.Now;

            return message;
        }

        public static void AddDoctorMessage(DoctorMessage message)
        {
            EntityModelContainer container = new EntityModelContainer();

            container.DoctorMessageSet.Add(message);

            DoctorMessage m = container.DoctorMessageSet.Find(message.Id);
            m.Administrator = container.AdministratorSet.Find(m.RecipientCode);
            m.Doctor = container.DoctorSet.Find(m.SenderCode);

            Administrator recipient = container.AdministratorSet.Find(m.RecipientCode);
            recipient.Message.Add(m);

            container.SaveChanges();
        }

        public static void AddPatient(Patient newPatient, Doctor doctor)
        {
            EntityModelContainer container = new EntityModelContainer();

            container.PatientSet.Add(newPatient);
            container.SaveChanges();

            AddDoctorPatientConnection(doctor, newPatient);
        }

        public static void AddDevice(Device newDevice, Patient owner)
        {
            EntityModelContainer container = new EntityModelContainer();

            container.DeviceSet.Add(newDevice);
       //     container.SaveChanges();

            // создание связей между сущностями
            owner = container.PatientSet.Find(owner.UserCode);
            newDevice = container.DeviceSet.Find(newDevice.DeviceCode);

            owner.Device.Add(newDevice);
            newDevice.Patient = owner;

            container.SaveChanges();
        }

        public static void AddDoctorPatientConnection(Doctor doctor, Patient patient)
        {
            EntityModelContainer container = new EntityModelContainer();

            patient = container.PatientSet.Find(patient.UserCode);
            doctor = container.DoctorSet.Find(doctor.UserCode);

            doctor.Patient.Add(patient);
            patient.Doctor.Add(doctor);

            container.SaveChanges();
        }

        public static void GiveLoginPassword(string message, out string login, out string password, out bool exist)
        {
            login = string.Empty;
            password = string.Empty;
            exist = false;

            string messagePattern =
                @"Зарегистрирован\sновый\sпациент\s([\w,\s]*)\sс\sкодом\s([\d]*)\.\sТребуется\sпредоставление\sдоступа\.";

            string[] info = Regex.Split(message, messagePattern);

            EntityModelContainer container = new EntityModelContainer();
            Patient patient = container.PatientSet.Find(int.Parse(info[2]));

            if (patient.Login != "none")
            {
                exist = true;
            }
            else
            {
                login = GetLogin(info[1]);
                password = GetPassword(info[1]);

                patient.Login = login;
                patient.Password = password;
                container.SaveChanges();
            }
        }

        static string GetLogin(string fullName)
        {
            string login = string.Empty;

            string[] nameParts = fullName.Split();

            string surname = nameParts[0];

            login = ConverToEng(surname);

            EntityModelContainer container = new EntityModelContainer();

            int existCount = 0;
            int addCode = -1;
            login = "Pat" + login;
            string newLogin = login;

            do
            {
                addCode++;
                if (addCode != 0)
                {
                    newLogin = login + "_" + addCode;
                }

                existCount = (from p in container.PatientSet where p.Login == newLogin select p).Count();
            } while (existCount != 0);

            return newLogin;
        }

        static string GetPassword(string fullName)
        {
            string[] nameParts = fullName.Split();

            return ConverToEng(nameParts[0]) + "1234";
        }

        static string ConverToEng(string text)
        {
            string rusAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            string[] engParser =
            {
                "a", "b", "v", "g", "d", "e", "yo", "zh", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u",
                "f", "h", "c", "ch", "sh", "shch", "'", "y", "", "e", "yu", "ya"
            };

            string result = string.Empty;

            foreach (char symbol in text)
            {
                // меняем заглавную
                if (symbol >= 'А' && symbol <= 'Я')
                {
                    char newSymbol = char.Parse(symbol.ToString().ToLower());

                    string newPart = engParser[rusAlphabet.IndexOf(newSymbol)];
                    char first = newPart[0];
                    newPart = newPart.Remove(0, 1);
                    newPart = first.ToString().ToUpper() + newPart;
                    result += newPart;
                }
                else
                {
                    result += engParser[rusAlphabet.IndexOf(symbol)];
                }
            }

            return result;
        }
        
        public static void AddHealthStatus(string info, DateTime creatingTime, Patient owner)
        {
            HealthStatus status = new HealthStatus();
            
            status.Status = string.Empty;
            status.CreatingTime = creatingTime;                         // задание времени создания

          //  status.Number = GetHealthStatusCode();

            // задание связи
            EntityModelContainer container = new EntityModelContainer();
            owner = container.PatientSet.Find(owner.UserCode);      
            status.Patient = owner;

            container.HealthStatusSet.Add(status);                      // добавление в базу данных
            container.SaveChanges();
            
            status = container.HealthStatusSet.Find(status.Number);

            status.Status = info;

            // задание связи с пациентом
            owner.HealthStatus.Add(status);
            int code = owner.UserCode;
            status.OwnerCode = code;

            container.SaveChanges();
        }

    /*    static int GetHealthStatusCode()
        {
            int statusCode = 0;
            bool hasStatus = false;
            EntityModelContainer container = new EntityModelContainer();

            do
            {
                statusCode++;
                HealthStatus exist = container.HealthStatusSet.Find(statusCode);

                hasStatus = (exist != null);
            } while (hasStatus);

            return statusCode;
        }*/

        public static MeasuredData CreateMeasure(Device device, Patient owner)
        {
            string measure = string.Empty;

            switch (device.Function)
            {
                case DeviceFunction.Glucometer:
                    double prevLevel;

                    GetPreviousSugarLevel(device, out prevLevel);
                    measure = MeasureGenerator.BloodSugarLevelGenerator(prevLevel);
                    break;

                case DeviceFunction.HeartRateMonitor:
                    int prevRate;
                    GetPreviousPulse(device, out prevRate);

                    measure = MeasureGenerator.HeartRateGenerator(prevRate);
                    break;

                case DeviceFunction.BloodPressureMonitor:
                    int prevHigh;
                    int prevLow;

                    GetPreviousPressure(device, out prevHigh, out prevLow);

                    measure = MeasureGenerator.BloodPressureGenerator(prevHigh, prevLow);
                    break;
            }

            MeasuredData data = new MeasuredData();

            data.Value = measure;
            data.CreatingTime = DateTime.Now;
            data.DeviceCode = device.DeviceCode;
            data.OwnerCode = owner.UserCode;
          //  data.Number = GetMeasuredDataCode();

            return data;
        }
        
        public static void AddMeasuredData(MeasuredData data, Patient owner, Device device)
        {
            EntityModelContainer container = new EntityModelContainer();

            container.MeasuredDataSet.Add(data);
         //   container.SaveChanges();

            owner = container.PatientSet.Find(owner.UserCode);
            data = container.MeasuredDataSet.Find(data.Number);
            device = container.DeviceSet.Find(device.DeviceCode);

            owner.MeasuredData.Add(data);
            data.Patient = owner;

            container.SaveChanges();
        }

        public static void WorkAllDevices()
        {
            Random rnd = new Random();

            do
            {
                Thread.Sleep(180000);

                EntityModelContainer container = new EntityModelContainer();

                foreach (Device device in container.DeviceSet)
                {
                    int choice = rnd.Next(0, 50);

                    if (choice != 49)
                    {
                        MeasuredData newData = CreateMeasure(device, device.Patient);
                        AddMeasuredData(newData, device.Patient, device);
                    }
                    else
                    {
                        DeviceMessage message = CreateDeviceMessage(device);
                        AddDeviceMessage(message);
                    } 
                        
                }
            } while (true);
        }

        static void GetPreviousPressure(Device device, out int high, out int low)
        {
            high = 0;
            low = 0;

            EntityModelContainer container = new EntityModelContainer();
            Patient owner = container.PatientSet.Find(device.OwnerCode);

            List<MeasuredData> list = (from data in owner.MeasuredData
                    where data.DeviceCode == device.DeviceCode
                    select data)
                .ToList();

            if (list.Count != 0)
            {
                MeasuredData last = list.Max();

                string measurePattern = @"([\d]+)\s/\s([\d]+)";

                string[] values = Regex.Split(last.Value, measurePattern);
                high = int.Parse(values[1]);
                low = int.Parse(values[2]);
            }
        }

        static void GetPreviousPulse(Device device, out int rate)
        {
            rate = 0;

            EntityModelContainer container = new EntityModelContainer();
            Patient owner = container.PatientSet.Find(device.OwnerCode);

            List<MeasuredData> list = (from data in owner.MeasuredData
                    where data.DeviceCode == device.DeviceCode
                    select data)
                .ToList();

            if (list.Count != 0)
            {
                MeasuredData last = list.Max();

                string measurePattern = @"([\d]+) уд/мин.";

                string[] value = Regex.Split(last.Value, measurePattern);

                rate = int.Parse(value[1]);
            }
        }

        static void GetPreviousSugarLevel(Device device, out double level)
        {
            level = 0;

            EntityModelContainer container = new EntityModelContainer();
            Patient owner = container.PatientSet.Find(device.OwnerCode);

            List<MeasuredData> list = (from data in owner.MeasuredData
                    where data.DeviceCode == device.DeviceCode
                    select data)
                .ToList();

            if (list.Count != 0)
            {
                MeasuredData last = list.Max();

                string measurePattern = @"([\d|,]+) ммоль/л.";

                string[] value = Regex.Split(last.Value, measurePattern);

                level = double.Parse(value[1]);
            }
        }

        static DeviceMessage CreateDeviceMessage(Device sender)
        {
            DeviceMessage message = new DeviceMessage();

            message.SenderCode = sender.DeviceCode;
            message.RecipientCode = 1;
            message.Title = "Ошибка записи измерения";
            message.Text = "Не удалось произвести сохранение измерения";
            message.Date = DateTime.Now;

            return message;
        }

        static void AddDeviceMessage(DeviceMessage message)
        {
            EntityModelContainer container = new EntityModelContainer();

            container.DeviceMessageSet.Add(message);

            DeviceMessage m = container.DeviceMessageSet.Find(message.Id);
            m.Administrator = container.AdministratorSet.Find(m.RecipientCode);
            m.Device = container.DeviceSet.Find(m.SenderCode);

            Administrator recipient = container.AdministratorSet.Find(m.RecipientCode);
            recipient.DeviceMessage.Add(m);

            container.SaveChanges();
        }

        public static void DeleteHealthStatus(HealthStatus status)
        {
            EntityModelContainer container = new EntityModelContainer();

            Patient owner = container.PatientSet.Find(status.OwnerCode);
            
            owner.HealthStatus.Remove(status);          // удаление связей
            container.HealthStatusSet.Remove(status);   // удаление сущности

            container.SaveChanges();
        }

        public static void ChangeHealthStatus(HealthStatus status, string newValue)
        {
            EntityModelContainer container = new EntityModelContainer();

            status = container.HealthStatusSet.Find(status.Number);
            status.Status = newValue;               // меняем значение

            container.Entry(status).State = EntityState.Modified;
            container.SaveChanges();                // сохранение изменений
        }
    }
}
