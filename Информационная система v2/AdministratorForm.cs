using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Информационная_система_v2
{
    public partial class AdministratorForm : Form
    {
        public Administrator user;

        public AdministratorForm()
        {
            InitializeComponent();
        }

        private EntityModelContainer _container;

        void RefreshMessages()
        {
            _container = new EntityModelContainer();
            user = _container.AdministratorSet.Find(user.UserCode);

            if (NewPatientsMessage.Checked && DeviceMessages.Checked)
            {
                if (AllMessages.Checked)
                {
                    MessageList.DataSource = (from patientMessage in user.Message.AsParallel()
                        select new
                        {
                            Дата = patientMessage.Date.ToString(),
                            Сообщение = patientMessage.Title,
                            Статус = patientMessage.GetChecked(),
                            Код = patientMessage.Id
                        }).Union(from deviceMessage in user.DeviceMessage.AsParallel()
                        select new
                        {
                            Дата = deviceMessage.Date.ToString(),
                            Сообщение = deviceMessage.Title,
                            Статус = deviceMessage.GetChecked(),
                            Код = deviceMessage.Id
                        }).ToList();

                    MessageList.Update();
                }
                else
                {
                    MessageList.DataSource = (from patientMessage in user.Message.AsParallel()
                        where patientMessage.Checked == false
                        select new
                        {
                            Дата = patientMessage.Date.ToString(),
                            Сообщение = patientMessage.Title,
                            Статус = patientMessage.GetChecked(),
                            Код = patientMessage.Id
                        }).Union(from deviceMessage in user.DeviceMessage.AsParallel()
                        where deviceMessage.Checked == false
                        select new
                        {
                            Дата = deviceMessage.Date.ToString(),
                            Сообщение = deviceMessage.Title,
                            Статус = deviceMessage.GetChecked(),
                            Код = deviceMessage.Id
                        }).ToList();

                    MessageList.Update();
                }
            }
            else
            {
                if (NewPatientsMessage.Checked)
                {
                    if (AllMessages.Checked)
                    {
                        MessageList.DataSource = (from patientMessage in user.Message.AsParallel()
                            select new
                            {
                                Дата = patientMessage.Date.ToString(),
                                Сообщение = patientMessage.Title,
                                Статус = patientMessage.GetChecked(),
                                Код = patientMessage.Id
                            }).ToList();
                    }
                    else
                    {
                        MessageList.DataSource = (from patientMessage in user.Message.AsParallel()
                            where patientMessage.Checked == false
                            select new
                            {
                                Дата = patientMessage.Date.ToString(),
                                Сообщение = patientMessage.Title,
                                Статус = patientMessage.GetChecked(),
                                Код = patientMessage.Id
                            }).ToList();
                    }
                }
                else
                {
                    if (DeviceMessages.Checked)
                    {
                        if (AllMessages.Checked)
                        {
                            MessageList.DataSource = (from deviceMessage in user.DeviceMessage.AsParallel()
                                select new
                                {
                                    Дата = deviceMessage.Date.ToString(),
                                    Сообщение = deviceMessage.Title,
                                    Статус = deviceMessage.GetChecked(),
                                    Код = deviceMessage.Id
                                }).ToList();
                        }
                        else
                        {
                            MessageList.DataSource = (from deviceMessage in user.DeviceMessage.AsParallel()
                                where deviceMessage.Checked == false
                                select new
                                {
                                    Дата = deviceMessage.Date.ToString(),
                                    Сообщение = deviceMessage.Title,
                                    Статус = deviceMessage.GetChecked(),
                                    Код = deviceMessage.Id
                                }).ToList();
                        }
                    }
                    else
                    {
                        MessageList.DataSource = null;
                    }
                }
            }

            MessageList.Update();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            AdminName.Text = user.FullName;

            _container = new EntityModelContainer();

            MessageList.DataSource = (from patientMessage in user.Message.AsParallel()
                select new
                {
                    Дата =  patientMessage.Date.ToLongDateString(),
                    Сообщение = patientMessage.Title,
                    Статус = patientMessage.GetChecked(),
                    Код = patientMessage.Id
                }).Union(from deviceMessage in user.DeviceMessage.AsParallel()
                select new
                {
                    Дата =  deviceMessage.Date.ToLongDateString(),
                    Сообщение = deviceMessage.Title,
                    Статус = deviceMessage.GetChecked(),
                    Код = deviceMessage.Id
                }).ToList();

            MessageList.Update();

            MessageList.Columns[0].Width = 117;
            MessageList.Columns[1].Width = 170;
            MessageList.Columns[2].Width = 100;
            MessageList.Columns[3].Visible = false;
        }

        private void ExitAdministrator_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdministratorForm_Activated(object sender, EventArgs e)
        {
       //     RefreshMessages();
            
            MessageList.Columns[0].Width = 117;
            MessageList.Columns[1].Width = 170;
            MessageList.Columns[2].Width = 100;
            MessageList.Columns[3].Visible = false;
        }

        private void AllMessages_CheckedChanged(object sender, EventArgs e)
        {
            OnlyUnread.Checked = !AllMessages.Checked;
        }

        private void OnlyUnread_CheckedChanged(object sender, EventArgs e)
        {
            AllMessages.Checked = !OnlyUnread.Checked;
        }

        private void MessageList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = MessageList.SelectedCells[0].RowIndex;
            int messageCode = (int)MessageList.Rows[row].Cells[3].Value;

            if (MessageList.Rows[row].Cells[1].Value.ToString() == "Запрос доступа к системе")
            {
                DoctorMessage message = (from userMessage in _container.DoctorMessageSet.AsParallel()
                    where userMessage.Id == messageCode
                    select userMessage).ToList()[0];

                message = _container.DoctorMessageSet.Find(message.Id);

                ReadMessageForm readMessage = new ReadMessageForm();

                readMessage.needSignUp = true;
                readMessage.docMessage = message;
                readMessage.isDocMessage = true;

                DialogResult messageResult = readMessage.ShowDialog();

                if (messageResult == DialogResult.OK)
                {
                    message.Checked = true;
                    _container.SaveChanges();
                }
                else
                {
                    if (messageResult == DialogResult.Ignore)
                    {
                        message.Checked = false;
                        _container.SaveChanges();
                    }
                }
            }
            else
            {
                if (MessageList.Rows[row].Cells[1].Value.ToString() == "Зарегистрирован новый пациент")
                {
                    DoctorMessage message = (from userMessage in _container.DoctorMessageSet.AsParallel()
                        where userMessage.Id == messageCode
                        select userMessage).ToList()[0];

                    message = _container.DoctorMessageSet.Find(message.Id);

                    ReadMessageForm readMessage = new ReadMessageForm();

                    readMessage.needSignUp = false;
                    readMessage.docMessage = message;
                    readMessage.isDocMessage = true;

                    DialogResult messageResult = readMessage.ShowDialog();

                    if (messageResult == DialogResult.OK)
                    {
                        message.Checked = true;
                        _container.SaveChanges();
                    }
                    else
                    {
                        if (messageResult == DialogResult.Ignore)
                        {
                            message.Checked = false;
                            _container.SaveChanges();
                        }
                    }
                }
                else
                {
                    DeviceMessage message = (from userMessage in _container.DeviceMessageSet.AsParallel()
                        where userMessage.Id == messageCode
                        select userMessage).ToList()[0];

                    message = _container.DeviceMessageSet.Find(message.Id);

                    ReadMessageForm readMessage = new ReadMessageForm();

                    readMessage.needSignUp = false;
                    readMessage.deviceMessage = message;
                    readMessage.isDocMessage = false;

                    DialogResult messageResult = readMessage.ShowDialog();

                    if (messageResult == DialogResult.OK)
                    {
                        message.Checked = true;
                        _container.SaveChanges();
                    }
                    else
                    {
                        if (messageResult == DialogResult.Ignore)
                        {
                            message.Checked = false;
                            _container.SaveChanges();
                        }
                    }
                }
            }

          //  MessageList.Update();
          RefreshMessages();
            MessageList.Columns[0].Width = 117;
            MessageList.Columns[1].Width = 170;
            MessageList.Columns[2].Width = 100;
            MessageList.Columns[3].Visible = false;
        }

        private void UpdateMessageList_Click(object sender, EventArgs e)
        {
            RefreshMessages();

            if (MessageList.DataSource != null)
            {
                MessageList.Columns[0].Width = 117;
                MessageList.Columns[1].Width = 170;
                MessageList.Columns[2].Width = 100;
                MessageList.Columns[3].Visible = false;
            }
        }
    }
}
