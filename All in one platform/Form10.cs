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
using System.Speech.Recognition; //This library used for speech system

namespace All_in_one_platform
{
    public partial class Form10 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form10()
        {
            InitializeComponent();
        }
        //Creating a function to autocomplete
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
            Process.Start("https://www.netflix.com/in\r\n");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.primevideo.com");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Process.Start("https://gaana.com");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.hotstar.com");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.spotify.com");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Process.Start("https://wynk.in\r\n");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.voot.com");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.zee5.com\r\n");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Process.Start("http://in.youtube.com");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Process.Start("https://picashow.fun");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.altbalaji.com");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Process.Start("https://kukufm.com\r\n");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.pocketfm.com");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Process.Start("https://ullu.app");
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

        private void button13_Click(object sender, EventArgs e)
        {
            Form13 fp13 = new Form13();
            fp13.Show();
            this.Hide();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            AutocompleteTB();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Creating exceptionnal handling for speech recognition system
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
