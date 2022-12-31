using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        Timer tmr = null;
        private void startTime()
        {
            tmr = new Timer();
            tmr.Interval = 10;
            tmr.Tick += new EventHandler(timer1_Tick);
            tmr.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            startTime();
        }
    }
}
