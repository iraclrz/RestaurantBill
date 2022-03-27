using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double result = 0;

        private void addButton_Click(object sender, EventArgs e)
        {
            double quantity = Convert.ToDouble(quantityTextBox.Text);
            double price = Convert.ToDouble(priceTextBox.Text);
            result = quantity * price;

            if (this.quantityTextBox.Text != "")
            {
                listBox2.Items.Add(this.menuTextBox.Text);
                listBox1.Items.Add(quantity);
                listBox3.Items.Add(result);
                quantityTextBox.Text = "";
                menuTextBox.Text = "";
                priceTextBox.Text = "";
            }
            
        }


        private void tbillButton_Click(object sender, EventArgs e)
        {
            totalTextBox.Text = result.ToString();
            decimal sum = 0;
            for (int i = 0; i<listBox3.Items.Count; i++)
            {
                sum += Convert.ToDecimal(listBox3.Items[i]);
            }
            totalTextBox.Text = "$" + sum;
            
            
        }
    }
}
