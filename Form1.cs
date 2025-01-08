using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowManyDaysOnEarth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("You want to Exit?", "yes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblCalculate_Click(object sender, EventArgs e)
        {
            DateTime DOB, Todate;
            int AddDate;

            DOB = Convert.ToDateTime(dateTimePicker1.Value);
            Todate = Convert.ToDateTime(dateTimePicker2.Value);

            AddDate = (Todate - DOB).Days;
            lblLived.Text = String.Format("{0:0}", AddDate);
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            lblLived.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Long;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker2.Format = DateTimePickerFormat.Long;

        }
    }
}
