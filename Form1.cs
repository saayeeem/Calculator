using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{


    public partial class Form1 : Form
    {
        String operation = " ";
        Double value = 0;
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || operation_pressed)
                txtResult.Clear();
                operation_pressed = false;
            Button button = (Button)sender;
            this.txtResult.Text = this.txtResult.Text + button.Text;

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "0";
           
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            
                Button button = (Button)sender;
                operation = button.Text;
                operation_pressed = true;
                value = Double.Parse(txtResult.Text);
              
                txtResult2.Text = value + " " + operation;
               
            
        }



        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtResult.Text = (value + Double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (value - Double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (value * Double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (value / Double.Parse(txtResult.Text)).ToString();
                    break;
                case "%":
                    txtResult.Text = (value/100).ToString();
                    break;
                default:
                    break;
            }
        }

    }
}
