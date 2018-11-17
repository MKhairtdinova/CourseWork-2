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
    public partial class PatientDataForm : Form
    {
        public PatientDataForm()
        {
            InitializeComponent();
        }

        public Patient Patient;
        private EntityModelContainer _container;
        private Thread excelThread;

        private void PatientDataForm_Load(object sender, EventArgs e)
        {
            PatientName.Text = Patient.FullName;
            PatientBirthDate.Text = Patient.BirthDate.ToShortDateString();

            if (Patient.Male == Male.Female)
                PatientMale.Text = "Женский";
            else
                PatientMale.Text = "Мужской";

            PatientHeight.Text = Patient.Height.ToString() + " см";
            PatientWeight.Text = Patient.Weight.ToString() + " кг";

            _container = new EntityModelContainer();

            PatientResults.DataSource = (from measuredData in _container.MeasuredDataSet
                where measuredData.OwnerCode == Patient.UserCode
                orderby measuredData.CreatingTime
                select new { Дата = measuredData.CreatingTime.ToString(), Результат = measuredData.Value, Тип = "Измерение" }).Union(
                from healthStatus in _container.HealthStatusSet
                where healthStatus.OwnerCode == Patient.UserCode
                select new { Дата = healthStatus.CreatingTime.ToString(), Результат = healthStatus.Status, Тип = "Статус" }).ToList();

            PatientResults.Update();

            PatientResults.Columns[0].Width = 100;
            PatientResults.Columns[1].Width = 245;
            PatientResults.Columns[2].Visible = false;

           excelThread =
                new Thread(ExcelWorker.WriteResults);

            EndPeriod.MaxDate = DateTime.Now;
        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            List<string[]> measures, statuses;

            ReadShownResults(out measures, out statuses);

            if (measures.Count == 0 && statuses.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одной записи для экспорта", "Ошибка экспорта данных",
                    MessageBoxButtons.OK);
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "xlsx-файлы (*.xlsx)|*.xlsx";
                save.CheckFileExists = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    Thread excelThread =
                        new Thread(ExcelWorker.WriteResults);

                    excelThread.Name = "ExcelWriter";

                    ExcelExportData data = new ExcelExportData(save.FileName, measures, statuses, Patient);

                    excelThread.Start(data);

                    //MessageBox.Show("Файл успешно сохранен", "Сохранение данных", MessageBoxButtons.OK);
                }
            }
        }

        void ReadShownResults(out List<string[]> measures, out List<string[]> statuses)
        {
            measures = new List<string[]>();
            statuses = new List<string[]>();

            for (int row = 0; row < PatientResults.RowCount; row++)
            {
                string[] result = new string[2];

                for (int column = 0; column < 2; column++)
                {
                    result[column] = PatientResults.Rows[row].Cells[column].Value.ToString();

                    if (PatientResults.Rows[row].Cells[2].Value.ToString() == "Статус")
                        statuses.Add(result);
                    else
                        measures.Add(result);
                }
            }
        }

        private void UpdateTable_Click(object sender, EventArgs e)
        {
            RefreshData();
            PatientResults.Update();

            PatientResults.Columns[0].Width = 110;
            PatientResults.Columns[1].Width = 232;
            PatientResults.Columns[2].Visible = false;
        }

        void RefreshData()
        {
            _container= new EntityModelContainer();

            if (ShowHealthState.Checked && ShowMeasuredData.Checked)
            {
                AllData();
            }
            else
            {
                if (ShowHealthState.Checked)
                    AllHealthStatus();
                else AllMeasuredData();
            }
        }

        void AllData()
        {
            if (AllPeriodData.Checked)
            {
                if (AllDevicesData.Checked)
                {
                    PatientResults.DataSource = (from measuredData in Patient.MeasuredData.AsParallel()
                        //       where measuredData.OwnerCode == user.UserCode
                        orderby measuredData.CreatingTime
                        select new { Дата = measuredData.CreatingTime, Результат = measuredData.Value, Тип = "Измерение"}).Union(
                        from healthStatus in _container.HealthStatusSet.AsParallel()
                        orderby healthStatus.CreatingTime
                        where healthStatus.OwnerCode == Patient.UserCode
                        select new { Дата = healthStatus.CreatingTime, Результат = healthStatus.Status, Тип = "Статус"}).ToList();
                }
                else
                {
                    switch (ChooseDevice.SelectedIndex)
                    {
                        case 0:
                            PatientResults.DataSource = (from measuredData in Patient.MeasuredData.AsParallel()
                                    orderby measuredData.CreatingTime
                                    where _container.DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.Glucometer
                                    select new { Дата = measuredData.CreatingTime, Результат = measuredData.Value, Тип = "Измерение"})
                                .Union(
                                    from healthStatus in _container.HealthStatusSet.AsParallel()
                                    orderby healthStatus.CreatingTime
                                    where healthStatus.OwnerCode == Patient.UserCode
                                    select new { Дата = healthStatus.CreatingTime, Результат = healthStatus.Status, Тип = "Статус"})
                                .ToList();
                            break;

                        case 1:
                            PatientResults.DataSource = (from measuredData in Patient.MeasuredData.AsParallel()
                                    orderby measuredData.CreatingTime
                                    where _container.DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.HeartRateMonitor
                                    select new { Дата = measuredData.CreatingTime, Результат = measuredData.Value, Тип = "Измерение"})
                                .Union(
                                    from healthStatus in _container.HealthStatusSet.AsParallel()
                                    orderby healthStatus.CreatingTime
                                    where healthStatus.OwnerCode == Patient.UserCode
                                    select new { Дата = healthStatus.CreatingTime, Результат = healthStatus.Status, Тип = "Статус"})
                                .ToList();
                            break;
                        case 2:
                            PatientResults.DataSource = (from measuredData in Patient.MeasuredData.AsParallel()
                                    orderby measuredData.CreatingTime
                                    where _container.DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.BloodPressureMonitor
                                    select new { Дата = measuredData.CreatingTime, Результат = measuredData.Value, Тип = "Измерение"})
                                .Union(
                                    from healthStatus in _container.HealthStatusSet.AsParallel()
                                    orderby healthStatus.CreatingTime
                                    where healthStatus.OwnerCode == Patient.UserCode
                                    select new { Дата = healthStatus.CreatingTime, Результат = healthStatus.Status, Тип = "Статус" })
                                .ToList();
                            break;
                    }
                }
            }

            else
            {
                if (AllDevicesData.Checked)
                {
                    PatientResults.DataSource = (from measuredData in Patient.MeasuredData.AsParallel()
                            where measuredData.OwnerCode == Patient.UserCode &&
                                  DateTime.Compare(measuredData.CreatingTime, BeginPeriod.Value) != -1 &&
                                  DateTime.Compare(measuredData.CreatingTime, EndPeriod.Value) != 1
                            orderby measuredData.CreatingTime
                            select new
                            {
                                Дата = measuredData.CreatingTime,
                                Результат = measuredData.Value,
                                Тип = "Измерение"
                            }).Union(
                            from healthStatus in _container.HealthStatusSet.AsParallel()
                            where healthStatus.OwnerCode == Patient.UserCode &&
                                  DateTime.Compare(healthStatus.CreatingTime, BeginPeriod.Value) != -1 &&
                                  DateTime.Compare(healthStatus.CreatingTime, EndPeriod.Value) != 1
                            select new
 {
                                Дата = healthStatus.CreatingTime,
                                Результат = healthStatus.Status,
                                Тип = "Статус"
                            })
                        .ToList();
                }
                else
                {
                    switch (ChooseDevice.SelectedIndex)
                    {
                        case 0:
                            PatientResults.DataSource = (from measuredData in Patient.MeasuredData.AsParallel()
                                    where measuredData.OwnerCode == Patient.UserCode &&
                                          DateTime.Compare(measuredData.CreatingTime, BeginPeriod.Value) != -1 &&
                                          DateTime.Compare(measuredData.CreatingTime, EndPeriod.Value) != 1 &&
                                          _container
                                              .DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.Glucometer
                                    orderby measuredData.CreatingTime
                                    select new
                                    {
                                        Дата = measuredData.CreatingTime,
                                        Результат = measuredData.Value,
                                        Тип = "Измерение"
                                    })
                                .Union(
                                    from healthStatus in _container.HealthStatusSet.AsParallel()
                                    orderby healthStatus.CreatingTime
                                    where healthStatus.OwnerCode == Patient.UserCode &&
                                          DateTime.Compare(healthStatus.CreatingTime, BeginPeriod.Value) != -1 &&
                                          DateTime.Compare(healthStatus.CreatingTime, EndPeriod.Value) != 1
                                    select new
                                    {
                                        Дата = healthStatus.CreatingTime,
                                        Результат = healthStatus.Status,
                                        Тип = "Статус"
                                    })
                                .ToList();
                            break;

                        case 1:
                            PatientResults.DataSource = (from measuredData in Patient.MeasuredData.AsParallel()
                                    where measuredData.OwnerCode == Patient.UserCode &&
                                          DateTime.Compare(measuredData.CreatingTime, BeginPeriod.Value) != -1 &&
                                          DateTime.Compare(measuredData.CreatingTime, EndPeriod.Value) != 1 &&
                                          _container
                                              .DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.HeartRateMonitor
                                    orderby measuredData.CreatingTime
                                    select new
                                    {
                                        Дата = measuredData.CreatingTime,
                                        Результат = measuredData.Value,
                                        Тип = "Измерение"
                                    })
                                .Union(
                                    from healthStatus in _container.HealthStatusSet.AsParallel()
                                    orderby healthStatus.CreatingTime
                                    where healthStatus.OwnerCode == Patient.UserCode &&
                                          DateTime.Compare(healthStatus.CreatingTime, BeginPeriod.Value) != -1 &&
                                          DateTime.Compare(healthStatus.CreatingTime, EndPeriod.Value) != 1
                                    select new
                                    {
                                        Дата = healthStatus.CreatingTime,
                                        Результат = healthStatus.Status,
                                        Тип = "Статус"
                                    })
                                .ToList();
                            break;

                        case 2:
                            PatientResults.DataSource = (from measuredData in Patient.MeasuredData.AsParallel()
                                    where measuredData.OwnerCode == Patient.UserCode &&
                                          DateTime.Compare(measuredData.CreatingTime, BeginPeriod.Value) != -1 &&
                                          DateTime.Compare(measuredData.CreatingTime, EndPeriod.Value) != 1 &&
                                          _container
                                              .DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.BloodPressureMonitor
                                    orderby measuredData.CreatingTime
                                    select new
                                    {
                                        Дата = measuredData.CreatingTime,
                                        Результат = measuredData.Value,
                                        Тип = "Измерение"
                                    })
                                .Union(
                                    from healthStatus in _container.HealthStatusSet.AsParallel()
                                    where healthStatus.OwnerCode == Patient.UserCode &&
                                          DateTime.Compare(healthStatus.CreatingTime, BeginPeriod.Value) != -1 &&
                                          DateTime.Compare(healthStatus.CreatingTime, EndPeriod.Value) != 1
                                    orderby healthStatus.CreatingTime
                                    select new
                                    {
                                        Дата = healthStatus.CreatingTime,
                                        Результат = healthStatus.Status,
                                        Тип = "Статус"
                                    })
                                .ToList();
                            break;
                    }
                }
            }
        }

        void AllHealthStatus()
        {
            if (AllPeriodData.Checked)
            {
                PatientResults.DataSource =
                (from healthStatus in _container.HealthStatusSet.AsParallel()
                    where healthStatus.OwnerCode == Patient.UserCode
                    orderby healthStatus.CreatingTime
                    select new
                    {
                        Дата = healthStatus.CreatingTime,
                        Результат = healthStatus.Status,
                        Тип = "Статус"
                    }).ToList();

            }

            else
            {
                PatientResults.DataSource =
                (from healthStatus in _container.HealthStatusSet.AsParallel()
                    where healthStatus.OwnerCode == Patient.UserCode && DateTime.Compare(healthStatus.CreatingTime, BeginPeriod.Value) != -1 &&
                          DateTime.Compare(healthStatus.CreatingTime, EndPeriod.Value) != 1
                    orderby healthStatus.CreatingTime
                    select new
                    {
                        Дата = healthStatus.CreatingTime,
                        Результат = healthStatus.Status,
                        Тип = "Статус"
                    }).ToList();
            }

        }

        void AllMeasuredData()
        {
            if (AllPeriodData.Checked)
            {
                if (AllDevicesData.Checked)
                {
                    PatientResults.DataSource = (from measuredData in _container.MeasuredDataSet.AsParallel()
                        where measuredData.OwnerCode == Patient.UserCode
                        orderby measuredData.CreatingTime
                        select new
                        {
                            Дата = measuredData.CreatingTime,
                            Результат = measuredData.Value,
                            Тип = "Измерение"
                        }).ToList();
                }
                else
                {
                    switch (ChooseDevice.SelectedIndex)
                    {
                        case 0:
                            PatientResults.DataSource = (from measuredData in _container.MeasuredDataSet.AsParallel()
                                    orderby measuredData.CreatingTime
                                    where measuredData.OwnerCode == Patient.UserCode && _container.DeviceSet
                                              .Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.Glucometer
                                    select new
                                    {
                                        Дата = measuredData.CreatingTime,
                                        Результат = measuredData.Value,
                                        Тип = "Измерение"
                                    })
                                .ToList();
                            break;

                        case 1:
                            PatientResults.DataSource = (from measuredData in _container.MeasuredDataSet.AsParallel()
                                    orderby measuredData.CreatingTime
                                    where measuredData.OwnerCode == Patient.UserCode && _container.DeviceSet
                                              .Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.HeartRateMonitor
                                    select new
                                    {
                                        Дата = measuredData.CreatingTime,
                                        Результат = measuredData.Value,
                                        Тип = "Измерение"
                                    })
                                .ToList();
                            break;
                        case 2:
                            PatientResults.DataSource = (from measuredData in _container.MeasuredDataSet.AsParallel()
                                    orderby measuredData.CreatingTime
                                    where measuredData.OwnerCode == Patient.UserCode && _container.DeviceSet
                                              .Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.BloodPressureMonitor
                                    select new
                                    {
                                        Дата = measuredData.CreatingTime,
                                        Результат = measuredData.Value,
                                        Тип = "Измерение"
                                    })
                                .ToList();
                            break;
                    }
                }
            }

            else
            {
                if (AllDevicesData.Checked)
                {
                    PatientResults.DataSource = (from measuredData in Patient.MeasuredData.AsParallel()
                        where measuredData.OwnerCode == Patient.UserCode &&
                              DateTime.Compare(measuredData.CreatingTime, BeginPeriod.Value) != -1 &&
                              DateTime.Compare(measuredData.CreatingTime, EndPeriod.Value) != 1
                        orderby measuredData.CreatingTime
                        select new
                        {
                            Дата = measuredData.CreatingTime,
                            Результат = measuredData.Value,
                            Тип = "Измерение"
                        }).ToList();
                }
                else
                {
                    switch (ChooseDevice.SelectedIndex)
                    {
                        case 0:
                            PatientResults.DataSource = (from measuredData in Patient.MeasuredData.AsParallel()
                                    where measuredData.OwnerCode == Patient.UserCode &&
                                          DateTime.Compare(measuredData.CreatingTime, BeginPeriod.Value) != -1 &&
                                          DateTime.Compare(measuredData.CreatingTime, EndPeriod.Value) != 1 &&
                                          _container
                                              .DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.Glucometer
                                    orderby measuredData.CreatingTime
                                    select new
                                    {
                                        Дата = measuredData.CreatingTime,
                                        Результат = measuredData.Value,
                                        Тип = "Измерение"
                                    })
                                .ToList();
                            break;

                        case 1:
                            PatientResults.DataSource = (from measuredData in Patient.MeasuredData.AsParallel()
                                    where measuredData.OwnerCode == Patient.UserCode &&
                                          DateTime.Compare(measuredData.CreatingTime, BeginPeriod.Value) != -1 &&
                                          DateTime.Compare(measuredData.CreatingTime, EndPeriod.Value) != 1 &&
                                          _container
                                              .DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.HeartRateMonitor
                                    orderby measuredData.CreatingTime
                                    select new
                                    {
                                        Дата = measuredData.CreatingTime,
                                        Результат = measuredData.Value,
                                        Тип = "Измерение"
                                    })
                                .ToList();
                            break;

                        case 2:
                            PatientResults.DataSource = (from measuredData in Patient.MeasuredData.AsParallel()
                                    where measuredData.OwnerCode == Patient.UserCode &&
                                          DateTime.Compare(measuredData.CreatingTime, BeginPeriod.Value) != -1 &&
                                          DateTime.Compare(measuredData.CreatingTime, EndPeriod.Value) != 1 &&
                                          _container
                                              .DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.BloodPressureMonitor
                                    orderby measuredData.CreatingTime
                                    select new
                                    {
                                        Дата = measuredData.CreatingTime,
                                        Результат = measuredData.Value,
                                        Тип = "Измерение"
                                    })
                                .ToList();
                            break;
                    }
                }
            }
        }

        private void ParticularPeriodData_CheckedChanged(object sender, EventArgs e)
        {
            AllPeriodData.Checked = !ParticularPeriodData.Checked;
            BeginPeriod.Enabled = ParticularPeriodData.Checked;
            EndPeriod.Enabled = ParticularPeriodData.Checked;
        }

        private void AllPeriodData_CheckedChanged(object sender, EventArgs e)
        {
            ParticularPeriodData.Checked = !AllPeriodData.Checked;
        }

        private void AllDevicesData_CheckedChanged(object sender, EventArgs e)
        {
            ParticularDeviceData.Checked = !AllDevicesData.Checked;
        }

        private void ParticularDeviceData_CheckedChanged(object sender, EventArgs e)
        {
            AllDevicesData.Checked = !ParticularDeviceData.Checked;
            ChooseDevice.Enabled = ParticularDeviceData.Checked;
        }

        private void PatientDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (excelThread.IsAlive)
            {
                MessageBox.Show("Пожалуйста, подождите. Идет сохранение отчета...", "Ошибка закрытия окна",
                    MessageBoxButtons.OK);
                e.Cancel = true;
            }

        }
    }
}
