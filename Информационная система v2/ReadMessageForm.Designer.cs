namespace Информационная_система_v2
{
    partial class ReadMessageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MessageDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MessageSender = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MessageTitle = new System.Windows.Forms.Label();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.LeaveRead = new System.Windows.Forms.Button();
            this.LeaveUnread = new System.Windows.Forms.Button();
            this.SignUpPatient = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тема";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MessageDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MessageSender);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MessageTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о сообщении";
            // 
            // MessageDate
            // 
            this.MessageDate.AutoSize = true;
            this.MessageDate.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.MessageDate.Location = new System.Drawing.Point(89, 73);
            this.MessageDate.Name = "MessageDate";
            this.MessageDate.Size = new System.Drawing.Size(161, 15);
            this.MessageDate.TabIndex = 26;
            this.MessageDate.Text = "Дата создания сообщения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Время";
            // 
            // MessageSender
            // 
            this.MessageSender.AutoSize = true;
            this.MessageSender.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageSender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.MessageSender.Location = new System.Drawing.Point(89, 46);
            this.MessageSender.Name = "MessageSender";
            this.MessageSender.Size = new System.Drawing.Size(178, 15);
            this.MessageSender.TabIndex = 24;
            this.MessageSender.Text = "ФИО врача или код прибора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Отправитель";
            // 
            // MessageTitle
            // 
            this.MessageTitle.AutoSize = true;
            this.MessageTitle.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.MessageTitle.Location = new System.Drawing.Point(89, 20);
            this.MessageTitle.Name = "MessageTitle";
            this.MessageTitle.Size = new System.Drawing.Size(105, 15);
            this.MessageTitle.TabIndex = 22;
            this.MessageTitle.Text = "Тема сообщения";
            // 
            // MessageText
            // 
            this.MessageText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MessageText.Enabled = false;
            this.MessageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MessageText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.MessageText.Location = new System.Drawing.Point(13, 130);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.ReadOnly = true;
            this.MessageText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageText.Size = new System.Drawing.Size(317, 86);
            this.MessageText.TabIndex = 3;
            // 
            // LeaveRead
            // 
            this.LeaveRead.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.LeaveRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaveRead.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9F, System.Drawing.FontStyle.Bold);
            this.LeaveRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.LeaveRead.Location = new System.Drawing.Point(13, 222);
            this.LeaveRead.Name = "LeaveRead";
            this.LeaveRead.Size = new System.Drawing.Size(154, 41);
            this.LeaveRead.TabIndex = 34;
            this.LeaveRead.Text = "OK";
            this.LeaveRead.UseVisualStyleBackColor = true;
            this.LeaveRead.Click += new System.EventHandler(this.LeaveRead_Click);
            // 
            // LeaveUnread
            // 
            this.LeaveUnread.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.LeaveUnread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaveUnread.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9F, System.Drawing.FontStyle.Bold);
            this.LeaveUnread.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.LeaveUnread.Location = new System.Drawing.Point(176, 222);
            this.LeaveUnread.Name = "LeaveUnread";
            this.LeaveUnread.Size = new System.Drawing.Size(154, 41);
            this.LeaveUnread.TabIndex = 35;
            this.LeaveUnread.Text = "Оставить непрочитанным";
            this.LeaveUnread.UseVisualStyleBackColor = true;
            this.LeaveUnread.Click += new System.EventHandler(this.LeaveUnread_Click);
            // 
            // SignUpPatient
            // 
            this.SignUpPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpPatient.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9F, System.Drawing.FontStyle.Bold);
            this.SignUpPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.SignUpPatient.Location = new System.Drawing.Point(88, 269);
            this.SignUpPatient.Name = "SignUpPatient";
            this.SignUpPatient.Size = new System.Drawing.Size(159, 28);
            this.SignUpPatient.TabIndex = 36;
            this.SignUpPatient.Text = "Предоставить доступ";
            this.SignUpPatient.UseVisualStyleBackColor = true;
            this.SignUpPatient.Visible = false;
            this.SignUpPatient.Click += new System.EventHandler(this.SignUpPatient_Click);
            // 
            // ReadMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(342, 303);
            this.Controls.Add(this.SignUpPatient);
            this.Controls.Add(this.LeaveUnread);
            this.Controls.Add(this.LeaveRead);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReadMessageForm";
            this.Text = "Сообщение";
            this.Load += new System.EventHandler(this.ReadMessageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MessageDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MessageSender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MessageTitle;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.Button LeaveRead;
        private System.Windows.Forms.Button LeaveUnread;
        private System.Windows.Forms.Button SignUpPatient;
    }
}