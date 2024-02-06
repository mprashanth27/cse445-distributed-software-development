using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtURL.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 + num2; // Add given numbers
            label2.Text = result.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 - num2; //Subtract given numbers
            label2.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 * num2; // Multiply given numbers
            label2.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 / num2; // Divide given numbers
            label2.Text = result.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            EncryptService.ServiceClient myClient = new EncryptService.ServiceClient();
            try
            {
                lblEncrypted.Text = myClient.Encrypt(txtInput.Text); // Encrypting given text
            }
            catch (Exception ec)
            {
                lblEncrypted.Text = ec.Message.ToString();
            }

            try
            {
                lblDecrypted.Text = myClient.Decrypt(lblEncrypted.Text); // Decrypting given text
            }
            catch (Exception dc)
            {
                lblDecrypted.Text = dc.Message.ToString();
            }
        }
    }
}
