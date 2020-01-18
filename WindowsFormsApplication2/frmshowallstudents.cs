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
    public partial class frmshowallstudents : Form
    {
        public frmshowallstudents()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentDo manager = new StudentDo();
            manager.showAll();
            dataGridView1.DataSource = manager.Table;
        }
    }
}
