using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Collections.Generic;
using System.Threading;

namespace Информационная_система_v2
{
    public partial class PatientForm : Form
    {
        private EntityModelContainer _container;
        private DbSet<HealthStatus> _healthStatuses;
       
        public Patient user;

        public PatientForm()
        {
            InitializeComponent();
        }

        private void AllPeriodData_CheckedChanged(object sender, EventArgs e)
        {
            ParticularPeriodData.Checked = !AllPeriodData.Checked;
        }

        private void ParticularPeriodData_CheckedChanged(object sender, EventArgs e)
        {
            BeginPeriod.Enabled = ParticularPeriodData.Checked;
            EndPeriod.Enabled = ParticularPeriodData.Checked;
            AllPeriodData.Checked = !ParticularPeriodData.Checked;
        }

        private void AllDevicesData_CheckedChanged(object sender, EventArgs e)
        {
            ParticularDeviceData.Checked = !AllDevicesData.Checked;
        }

        private void ParticularDeviceData_CheckedChanged(object sender, EventArgs e)
        {
            AllDevicesData.Checked = !ParticularDeviceData.Checked;
            ChooseDevice.Enabled = ParticularDeviceData.Checked;
            ChooseDevice.SelectedIndex = 0;
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            PatientName.Text = user.FullName;

            _container = new EntityModelContainer();
            
            // собираем результаты всех обследований за все время
          
            MedicalResults.DataSource = (from measuredData in _container.MeasuredDataSet.AsParallel()
                where measuredData.OwnerCode == user.UserCode
                orderby measuredData.CreatingTime
                select new {Дата = measuredData.CreatingTime, Значение = measuredData.Value, Тип = "Измерение", Код = measuredData.Number }).Union(
                from healthStatus in _container.HealthStatusSet.AsParallel()
                where healthStatus.OwnerCode == user.UserCode
                select new {Дата = healthStatus.CreatingTime, Значение = healthStatus.Status, Тип = "Статус", Код = (long)healthStatus.Number }).ToList();

            MedicalResults.Update();

            BeginPeriod.MaxDate = DateTime.Now;
            EndPeriod.MaxDate = DateTime.Now;

            MedicalResults.Columns[0].Width = 100;
            MedicalResults.Columns[1].Width = 205;
            MedicalResults.Columns[2].Visible = false;
            MedicalResults.Columns[3].Visible = false;
        }

        private void AddHealthStatus_Click(object sender, EventArgs e)
        {
            HealthStatusForm healthStatusForm = new HealthStatusForm();
            healthStatusForm.user = user;
            healthStatusForm.newStatus = true;

            healthStatusForm.ShowDialog();
        }

