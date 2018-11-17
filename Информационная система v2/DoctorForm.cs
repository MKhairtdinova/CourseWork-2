using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Информационная_система_v2
{
    public partial class DoctorForm : Form
    {
        public Doctor user;
        private EntityModelContainer _container;

        public DoctorForm()
        {
            InitializeComponent();
        }

        void RefreshPatients()
        {
            _container = new EntityModelContainer();

            Doctor refreshUser = _container.DoctorSet.Find(user.UserCode);

            user = refreshUser;

            if (AllPatientsSearch.Checked)
            {
                PatientsList.DataSource = (from patient in user.Patient.AsParallel()
                    select new
                    {
                        Код = patient.UserCode,
                        ФИО = patient.FullName,
                        Дата_рождения = patient.BirthDate.ToShortDateString()
                    }).ToList();
            }
            else
            {
                if (NameSearch.Checked)
                {
                    PatientsList.DataSource = (from patient in user.Patient.AsParallel()
                        where patient.FullName.IndexOf(PatientNameSearch.Text) != -1
                        select new
                        {
                            Код = patient.UserCode,
                            ФИО = patient.FullName,
                            Дата_рождения = patient.BirthDate.ToShortDateString()
                        }).ToList();
                }
                else
                {
                    PatientsList.DataSource = (from patient in user.Patient.AsParallel()
                        where patient.UserCode == int.Parse(PatientCodeSearch.Text)
                        select new
                        {
                            Код = patient.UserCode,
                            ФИО = patient.FullName,
                            Дата_рождения = patient.BirthDate.ToShortDateString()
                        }).ToList();
                }
            }

            PatientsList.Update();
        }

        private void NameSearch_CheckedChanged(object sender, EventArgs e)
        {
            PatientNameSearch.Enabled = NameSearch.Checked;
            AllPatientsSearch.Checked = !(NameSearch.Checked | CodeSearch.Checked);
        }

        private void CodeSearch_CheckedChanged(object sender, EventArgs e)
        {
            PatientCodeSearch.Enabled = CodeSearch.Checked;
            AllPatientsSearch.Checked = !(NameSearch.Checked | CodeSearch.Checked);
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            DoctorName.Text = user.FullName;
            _container = new EntityModelContainer();

            RefreshPatients();
            PatientsList.Update();
        }

        private void ExitDoctor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewPatient_Click(object sender, EventArgs e)
        {
            NewPatientForm newPatientForm = new NewPatientForm();
            newPatientForm.user = this.user;
            newPatientForm.ShowDialog();
            RefreshPatients();
        }

        private void UpdatePatientList_Click(object sender, EventArgs e)
        {
            RefreshPatients();

            PatientsList.Update();
            PatientsList.Columns[0].Width = 42;
            PatientsList.Columns[1].Width = 232;
        }

        private void DoctorForm_Activated(object sender, EventArgs e)
        {
            RefreshPatients();
            
            PatientsList.Update();
            PatientsList.Columns[0].Width = 42;
            PatientsList.Columns[1].Width = 232;
        }
        
        private void PatientListOptions_Opened(object sender, EventArgs e)
        {
            PatientListOptions.Items[0].Enabled = PatientsList.SelectedRows.Count == 0;
            PatientListOptions.Items[0].Enabled = PatientsList.SelectedRows.Count == 0;
        }

        private void DeletePatient_Click(object sender, EventArgs e)
        {
            int row = PatientsList.SelectedCells[0].RowIndex;
            int code = int.Parse(PatientsList.Rows[row].Cells[0].Value.ToString());

            Patient deletedPatient = _container.PatientSet.Find(code);
            deletedPatient.Doctor.Remove(_container.DoctorSet.Find(user.UserCode));
            user = _container.DoctorSet.Find(user.UserCode);
            user.Patient.Remove(deletedPatient);
            _container.SaveChanges();

            RefreshPatients();
        }

        private void NewPatientSearch_Click(object sender, EventArgs e)
        {
            SearchPatientForm search = new SearchPatientForm();
            search.user = user;

            search.ShowDialog();
        }

        private void AddDevice_Click(object sender, EventArgs e)
        {
            int row = PatientsList.SelectedCells[0].RowIndex;
            int userCode = int.Parse(PatientsList.Rows[row].Cells[0].Value.ToString());

            Patient selectedPat = _container.PatientSet.Find(userCode);

            AddDeviceForm newDeviceType = new AddDeviceForm();

            if (newDeviceType.ShowDialog() != DialogResult.Cancel)
            {
                DeviceFunction type = newDeviceType.function;

                bool exist = false;

                foreach (Device d in selectedPat.Device)
                {
                    if (d.Function == type)
                        exist = true;
                }

                if (exist)
                {
                    MessageBox.Show("Данный тип прибора уже закреплен за пациентом.");
                }
                else
                {
                    Device newDevice = InformationSystem.CreateDevice(selectedPat, type);
                    InformationSystem.AddDevice(newDevice, selectedPat);
                }
            }
        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            int row = PatientsList.SelectedCells[0].RowIndex;
            int userCode = int.Parse(PatientsList.Rows[row].Cells[0].Value.ToString());

            Patient selectedPat = _container.PatientSet.Find(userCode);

            PatientDataForm patientData = new PatientDataForm();
            patientData.Patient = selectedPat;

            patientData.Show();
        }
    }
}
