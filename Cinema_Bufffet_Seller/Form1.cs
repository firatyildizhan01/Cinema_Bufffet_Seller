using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Bufffet_Seller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int cashAmount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int corn, ticket, water, tea, sum;

            corn = Convert.ToInt32(txtCorn.Text);
            ticket = Convert.ToInt32(txtTicket.Text);
            water = Convert.ToInt32(txtWater.Text);
            tea = Convert.ToInt32(txtTea.Text);

            sum = corn * 4 + tea * 2 + water * 1 + ticket * 8;
            lblSum.Text = sum.ToString() + "$" ;

            cashAmount = cashAmount + sum;
            lblCash.Text = cashAmount.ToString() + "$";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTicket.Text = "";
            txtTea.Text = "";
            txtCorn.Text = "";
            txtWater.Text = "";
            txtCorn.Focus();
        }
    }
}
