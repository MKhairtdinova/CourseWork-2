namespace Информационная_система_v2
{
    partial class PatientDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.PatientName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PatientResults = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PatientHeight = new System.Windows.Forms.Label();
            this.PatientWeight = new System.Windows.Forms.Label();
            this.PatientMale = new System.Windows.Forms.Label();
            this.PatientBirthDate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ShowMeasuredData = new System.Windows.Forms.CheckBox();
            this.ShowHealthState = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ParticularPeriodData = new System.Windows.Forms.CheckBox();
            this.AllPeriodData = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EndPeriod = new System.Windows.Forms.DateTimePicker();
            this.BeginPeriod = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ChooseDevice = new System.Windows.Forms.ComboBox();
            this.ParticularDeviceData = new System.Windows.Forms.CheckBox();
            this.AllDevicesData = new System.Windows.Forms.CheckBox();
            this.GenerateReport = new System.Windows.Forms.Button();
            this.UpdateTable = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientResults)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.PatientName);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 59);
            this.panel1.TabIndex = 2;
            // 
            // PatientName
            // 
            this.PatientName.AutoSize = true;
            this.PatientName.Font = new System.Drawing.Font("Myriad Pro Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatientName.Location = new System.Drawing.Point(4, 19);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(136, 23);
            this.PatientName.TabIndex = 1;
            this.PatientName.Text = "ФИО пациента";
            this.PatientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PatientResults);
            this.groupBox1.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox1.Location = new System.Drawing.Point(247, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 427);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные исследований";
            // 
            // PatientResults
            // 
            this.PatientResults.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PatientResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PatientResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientResults.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PatientResults.Location = new System.Drawing.Point(3, 19);
            this.PatientResults.Name = "PatientResults";
            this.PatientResults.RowHeadersVisible = false;
            this.PatientResults.Size = new System.Drawing.Size(347, 405);
            this.PatientResults.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Пол";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Рост";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Масса";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PatientHeight);
            this.groupBox2.Controls.Add(this.PatientWeight);
            this.groupBox2.Controls.Add(this.PatientMale);
            this.groupBox2.Controls.Add(this.PatientBirthDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox2.Location = new System.Drawing.Point(8, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 127);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные о пациенте";
            // 
            // PatientHeight
            // 
            this.PatientHeight.AutoSize = true;
            this.PatientHeight.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.PatientHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.PatientHeight.Location = new System.Drawing.Point(113, 105);
            this.PatientHeight.Name = "PatientHeight";
            this.PatientHeight.Size = new System.Drawing.Size(33, 15);
            this.PatientHeight.TabIndex = 29;
            this.PatientHeight.Text = "Рост";
            // 
            // PatientWeight
            // 
            this.PatientWeight.AutoSize = true;
            this.PatientWeight.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.PatientWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.PatientWeight.Location = new System.Drawing.Point(113, 81);
            this.PatientWeight.Name = "PatientWeight";
            this.PatientWeight.Size = new System.Drawing.Size(42, 15);
            this.PatientWeight.TabIndex = 28;
            this.PatientWeight.Text = "Масса";
            // 
            // PatientMale
            // 
            this.PatientMale.AutoSize = true;
            this.PatientMale.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.PatientMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.PatientMale.Location = new System.Drawing.Point(113, 55);
            this.PatientMale.Name = "PatientMale";
            this.PatientMale.Size = new System.Drawing.Size(31, 15);
            this.PatientMale.TabIndex = 27;
            this.PatientMale.Text = "Пол";
            // 
            // PatientBirthDate
            // 
            this.PatientBirthDate.AutoSize = true;
            this.PatientBirthDate.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.PatientBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.PatientBirthDate.Location = new System.Drawing.Point(113, 30);
            this.PatientBirthDate.Name = "PatientBirthDate";
            this.PatientBirthDate.Size = new System.Drawing.Size(32, 15);
            this.PatientBirthDate.TabIndex = 26;
            this.PatientBirthDate.Text = "Дата";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ShowMeasuredData);
            this.groupBox3.Controls.Add(this.ShowHealthState);
            this.groupBox3.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox3.Location = new System.Drawing.Point(8, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 74);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Типы наблюдений";
            // 
            // ShowMeasuredData
            // 
            this.ShowMeasuredData.AutoSize = true;
            this.ShowMeasuredData.Checked = true;
            this.ShowMeasuredData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowMeasuredData.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.ShowMeasuredData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ShowMeasuredData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ShowMeasuredData.Location = new System.Drawing.Point(6, 47);
            this.ShowMeasuredData.Name = "ShowMeasuredData";
            this.ShowMeasuredData.Size = new System.Drawing.Size(157, 19);
            this.ShowMeasuredData.TabIndex = 3;
            this.ShowMeasuredData.Text = "Измерения приборов";
            this.ShowMeasuredData.UseVisualStyleBackColor = true;
            // 
            // ShowHealthState
            // 
            this.ShowHealthState.AutoSize = true;
            this.ShowHealthState.Checked = true;
            this.ShowHealthState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowHealthState.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.ShowHealthState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ShowHealthState.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ShowHealthState.Location = new System.Drawing.Point(6, 22);
            this.ShowHealthState.Name = "ShowHealthState";
            this.ShowHealthState.Size = new System.Drawing.Size(205, 19);
            this.ShowHealthState.TabIndex = 2;
            this.ShowHealthState.Text = "Записи о состоянии здоровья";
            this.ShowHealthState.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ParticularPeriodData);
            this.groupBox4.Controls.Add(this.AllPeriodData);
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox4.Location = new System.Drawing.Point(8, 278);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 145);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Период наблюдения";
            // 
            // ParticularPeriodData
            // 
            this.ParticularPeriodData.AutoSize = true;
            this.ParticularPeriodData.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.ParticularPeriodData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ParticularPeriodData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ParticularPeriodData.Location = new System.Drawing.Point(6, 44);
            this.ParticularPeriodData.Name = "ParticularPeriodData";
            this.ParticularPeriodData.Size = new System.Drawing.Size(170, 19);
            this.ParticularPeriodData.TabIndex = 5;
            this.ParticularPeriodData.Text = "За промежуток времени:";
            this.ParticularPeriodData.UseVisualStyleBackColor = true;
            this.ParticularPeriodData.CheckedChanged += new System.EventHandler(this.ParticularPeriodData_CheckedChanged);
            // 
            // AllPeriodData
            // 
            this.AllPeriodData.AutoSize = true;
            this.AllPeriodData.Checked = true;
            this.AllPeriodData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllPeriodData.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.AllPeriodData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.AllPeriodData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AllPeriodData.Location = new System.Drawing.Point(6, 19);
            this.AllPeriodData.Name = "AllPeriodData";
            this.AllPeriodData.Size = new System.Drawing.Size(116, 19);
            this.AllPeriodData.TabIndex = 4;
            this.AllPeriodData.Text = "За весь период";
            this.AllPeriodData.UseVisualStyleBackColor = true;
            this.AllPeriodData.CheckedChanged += new System.EventHandler(this.AllPeriodData_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.EndPeriod);
            this.panel3.Controls.Add(this.BeginPeriod);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(2, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 70);
            this.panel3.TabIndex = 7;
            // 
            // EndPeriod
            // 
            this.EndPeriod.CalendarForeColor = System.Drawing.Color.White;
            this.EndPeriod.Enabled = false;
            this.EndPeriod.Location = new System.Drawing.Point(37, 37);
            this.EndPeriod.MinDate = new System.DateTime(2018, 3, 8, 0, 0, 0, 0);
            this.EndPeriod.Name = "EndPeriod";
            this.EndPeriod.Size = new System.Drawing.Size(137, 23);
            this.EndPeriod.TabIndex = 7;
            // 
            // BeginPeriod
            // 
            this.BeginPeriod.CalendarForeColor = System.Drawing.Color.Maroon;
            this.BeginPeriod.CalendarTitleForeColor = System.Drawing.Color.White;
            this.BeginPeriod.Checked = false;
            this.BeginPeriod.CustomFormat = "";
            this.BeginPeriod.Enabled = false;
            this.BeginPeriod.Location = new System.Drawing.Point(37, 8);
            this.BeginPeriod.MinDate = new System.DateTime(2018, 3, 8, 0, 0, 0, 0);
            this.BeginPeriod.Name = "BeginPeriod";
            this.BeginPeriod.Size = new System.Drawing.Size(137, 23);
            this.BeginPeriod.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(7, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "По";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(16, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "С";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ChooseDevice);
            this.groupBox5.Controls.Add(this.ParticularDeviceData);
            this.groupBox5.Controls.Add(this.AllDevicesData);
            this.groupBox5.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox5.Location = new System.Drawing.Point(8, 429);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(233, 104);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Приборы";
            // 
            // ChooseDevice
            // 
            this.ChooseDevice.AllowDrop = true;
            this.ChooseDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseDevice.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.ChooseDevice.FormattingEnabled = true;
            this.ChooseDevice.Location = new System.Drawing.Point(6, 69);
            this.ChooseDevice.Name = "ChooseDevice";
            this.ChooseDevice.Size = new System.Drawing.Size(205, 23);
            this.ChooseDevice.Sorted = true;
            this.ChooseDevice.TabIndex = 6;
            // 
            // ParticularDeviceData
            // 
            this.ParticularDeviceData.AutoSize = true;
            this.ParticularDeviceData.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.ParticularDeviceData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ParticularDeviceData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ParticularDeviceData.Location = new System.Drawing.Point(6, 44);
            this.ParticularDeviceData.Name = "ParticularDeviceData";
            this.ParticularDeviceData.Size = new System.Drawing.Size(123, 19);
            this.ParticularDeviceData.TabIndex = 5;
            this.ParticularDeviceData.Text = "Выбрать прибор";
            this.ParticularDeviceData.UseVisualStyleBackColor = true;
            this.ParticularDeviceData.UseWaitCursor = true;
            this.ParticularDeviceData.CheckedChanged += new System.EventHandler(this.ParticularDeviceData_CheckedChanged);
            // 
            // AllDevicesData
            // 
            this.AllDevicesData.AutoSize = true;
            this.AllDevicesData.Checked = true;
            this.AllDevicesData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllDevicesData.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.AllDevicesData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.AllDevicesData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AllDevicesData.Location = new System.Drawing.Point(6, 19);
            this.AllDevicesData.Name = "AllDevicesData";
            this.AllDevicesData.Size = new System.Drawing.Size(193, 19);
            this.AllDevicesData.TabIndex = 4;
            this.AllDevicesData.Text = "Наблюдения всех приборов";
            this.AllDevicesData.UseVisualStyleBackColor = true;
            this.AllDevicesData.CheckedChanged += new System.EventHandler(this.AllDevicesData_CheckedChanged);
            // 
            // GenerateReport
            // 
            this.GenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateReport.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9F, System.Drawing.FontStyle.Bold);
            this.GenerateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.GenerateReport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GenerateReport.Location = new System.Drawing.Point(430, 505);
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Size = new System.Drawing.Size(167, 28);
            this.GenerateReport.TabIndex = 21;
            this.GenerateReport.Text = "Сгенерировать отчет";
            this.GenerateReport.UseVisualStyleBackColor = true;
            this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // UpdateTable
            // 
            this.UpdateTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateTable.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9F, System.Drawing.FontStyle.Bold);
            this.UpdateTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.UpdateTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UpdateTable.Location = new System.Drawing.Point(250, 505);
            this.UpdateTable.Name = "UpdateTable";
            this.UpdateTable.Size = new System.Drawing.Size(152, 28);
            this.UpdateTable.TabIndex = 30;
            this.UpdateTable.Text = "Обновить таблицу";
            this.UpdateTable.UseVisualStyleBackColor = true;
            this.UpdateTable.Click += new System.EventHandler(this.UpdateTable_Click);
            // 
            // PatientDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(612, 539);
            this.Controls.Add(this.UpdateTable);
            this.Controls.Add(this.GenerateReport);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "PatientDataForm";
            this.Text = "Данные пациента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatientDataForm_FormClosing);
            this.Load += new System.EventHandler(this.PatientDataForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatientResults)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView PatientResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label PatientBirthDate;
        private System.Windows.Forms.Label PatientHeight;
        private System.Windows.Forms.Label PatientWeight;
        private System.Windows.Forms.Label PatientMale;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ShowMeasuredData;
        private System.Windows.Forms.CheckBox ShowHealthState;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ParticularPeriodData;
        private System.Windows.Forms.CheckBox AllPeriodData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker EndPeriod;
        private System.Windows.Forms.DateTimePicker BeginPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox ChooseDevice;
        private System.Windows.Forms.CheckBox ParticularDeviceData;
        private System.Windows.Forms.CheckBox AllDevicesData;
        private System.Windows.Forms.Button GenerateReport;
        private System.Windows.Forms.Button UpdateTable;
    }
}