using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksBank
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //set action for close button
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            clearEntry();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        //set the form as default arrangement
        private void clearEntry()
        {

            txtId.Text = "";
            txtDate.Text = "";
            txtTransaction1.Text = "";
            txtBalance1.Text = "";
            txtBalance2.Text = "";
            txtAmount.Text = "";

            txtBalance2.Visible = false;
            lbTarget.Visible = false;

            txtId.Focus();
        }
        
    }
}
