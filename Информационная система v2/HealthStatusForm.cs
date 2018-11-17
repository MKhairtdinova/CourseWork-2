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
    public partial class HealthStatusForm : Form
    {
        public Patient user;

        public bool newStatus;
        public HealthStatus status;

        public HealthStatusForm()
        {
            InitializeComponent();
        }

        private void ExitHealthStatus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddHealthStatus_Click(object sender, EventArgs e)
        {
                bool[] symptoms = new bool[14];

                if (Ailment.Checked) // недомогание
                    symptoms[Array.IndexOf(HealthStatus.SymptomsNames, "Недомогание")] = true;

                if (Dizziness.Checked) // головокружение
                    symptoms[Array.IndexOf(HealthStatus.SymptomsNames, "Головокружение")] = true;

                if (HighBloodPressure.Checked) // повышенное давление 
                    symptoms[Array.IndexOf(HealthStatus.SymptomsNames, "Повышенное артериальное давление")] = true;

                if (LowBloodPressure.Checked) // пониженное давление 
                    symptoms[Array.IndexOf(HealthStatus.SymptomsNames, "Пониженное артериальное давление")] = true;

                if (Fever.Checked) // жар
                    symptoms[Array.IndexOf(HealthStatus.SymptomsNames, "Жар")] = true;

                if (Headache.Checked) // головная боль
                    symptoms[Array.IndexOf(HealthStatus.SymptomsNames, "Головная боль")] = true;

                if (Insomnia.Checked) // бессонница
                    symptoms[Array.IndexOf(HealthStatus.SymptomsNames, "Бессонница")] = true;

                if (Nausea.Checked) // тошнота
                    symptoms[Array.IndexOf(HealthStatus.SymptomsNames, "Тошнота")] = true;

                if (Fatigue.Checked) // усталость
                    symptoms[Array.IndexOf(HealthStatus.SymptomsNames, "Усталость")] = true;

                if (DryMouth.Checked) // сухость во рту
                    symptoms[Array.IndexOf(HealthStatus.SymptomsNames, "Сухость во рту")] = true;

                if (IncreasedWeigh.Checked) // прибавление веса
                    symptoms[Array.IndexOf(HealthStatus.SymptomsNames, "Прибавление веса")] = true;

                if (DecreasedWeigh.Checked) // потеря веса
                    symptoms[Array.IndexOf(HealthStatus.SymptomsNames, "Потеря веса")] = true;

                if (Weakness.Checked) // слабость
                    symptoms[Array.IndexOf(HealthStatus.SymptomsNames, "Слабость")] = true;

                if (Thirst.Checked) // жажда
                    symptoms[Array.IndexOf(HealthStatus.SymptomsNames, "Жажда")] = true;

                string generatedStatus = HealthStatus.GetHealthStatus(symptoms);

            if (newStatus)
                InformationSystem.AddHealthStatus(generatedStatus, DateTime.Now, user);
            else
            {
                EntityModelContainer container = new EntityModelContainer();

                status = container.HealthStatusSet.Find(status.Number);
                InformationSystem.ChangeHealthStatus(status, generatedStatus);
            }

            this.Close();
        }

        private void HealthStatusForm_Load(object sender, EventArgs e)
        {
            if (!newStatus)
            {
                AddHealthStatus.Text = "Сохранить изменения";
                bool[] symptoms = HealthStatus.GetBoolArray(status.Status);

                for (int symptom = 0; symptom < symptoms.Length; symptom++)
                {
                    if (symptoms[symptom])
                    {
                        #region Перечисление симптомов
                        switch (symptom)
                        {
                            case 0:
                                Ailment.Checked = true;
                                break;

                            case 1:
                                Dizziness.Checked = true;
                                break;

                            case 2:
                                HighBloodPressure.Checked = true;
                                break;

                            case 3:
                                LowBloodPressure.Checked = true;
                                break;

                            case 4:
                                Fever.Checked = true;
                                break;

                            case 5:
                                Headache.Checked = true;
                                break;

                            case 6:
                                Insomnia.Checked = true;
                                break;

                            case 7:
                                Nausea.Checked = true;
                                break;

                            case 8:
                                Fatigue.Checked = true;
                                break;

                            case 9:
                                DryMouth.Checked = true;
                                break;

                            case 10:
                                IncreasedWeigh.Checked = true;
                                break;

                            case 11:
                                DecreasedWeigh.Checked = true;
                                break;

                            case 12:
                                Weakness.Checked = true;
                                break;

                            case 13:
                                Thirst.Checked = true;
                                break;
                        }
#endregion
                    }
                }
            }
        }
    }
}
