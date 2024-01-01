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
using System.Configuration;
using System.Data.SqlClient;
using System.Speech.Recognition;

namespace All_in_one_platform
{
    public partial class Form8 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form8()
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

        private void button24_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.flipkart.com");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.amazon.in");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.meesho.com/");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.myntra.com");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.zomato.com");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.swiggy.com");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.firstcry.com");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.snapdeal.com");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.shopclues.com");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.shopify.com");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.wingslifestyle.in");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.alibaba.com/");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.indiamart.com");
        }

        private void button37_Click(object sender, EventArgs e)
        { 
            Process.Start("https://in.bookmyshow.com");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.nykaa.com");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.olx.in");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.cashify.in");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.justdial.com");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.jiomart.com/");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.marutisuzukitruevalue.com/");
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

        private void Form8_Load(object sender, EventArgs e)
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
