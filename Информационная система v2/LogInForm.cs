using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Информационная_система_v2
{
    public partial class LogInForm : Form
    {
        private static DateTime currentTime = DateTime.Now;

        public LogInForm()
        {
            InitializeComponent();
        }

        void DeviceWork(object sender, EventArgs e)
        {
            Thread primaryThread = Thread.CurrentThread;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string login = Login.Text;
            string password = Password.Text;
            User.UserType type;
            User searchResult;

            EntityModelContainer container = new EntityModelContainer();

            bool correct = InformationSystem.CheckLoginPassword(login, password, out type, out searchResult);

            if (!correct)
                MessageBox.Show("Неверное имя пользователя или пароль");
            else
            {
                if (type == User.UserType.administrator)
                {
                    AdministratorForm adminForm = new AdministratorForm();
                    Administrator result = searchResult as Administrator;

                    adminForm.user = container.AdministratorSet.Find(result.UserCode); ;
                    adminForm.ShowDialog();
                }
                else
                {
                    if (type == User.UserType.doctor)
                    {
                        DoctorForm doctorForm = new DoctorForm();
                        Doctor result =  searchResult as Doctor;

                        doctorForm.user = container.DoctorSet.Find(result.UserCode);
                         
                        doctorForm.ShowDialog();
                    }
                    else
                    {
                        PatientForm patientForm = new PatientForm();
                        Patient result = searchResult as Patient;

                        patientForm.user = container.PatientSet.Find(result.UserCode);
                        patientForm.ShowDialog();
                    }
                }
            }
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            bool loginHasText = (Login.Text != string.Empty);
            bool passwordHasText = (Password.Text != string.Empty);

            LogInButton.Enabled = loginHasText && passwordHasText;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            bool loginHasText = (Login.Text != string.Empty);
            bool passwordHasText = (Password.Text != string.Empty);

            LogInButton.Enabled = loginHasText && passwordHasText;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "UserWork";

            // создаем фоновый поток для записи измерений прибора
            Thread backgroundThread = new Thread(new ThreadStart(InformationSystem.WorkAllDevices));
            backgroundThread.Name = "DeviceWork";
            backgroundThread.IsBackground = true;
            backgroundThread.Start();
        }
    }
}
