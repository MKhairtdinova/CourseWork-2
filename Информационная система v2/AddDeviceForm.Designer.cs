namespace Информационная_система_v2
{
    partial class AddDeviceForm
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
            this.ExitAddDevice = new System.Windows.Forms.Button();
            this.PatientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddDeviceType = new System.Windows.Forms.ComboBox();
            this.AddDeviceToPatient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.ExitAddDevice);
            this.panel1.Controls.Add(this.PatientName);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 59);
            this.panel1.TabIndex = 2;
            // 
            // ExitAddDevice
            // 
            this.ExitAddDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitAddDevice.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitAddDevice.FlatAppearance.BorderSize = 0;
            this.ExitAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitAddDevice.Font = new System.Drawing.Font("Myriad Pro Light", 10F, System.Drawing.FontStyle.Bold);
            this.ExitAddDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ExitAddDevice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExitAddDevice.Location = new System.Drawing.Point(218, 14);
            this.ExitAddDevice.Name = "ExitAddDevice";
            this.ExitAddDevice.Size = new System.Drawing.Size(66, 36);
            this.ExitAddDevice.TabIndex = 5;
            this.ExitAddDevice.Text = "Отмена";
            this.ExitAddDevice.UseVisualStyleBackColor = true;
            this.ExitAddDevice.Click += new System.EventHandler(this.ExitAddDevice_Click);
            // 
            // PatientName
            // 
            this.PatientName.AutoSize = true;
            this.PatientName.Font = new System.Drawing.Font("Myriad Pro Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatientName.Location = new System.Drawing.Point(12, 19);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(164, 23);
            this.PatientName.TabIndex = 1;
            this.PatientName.Text = "Добавить прибор";
            this.PatientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(86, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Выберите прибор, ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(48, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "который необходимо закрепить";
            // 
            // AddDeviceType
            // 
            this.AddDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddDeviceType.FormattingEnabled = true;
            this.AddDeviceType.Items.AddRange(new object[] {
            "Глюкометр",
            "Пульсометр",
            "Измеритель артериального давления"});
            this.AddDeviceType.Location = new System.Drawing.Point(16, 94);
            this.AddDeviceType.Name = "AddDeviceType";
            this.AddDeviceType.Size = new System.Drawing.Size(258, 21);
            this.AddDeviceType.TabIndex = 35;
            this.AddDeviceType.SelectedIndexChanged += new System.EventHandler(this.AddDeviceType_SelectedIndexChanged);
            // 
            // AddDeviceToPatient
            // 
            this.AddDeviceToPatient.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddDeviceToPatient.Enabled = false;
            this.AddDeviceToPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDeviceToPatient.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9F, System.Drawing.FontStyle.Bold);
            this.AddDeviceToPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.AddDeviceToPatient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddDeviceToPatient.Location = new System.Drawing.Point(67, 121);
            this.AddDeviceToPatient.Name = "AddDeviceToPatient";
            this.AddDeviceToPatient.Size = new System.Drawing.Size(152, 28);
            this.AddDeviceToPatient.TabIndex = 36;
            this.AddDeviceToPatient.Text = "Закрепить прибор";
            this.AddDeviceToPatient.UseVisualStyleBackColor = true;
            this.AddDeviceToPatient.Click += new System.EventHandler(this.AddDeviceToPatient_Click);
            // 
            // AddDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(286, 160);
            this.Controls.Add(this.AddDeviceToPatient);
            this.Controls.Add(this.AddDeviceType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AddDeviceForm";
            this.Text = "Выбор прибора";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitAddDevice;
        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AddDeviceType;
        private System.Windows.Forms.Button AddDeviceToPatient;
    }
}