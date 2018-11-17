namespace Информационная_система_v2
{
    partial class HealthStatusForm
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
            this.ExitHealthStatus = new System.Windows.Forms.Button();
            this.PatientName = new System.Windows.Forms.Label();
            this.Ailment = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HighBloodPressure = new System.Windows.Forms.CheckBox();
            this.LowBloodPressure = new System.Windows.Forms.CheckBox();
            this.Dizziness = new System.Windows.Forms.CheckBox();
            this.Fever = new System.Windows.Forms.CheckBox();
            this.Headache = new System.Windows.Forms.CheckBox();
            this.Insomnia = new System.Windows.Forms.CheckBox();
            this.Nausea = new System.Windows.Forms.CheckBox();
            this.Fatigue = new System.Windows.Forms.CheckBox();
            this.DryMouth = new System.Windows.Forms.CheckBox();
            this.IncreasedWeigh = new System.Windows.Forms.CheckBox();
            this.DecreasedWeigh = new System.Windows.Forms.CheckBox();
            this.Weakness = new System.Windows.Forms.CheckBox();
            this.Thirst = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddHealthStatus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.ExitHealthStatus);
            this.panel1.Controls.Add(this.PatientName);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 59);
            this.panel1.TabIndex = 2;
            // 
            // ExitHealthStatus
            // 
            this.ExitHealthStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitHealthStatus.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitHealthStatus.FlatAppearance.BorderSize = 0;
            this.ExitHealthStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitHealthStatus.Font = new System.Drawing.Font("Myriad Pro Light", 10F, System.Drawing.FontStyle.Bold);
            this.ExitHealthStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ExitHealthStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExitHealthStatus.Location = new System.Drawing.Point(275, 14);
            this.ExitHealthStatus.Name = "ExitHealthStatus";
            this.ExitHealthStatus.Size = new System.Drawing.Size(66, 36);
            this.ExitHealthStatus.TabIndex = 4;
            this.ExitHealthStatus.Text = "Отмена";
            this.ExitHealthStatus.UseVisualStyleBackColor = true;
            this.ExitHealthStatus.Click += new System.EventHandler(this.ExitHealthStatus_Click);
            // 
            // PatientName
            // 
            this.PatientName.AutoSize = true;
            this.PatientName.Font = new System.Drawing.Font("Myriad Pro Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatientName.Location = new System.Drawing.Point(12, 19);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(189, 23);
            this.PatientName.TabIndex = 1;
            this.PatientName.Text = "Состояние здоровья";
            this.PatientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Ailment
            // 
            this.Ailment.AutoSize = true;
            this.Ailment.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.Ailment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Ailment.Location = new System.Drawing.Point(6, 25);
            this.Ailment.Name = "Ailment";
            this.Ailment.Size = new System.Drawing.Size(106, 19);
            this.Ailment.TabIndex = 3;
            this.Ailment.Text = "Недомогание";
            this.Ailment.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отметьте все симптомы, которые Вы сейчас ощущаете";
            // 
            // HighBloodPressure
            // 
            this.HighBloodPressure.AutoSize = true;
            this.HighBloodPressure.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.HighBloodPressure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.HighBloodPressure.Location = new System.Drawing.Point(6, 50);
            this.HighBloodPressure.Name = "HighBloodPressure";
            this.HighBloodPressure.Size = new System.Drawing.Size(163, 19);
            this.HighBloodPressure.TabIndex = 5;
            this.HighBloodPressure.Text = "Повышенное давление";
            this.HighBloodPressure.UseVisualStyleBackColor = true;
            // 
            // LowBloodPressure
            // 
            this.LowBloodPressure.AutoSize = true;
            this.LowBloodPressure.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.LowBloodPressure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.LowBloodPressure.Location = new System.Drawing.Point(176, 50);
            this.LowBloodPressure.Name = "LowBloodPressure";
            this.LowBloodPressure.Size = new System.Drawing.Size(162, 19);
            this.LowBloodPressure.TabIndex = 6;
            this.LowBloodPressure.Text = "Пониженное давление";
            this.LowBloodPressure.UseVisualStyleBackColor = true;
            // 
            // Dizziness
            // 
            this.Dizziness.AutoSize = true;
            this.Dizziness.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.Dizziness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Dizziness.Location = new System.Drawing.Point(176, 25);
            this.Dizziness.Name = "Dizziness";
            this.Dizziness.Size = new System.Drawing.Size(127, 19);
            this.Dizziness.TabIndex = 7;
            this.Dizziness.Text = "Головокружение";
            this.Dizziness.UseVisualStyleBackColor = true;
            // 
            // Fever
            // 
            this.Fever.AutoSize = true;
            this.Fever.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.Fever.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Fever.Location = new System.Drawing.Point(6, 75);
            this.Fever.Name = "Fever";
            this.Fever.Size = new System.Drawing.Size(51, 19);
            this.Fever.TabIndex = 8;
            this.Fever.Text = "Жар";
            this.Fever.UseVisualStyleBackColor = true;
            // 
            // Headache
            // 
            this.Headache.AutoSize = true;
            this.Headache.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.Headache.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Headache.Location = new System.Drawing.Point(176, 75);
            this.Headache.Name = "Headache";
            this.Headache.Size = new System.Drawing.Size(113, 19);
            this.Headache.TabIndex = 9;
            this.Headache.Text = "Головная боль";
            this.Headache.UseVisualStyleBackColor = true;
            // 
            // Insomnia
            // 
            this.Insomnia.AutoSize = true;
            this.Insomnia.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.Insomnia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Insomnia.Location = new System.Drawing.Point(6, 100);
            this.Insomnia.Name = "Insomnia";
            this.Insomnia.Size = new System.Drawing.Size(95, 19);
            this.Insomnia.TabIndex = 10;
            this.Insomnia.Text = "Бессонница";
            this.Insomnia.UseVisualStyleBackColor = true;
            // 
            // Nausea
            // 
            this.Nausea.AutoSize = true;
            this.Nausea.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.Nausea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Nausea.Location = new System.Drawing.Point(176, 100);
            this.Nausea.Name = "Nausea";
            this.Nausea.Size = new System.Drawing.Size(76, 19);
            this.Nausea.TabIndex = 11;
            this.Nausea.Text = "Тошнота";
            this.Nausea.UseVisualStyleBackColor = true;
            // 
            // Fatigue
            // 
            this.Fatigue.AutoSize = true;
            this.Fatigue.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.Fatigue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Fatigue.Location = new System.Drawing.Point(6, 125);
            this.Fatigue.Name = "Fatigue";
            this.Fatigue.Size = new System.Drawing.Size(82, 19);
            this.Fatigue.TabIndex = 12;
            this.Fatigue.Text = "Усталость";
            this.Fatigue.UseVisualStyleBackColor = true;
            // 
            // DryMouth
            // 
            this.DryMouth.AutoSize = true;
            this.DryMouth.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.DryMouth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.DryMouth.Location = new System.Drawing.Point(176, 125);
            this.DryMouth.Name = "DryMouth";
            this.DryMouth.Size = new System.Drawing.Size(112, 19);
            this.DryMouth.TabIndex = 13;
            this.DryMouth.Text = "Сухость во рту";
            this.DryMouth.UseVisualStyleBackColor = true;
            // 
            // IncreasedWeigh
            // 
            this.IncreasedWeigh.AutoSize = true;
            this.IncreasedWeigh.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.IncreasedWeigh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.IncreasedWeigh.Location = new System.Drawing.Point(6, 150);
            this.IncreasedWeigh.Name = "IncreasedWeigh";
            this.IncreasedWeigh.Size = new System.Drawing.Size(136, 19);
            this.IncreasedWeigh.TabIndex = 14;
            this.IncreasedWeigh.Text = "Прибавление веса";
            this.IncreasedWeigh.UseVisualStyleBackColor = true;
            // 
            // DecreasedWeigh
            // 
            this.DecreasedWeigh.AutoSize = true;
            this.DecreasedWeigh.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.DecreasedWeigh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.DecreasedWeigh.Location = new System.Drawing.Point(176, 150);
            this.DecreasedWeigh.Name = "DecreasedWeigh";
            this.DecreasedWeigh.Size = new System.Drawing.Size(99, 19);
            this.DecreasedWeigh.TabIndex = 15;
            this.DecreasedWeigh.Text = "Потеря веса";
            this.DecreasedWeigh.UseVisualStyleBackColor = true;
            // 
            // Weakness
            // 
            this.Weakness.AutoSize = true;
            this.Weakness.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.Weakness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Weakness.Location = new System.Drawing.Point(6, 175);
            this.Weakness.Name = "Weakness";
            this.Weakness.Size = new System.Drawing.Size(80, 19);
            this.Weakness.TabIndex = 16;
            this.Weakness.Text = "Слабость";
            this.Weakness.UseVisualStyleBackColor = true;
            // 
            // Thirst
            // 
            this.Thirst.AutoSize = true;
            this.Thirst.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.Thirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Thirst.Location = new System.Drawing.Point(176, 175);
            this.Thirst.Name = "Thirst";
            this.Thirst.Size = new System.Drawing.Size(65, 19);
            this.Thirst.TabIndex = 17;
            this.Thirst.Text = "Жажда";
            this.Thirst.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ailment);
            this.groupBox1.Controls.Add(this.Thirst);
            this.groupBox1.Controls.Add(this.HighBloodPressure);
            this.groupBox1.Controls.Add(this.DecreasedWeigh);
            this.groupBox1.Controls.Add(this.Weakness);
            this.groupBox1.Controls.Add(this.DryMouth);
            this.groupBox1.Controls.Add(this.Fever);
            this.groupBox1.Controls.Add(this.Nausea);
            this.groupBox1.Controls.Add(this.Insomnia);
            this.groupBox1.Controls.Add(this.Headache);
            this.groupBox1.Controls.Add(this.IncreasedWeigh);
            this.groupBox1.Controls.Add(this.Dizziness);
            this.groupBox1.Controls.Add(this.LowBloodPressure);
            this.groupBox1.Controls.Add(this.Fatigue);
            this.groupBox1.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox1.Location = new System.Drawing.Point(2, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 202);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Симптомы";
            // 
            // AddHealthStatus
            // 
            this.AddHealthStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddHealthStatus.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9F, System.Drawing.FontStyle.Bold);
            this.AddHealthStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.AddHealthStatus.Location = new System.Drawing.Point(16, 297);
            this.AddHealthStatus.Name = "AddHealthStatus";
            this.AddHealthStatus.Size = new System.Drawing.Size(305, 28);
            this.AddHealthStatus.TabIndex = 21;
            this.AddHealthStatus.Text = "Добавить состояние здоровья";
            this.AddHealthStatus.UseVisualStyleBackColor = true;
            this.AddHealthStatus.Click += new System.EventHandler(this.AddHealthStatus_Click);
            // 
            // HealthStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(343, 333);
            this.Controls.Add(this.AddHealthStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "HealthStatusForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Состояние здоровья";
            this.Load += new System.EventHandler(this.HealthStatusForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.Button ExitHealthStatus;
        private System.Windows.Forms.CheckBox Ailment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox HighBloodPressure;
        private System.Windows.Forms.CheckBox LowBloodPressure;
        private System.Windows.Forms.CheckBox Dizziness;
        private System.Windows.Forms.CheckBox Fever;
        private System.Windows.Forms.CheckBox Headache;
        private System.Windows.Forms.CheckBox Insomnia;
        private System.Windows.Forms.CheckBox Nausea;
        private System.Windows.Forms.CheckBox Fatigue;
        private System.Windows.Forms.CheckBox DryMouth;
        private System.Windows.Forms.CheckBox IncreasedWeigh;
        private System.Windows.Forms.CheckBox DecreasedWeigh;
        private System.Windows.Forms.CheckBox Weakness;
        private System.Windows.Forms.CheckBox Thirst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddHealthStatus;
    }
}