        private void ExitPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void GetAllResults()
        {
            if (AllPeriodData.Checked)
            {
                if (AllDevicesData.Checked)
                {
                    MedicalResults.DataSource = (from measuredData in user.MeasuredData.AsParallel()
                        orderby measuredData.CreatingTime
                        select new
                        {
                            Дата = measuredData.CreatingTime,
                            Результат = measuredData.Value,
                            Тип = "Измерение",
                            Код = measuredData.Number
                        }).Union(
                        from healthStatus in _container.HealthStatusSet.AsParallel()
                        orderby healthStatus.CreatingTime
                        where healthStatus.OwnerCode == user.UserCode
                        select new
                        {
                            Дата = healthStatus.CreatingTime,
                            Результат = healthStatus.Status,
                            Тип = "Статус",
                            Код = (long) healthStatus.Number
                        }).ToList();
                }
                else
                {
                    switch (ChooseDevice.SelectedIndex)
                    {
                        case 0:
                            MedicalResults.DataSource = (from measuredData in user.MeasuredData.AsParallel()
                                    orderby measuredData.CreatingTime
                                    where _container.DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.Glucometer
                                    select new
                                    {
                                        Дата = measuredData.CreatingTime,
                                        Результат = measuredData.Value,
                                        Тип = "Измерение",
                                        Код = measuredData.Number
                                    })
                                .Union(
                                    from healthStatus in _container.HealthStatusSet.AsParallel()
                                    orderby healthStatus.CreatingTime
                                    where healthStatus.OwnerCode == user.UserCode
                                    select new
                                    {
                                        Дата = healthStatus.CreatingTime,
                                        Результат = healthStatus.Status,
                                        Тип = "Статус",
                                        Код = (long) healthStatus.Number
                                    })
                                .ToList();
                            break;

                        case 1:
                            MedicalResults.DataSource = (from measuredData in user.MeasuredData.AsParallel()
                                    orderby measuredData.CreatingTime
                                    where _container.DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.HeartRateMonitor
                                    select new
                                    {
                                        Дата = measuredData.CreatingTime,
                                        Результат = measuredData.Value,
                                        Тип = "Измерение",
                                        Код = measuredData.Number
                                    })
                                .Union(
                                    from healthStatus in _container.HealthStatusSet.AsParallel()
                                    orderby healthStatus.CreatingTime
                                    where healthStatus.OwnerCode == user.UserCode
                                    select new
                                    {
                                        Дата = healthStatus.CreatingTime,
                                        Результат = healthStatus.Status,
                                        Тип = "Статус",
                                        Код = (long) healthStatus.Number
                                    })
                                .ToList();
                            break;
                        case 2:
                            MedicalResults.DataSource = (from measuredData in user.MeasuredData.AsParallel()
                                    orderby measuredData.CreatingTime
                                    where _container.DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.BloodPressureMonitor
                                    select new
                                    {
                                        Дата = measuredData.CreatingTime,
                                        Результат = measuredData.Value,
                                        Тип = "Измерение",
                                        Код = measuredData.Number
                                    })
                                .Union(
                                    from healthStatus in _container.HealthStatusSet.AsParallel()
                                    orderby healthStatus.CreatingTime
                                    where healthStatus.OwnerCode == user.UserCode
                                    select new
                                    {
                                        Дата = healthStatus.CreatingTime,
                                        Результат = healthStatus.Status,
                                        Тип = "Статус",
                                        Код = (long) healthStatus.Number
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
                    MedicalResults.DataSource = (from measuredData in user.MeasuredData.AsParallel()
                        where measuredData.OwnerCode == user.UserCode &&
                              DateTime.Compare(measuredData.CreatingTime, BeginPeriod.Value) != -1 &&
                              DateTime.Compare(measuredData.CreatingTime, EndPeriod.Value) != 1
                        orderby measuredData.CreatingTime
                        select new
                        {
                            Дата = measuredData.CreatingTime,
                            Результат = measuredData.Value,
                            Тип = "Измерение",
                            Код = measuredData.Number
                        }).Union(
                        from healthStatus in _container.HealthStatusSet.AsParallel()
                        where healthStatus.OwnerCode == user.UserCode &&
                              DateTime.Compare(healthStatus.CreatingTime, BeginPeriod.Value) != -1 &&
                              DateTime.Compare(healthStatus.CreatingTime, EndPeriod.Value) != 1
                        select new
                        {
                            Дата = healthStatus.CreatingTime,
                            Результат = healthStatus.Status,
                            Тип = "Статус",
                            Код = (long) healthStatus.Number
                        }).ToList();
                }
                else
                {
                    switch (ChooseDevice.SelectedIndex)
                    {
                        case 0:
                            MedicalResults.DataSource = (from measuredData in user.MeasuredData.AsParallel()
                                    where measuredData.OwnerCode == user.UserCode &&
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
                                        Тип = "Измерение",
                                        Код = measuredData.Number
                                    })
                                .Union(
                                    from healthStatus in _container.HealthStatusSet.AsParallel()
                                    orderby healthStatus.CreatingTime
                                    where healthStatus.OwnerCode == user.UserCode &&
                                          DateTime.Compare(healthStatus.CreatingTime, BeginPeriod.Value) != -1 &&
                                          DateTime.Compare(healthStatus.CreatingTime, EndPeriod.Value) != 1
                                    select new
                                    {
                                        Дата = healthStatus.CreatingTime,
                                        Результат = healthStatus.Status,
                                        Тип = "Статус",
                                        Код = (long) healthStatus.Number
                                    })
                                .ToList();
                            break;

                        case 1:
                            MedicalResults.DataSource = (from measuredData in user.MeasuredData.AsParallel()
                                    where measuredData.OwnerCode == user.UserCode &&
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
                                        Тип = "Измерение",
                                        Код = measuredData.Number
                                    })
                                .Union(
                                    from healthStatus in _container.HealthStatusSet.AsParallel()
                                    orderby healthStatus.CreatingTime
                                    where healthStatus.OwnerCode == user.UserCode &&
                                          DateTime.Compare(healthStatus.CreatingTime, BeginPeriod.Value) != -1 &&
                                          DateTime.Compare(healthStatus.CreatingTime, EndPeriod.Value) != 1
                                    select new
                                    {
                                        Дата = healthStatus.CreatingTime,
                                        Результат = healthStatus.Status,
                                        Тип = "Статус",
                                        Код = (long) healthStatus.Number
                                    })
                                .ToList();
                            break;

                        case 2:
                            MedicalResults.DataSource = (from measuredData in user.MeasuredData.AsParallel()
                                    where measuredData.OwnerCode == user.UserCode &&
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
                                        Тип = "Измерение",
                                        Код = measuredData.Number
                                    })
                                .Union(
                                    from healthStatus in _container.HealthStatusSet.AsParallel()
                                    where healthStatus.OwnerCode == user.UserCode &&
                                          DateTime.Compare(healthStatus.CreatingTime, BeginPeriod.Value) != -1 &&
                                          DateTime.Compare(healthStatus.CreatingTime, EndPeriod.Value) != 1
                                    orderby healthStatus.CreatingTime
                                    select new
                                    {
                                        Дата = healthStatus.CreatingTime,
                                        Результат = healthStatus.Status,
                                        Тип = "Статус",
                                        Код = (long) healthStatus.Number
                                    })
                                .ToList();
                            break;
                    }
                }
            }

            MedicalResults.Update();
        }

