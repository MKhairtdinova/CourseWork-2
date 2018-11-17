using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Информационная_система_v2
{
    public partial class NewPatientForm : Form
    {
        private bool weightValidated;
        private bool heightValidated;
        private bool hasName;
        private bool hasMale;
        private EntityModelContainer _container;
        public Doctor user;

        public NewPatientForm()
        {
            InitializeComponent();
        }

        private void NewName_TextChanged(object sender, EventArgs e)
        {
            if (NewName.Text != string.Empty)
            {
                string text = NewName.Text;

                int i = 0;

                do
                {
                    if (!(text[i] >= 'А' && text[i] <= 'Я' || text[i] >= 'а' && text[i] <= 'я' || text[i] == ' '))
                        text = text.Remove(i, 1);
                    else
                        i++;
                } while (i < text.Length && i != 0);

                NewName.Text = text;
            }

            hasName = NewName.Text != string.Empty;

            SignUp.Enabled = hasName && hasMale &&  weightValidated && heightValidated && (NewDeviceType.SelectedIndex != -1);
        }

        private void NewPatient_Load(object sender, EventArgs e)
        {
        //    dateBirthValidated = false;
            weightValidated = false;
            heightValidated = false;
            hasName = false;
            hasMale = false;

            _container = new EntityModelContainer();
        }

        private void NewWeight_Validated(object sender, EventArgs e)
        {
            weightValidated = NewWeight.Text != string.Empty;

            SignUp.Enabled = hasName && hasMale &&  weightValidated && heightValidated && (NewDeviceType.SelectedIndex != -1);
        }

        private void NewHeight_Validated(object sender, EventArgs e)
        {
            heightValidated = NewHeight.Text != string.Empty;

            SignUp.Enabled = hasName && hasMale &&  weightValidated && heightValidated && (NewDeviceType.SelectedIndex != -1);
        }

        private void NewMale_CheckedChanged(object sender, EventArgs e)
        {
            if (NewMale.Checked)
                NewFemale.Checked = false;

            hasMale = NewMale.Checked || NewFemale.Checked;

            SignUp.Enabled = hasName && hasMale && weightValidated && heightValidated && (NewDeviceType.SelectedIndex != -1);
        }

        private void NewFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (NewFemale.Checked)
                NewMale.Checked = false;

            hasMale = NewMale.Checked || NewFemale.Checked;

            SignUp.Enabled = hasName && hasMale && weightValidated && heightValidated && (NewDeviceType.SelectedIndex != -1);
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            string name = NewName.Text;
            DateTime birthDate = NewDateBirth.Value;
            Male male = NewMale.Checked ? Male.Male : Male.Female;
            byte height = byte.Parse(NewHeight.Text);
            byte weight = byte.Parse(NewWeight.Text);

            _container = new EntityModelContainer();
            Patient newPatient = InformationSystem.CreatePatient(name, birthDate, male, height, weight, user);
            InformationSystem.AddPatient(newPatient, user);
            
            DeviceFunction deviceType = 0;

            switch (NewDeviceType.SelectedIndex)
            {
                case 0:
                    deviceType = DeviceFunction.Glucometer;
                    break;

                case 1:
                    deviceType = DeviceFunction.HeartRateMonitor;
                    break;

                case 2:
                    deviceType = DeviceFunction.BloodPressureMonitor;
                    break;
            }
            
            Device newDevice = InformationSystem.CreateDevice(newPatient, deviceType);
            InformationSystem.AddDevice(newDevice, newPatient);

            DoctorMessage informMessage = InformationSystem.CreatePatientMessage(user, newPatient, AllowAccess.Checked);

            InformationSystem.AddDoctorMessage(informMessage);

            MessageBox.Show("Пациент успешно зарегистрирован");

            this.Close();
        }

        private void NewDeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NewDeviceType.SelectedIndex != -1)
            {
                SignUp.Enabled = hasName && hasMale && weightValidated && heightValidated;
            }
        }

        private void ReadExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "xlsx-файлы (*.xlsx)|*.xlsx";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string fileDirectory = openFile.FileName;

                bool correct;
                string name;
                DateTime birthDate;
                Male male;
                byte height;
                byte weight;
                DeviceFunction function;
                bool access;

                ExcelWorker.ParseFile(fileDirectory, out correct, out name, out birthDate, out male, out height, out weight, out function, out access);

                if (!correct)
                    MessageBox.Show("Загруженный файл не соответствует шаблону формы");
                else
                {
                    NewName.Text = name;
                    NewDateBirth.Value = birthDate;

                    if (male == Male.Male)
                        NewMale.Checked = true;
                    else
                        NewFemale.Checked = true;

                    NewHeight.Text = height.ToString();
                    heightValidated = true;
                    NewWeight.Text = weight.ToString();
                    weightValidated = true;
                    
                    if (function == DeviceFunction.Glucometer)
                        NewDeviceType.SelectedIndex = 0;
                    else
                    {
                        if (function == DeviceFunction.HeartRateMonitor)
                            NewDeviceType.SelectedIndex = 1;

                        else
                            NewDeviceType.SelectedIndex = 2;
                    }

                    AllowAccess.Checked = access;
                }
            }
        }

        private void ExitNewPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
