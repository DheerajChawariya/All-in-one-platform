using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace All_in_one_platform
{
    public partial class Form3 : Form
    {
        //Creation a connection string and store in cs variable 
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This connection string is created to check weather the input data is availabe or not 
            SqlConnection con = new SqlConnection(cs);

            //connection is open
            con.Open();
            string query = "select * from login where username = @user and email = @email and contact_number = @contact";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@email", textBox2.Text);
            cmd.Parameters.AddWithValue("@contact", textBox3.Text);
            cmd.Parameters.AddWithValue("@pass", textBox4.Text);
            cmd.Parameters.AddWithValue("@confirm_pass", textBox5.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            //Now we are check that user can enter correct data or not for updation
            if (dr.HasRows == true)
            {
                MessageBox.Show("Now You able to update password,please enter new password");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

                //We are doing exeception handling to handle any type of exception in our code block
                try
                {
                    //Now user can able to update his/her data in database
                    SqlConnection con1 = new SqlConnection(cs);
                    con1.Open();
                    string query1 = "UPDATE login SET username = @user, email = @email, contact_number = @contact, password = @pass, confirm_passoword = @confirm_pass WHERE username = @user AND email = @email AND contact_number = @contact";
                    SqlCommand cmd1 = new SqlCommand(query1, con1);
                    cmd1.Parameters.AddWithValue("@user", textBox1.Text);
                    cmd1.Parameters.AddWithValue("@email", textBox2.Text);
                    cmd1.Parameters.AddWithValue("@contact", textBox3.Text);
                    cmd1.Parameters.AddWithValue("@pass", textBox4.Text);
                    cmd1.Parameters.AddWithValue("@confirm_pass", textBox5.Text);

                    //in this we created integer variable to check our data is updated or not
                    int rowsAffected = cmd1.ExecuteNonQuery();

                    //if data is updated then message is shown
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("password created");
                    }
                    else
                    {
                        MessageBox.Show("error occured");
                    }
                    con1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("wrong password");
            }
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fp1 = new Form1();
            fp1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 fp4 = new Form4();
            fp4.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
