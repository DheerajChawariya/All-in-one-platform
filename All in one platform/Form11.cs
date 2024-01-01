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
using Org.BouncyCastle.Tls.Crypto;
using System.Configuration;
using System.Data.SqlClient;
using System.Speech.Recognition;

namespace All_in_one_platform
{
    public partial class Form11 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form11()
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

            }
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteCustomSource = coll;
            con.Close();
        }
        private void button24_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.useblackbox.io");
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

        private void button11_Click(object sender, EventArgs e)
        {
            Form10 fp10 = new Form10();
            fp10.Show();
            this.Hide();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Process.Start("https://codeamigo.dev");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Process.Start("https://deepai.org/");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.tabnine.com");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/features/copilot\r\n");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Process.Start("https://mintlify.com");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.deepcode.ai\r\n");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.codeconvert.ai\r\n");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Process.Start("https://jit.codes\r\n");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.fotor.com/");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Process.Start("https://lucidpic.com\r\n");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.hama.app\r\n");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Process.Start("https://ai-finder.net/ai/picapiu");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Process.Start("https://gencraft.com/");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.fotor.com/features/ai-image-generator");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.freepik.com/");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Process.Start("https://pfpmaker.com\r\n");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.undetectablegpt.com");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Process.Start("https://chatgptwriter.ai\r\n");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Process.Start("https://chat.openai.com/auth/login");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.compose.ai\r\n");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Process.Start("https://resoomer.com/en\r\n");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Process.Start("https://quillbot.com");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Process.Start("https://turbologo.com/");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Process.Start("https://brandmark.io");
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Process.Start("https://logocreatorai.com");
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.logoai.com/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fp1 = new Form1();
            fp1.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 fp12 = new Form12();
            fp12.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form13 fp13 = new Form13();
            fp13.Show();
            this.Hide();
        }

        private void Form11_Load(object sender, EventArgs e)
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
