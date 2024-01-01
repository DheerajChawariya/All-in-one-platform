using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace All_in_one_platform
{
    public partial class Form2 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This connection is created for checking user name and password is correct or not
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select * from login where username = @user and confirm_passoword = @pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user",textBox1.Text);
            cmd.Parameters.AddWithValue("@pass",textBox2.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                    Form5 fp5 = new Form5();
                    fp5.Show();
                    this.Hide();
            }
            else
            {
                MessageBox.Show("wrong password");
            }
            con.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 fp3 = new Form3();
            fp3.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 fp4= new Form4();
            fp4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
