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
    public partial class AddDeviceForm : Form
    {
        public AddDeviceForm()
        {
            InitializeComponent();
        }

        public DeviceFunction function;

        private void ExitAddDevice_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddDeviceType.SelectedIndex != -1)
            {
                switch (AddDeviceType.SelectedIndex)
                {
                    case 0:
                        function = DeviceFunction.Glucometer;
                        break;

                    case 1:
                        function = DeviceFunction.HeartRateMonitor;
                        break;

                    case 2:
                        function = DeviceFunction.BloodPressureMonitor;
                        break;
                }
            }

            AddDeviceToPatient.Enabled = true;
        }

        private void AddDeviceToPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
