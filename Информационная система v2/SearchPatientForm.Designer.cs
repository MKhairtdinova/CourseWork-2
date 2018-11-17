namespace Информационная_система_v2
{
    partial class SearchPatientForm
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
            this.ExitSearch = new System.Windows.Forms.Button();
            this.ExitSearchPatient = new System.Windows.Forms.Button();
            this.PatientName = new System.Windows.Forms.Label();
            this.SearchByCode = new System.Windows.Forms.CheckBox();
            this.SearchByName = new System.Windows.Forms.CheckBox();
            this.SearchByDate = new System.Windows.Forms.CheckBox();
            this.SearchCode = new System.Windows.Forms.TextBox();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.SearchBirthDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SearchResults = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.AddPatient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.ExitSearch);
            this.panel1.Controls.Add(this.ExitSearchPatient);
            this.panel1.Controls.Add(this.PatientName);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 53);
            this.panel1.TabIndex = 23;
            // 
            // ExitSearch
            // 
            this.ExitSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitSearch.FlatAppearance.BorderSize = 0;
            this.ExitSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitSearch.Font = new System.Drawing.Font("Myriad Pro Light", 10F, System.Drawing.FontStyle.Bold);
            this.ExitSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ExitSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExitSearch.Location = new System.Drawing.Point(262, 9);
            this.ExitSearch.Name = "ExitSearch";
            this.ExitSearch.Size = new System.Drawing.Size(66, 36);
            this.ExitSearch.TabIndex = 29;
            this.ExitSearch.Text = "Отмена";
            this.ExitSearch.UseVisualStyleBackColor = true;
            this.ExitSearch.Click += new System.EventHandler(this.ExitSearch_Click);
            // 
            // ExitSearchPatient
            // 
            this.ExitSearchPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitSearchPatient.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitSearchPatient.FlatAppearance.BorderSize = 0;
            this.ExitSearchPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitSearchPatient.Font = new System.Drawing.Font("Myriad Pro Light", 10F, System.Drawing.FontStyle.Bold);
            this.ExitSearchPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ExitSearchPatient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExitSearchPatient.Location = new System.Drawing.Point(465, 9);
            this.ExitSearchPatient.Name = "ExitSearchPatient";
            this.ExitSearchPatient.Size = new System.Drawing.Size(71, 36);
            this.ExitSearchPatient.TabIndex = 3;
            this.ExitSearchPatient.Text = "Отмена";
            this.ExitSearchPatient.UseVisualStyleBackColor = true;
            this.ExitSearchPatient.Click += new System.EventHandler(this.ExitSearchPatient_Click);
            // 
            // PatientName
            // 
            this.PatientName.AutoSize = true;
            this.PatientName.Font = new System.Drawing.Font("Myriad Pro Light", 14.25F, System.Drawing.FontStyle.Bold);
            this.PatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatientName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PatientName.Location = new System.Drawing.Point(13, 14);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(150, 23);
            this.PatientName.TabIndex = 0;
            this.PatientName.Text = "Поиск пациента";
            this.PatientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SearchByCode
            // 
            this.SearchByCode.AutoSize = true;
            this.SearchByCode.Checked = true;
            this.SearchByCode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchByCode.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.SearchByCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.SearchByCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SearchByCode.Location = new System.Drawing.Point(12, 57);
            this.SearchByCode.Name = "SearchByCode";
            this.SearchByCode.Size = new System.Drawing.Size(129, 19);
            this.SearchByCode.TabIndex = 4;
            this.SearchByCode.Text = "По коду пациента";
            this.SearchByCode.UseVisualStyleBackColor = true;
            this.SearchByCode.CheckedChanged += new System.EventHandler(this.SearchByCode_CheckedChanged);
            // 
            // SearchByName
            // 
            this.SearchByName.AutoSize = true;
            this.SearchByName.Checked = true;
            this.SearchByName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchByName.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.SearchByName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.SearchByName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SearchByName.Location = new System.Drawing.Point(12, 82);
            this.SearchByName.Name = "SearchByName";
            this.SearchByName.Size = new System.Drawing.Size(75, 19);
            this.SearchByName.TabIndex = 24;
            this.SearchByName.Text = "По ФИО";
            this.SearchByName.UseVisualStyleBackColor = true;
            this.SearchByName.CheckedChanged += new System.EventHandler(this.SearchByName_CheckedChanged);
            // 
            // SearchByDate
            // 
            this.SearchByDate.AutoSize = true;
            this.SearchByDate.Checked = true;
            this.SearchByDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchByDate.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.SearchByDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.SearchByDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SearchByDate.Location = new System.Drawing.Point(12, 107);
            this.SearchByDate.Name = "SearchByDate";
            this.SearchByDate.Size = new System.Drawing.Size(135, 19);
            this.SearchByDate.TabIndex = 25;
            this.SearchByDate.Text = "По дате рождения";
            this.SearchByDate.UseVisualStyleBackColor = true;
            this.SearchByDate.CheckedChanged += new System.EventHandler(this.SearchByDate_CheckedChanged);
            // 
            // SearchCode
            // 
            this.SearchCode.Location = new System.Drawing.Point(147, 56);
            this.SearchCode.Name = "SearchCode";
            this.SearchCode.Size = new System.Drawing.Size(177, 20);
            this.SearchCode.TabIndex = 26;
            this.SearchCode.TextChanged += new System.EventHandler(this.SearchCode_TextChanged);
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(147, 81);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(177, 20);
            this.SearchName.TabIndex = 27;
            this.SearchName.TextChanged += new System.EventHandler(this.SearchName_TextChanged);
            // 
            // SearchBirthDate
            // 
            this.SearchBirthDate.Location = new System.Drawing.Point(147, 107);
            this.SearchBirthDate.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.SearchBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.SearchBirthDate.Name = "SearchBirthDate";
            this.SearchBirthDate.Size = new System.Drawing.Size(177, 20);
            this.SearchBirthDate.TabIndex = 28;
            this.SearchBirthDate.Value = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SearchResults);
            this.groupBox3.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 158);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результаты поиска";
            // 
            // SearchResults
            // 
            this.SearchResults.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchResults.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchResults.Location = new System.Drawing.Point(3, 19);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.RowHeadersVisible = false;
            this.SearchResults.Size = new System.Drawing.Size(301, 136);
            this.SearchResults.TabIndex = 17;
            // 
            // Search
            // 
            this.Search.Enabled = false;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9F, System.Drawing.FontStyle.Bold);
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Search.Location = new System.Drawing.Point(86, 144);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(152, 28);
            this.Search.TabIndex = 19;
            this.Search.Text = "Найти";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // AddPatient
            // 
            this.AddPatient.Enabled = false;
            this.AddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPatient.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9F, System.Drawing.FontStyle.Bold);
            this.AddPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.AddPatient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddPatient.Location = new System.Drawing.Point(86, 342);
            this.AddPatient.Name = "AddPatient";
            this.AddPatient.Size = new System.Drawing.Size(152, 28);
            this.AddPatient.TabIndex = 30;
            this.AddPatient.Text = "Добавить пациента";
            this.AddPatient.UseVisualStyleBackColor = true;
            this.AddPatient.Click += new System.EventHandler(this.AddPatient_Click);
            // 
            // SearchPatientForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(329, 376);
            this.Controls.Add(this.AddPatient);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.SearchBirthDate);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.SearchCode);
            this.Controls.Add(this.SearchByDate);
            this.Controls.Add(this.SearchByName);
            this.Controls.Add(this.SearchByCode);
            this.Controls.Add(this.panel1);
            this.Name = "SearchPatientForm";
            this.Text = "Поиск пациента";
            this.Load += new System.EventHandler(this.SearchPatientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitSearchPatient;
        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.CheckBox SearchByCode;
        private System.Windows.Forms.CheckBox SearchByName;
        private System.Windows.Forms.CheckBox SearchByDate;
        private System.Windows.Forms.TextBox SearchCode;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.DateTimePicker SearchBirthDate;
        private System.Windows.Forms.Button ExitSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView SearchResults;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button AddPatient;
    }
}