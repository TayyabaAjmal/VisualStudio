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
    public partial class frmshowallt : Form
    {
        public frmshowallt()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeachersDo manager = new TeachersDo();
            manager.showAll();
            dataGridView1.DataSource = manager.Table;
        }
    }
}
