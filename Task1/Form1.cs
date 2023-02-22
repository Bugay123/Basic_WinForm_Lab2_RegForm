using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Var2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pizzaPrice;
            double deliveryPrice;
            double totalPrice;

            string pizzaType = comboBox1.Text;

            int numberOfPizzas = (int)numericUpDown1.Value;

            switch (pizzaType)
            {
                case "Cheese":
                    pizzaPrice = 9;
                    break;
                case "Pepperoni":
                    pizzaPrice = 10;
                    break;
                case "Veggie":
                    pizzaPrice = 11;
                    break;
                default:
                    pizzaPrice = 0;
                    break;
            }

            double distance = (double)numericUpDown2.Value;

            deliveryPrice = (distance >= 3) ? 5 : 0;

            totalPrice = (pizzaPrice * numberOfPizzas) + deliveryPrice;

            label5.Text = totalPrice.ToString();
        }
    }
}
