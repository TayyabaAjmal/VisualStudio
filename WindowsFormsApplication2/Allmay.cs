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
    public partial class Allmay : Form
    {
        public study st = new study();
        public Security sec= new Security();
        public Medicalunit med = new Medicalunit();
        public Allmay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                med.pname = t1.Text;
                med.pid = Convert.ToInt32(t2.Text);
                med.medicines = t3.Text;
                med.availableDoc = Convert.ToInt32(t4.Text);
                med.age = Convert.ToInt32(t5.Text);
                med.disease = t6.Text;
                med.maintainance = t7.Text;
                med.management = t8.Text;
                med.issues = t9.Text;

                sec.noofCameras = Convert.ToInt32(s1.Text);
                sec.areasCovered = s2.Text;
                sec.controlrooms = s3.Text;

                st.lab = ss1.Text;
                st.lib = ss2.Text;
                st.libhours = Convert.ToInt32(ss3.Text);
                st.recordOfIssuedBooks = ss4.Text;
                st.NoofLibrarians = Convert.ToInt32(ss5.Text);
                st.labhours = Convert.ToInt32(ss6.Text);
                st.systems = Convert.ToInt32(ss7.Text);
                st.labattenders = Convert.ToInt32(ss8.Text);

                med.AddRecords();
                sec.AddRecords();
                st.AddRecords();
                MessageBox.Show("Saved!");
            }
            catch
            {
                MessageBox.Show("Error Saving Record");
            }
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            med.showAll();
            dataGridView1.DataSource = med.Table;
            sec.showAll();
            dataGridView2.DataSource = sec.Table;
            st.showAll();
            dataGridView3.DataSource = st.Table;
           
        }
    }
}