        void GetOnlyMeasured()
        {
            if (AllPeriodData.Checked)
            {
                if (AllDevicesData.Checked)
                {
                    MedicalResults.DataSource = (from measuredData in _container.MeasuredDataSet.AsParallel()
                        where measuredData.OwnerCode == user.UserCode
                                                 orderby measuredData.CreatingTime
                        select new { Дата = measuredData.CreatingTime, Результат = measuredData.Value, Тип = "Измерение", Код = measuredData.Number }).ToList();
                }
                else
                {
                    switch (ChooseDevice.SelectedIndex)
                    {
                        case 0:
                            MedicalResults.DataSource = (from measuredData in _container.MeasuredDataSet.AsParallel()
                                    orderby measuredData.CreatingTime
                                    where measuredData.OwnerCode == user.UserCode && _container.DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.Glucometer
                                    select new { Дата = measuredData.CreatingTime, Результат = measuredData.Value, Тип = "Измерение", Код = measuredData.Number })
                                .ToList();
                            break;

                        case 1:
                            MedicalResults.DataSource = (from measuredData in _container.MeasuredDataSet.AsParallel()
                                    orderby measuredData.CreatingTime
                                    where measuredData.OwnerCode == user.UserCode && _container.DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.HeartRateMonitor
                                    select new { Дата = measuredData.CreatingTime, Результат = measuredData.Value, Тип = "Измерение", Код = measuredData.Number })
                                .ToList();
                            break;
                        case 2:
                            MedicalResults.DataSource = (from measuredData in _container.MeasuredDataSet.AsParallel()
                                    orderby measuredData.CreatingTime
                                    where measuredData.OwnerCode == user.UserCode && _container.DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.BloodPressureMonitor
                                    select new { Дата = measuredData.CreatingTime, Результат = measuredData.Value, Тип = "Измерение", Код = measuredData.Number })
                                .ToList();
                            break;
                    }
                }
            }

            else
            {
                if (AllDevicesData.Checked)
                {
                    MedicalResults.DataSource = (from measuredData in user.MeasuredData.AsParallel()
                        where measuredData.OwnerCode == user.UserCode && DateTime.Compare(measuredData.CreatingTime, BeginPeriod.Value) != -1 &&
                              DateTime.Compare(measuredData.CreatingTime, EndPeriod.Value) != 1
                        orderby measuredData.CreatingTime
                        select new { Дата = measuredData.CreatingTime, Результат = measuredData.Value, Тип = "Измерение", Код = measuredData.Number }).ToList();
                }
                else
                {
                    switch (ChooseDevice.SelectedIndex)
                    {
                        case 0:
                            MedicalResults.DataSource = (from measuredData in user.MeasuredData.AsParallel()
                                    where measuredData.OwnerCode == user.UserCode && DateTime.Compare(measuredData.CreatingTime, BeginPeriod.Value) != -1 &&
                                          DateTime.Compare(measuredData.CreatingTime, EndPeriod.Value) != 1 &&
                                          _container
                                              .DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.Glucometer
                                    orderby measuredData.CreatingTime
                                    select new { Дата = measuredData.CreatingTime, Результат = measuredData.Value, Тип = "Измерение", Код = measuredData.Number })
                                .ToList();
                            break;

                        case 1:
                            MedicalResults.DataSource = (from measuredData in user.MeasuredData.AsParallel()
                                    where measuredData.OwnerCode == user.UserCode && DateTime.Compare(measuredData.CreatingTime, BeginPeriod.Value) != -1 &&
                                          DateTime.Compare(measuredData.CreatingTime, EndPeriod.Value) != 1 &&
                                          _container
                                              .DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.HeartRateMonitor
                                    orderby measuredData.CreatingTime
                                    select new { Дата = measuredData.CreatingTime, Результат = measuredData.Value, Тип = "Измерение", Код = measuredData.Number })
                                .ToList();
                            break;

                        case 2:
                            MedicalResults.DataSource = (from measuredData in user.MeasuredData.AsParallel()
                                    where measuredData.OwnerCode == user.UserCode&&  DateTime.Compare(measuredData.CreatingTime, BeginPeriod.Value) != -1 &&
                                          DateTime.Compare(measuredData.CreatingTime, EndPeriod.Value) != 1 &&
                                          _container
                                              .DeviceSet.Find(measuredData.DeviceCode).Function ==
                                          DeviceFunction.BloodPressureMonitor
                                    orderby measuredData.CreatingTime
                                    select new { Дата = measuredData.CreatingTime, Результат = measuredData.Value, Тип = "Измерение", Код = measuredData.Number })
                                .ToList();
                            break;
                    }
                }
            }

            MedicalResults.Update();
        }

