using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Speech.Recognition;

namespace All_in_one_platform
{
    public partial class Form9 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form9()
        {
            InitializeComponent();
        }
        void AutocompleteTB()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Select * from autocomplete";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                coll.Add(dr.GetString(0));
                //coll.Add(dr.GetString(2));
                //coll.Add(dr.GetString(3));
                //coll.Add(dr.GetString(4));
                //coll.Add(dr.GetString(5));
                //coll.Add(dr.GetString(6));
                //coll.Add(dr.GetString(7));
                //coll.Add(dr.GetString(8));
            }
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteCustomSource = coll;
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 fp5 = new Form5();
            fp5.Show();
            this.Hide();
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

        private void button24_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.trivago.in\r\n");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.yatra.com");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.makemytrip.com\r\n");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.expedia.co.in");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.priceline.com\r\n");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.in.cheapflights.com");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.agoda.com");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bookingbuddy.com\r\n");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.tripadvisor.in\r\n");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.oyorooms.com\r\n");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ixigo.com");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.redbus.in");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Process.Start("https://rapido.bike\r\n");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.abhibus.com");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form10 fp10 = new Form10();
            fp10.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form fp11 = new Form();
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

        private void button13_Click(object sender, EventArgs e)
        {
            Form13 fp13 = new Form13();
            fp13.Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            AutocompleteTB();
        }

        private void button15_Click(object sender, EventArgs e)
        {
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
