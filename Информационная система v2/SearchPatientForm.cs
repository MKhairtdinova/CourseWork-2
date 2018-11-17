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
    public partial class SearchPatientForm : Form
    {
        public SearchPatientForm()
        {
            InitializeComponent();
        }

        public Doctor user;
        private bool needName = true;
        private bool needCode = true;

        private void SearchPatientForm_Load(object sender, EventArgs e)
        {
            needName = true;
            needCode = true;
        }

        private void ExitSearchPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitSearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchCode_TextChanged(object sender, EventArgs e)
        {
            if (SearchCode.Text != string.Empty)
            {
                string text = SearchCode.Text;

                int i = 0;

                do
                {
                    if (text[i] < '0' || text[i] > '9')
                        text = text.Remove(i, 1);
                    else
                        i++;
                } while (i < text.Length && i != 0);

                SearchCode.Text = text;
            }

            needCode = SearchCode.Text == string.Empty;

            Search.Enabled = !(needCode && needName);
        }

        private void SearchName_TextChanged(object sender, EventArgs e)
        {
            if (SearchName.Text != string.Empty)
            {
                string text = SearchName.Text;

                int i = 0;

                do
                {
                    if (!(text[i] >= 'А' && text[i] <= 'Я' || text[i] >= 'а' && text[i] <= 'я' || text[i] == ' '))
                        text = text.Remove(i, 1);
                    else
                        i++;
                } while (i < text.Length && i != 0);

                SearchName.Text = text;
            }

            needName = SearchName.Text == string.Empty;
            Search.Enabled = !(needCode && needName);
        }

        private void SearchByCode_CheckedChanged(object sender, EventArgs e)
        {
            SearchCode.Enabled = SearchByCode.Checked;
            needCode = SearchByCode.Checked && (SearchCode.Text == string.Empty);
        }

        private void SearchByName_CheckedChanged(object sender, EventArgs e)
        {
            SearchName.Enabled = SearchByName.Checked;
            needName = SearchByName.Checked && (SearchName.Text == string.Empty);
        }

        private void SearchByDate_CheckedChanged(object sender, EventArgs e)
        {
            SearchBirthDate.Enabled = SearchByDate.Checked;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (SearchByCode.Checked)
            {
                CodeSearch();
            }
            else
            {
                if (SearchByName.Checked)
                {
                    if (SearchByDate.Checked)
                    { NameDateSearch();}
                    else 
                        OnlyNameSearch();
                }
                else 
                    if (SearchByDate.Checked)
                { OnlyDateSearch(); }
            }

            if (SearchResults.ColumnCount != 0)
            {
                AddPatient.Enabled = true;
                SearchResults.Columns[0].Width = 40;
                SearchResults.Columns[1].Width = 155;
                SearchResults.Columns[2].Width = 100;
            }
        }

        void CodeSearch()
        {
            EntityModelContainer container = new EntityModelContainer();

            bool found = false;

            Patient pat = container.PatientSet.Find(int.Parse(SearchCode.Text));

            if (pat != null)
            {
                found = true;

                if (SearchByName.Checked)
                    if (pat.FullName.IndexOf(SearchName.Text) == -1)
                        found = false;

                if (SearchByDate.Checked)
                    if (SearchBirthDate.Value != pat.BirthDate)
                        found = false;

                if (user.Patient.Contains(pat, new PatientComparer()))
                    found = false;
            }

            if (found)
            {
                List<Patient> list = new List<Patient>();
                list.Add(pat);

                SearchResults.DataSource =( from p in list select new 
                {
                    Код = p.UserCode,
                    ФИО = p.FullName,
                    Дата_рождения = p.BirthDate
                }).ToList();

                SearchResults.Update();
            }
            else
                MessageBox.Show(
                    "Пациент с указанными данными не найден. Возможно, данный пациент уже находится в Вашем списке пациентов.",
                    "Пациент не найден", MessageBoxButtons.OK);
        }

        void OnlyNameSearch()
        {
            EntityModelContainer container = new EntityModelContainer();

            SearchResults.DataSource =  (from pat in container.PatientSet.AsParallel()
                where pat.FullName.IndexOf(SearchName.Text) != -1 && !user.Patient.Contains(pat, new PatientComparer())
                orderby pat.UserCode
                select new
                {
                    Код = pat.UserCode,
                    ФИО = pat.FullName,
                    Дата_рождения = pat.BirthDate
                }).ToList();

            SearchResults.Update();

            if (SearchResults.RowCount == 0)
                MessageBox.Show(
                    "Пациент с указанными данными не найден. Возможно, данный пациент уже находится в Вашем списке пациентов.",
                    "Пациент не найден", MessageBoxButtons.OK);
        }

        void OnlyDateSearch()
        {
            EntityModelContainer container = new EntityModelContainer();

            SearchResults.DataSource = (from pat in container.PatientSet.AsParallel()
                where pat.BirthDate == SearchBirthDate.Value && !user.Patient.Contains(pat, new PatientComparer())
                                        orderby  pat.UserCode
                select new
                {
                    Код = pat.UserCode,
                    ФИО = pat.FullName,
                    Дата_рождения = pat.BirthDate
                }).ToList();

            SearchResults.Update();
            if (SearchResults.RowCount == 0)
                MessageBox.Show(
                    "Пациент с указанными данными не найден. Возможно, данный пациент уже находится в Вашем списке пациентов.",
                    "Пациент не найден", MessageBoxButtons.OK);
        }

        void NameDateSearch()
        {
            EntityModelContainer container = new EntityModelContainer();

            SearchResults.DataSource = (from pat in container.PatientSet.AsParallel()
                where pat.FullName.IndexOf(SearchName.Text) != -1 && pat.BirthDate == SearchBirthDate.Value &&
                      !user.Patient.Contains(pat, new PatientComparer())
                orderby pat.UserCode
                select new
                {
                    Код = pat.UserCode,
                    ФИО = pat.FullName,
                    Дата_рождения = pat.BirthDate
                }).ToList();

            SearchResults.Update();

            if (SearchResults.RowCount == 0)
                MessageBox.Show(
                    "Пациент с указанными данными не найден. Возможно, данный пациент уже находится в Вашем списке пациентов.",
                    "Пациент не найден", MessageBoxButtons.OK);

        }

        private void AddPatient_Click(object sender, EventArgs e)
        {
            EntityModelContainer container = new EntityModelContainer();

            int row = SearchResults.SelectedCells[0].RowIndex;

           Patient selectedPat =
                container.PatientSet.Find(int.Parse(SearchResults.Rows[row].Cells[0].Value.ToString()));

           AddDeviceForm newDeviceType = new AddDeviceForm();

            if (newDeviceType.ShowDialog() == DialogResult.OK)
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
                    if (MessageBox.Show(
                            "Данный тип прибора уже закреплен за пациентом. Добавить пациента в список пациентов?", "",
                            MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        InformationSystem.AddDoctorPatientConnection(user, selectedPat);
                        this.Close();
                    }
                }
                else
                {
                    Device newDevice = InformationSystem.CreateDevice(selectedPat, type);
                    InformationSystem.AddDevice(newDevice, selectedPat);

                    InformationSystem.AddDoctorPatientConnection(user, selectedPat);
                    this.Close();
                }
            }

            container.SaveChanges();
        }
    }
}
