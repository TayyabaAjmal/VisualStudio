using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmTeacherAlert : Form
    {
        public frmTeacherAlert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeachersDo manager = new TeachersDo();
            manager.showAlerts(Convert.ToInt32(textBox1.Text));
            if (manager.alerts == "")
            {  
               textBox2.Text = "No Alerts";
            }
            else {
                 textBox2.Text = manager.alerts;
        }
        }
    }
}
