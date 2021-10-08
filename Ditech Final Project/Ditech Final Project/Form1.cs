using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ditech_Final_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text;
            string pass = txtPassword.Text;

            if (txtUsername.Text == "admin@esoft.lk" && txtPassword.Text == "1234")
            {MessageBox.Show("Login Success !");
                new Form2().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

