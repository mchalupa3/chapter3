using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKilometers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalculateconversion_Click(object sender, EventArgs e)
        {
            double miles;
            double kilometers;
            double milesToKilo = 1.6;
            double milestoKiloConversion;

            miles = Convert.ToDouble(txtMiles.Text);

            milestoKiloConversion = miles * milesToKilo;

            lblResult.Text = milestoKiloConversion.ToString("n");
        }
    }
}