        void GetOnlyHealthStatus()
        {
            if (AllPeriodData.Checked)
            {
                MedicalResults.DataSource =
                (from healthStatus in _container.HealthStatusSet.AsParallel()
                 where healthStatus.OwnerCode == user.UserCode
                    orderby healthStatus.CreatingTime
                    select new
                    {
                        Дата = healthStatus.CreatingTime,
                        Результат = healthStatus.Status,
                        Тип = "Статус",
                        Код = (long) healthStatus.Number
                    }).ToList();

            }

            else
            {
                MedicalResults.DataSource =
                (from healthStatus in _container.HealthStatusSet.AsParallel()
                 where healthStatus.OwnerCode == user.UserCode && DateTime.Compare(healthStatus.CreatingTime, BeginPeriod.Value) != -1 &&
                          DateTime.Compare(healthStatus.CreatingTime, EndPeriod.Value) != 1
                    orderby healthStatus.CreatingTime
                    select new
                    {
                        Дата = healthStatus.CreatingTime,
                        Результат = healthStatus.Status,
                        Тип = "Статус",
                        Код = (long) healthStatus.Number
                    }).ToList();
            }

            MedicalResults.Update();
        }

        void RefreshMedicalResults()
        {
            _container = new EntityModelContainer();
            
            _healthStatuses = _container.HealthStatusSet;

            user = _container.PatientSet.Find(user.UserCode);

            if (ShowHealthState.Checked && ShowMeasuredData.Checked)
            {
                GetAllResults();
            }
            else
            {
                if (ShowHealthState.Checked)
                    GetOnlyHealthStatus();
                else 
                    GetOnlyMeasured();
            }

            MedicalResults.Update();
            MedicalResults.Columns[0].Width = 100;
            MedicalResults.Columns[1].Width = 205;
            MedicalResults.Columns[2].Visible = false;
            MedicalResults.Columns[3].Visible = false;
        }

        private void ShowMeasuredData_CheckedChanged(object sender, EventArgs e)
        {
            AllDevicesData.Enabled = ShowMeasuredData.Checked;
            ParticularDeviceData.Enabled = ShowMeasuredData.Checked;
        }

        private void UpdateMedicalResults_Click(object sender, EventArgs e)
        {
            RefreshMedicalResults();
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

                    ExcelExportData data = new ExcelExportData(save.FileName, measures, statuses, user);

                    excelThread.Start(data);
                }
            }
        }

        void ReadShownResults(out List<string[]> measures, out List<string[]> statuses)
        {
            measures = new List<string[]>();
            statuses = new List<string[]>();

            for (int row = 0; row < MedicalResults.RowCount; row++)
            {
                string[] result = new string[2];

                for (int column = 0; column < 2; column++)
                {
                    result[column] = MedicalResults.Rows[row].Cells[column].Value.ToString();

                    if (MedicalResults.Rows[row].Cells[2].Value.ToString() == "Статус")
                        statuses.Add(result);
                    else
                        measures.Add(result);
                }
            }
        }

        private void ResultsOptions_Opened(object sender, EventArgs e)
        {
            int row = MedicalResults.SelectedCells[0].RowIndex;

            if (MedicalResults.SelectedCells.Count != 0 && MedicalResults.Rows[row].Cells[2].Value.ToString() == "Статус")
            {
                ResultsOptions.Items[0].Enabled = true;
                ResultsOptions.Items[1].Enabled = true;
            }
            else {
                ResultsOptions.Items[0].Enabled = false;
                ResultsOptions.Items[1].Enabled = false;
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            HealthStatusForm statusForm = new HealthStatusForm();
            statusForm.newStatus = false;

            int row = MedicalResults.SelectedCells[0].RowIndex;

            HealthStatus changed = _container.HealthStatusSet.Find(int.Parse(MedicalResults.Rows[row].Cells[3].Value.ToString()));
            statusForm.status = changed;
            
            statusForm.ShowDialog();

            _container.SaveChanges();
            RefreshMedicalResults();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить данную запись?", "Удаление записи",
                    MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                int row = MedicalResults.SelectedCells[0].RowIndex;

                HealthStatus deleted =
                    _container.HealthStatusSet.Find(int.Parse(MedicalResults.Rows[row].Cells[3].Value.ToString()));
                InformationSystem.DeleteHealthStatus(deleted);
                _container.SaveChanges();
                RefreshMedicalResults();
            }
        }
    }
}
