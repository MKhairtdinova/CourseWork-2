namespace Информационная_система_v2
{
    partial class AdministratorForm
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
            this.ExitAdministrator = new System.Windows.Forms.Button();
            this.AdminName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MessageList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeviceMessages = new System.Windows.Forms.CheckBox();
            this.NewPatientsMessage = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OnlyUnread = new System.Windows.Forms.CheckBox();
            this.AllMessages = new System.Windows.Forms.CheckBox();
            this.UpdateMessageList = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessageList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.ExitAdministrator);
            this.panel1.Controls.Add(this.AdminName);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 53);
            this.panel1.TabIndex = 1;
            // 
            // ExitAdministrator
            // 
            this.ExitAdministrator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitAdministrator.FlatAppearance.BorderSize = 0;
            this.ExitAdministrator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitAdministrator.Font = new System.Drawing.Font("Myriad Pro Light", 10F, System.Drawing.FontStyle.Bold);
            this.ExitAdministrator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ExitAdministrator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExitAdministrator.Location = new System.Drawing.Point(601, 8);
            this.ExitAdministrator.Name = "ExitAdministrator";
            this.ExitAdministrator.Size = new System.Drawing.Size(57, 36);
            this.ExitAdministrator.TabIndex = 4;
            this.ExitAdministrator.Text = "Выйти";
            this.ExitAdministrator.UseVisualStyleBackColor = true;
            this.ExitAdministrator.Click += new System.EventHandler(this.ExitAdministrator_Click);
            // 
            // AdminName
            // 
            this.AdminName.AutoSize = true;
            this.AdminName.Font = new System.Drawing.Font("Myriad Pro Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AdminName.Location = new System.Drawing.Point(13, 13);
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(263, 23);
            this.AdminName.TabIndex = 1;
            this.AdminName.Text = "Полное имя администратора";
            this.AdminName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MessageList);
            this.groupBox1.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 298);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сообщения";
            // 
            // MessageList
            // 
            this.MessageList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MessageList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MessageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MessageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageList.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MessageList.Location = new System.Drawing.Point(3, 19);
            this.MessageList.Name = "MessageList";
            this.MessageList.Size = new System.Drawing.Size(430, 276);
            this.MessageList.TabIndex = 0;
            this.MessageList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MessageList_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeviceMessages);
            this.groupBox2.Controls.Add(this.NewPatientsMessage);
            this.groupBox2.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox2.Location = new System.Drawing.Point(454, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Типы сообщений";
            // 
            // DeviceMessages
            // 
            this.DeviceMessages.AutoSize = true;
            this.DeviceMessages.Checked = true;
            this.DeviceMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DeviceMessages.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.DeviceMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.DeviceMessages.Location = new System.Drawing.Point(6, 47);
            this.DeviceMessages.Name = "DeviceMessages";
            this.DeviceMessages.Size = new System.Drawing.Size(167, 19);
            this.DeviceMessages.TabIndex = 5;
            this.DeviceMessages.Text = "Сообщение от прибора";
            this.DeviceMessages.UseVisualStyleBackColor = true;
            // 
            // NewPatientsMessage
            // 
            this.NewPatientsMessage.AutoSize = true;
            this.NewPatientsMessage.Checked = true;
            this.NewPatientsMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NewPatientsMessage.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.NewPatientsMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.NewPatientsMessage.Location = new System.Drawing.Point(6, 22);
            this.NewPatientsMessage.Name = "NewPatientsMessage";
            this.NewPatientsMessage.Size = new System.Drawing.Size(116, 19);
            this.NewPatientsMessage.TabIndex = 4;
            this.NewPatientsMessage.Text = "Новый пациент";
            this.NewPatientsMessage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OnlyUnread);
            this.groupBox3.Controls.Add(this.AllMessages);
            this.groupBox3.Font = new System.Drawing.Font("Myriad Pro Light SemiCond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.groupBox3.Location = new System.Drawing.Point(454, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 74);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Прочитанные";
            // 
            // OnlyUnread
            // 
            this.OnlyUnread.AutoSize = true;
            this.OnlyUnread.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.OnlyUnread.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.OnlyUnread.Location = new System.Drawing.Point(6, 47);
            this.OnlyUnread.Name = "OnlyUnread";
            this.OnlyUnread.Size = new System.Drawing.Size(163, 19);
            this.OnlyUnread.TabIndex = 5;
            this.OnlyUnread.Text = "Только непрочитанные";
            this.OnlyUnread.UseVisualStyleBackColor = true;
            this.OnlyUnread.CheckedChanged += new System.EventHandler(this.OnlyUnread_CheckedChanged);
            // 
            // AllMessages
            // 
            this.AllMessages.AutoSize = true;
            this.AllMessages.Checked = true;
            this.AllMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllMessages.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9.749999F);
            this.AllMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.AllMessages.Location = new System.Drawing.Point(6, 22);
            this.AllMessages.Name = "AllMessages";
            this.AllMessages.Size = new System.Drawing.Size(117, 19);
            this.AllMessages.TabIndex = 4;
            this.AllMessages.Text = "Все сообщения";
            this.AllMessages.UseVisualStyleBackColor = true;
            this.AllMessages.CheckedChanged += new System.EventHandler(this.AllMessages_CheckedChanged);
            // 
            // UpdateMessageList
            // 
            this.UpdateMessageList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateMessageList.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 9F, System.Drawing.FontStyle.Bold);
            this.UpdateMessageList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.UpdateMessageList.Location = new System.Drawing.Point(454, 226);
            this.UpdateMessageList.Name = "UpdateMessageList";
            this.UpdateMessageList.Size = new System.Drawing.Size(204, 28);
            this.UpdateMessageList.TabIndex = 20;
            this.UpdateMessageList.Text = "Обновить таблицу";
            this.UpdateMessageList.UseVisualStyleBackColor = true;
            this.UpdateMessageList.Click += new System.EventHandler(this.UpdateMessageList_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(670, 368);
            this.Controls.Add(this.UpdateMessageList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "AdministratorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Система учета физической активности";
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MessageList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AdminName;
        private System.Windows.Forms.Button ExitAdministrator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView MessageList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox DeviceMessages;
        private System.Windows.Forms.CheckBox NewPatientsMessage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox OnlyUnread;
        private System.Windows.Forms.CheckBox AllMessages;
        private System.Windows.Forms.Button UpdateMessageList;
    }
}