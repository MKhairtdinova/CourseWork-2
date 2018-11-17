namespace Информационная_система_v2
{
    partial class NewPatientForm
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
            this.ExitNewPatient = new System.Windows.Forms.Button();
            this.PatientName = new System.Windows.Forms.Label();
            this.NewMale = new System.Windows.Forms.CheckBox();
            this.NewFemale = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NewWeight = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NewName = new System.Windows.Forms.TextBox();
            this.NewHeight = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReadExcel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewDateBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NewDeviceType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AllowAccess = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.ExitNewPatient);
            this.panel1.Controls.Add(this.PatientName);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 59);
            this.panel1.TabIndex = 1;
            // 
            // ExitNewPatient
            // 
            this.ExitNewPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitNewPatient.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitNewPatient.FlatAppearance.BorderSize = 0;
            this.ExitNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitNewPatient.Font = new System.Drawing.Font("Myriad Pro Light", 10F, System.Drawing.FontStyle.Bold);
            this.ExitNewPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ExitNewPatient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExitNewPatient.Location = new System.Drawing.Point(261, 14);
            this.ExitNewPatient.Name = "ExitNewPatient";
            this.ExitNewPatient.Size = new System.Drawing.Size(66, 36);
            this.ExitNewPatient.TabIndex = 5;
            this.ExitNewPatient.Text = "Отмена";
            this.ExitNewPatient.UseVisualStyleBackColor = true;
            this.ExitNewPatient.Click += new System.EventHandler(this.ExitNewPatient_Click);
            // 
            // PatientName
            // 
            this.PatientName.AutoSize = true;
            this.PatientName.Font = new System.Drawing.Font("Myriad Pro Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatientName.Location = new System.Drawing.Point(12, 19);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(145, 23);
            this.PatientName.TabIndex = 1;
            this.PatientName.Text = "Новый пациент";
            this.PatientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NewMale
            // 
            this.NewMale.AutoSize = true;
            this.NewMale.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.NewMale.Location = new System.Drawing.Point(44, 133);
            this.NewMale.Name = "NewMale";
            this.NewMale.Size = new System.Drawing.Size(37, 19);
            this.NewMale.TabIndex = 26;
            this.NewMale.Text = "М";
            this.NewMale.UseVisualStyleBackColor = true;
            this.NewMale.CheckedChanged += new System.EventHandler(this.NewMale_CheckedChanged);
            // 
            // NewFemale
            // 
            this.NewFemale.AutoSize = true;
            this.NewFemale.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.NewFemale.Location = new System.Drawing.Point(87, 133);
            this.NewFemale.Name = "NewFemale";
            this.NewFemale.Size = new System.Drawing.Size(37, 19);
            this.NewFemale.TabIndex = 27;
            this.NewFemale.Text = "Ж";
            this.NewFemale.UseVisualStyleBackColor = true;
            this.NewFemale.CheckedChanged += new System.EventHandler(this.NewFemale_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(7, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(122, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Масса";
            // 
            // NewWeight
            // 
            this.NewWeight.Location = new System.Drawing.Point(170, 130);
            this.NewWeight.Mask = "00000";
            this.NewWeight.Name = "NewWeight";
            this.NewWeight.Size = new System.Drawing.Size(37, 23);
            this.NewWeight.TabIndex = 29;
            this.NewWeight.ValidatingType = typeof(int);
            this.NewWeight.Validated += new System.EventHandler(this.NewWeight_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(5, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.label5.Location = new System.Drawing.Point(213, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Рост";
            // 
            // NewName
            // 
            this.NewName.Location = new System.Drawing.Point(49, 64);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(264, 23);
            this.NewName.TabIndex = 22;
            this.NewName.TextChanged += new System.EventHandler(this.NewName_TextChanged);
            // 
            // NewHeight
            // 
            this.NewHeight.Location = new System.Drawing.Point(252, 130);
            this.NewHeight.Mask = "00000";
            this.NewHeight.Name = "NewHeight";
            this.NewHeight.Size = new System.Drawing.Size(37, 23);
            this.NewHeight.TabIndex = 31;
            this.NewHeight.ValidatingType = typeof(int);
            this.NewHeight.Validated += new System.EventHandler(this.NewHeight_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.label6.Location = new System.Drawing.Point(292, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "см";
            // 
            // ReadExcel
            // 
            this.ReadExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadExcel.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9F, System.Drawing.FontStyle.Bold);
            this.ReadExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.ReadExcel.Location = new System.Drawing.Point(8, 22);
            this.ReadExcel.Name = "ReadExcel";
            this.ReadExcel.Size = new System.Drawing.Size(305, 28);
            this.ReadExcel.TabIndex = 20;
            this.ReadExcel.Text = "Загрузить данные из файла";
            this.ReadExcel.UseVisualStyleBackColor = true;
            this.ReadExcel.Click += new System.EventHandler(this.ReadExcel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewDateBirth);
            this.groupBox1.Controls.Add(this.ReadExcel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NewHeight);
            this.groupBox1.Controls.Add(this.NewName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NewWeight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NewFemale);
            this.groupBox1.Controls.Add(this.NewMale);
            this.groupBox1.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox1.Location = new System.Drawing.Point(5, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 161);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные о пациенте";
            // 
            // NewDateBirth
            // 
            this.NewDateBirth.Location = new System.Drawing.Point(107, 97);
            this.NewDateBirth.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.NewDateBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.NewDateBirth.Name = "NewDateBirth";
            this.NewDateBirth.Size = new System.Drawing.Size(206, 23);
            this.NewDateBirth.TabIndex = 33;
            this.NewDateBirth.Value = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(5, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "ФИО";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NewDeviceType);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox2.Location = new System.Drawing.Point(5, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 59);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные о приборе";
            // 
            // NewDeviceType
            // 
            this.NewDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NewDeviceType.FormattingEnabled = true;
            this.NewDeviceType.Items.AddRange(new object[] {
            "Глюкометр",
            "Пульсометр",
            "Измеритель артериального давления"});
            this.NewDeviceType.Location = new System.Drawing.Point(99, 23);
            this.NewDeviceType.Name = "NewDeviceType";
            this.NewDeviceType.Size = new System.Drawing.Size(207, 24);
            this.NewDeviceType.TabIndex = 34;
            this.NewDeviceType.SelectedIndexChanged += new System.EventHandler(this.NewDeviceType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.label7.Location = new System.Drawing.Point(5, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Тип прибора";
            // 
            // SignUp
            // 
            this.SignUp.Enabled = false;
            this.SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9F, System.Drawing.FontStyle.Bold);
            this.SignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.SignUp.Location = new System.Drawing.Point(5, 359);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(319, 28);
            this.SignUp.TabIndex = 33;
            this.SignUp.Text = "Зарегистрировать прибор за пациентом";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AllowAccess);
            this.groupBox3.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox3.Location = new System.Drawing.Point(5, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 59);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Доступ к системе";
            // 
            // AllowAccess
            // 
            this.AllowAccess.AutoSize = true;
            this.AllowAccess.Checked = true;
            this.AllowAccess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllowAccess.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllowAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.AllowAccess.Location = new System.Drawing.Point(10, 22);
            this.AllowAccess.Name = "AllowAccess";
            this.AllowAccess.Size = new System.Drawing.Size(210, 19);
            this.AllowAccess.TabIndex = 34;
            this.AllowAccess.Text = "Предоставить доступ к системе";
            this.AllowAccess.UseVisualStyleBackColor = true;
            // 
            // NewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(329, 394);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "NewPatientForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Регистрация пациента";
            this.Load += new System.EventHandler(this.NewPatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.CheckBox NewMale;
        private System.Windows.Forms.CheckBox NewFemale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox NewWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.MaskedTextBox NewHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ReadExcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox NewDeviceType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.DateTimePicker NewDateBirth;
        private System.Windows.Forms.Button ExitNewPatient;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox AllowAccess;
        private System.Windows.Forms.Label label1;
    }
}