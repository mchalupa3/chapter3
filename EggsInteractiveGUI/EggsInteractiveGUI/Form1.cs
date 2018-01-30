using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            int chicken1Eggs;
            int chicken2Eggs;
            int chicken3Eggs;
            int chicken4Eggs;
            int chicken5Eggs;

           

            chicken1Eggs = Convert.ToInt32(txtchicken1Eggs.Text);
            chicken2Eggs = Convert.ToInt32(txtchicken2Eggs.Text);
            chicken3Eggs = Convert.ToInt32(txtchicken3Eggs.Text);
            chicken4Eggs = Convert.ToInt32(txtchicken4Eggs.Text);
            chicken5Eggs = Convert.ToInt32(txtchicken5Eggs.Text);

            int eggs = chicken1Eggs + chicken2Eggs + chicken3Eggs + chicken4Eggs + chicken5Eggs;

            int eggsToDozenQuotient = eggs / 12;

            int eggsToDozenRemainder = eggs % 12;

            lblResult.Text = eggs + " is " + eggsToDozenQuotient + " dozens with " + eggsToDozenRemainder + " remainding.";



        }
    }
}
