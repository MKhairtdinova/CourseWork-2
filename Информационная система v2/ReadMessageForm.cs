using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Информационная_система_v2
{
    public partial class ReadMessageForm : Form
    {
        public ReadMessageForm()
        {
            InitializeComponent();
        }

        public bool needSignUp;
        public DoctorMessage docMessage;
        public DeviceMessage deviceMessage;
        public bool isDocMessage;
        private EntityModelContainer _container;

        private void ReadMessageForm_Load(object sender, EventArgs e)
        {
            _container = new EntityModelContainer();

            if (isDocMessage)
            {
                MessageTitle.Text = docMessage.Title;
                Doctor mesSender = (from doc in _container.DoctorSet.AsParallel()
                    where doc.UserCode == docMessage.SenderCode
                    select doc).ToList()[0];

                MessageSender.Text = mesSender.FullName;
                MessageDate.Text = docMessage.Date.ToString();

                MessageText.Text = docMessage.Text;

                if (needSignUp)
                {
                    SignUpPatient.Visible = true;
                    this.Size = new Size(358, 342);
                }
                else
                {
                    SignUpPatient.Visible = false;
                    this.Size = new Size(358, 307);
                }
            }
        }

        private void LeaveRead_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LeaveUnread_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpPatient_Click(object sender, EventArgs e)
        {
            string login, password;
            bool exist;

            InformationSystem.GiveLoginPassword(docMessage.Text, out login, out password, out exist);

            if (exist)
                MessageBox.Show("Данному пациенту уже предоставлен доступ");
            else
            {
                string info = "Логин - " + login + ". \nПароль - " + password;
                MessageBox.Show(info);
            }

            SignUpPatient.Enabled = false;
        }
    }
}
