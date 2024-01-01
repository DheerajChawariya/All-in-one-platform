using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data.SqlClient;
using System.Speech.Recognition; //this library is used to develop speech recorgnition system

namespace All_in_one_platform
{
    public partial class Form5 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form5()
        {
            InitializeComponent();
        }
        private void loadResults()
        {

        }
        //Creating funtion for autocomplete search box
        void AutocompleteTB()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Select * from autocomplete";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
             SqlDataReader dr =  cmd.ExecuteReader();
            while(dr.Read())
            {
                coll.Add(dr.GetString(0));
            }
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteCustomSource = coll;
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 fp6 = new Form6();
            fp6.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 fp7 = new Form7();
            fp7.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form8 fp8 = new Form8();
            fp8.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form9 fp9 = new Form9();
            fp9.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form10 fp10 = new Form10();
            fp10.Show();
            this.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Process.Start("https://simple.wikipedia.org");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Process.Start("https://unacademy.com");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.udemy.com");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.academia.edu");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.vedantu.com");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Process.Start("https://learndigital.withgoogle.com");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Process.Start("https://learn.microsoft.com/en-in");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.shiksha.com");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Process.Start("https://brainly.in");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Process.Start("https://byjus.com");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.coursera.org/courses?query=free");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.khanacademy.org");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.grammarly.com");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.adventure2learning.com");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Process.Start("https://swayam.gov.in");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.skillshare.com/classes\r\n");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.udacity.com\r\n");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.mindluster.com\r\n");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Process.Start("https://allenplus.allen.ac.in\r\n");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.upgrad.com\r\n");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form11 fp11 = new Form11();
            fp11.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fp1 = new Form1();
            fp1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 fp12 = new Form12();
            fp12.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            loadResults();
            AutocompleteTB(); //Calling autocomplete search box funtion
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
            //AutocompleteTB();
        }

        private void searchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.searchResult.Rows[e.RowIndex];
            textBox1.Text = row.Cells["Platforms"].Value.ToString();
            searchResult.Height = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form13 fp13 = new Form13();
            fp13.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Creating speech recorgnition system 
            try
            {
                SpeechRecognitionEngine ss = new SpeechRecognitionEngine();
                Grammar words = new DictationGrammar();
                ss.LoadGrammar(words);
                ss.SetInputToDefaultAudioDevice();
                RecognitionResult result = ss.Recognize();
                textBox1.Text = result.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 fp14 = new Form14();
            fp14.Show();
            fp14 = new Form14();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 fp15 = new Form15();
            fp15.Show();
            this.Hide();
        }
    }
}
