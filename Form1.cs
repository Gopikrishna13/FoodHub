using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserName.Text) || string.IsNullOrWhiteSpace(PasswordEntry.Text))
                MessageBox.Show("Please Fill The Credentials!");


            validateUsers(UserName.Text, PasswordEntry.Text);

        

        }

        private void validateUsers(string username,string password)
        {
            if(username=="Admin" )
            {
                if(PasswordEntry.Text == "admin@123")
                {
                    Form3 form3 = new Form3();
                  
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login");
                }
             
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SignUp.Enabled = checkBox1.Checked;
        }
    }
}
