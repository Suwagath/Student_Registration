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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MCRG;Initial Catalog=Student Details;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Student_Details values (@StudentID,@First_Name,@Email_Address,@Contact_Number,@Gender,@Grade", con);
            cmd.Parameters.AddWithValue("@StudentID", (txtFname.Text));
            cmd.Parameters.AddWithValue("@First_Name", (txtFname.Text));
            cmd.Parameters.AddWithValue("@Email_Address", (txtmail.Text));
            cmd.Parameters.AddWithValue("@Contact_Number", (txtContactno.Text));
            cmd.Parameters.AddWithValue("@Gender", (cmbGender.Text));
            cmd.Parameters.AddWithValue("@Grade", (cmbGrade.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MCRG;Initial Catalog=Student Details;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Student_Details set First_Name=@First_Name,Email_Address=@Email_Address,Contact_Number=@Contact_Number,Gender=@Gender,@Grade ", con);
            cmd.Parameters.AddWithValue("@StudentID", (txtFname.Text));
            cmd.Parameters.AddWithValue("@First_Name", (txtFname.Text));
            cmd.Parameters.AddWithValue("@Email_Address", (txtmail.Text));
            cmd.Parameters.AddWithValue("@Contact_Number", (txtContactno.Text));
            cmd.Parameters.AddWithValue("@Gender", (cmbGender.Text));
            cmd.Parameters.AddWithValue("@Grade", (cmbGrade.Text));

            con.Close();
            MessageBox.Show("Successfully Updated");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MCRG;Initial Catalog=Student Details;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Student_Details where StudentID=@StudentID", con);
            cmd.Parameters.AddWithValue("@StudentID", (StudentIDtxt));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MCRG;Initial Catalog=Student Details;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Student_Details", con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
