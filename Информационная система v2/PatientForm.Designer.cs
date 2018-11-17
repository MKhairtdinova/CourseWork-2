namespace Информационная_система_v2
{
    partial class PatientForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitPatient = new System.Windows.Forms.Button();
            this.PatientName = new System.Windows.Forms.Label();
            this.GenerateReport = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ChooseDevice = new System.Windows.Forms.ComboBox();
            this.ParticularDeviceData = new System.Windows.Forms.CheckBox();
            this.AllDevicesData = new System.Windows.Forms.CheckBox();
            this.UpdateMedicalResults = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ParticularPeriodData = new System.Windows.Forms.CheckBox();
            this.AllPeriodData = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EndPeriod = new System.Windows.Forms.DateTimePicker();
            this.BeginPeriod = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowMeasuredData = new System.Windows.Forms.CheckBox();
            this.ShowHealthState = new System.Windows.Forms.CheckBox();
            this.MedicalResults = new System.Windows.Forms.DataGridView();
            this.ResultsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Change = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.AddHealthStatus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicalResults)).BeginInit();
            this.ResultsOptions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.ExitPatient);
            this.panel1.Controls.Add(this.PatientName);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ExitPatient
            // 
            resources.ApplyResources(this.ExitPatient, "ExitPatient");
            this.ExitPatient.FlatAppearance.BorderSize = 0;
            this.ExitPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ExitPatient.Name = "ExitPatient";
            this.ExitPatient.UseVisualStyleBackColor = true;
            this.ExitPatient.Click += new System.EventHandler(this.ExitPatient_Click);
            // 
            // PatientName
            // 
            resources.ApplyResources(this.PatientName, "PatientName");
            this.PatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatientName.Name = "PatientName";
            // 
            // GenerateReport
            // 
            resources.ApplyResources(this.GenerateReport, "GenerateReport");
            this.GenerateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.UseVisualStyleBackColor = true;
            this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ChooseDevice);
            this.groupBox4.Controls.Add(this.ParticularDeviceData);
            this.groupBox4.Controls.Add(this.AllDevicesData);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // ChooseDevice
            // 
            this.ChooseDevice.AllowDrop = true;
            this.ChooseDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ChooseDevice, "ChooseDevice");
            this.ChooseDevice.FormattingEnabled = true;
            this.ChooseDevice.Items.AddRange(new object[] {
            resources.GetString("ChooseDevice.Items"),
            resources.GetString("ChooseDevice.Items1"),
            resources.GetString("ChooseDevice.Items2")});
            this.ChooseDevice.Name = "ChooseDevice";
            this.ChooseDevice.Sorted = true;
            // 
            // ParticularDeviceData
            // 
            resources.ApplyResources(this.ParticularDeviceData, "ParticularDeviceData");
            this.ParticularDeviceData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ParticularDeviceData.Name = "ParticularDeviceData";
            this.ParticularDeviceData.UseVisualStyleBackColor = true;
            this.ParticularDeviceData.UseWaitCursor = true;
            this.ParticularDeviceData.CheckedChanged += new System.EventHandler(this.ParticularDeviceData_CheckedChanged);
            // 
            // AllDevicesData
            // 
            resources.ApplyResources(this.AllDevicesData, "AllDevicesData");
            this.AllDevicesData.Checked = true;
            this.AllDevicesData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllDevicesData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.AllDevicesData.Name = "AllDevicesData";
            this.AllDevicesData.UseVisualStyleBackColor = true;
            this.AllDevicesData.CheckedChanged += new System.EventHandler(this.AllDevicesData_CheckedChanged);
            // 
            // UpdateMedicalResults
            // 
            resources.ApplyResources(this.UpdateMedicalResults, "UpdateMedicalResults");
            this.UpdateMedicalResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.UpdateMedicalResults.Name = "UpdateMedicalResults";
            this.UpdateMedicalResults.UseVisualStyleBackColor = true;
            this.UpdateMedicalResults.Click += new System.EventHandler(this.UpdateMedicalResults_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ParticularPeriodData);
            this.groupBox2.Controls.Add(this.AllPeriodData);
            this.groupBox2.Controls.Add(this.panel3);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // ParticularPeriodData
            // 
            resources.ApplyResources(this.ParticularPeriodData, "ParticularPeriodData");
            this.ParticularPeriodData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ParticularPeriodData.Name = "ParticularPeriodData";
            this.ParticularPeriodData.UseVisualStyleBackColor = true;
            this.ParticularPeriodData.CheckedChanged += new System.EventHandler(this.ParticularPeriodData_CheckedChanged);
            // 
            // AllPeriodData
            // 
            resources.ApplyResources(this.AllPeriodData, "AllPeriodData");
            this.AllPeriodData.Checked = true;
            this.AllPeriodData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllPeriodData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.AllPeriodData.Name = "AllPeriodData";
            this.AllPeriodData.UseVisualStyleBackColor = true;
            this.AllPeriodData.CheckedChanged += new System.EventHandler(this.AllPeriodData_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.EndPeriod);
            this.panel3.Controls.Add(this.BeginPeriod);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // EndPeriod
            // 
            this.EndPeriod.CalendarForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.EndPeriod, "EndPeriod");
            this.EndPeriod.Name = "EndPeriod";
            // 
            // BeginPeriod
            // 
            this.BeginPeriod.CalendarForeColor = System.Drawing.Color.Maroon;
            this.BeginPeriod.CalendarTitleForeColor = System.Drawing.Color.White;
            this.BeginPeriod.Checked = false;
            resources.ApplyResources(this.BeginPeriod, "BeginPeriod");
            this.BeginPeriod.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BeginPeriod.Name = "BeginPeriod";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowMeasuredData);
            this.groupBox1.Controls.Add(this.ShowHealthState);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // ShowMeasuredData
            // 
            resources.ApplyResources(this.ShowMeasuredData, "ShowMeasuredData");
            this.ShowMeasuredData.Checked = true;
            this.ShowMeasuredData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowMeasuredData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ShowMeasuredData.Name = "ShowMeasuredData";
            this.ShowMeasuredData.UseVisualStyleBackColor = true;
            this.ShowMeasuredData.CheckedChanged += new System.EventHandler(this.ShowMeasuredData_CheckedChanged);
            // 
            // ShowHealthState
            // 
            resources.ApplyResources(this.ShowHealthState, "ShowHealthState");
            this.ShowHealthState.Checked = true;
            this.ShowHealthState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowHealthState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ShowHealthState.Name = "ShowHealthState";
            this.ShowHealthState.UseVisualStyleBackColor = true;
            // 
            // MedicalResults
            // 
            this.MedicalResults.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MedicalResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MedicalResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicalResults.ContextMenuStrip = this.ResultsOptions;
            resources.ApplyResources(this.MedicalResults, "MedicalResults");
            this.MedicalResults.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MedicalResults.Name = "MedicalResults";
            this.MedicalResults.RowHeadersVisible = false;
            // 
            // ResultsOptions
            // 
            this.ResultsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Change,
            this.Delete});
            this.ResultsOptions.Name = "ResultsOptions";
            resources.ApplyResources(this.ResultsOptions, "ResultsOptions");
            this.ResultsOptions.Opened += new System.EventHandler(this.ResultsOptions_Opened);
            // 
            // Change
            // 
            this.Change.Name = "Change";
            resources.ApplyResources(this.Change, "Change");
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MedicalResults);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.AddHealthStatus);
            this.groupBox5.Controls.Add(this.UpdateMedicalResults);
            this.groupBox5.Controls.Add(this.GenerateReport);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // AddHealthStatus
            // 
            resources.ApplyResources(this.AddHealthStatus, "AddHealthStatus");
            this.AddHealthStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.AddHealthStatus.Name = "AddHealthStatus";
            this.AddHealthStatus.UseVisualStyleBackColor = true;
            this.AddHealthStatus.Click += new System.EventHandler(this.AddHealthStatus_Click);
            // 
            // PatientForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "PatientForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicalResults)).EndInit();
            this.ResultsOptions.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.Button GenerateReport;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox ChooseDevice;
        private System.Windows.Forms.CheckBox ParticularDeviceData;
        private System.Windows.Forms.CheckBox AllDevicesData;
        private System.Windows.Forms.Button UpdateMedicalResults;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ParticularPeriodData;
        private System.Windows.Forms.CheckBox AllPeriodData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker EndPeriod;
        private System.Windows.Forms.DateTimePicker BeginPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ShowMeasuredData;
        private System.Windows.Forms.CheckBox ShowHealthState;
        private System.Windows.Forms.DataGridView MedicalResults;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button AddHealthStatus;
        private System.Windows.Forms.Button ExitPatient;
        private System.Windows.Forms.ContextMenuStrip ResultsOptions;
        private System.Windows.Forms.ToolStripMenuItem Change;
        private System.Windows.Forms.ToolStripMenuItem Delete;
    }
}