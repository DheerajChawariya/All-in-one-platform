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

namespace All_in_one_platform
{
    public partial class Form14 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This connection is created to develop book mark system and store all the bookmarks in database
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "Insert into bookmark(website_name,url) values('" + textBox1.Text + "','" + textBox2.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data inserted");
            }
            else
            {
                MessageBox.Show("error occured");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 fp15 = new Form15();
            fp15.Show();
            this.Hide();
        }
    }
}
