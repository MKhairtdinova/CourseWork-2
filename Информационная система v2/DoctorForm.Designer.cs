namespace Информационная_система_v2
{
    partial class DoctorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitDoctor = new System.Windows.Forms.Button();
            this.DoctorName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PatientsList = new System.Windows.Forms.DataGridView();
            this.PatientListOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowData = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePatient = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdatePatientList = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PatientCodeSearch = new System.Windows.Forms.TextBox();
            this.CodeSearch = new System.Windows.Forms.CheckBox();
            this.AllPatientsSearch = new System.Windows.Forms.CheckBox();
            this.NameSearch = new System.Windows.Forms.CheckBox();
            this.PatientNameSearch = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NewPatientSearch = new System.Windows.Forms.Button();
            this.AddNewPatient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsList)).BeginInit();
            this.PatientListOptions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.ExitDoctor);
            this.panel1.Controls.Add(this.DoctorName);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 53);
            this.panel1.TabIndex = 0;
            // 
            // ExitDoctor
            // 
            this.ExitDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitDoctor.FlatAppearance.BorderSize = 0;
            this.ExitDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitDoctor.Font = new System.Drawing.Font("Myriad Pro Light", 10F, System.Drawing.FontStyle.Bold);
            this.ExitDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ExitDoctor.Location = new System.Drawing.Point(589, 8);
            this.ExitDoctor.Name = "ExitDoctor";
            this.ExitDoctor.Size = new System.Drawing.Size(57, 36);
            this.ExitDoctor.TabIndex = 4;
            this.ExitDoctor.Text = "Выйти";
            this.ExitDoctor.UseVisualStyleBackColor = true;
            this.ExitDoctor.Click += new System.EventHandler(this.ExitDoctor_Click);
            // 
            // DoctorName
            // 
            this.DoctorName.AutoSize = true;
            this.DoctorName.Font = new System.Drawing.Font("Myriad Pro Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DoctorName.Location = new System.Drawing.Point(13, 13);
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.Size = new System.Drawing.Size(169, 23);
            this.DoctorName.TabIndex = 1;
            this.DoctorName.Text = "Полное имя врача";
            this.DoctorName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PatientsList);
            this.groupBox1.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 304);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Мои пациенты";
            // 
            // PatientsList
            // 
            this.PatientsList.AllowUserToAddRows = false;
            this.PatientsList.AllowUserToDeleteRows = false;
            this.PatientsList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PatientsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PatientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsList.ContextMenuStrip = this.PatientListOptions;
            this.PatientsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientsList.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PatientsList.Location = new System.Drawing.Point(3, 19);
            this.PatientsList.Name = "PatientsList";
            this.PatientsList.ReadOnly = true;
            this.PatientsList.RowHeadersVisible = false;
            this.PatientsList.Size = new System.Drawing.Size(377, 282);
            this.PatientsList.TabIndex = 0;
            // 
            // PatientListOptions
            // 
            this.PatientListOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowData,
            this.DeletePatient,
            this.AddDevice});
            this.PatientListOptions.Name = "PatientListOptions";
            this.PatientListOptions.Size = new System.Drawing.Size(236, 70);
            this.PatientListOptions.Opened += new System.EventHandler(this.PatientListOptions_Opened);
            // 
            // ShowData
            // 
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(235, 22);
            this.ShowData.Text = "Просмотреть данные";
            this.ShowData.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // DeletePatient
            // 
            this.DeletePatient.Name = "DeletePatient";
            this.DeletePatient.Size = new System.Drawing.Size(235, 22);
            this.DeletePatient.Text = "Удалить из списка пациентов";
            this.DeletePatient.Click += new System.EventHandler(this.DeletePatient_Click);
            // 
            // AddDevice
            // 
            this.AddDevice.Name = "AddDevice";
            this.AddDevice.Size = new System.Drawing.Size(235, 22);
            this.AddDevice.Text = "Добавить прибор";
            this.AddDevice.Click += new System.EventHandler(this.AddDevice_Click);
            // 
            // UpdatePatientList
            // 
            this.UpdatePatientList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdatePatientList.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9F, System.Drawing.FontStyle.Bold);
            this.UpdatePatientList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.UpdatePatientList.Location = new System.Drawing.Point(6, 153);
            this.UpdatePatientList.Name = "UpdatePatientList";
            this.UpdatePatientList.Size = new System.Drawing.Size(232, 28);
            this.UpdatePatientList.TabIndex = 19;
            this.UpdatePatientList.Text = "Обновить таблицу";
            this.UpdatePatientList.UseVisualStyleBackColor = true;
            this.UpdatePatientList.Click += new System.EventHandler(this.UpdatePatientList_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PatientCodeSearch);
            this.groupBox2.Controls.Add(this.UpdatePatientList);
            this.groupBox2.Controls.Add(this.CodeSearch);
            this.groupBox2.Controls.Add(this.AllPatientsSearch);
            this.groupBox2.Controls.Add(this.NameSearch);
            this.groupBox2.Controls.Add(this.PatientNameSearch);
            this.groupBox2.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox2.Location = new System.Drawing.Point(401, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 190);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск моих пациентов";
            // 
            // PatientCodeSearch
            // 
            this.PatientCodeSearch.Enabled = false;
            this.PatientCodeSearch.Location = new System.Drawing.Point(6, 124);
            this.PatientCodeSearch.Name = "PatientCodeSearch";
            this.PatientCodeSearch.Size = new System.Drawing.Size(232, 23);
            this.PatientCodeSearch.TabIndex = 10;
            // 
            // CodeSearch
            // 
            this.CodeSearch.AutoSize = true;
            this.CodeSearch.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.CodeSearch.Location = new System.Drawing.Point(6, 99);
            this.CodeSearch.Name = "CodeSearch";
            this.CodeSearch.Size = new System.Drawing.Size(111, 19);
            this.CodeSearch.TabIndex = 9;
            this.CodeSearch.Text = "Поиск по коду";
            this.CodeSearch.UseVisualStyleBackColor = true;
            this.CodeSearch.CheckedChanged += new System.EventHandler(this.CodeSearch_CheckedChanged);
            // 
            // AllPatientsSearch
            // 
            this.AllPatientsSearch.AutoSize = true;
            this.AllPatientsSearch.Checked = true;
            this.AllPatientsSearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllPatientsSearch.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPatientsSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.AllPatientsSearch.Location = new System.Drawing.Point(6, 22);
            this.AllPatientsSearch.Name = "AllPatientsSearch";
            this.AllPatientsSearch.Size = new System.Drawing.Size(104, 19);
            this.AllPatientsSearch.TabIndex = 8;
            this.AllPatientsSearch.Text = "Все пациенты";
            this.AllPatientsSearch.UseVisualStyleBackColor = true;
            // 
            // NameSearch
            // 
            this.NameSearch.AutoSize = true;
            this.NameSearch.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.NameSearch.Location = new System.Drawing.Point(6, 45);
            this.NameSearch.Name = "NameSearch";
            this.NameSearch.Size = new System.Drawing.Size(122, 19);
            this.NameSearch.TabIndex = 7;
            this.NameSearch.Text = "Поиск по имени";
            this.NameSearch.UseVisualStyleBackColor = true;
            this.NameSearch.CheckedChanged += new System.EventHandler(this.NameSearch_CheckedChanged);
            // 
            // PatientNameSearch
            // 
            this.PatientNameSearch.Enabled = false;
            this.PatientNameSearch.Location = new System.Drawing.Point(6, 70);
            this.PatientNameSearch.Name = "PatientNameSearch";
            this.PatientNameSearch.Size = new System.Drawing.Size(232, 23);
            this.PatientNameSearch.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NewPatientSearch);
            this.groupBox3.Controls.Add(this.AddNewPatient);
            this.groupBox3.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox3.Location = new System.Drawing.Point(401, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 108);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавление пациента ";
            // 
            // NewPatientSearch
            // 
            this.NewPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewPatientSearch.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9F, System.Drawing.FontStyle.Bold);
            this.NewPatientSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.NewPatientSearch.Location = new System.Drawing.Point(6, 65);
            this.NewPatientSearch.Name = "NewPatientSearch";
            this.NewPatientSearch.Size = new System.Drawing.Size(232, 28);
            this.NewPatientSearch.TabIndex = 21;
            this.NewPatientSearch.Text = "Поиск пациента";
            this.NewPatientSearch.UseVisualStyleBackColor = true;
            this.NewPatientSearch.Click += new System.EventHandler(this.NewPatientSearch_Click);
            // 
            // AddNewPatient
            // 
            this.AddNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewPatient.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9F, System.Drawing.FontStyle.Bold);
            this.AddNewPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.AddNewPatient.Location = new System.Drawing.Point(6, 22);
            this.AddNewPatient.Name = "AddNewPatient";
            this.AddNewPatient.Size = new System.Drawing.Size(232, 28);
            this.AddNewPatient.TabIndex = 20;
            this.AddNewPatient.Text = "Регистрация пациента";
            this.AddNewPatient.UseVisualStyleBackColor = true;
            this.AddNewPatient.Click += new System.EventHandler(this.AddNewPatient_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 369);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "DoctorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Система учета физической активности";
            this.Activated += new System.EventHandler(this.DoctorForm_Activated);
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsList)).EndInit();
            this.PatientListOptions.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DoctorName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView PatientsList;
        private System.Windows.Forms.Button UpdatePatientList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PatientNameSearch;
        private System.Windows.Forms.CheckBox AllPatientsSearch;
        private System.Windows.Forms.CheckBox NameSearch;
        private System.Windows.Forms.TextBox PatientCodeSearch;
        private System.Windows.Forms.CheckBox CodeSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AddNewPatient;
        private System.Windows.Forms.Button ExitDoctor;
        private System.Windows.Forms.ContextMenuStrip PatientListOptions;
        private System.Windows.Forms.ToolStripMenuItem ShowData;
        private System.Windows.Forms.ToolStripMenuItem DeletePatient;
        private System.Windows.Forms.Button NewPatientSearch;
        private System.Windows.Forms.ToolStripMenuItem AddDevice;
    }
}