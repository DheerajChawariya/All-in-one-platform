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
    public partial class Form13 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form13()
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form10 fp10 = new Form10();
            fp10.Show();
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

        private void button12_Click(object sender, EventArgs e)
        {
            Form11 fp11 = new Form11();
            fp11.Show();
            this.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.indiatoday.in");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process.Start("https://zeenews.india.com/live-tv");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.indiatvnews.com/livetv");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ndtv.com/");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Process.Start("https://news.abplive.com/live-tv");
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            AutocompleteTB();
        }

        private void button19_Click(object sender, EventArgs e)
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
