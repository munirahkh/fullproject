using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form5 : Form
    {


        Image[] imeges = new Image[10];


        Random randomClass = new Random();
        Random randomClass1 = new Random();
        Random randomClass2 = new Random();
        Random randomClass3 = new Random();
        Random randomClass4 = new Random();
        public int pos;
        public int pos1;
        public int pos2;
        public int pos3;
        public int pos4;
        public static int rbt = 0;
        String currentDrag = "";
       // public static Form8 frm = new Form8();

        public static int correctans = 1;
       
        public static int wrongans = 1;
        PictureBox currentdrag = new PictureBox();








        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;
            pictureBox9.AllowDrop = true;
            pictureBox10.AllowDrop = true;
            pictureBox11.AllowDrop = true;
            pictureBox12.AllowDrop = true;
            pictureBox13.AllowDrop = true;
            pictureBox14.AllowDrop = true;
            pictureBox15.AllowDrop = true;
            pictureBox16.AllowDrop = true;
            pos = randomClass.Next(0, 9);
            Image img1 = Image.FromFile(Application.StartupPath + @"\image\exitb.png");
            button1.Image = img1;

            Image img2 = Image.FromFile(Application.StartupPath + @"\image\home-icon.png");
            button3.Image = img2;


            Image img4 = Image.FromFile(Application.StartupPath + @"\image\BACKp.png");
            button2.Image = img4;

            string getForm1Value = "";
            getForm1Value = Form1.name;
            label2.Text = label2.Text + getForm1Value;


            radioButton3.Text = ConvertToArabicNumerals(radioButton3.Text);
            radioButton1.Text = ConvertToArabicNumerals(radioButton1.Text);
            radioButton2.Text = ConvertToArabicNumerals(radioButton2.Text);
            radioButton4.Text = ConvertToArabicNumerals(radioButton4.Text);
            radioButton5.Text = ConvertToArabicNumerals(radioButton5.Text);
            label3.Text = ConvertToArabicNumerals(label3.Text);
            label4.Text = ConvertToArabicNumerals(label4.Text);
            label5.Text = ConvertToArabicNumerals(label5.Text);
            label6.Text = ConvertToArabicNumerals(label6.Text);
            label7.Text = ConvertToArabicNumerals(label7.Text);
            label8.Text = ConvertToArabicNumerals(label8.Text);
            label9.Text = ConvertToArabicNumerals(label9.Text);
            label10.Text = ConvertToArabicNumerals(label10.Text);
            label11.Text = ConvertToArabicNumerals(label11.Text);
            label12.Text = ConvertToArabicNumerals(label12.Text); 




            imeges[0] = Image.FromFile(Application.StartupPath + @"\image\pc1.JPG");
            imeges[1] = Image.FromFile(Application.StartupPath + @"\image\pc2.JPG");
            imeges[2] = Image.FromFile(Application.StartupPath + @"\image\pc3.JPG");
            imeges[3] = Image.FromFile(Application.StartupPath + @"\image\pc4.JPG");
            imeges[4] = Image.FromFile(Application.StartupPath + @"\image\pc5.JPG");
            imeges[5] = Image.FromFile(Application.StartupPath + @"\image\pc6.JPG");
            imeges[6] = Image.FromFile(Application.StartupPath + @"\image\pc7.JPG");
            imeges[7] = Image.FromFile(Application.StartupPath + @"\image\pc8.JPG");
            imeges[8] = Image.FromFile(Application.StartupPath + @"\image\pc9.JPG");
            imeges[9] = Image.FromFile(Application.StartupPath + @"\image\pc10.JPG");
            pictureBox7.Image = imeges[0];
            pictureBox8.Image = imeges[1];
            pictureBox9.Image = imeges[2];
            pictureBox10.Image = imeges[3];
            pictureBox11.Image = imeges[4];
            pictureBox12.Image = imeges[5];
            pictureBox13.Image = imeges[6];
            pictureBox14.Image = imeges[7];
            pictureBox15.Image = imeges[8];
            pictureBox16.Image = imeges[9];
            Class1.correctans = 1;
            Class1.wrongans = 1;

            label1.Visible = false;
            panel1.Visible = false;
            button5.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;

            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;

            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;

            Class1.rbt = 4;
            pos1 = randomClass.Next(0, 9);
            pos2 = randomClass.Next(0, 9);
            pos3 = randomClass.Next(0, 9);
            pos4 = randomClass.Next(0, 9);

            for (int i = 0; i < 4; i++)
            {



                if (pos2 != pos1 && pos2 != pos3 && pos2 != pos4)
                {

                    pictureBox3.Image = imeges[pos2];
                }

                else
                {
                    pos2 = randomClass.Next(0, 9);
                    pictureBox3.Image = imeges[pos2];
                }
                if (pos3 != pos1 && pos3 != pos2 && pos3 != pos4)
                {

                    pictureBox4.Image = imeges[pos3];
                }

                else
                {
                    pos3 = randomClass.Next(0, 9);
                    pictureBox4.Image = imeges[pos3];
                }
                if (pos4 != pos1 && pos4 != pos2 && pos4 != pos3)
                {

                    pictureBox5.Image = imeges[pos4];
                }

                else
                {
                    pos4 = randomClass.Next(0, 9);
                    pictureBox5.Image = imeges[pos4];
                }
                if (pos1 != pos2 && pos1 != pos3 && pos1 != pos3)
                {

                    pictureBox6.Image = imeges[pos1];
                }

                else
                {
                    pictureBox6.Image = imeges[pos1];
                    pos = randomClass.Next(0, 9);
                }
            }
            if (pictureBox7.Image == pictureBox2.Image || pictureBox7.Image == pictureBox3.Image || pictureBox7.Image == pictureBox4.Image
               || pictureBox7.Image == pictureBox5.Image || pictureBox7.Image == pictureBox6.Image)
            {
                pictureBox7.Image = null;

            }
            if (pictureBox8.Image == pictureBox2.Image || pictureBox8.Image == pictureBox3.Image || pictureBox8.Image == pictureBox4.Image
               || pictureBox8.Image == pictureBox5.Image || pictureBox8.Image == pictureBox6.Image)
            {
                pictureBox8.Image = null;

            }
            if (pictureBox9.Image == pictureBox2.Image || pictureBox9.Image == pictureBox3.Image || pictureBox9.Image == pictureBox4.Image
               || pictureBox9.Image == pictureBox5.Image || pictureBox9.Image == pictureBox6.Image)
            {
                pictureBox9.Image = null;

            }
            if (pictureBox10.Image == pictureBox2.Image || pictureBox10.Image == pictureBox3.Image || pictureBox10.Image == pictureBox4.Image
               || pictureBox10.Image == pictureBox5.Image || pictureBox10.Image == pictureBox6.Image)
            {
                pictureBox10.Image = null;

            }
            if (pictureBox11.Image == pictureBox2.Image || pictureBox11.Image == pictureBox3.Image || pictureBox11.Image == pictureBox4.Image
               || pictureBox11.Image == pictureBox5.Image || pictureBox11.Image == pictureBox6.Image)
            {
                pictureBox11.Image = null;

            }
            if (pictureBox12.Image == pictureBox2.Image || pictureBox12.Image == pictureBox3.Image || pictureBox12.Image == pictureBox4.Image
              || pictureBox12.Image == pictureBox5.Image || pictureBox12.Image == pictureBox6.Image)
            {
                pictureBox12.Image = null;

            }
            if (pictureBox13.Image == pictureBox2.Image || pictureBox13.Image == pictureBox3.Image || pictureBox13.Image == pictureBox4.Image
              || pictureBox13.Image == pictureBox5.Image || pictureBox13.Image == pictureBox6.Image)
            {
                pictureBox13.Image = null;

            }
            if (pictureBox14.Image == pictureBox2.Image || pictureBox14.Image == pictureBox3.Image || pictureBox14.Image == pictureBox4.Image
              || pictureBox14.Image == pictureBox5.Image || pictureBox14.Image == pictureBox6.Image)
            {
                pictureBox14.Image = null;

            }
            if (pictureBox15.Image == pictureBox2.Image || pictureBox15.Image == pictureBox3.Image || pictureBox15.Image == pictureBox4.Image
              || pictureBox15.Image == pictureBox5.Image || pictureBox15.Image == pictureBox6.Image)
            {
                pictureBox15.Image = null;

            }
            if (pictureBox16.Image == pictureBox2.Image || pictureBox16.Image == pictureBox3.Image || pictureBox16.Image == pictureBox4.Image
              || pictureBox16.Image == pictureBox5.Image || pictureBox16.Image == pictureBox6.Image)
            {
                pictureBox16.Image = null;

            }


        }

        public string ConvertToArabicNumerals(string input)
        {
            System.Text.UTF8Encoding utf8Encoder = new UTF8Encoding();

            System.Text.Decoder utf8Decoder = utf8Encoder.GetDecoder();

            System.Text.StringBuilder convertedChars = new System.Text.StringBuilder();

            char[] convertedChar = new char[1];

            byte[] bytes = new byte[] { 217, 160 };

            char[] inputCharArray = input.ToCharArray();


            foreach (char c in inputCharArray)
            {


                if (char.IsDigit(c))
                {

                    bytes[1] = Convert.ToByte(160 + char.GetNumericValue(c));

                    utf8Decoder.GetChars(bytes, 0, 2, convertedChar, 0);


                    convertedChars.Append(convertedChar[0]);

                }
                else
                {
                    convertedChars.Append(c);

                }
            }

            return convertedChars.ToString();

        }//end method convert arabic

         
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 other = new Form1();
            other.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("هل تريد المغادرة؟ ", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                this.Show(); // for exit
        }

      

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            this.Hide();
            frm.Show();
        }

       
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            //pos = randomClass.Next(0, 9);
            

            PictureBox pictureBoxV = (PictureBox)sender;
            DoDragDrop(pictureBoxV.Image, DragDropEffects.Copy);
            currentdrag = (PictureBox)sender;
        }

        private void pictureBox7_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox7_DragDrop(object sender, DragEventArgs e)
        {
            Image current = (Image)e.Data.GetData(DataFormats.Bitmap);
            if (current.Equals(imeges[0]))
            {
                pictureBox7.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                axWindowsMediaPlayer1.URL = "applause-01.wav";
                currentdrag.Visible = false;
                String str = Convert.ToString(Class1.correctans);

                label13.Text = str;
               Class1.correctans++;
                
               

                if (pictureBox3.Image == pictureBox7.Image || pictureBox3.Image == pictureBox8.Image || pictureBox3.Image == pictureBox9.Image
               || pictureBox3.Image == pictureBox10.Image || pictureBox3.Image == pictureBox11.Image || pictureBox3.Image == pictureBox12.Image
                    || pictureBox3.Image == pictureBox13.Image || pictureBox3.Image == pictureBox14.Image || pictureBox3.Image == pictureBox15.Image
                    || pictureBox3.Image == pictureBox16.Image)
                {
                    pictureBox3.Image = null;

                }
                else if (pictureBox4.Image == pictureBox7.Image || pictureBox4.Image == pictureBox8.Image || pictureBox4.Image == pictureBox9.Image
               || pictureBox4.Image == pictureBox10.Image || pictureBox4.Image == pictureBox11.Image || pictureBox4.Image == pictureBox12.Image
                    || pictureBox4.Image == pictureBox13.Image || pictureBox4.Image == pictureBox14.Image || pictureBox4.Image == pictureBox15.Image
                    || pictureBox4.Image == pictureBox16.Image)
                {
                    pictureBox4.Image = null;

                }
                else if (pictureBox5.Image == pictureBox7.Image || pictureBox5.Image == pictureBox8.Image || pictureBox5.Image == pictureBox9.Image
               || pictureBox5.Image == pictureBox10.Image || pictureBox5.Image == pictureBox11.Image || pictureBox5.Image == pictureBox12.Image
                    || pictureBox5.Image == pictureBox13.Image || pictureBox5.Image == pictureBox14.Image || pictureBox5.Image == pictureBox15.Image
                    || pictureBox5.Image == pictureBox16.Image)
                {
                    pictureBox5.Image = null;

                }
                else if (pictureBox6.Image == pictureBox7.Image || pictureBox6.Image == pictureBox8.Image || pictureBox6.Image == pictureBox9.Image
              || pictureBox6.Image == pictureBox10.Image || pictureBox6.Image == pictureBox11.Image || pictureBox6.Image == pictureBox12.Image
                   || pictureBox6.Image == pictureBox13.Image || pictureBox6.Image == pictureBox14.Image || pictureBox6.Image == pictureBox15.Image
                   || pictureBox6.Image == pictureBox16.Image)
                {
                    pictureBox6.Image = null;

                }
                else if (pictureBox2.Image == pictureBox7.Image || pictureBox2.Image == pictureBox8.Image || pictureBox2.Image == pictureBox9.Image
              || pictureBox2.Image == pictureBox10.Image || pictureBox2.Image == pictureBox11.Image || pictureBox2.Image == pictureBox12.Image
                   || pictureBox2.Image == pictureBox13.Image || pictureBox2.Image == pictureBox14.Image || pictureBox2.Image == pictureBox15.Image
                   || pictureBox2.Image == pictureBox16.Image)
                {
                    pictureBox2.Image = null;

                }
               
            }

            else
            {

                axWindowsMediaPlayer1.URL = "fail-trombone-01.wav";
                String str1 = Convert.ToString(wrongans);
                label15.Text = str1;
                wrongans++;
            }
            if (radioButton3.Checked == true && label13.Text.Equals("1"))
            {
               // Form8 frm = new Form8();
               // this.Close();
               // timer1.Enabled = false;
               // frm.Show();
            }
            else if (radioButton1.Checked == true && label13.Text.Equals("2"))
            {
                //Form8 frm = new Form8();
                //this.Close();
                //timer1.Enabled = false;
               // frm.Show();
            }
            else if (radioButton2.Checked == true && label13.Text.Equals("3"))
            {
                //Form8 frm = new Form8();
                //this.Close();
                //timer1.Enabled = false;
                //frm.Show();
            }
            else if (radioButton4.Checked == true && label13.Text.Equals("4"))
            {
               // Form8 frm = new Form8();
               // this.Close();
               // timer1.Enabled = false;
               // frm.Show();
            }
            else if (radioButton5.Checked == true && label13.Text.Equals("5"))
            {
               // Form8 frm = new Form8();
                //this.Close();
                //timer1.Enabled = false;
                //frm.Show();
            }

           
            



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
           

            PictureBox pictureBoxV = (PictureBox)sender;
            DoDragDrop(pictureBoxV.Image, DragDropEffects.Copy);
            currentdrag = (PictureBox)sender;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBoxV = (PictureBox)sender;
            DoDragDrop(pictureBoxV.Image, DragDropEffects.Copy);
            currentdrag = (PictureBox)sender;
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBoxV = (PictureBox)sender;
            DoDragDrop(pictureBoxV.Image, DragDropEffects.Copy);
            currentdrag = (PictureBox)sender;
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBoxV = (PictureBox)sender;
            DoDragDrop(pictureBoxV.Image, DragDropEffects.Copy);
            currentdrag = (PictureBox)sender;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }
        //hear -----------------------------------------------------------------------------------------------------
       

        private void pictureBox7_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void pictureBox8_DragDrop(object sender, DragEventArgs e)
        {
            Image current = (Image)e.Data.GetData(DataFormats.Bitmap);
            if (current.Equals(imeges[1]))
            {
                pictureBox8.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                axWindowsMediaPlayer1.URL = "applause-01.wav";
                
                currentdrag.Visible = false;
                String str = Convert.ToString(Class1.correctans);

                label13.Text = str;
                Class1.correctans++;
               
                if (pictureBox3.Image == pictureBox7.Image || pictureBox3.Image == pictureBox8.Image || pictureBox3.Image == pictureBox9.Image
               || pictureBox3.Image == pictureBox10.Image || pictureBox3.Image == pictureBox11.Image || pictureBox3.Image == pictureBox12.Image
                    || pictureBox3.Image == pictureBox13.Image || pictureBox3.Image == pictureBox14.Image || pictureBox3.Image == pictureBox15.Image
                    || pictureBox3.Image == pictureBox16.Image)
                {
                    pictureBox3.Image = null;

                }
                else if (pictureBox4.Image == pictureBox7.Image || pictureBox4.Image == pictureBox8.Image || pictureBox4.Image == pictureBox9.Image
               || pictureBox4.Image == pictureBox10.Image || pictureBox4.Image == pictureBox11.Image || pictureBox4.Image == pictureBox12.Image
                    || pictureBox4.Image == pictureBox13.Image || pictureBox4.Image == pictureBox14.Image || pictureBox4.Image == pictureBox15.Image
                    || pictureBox4.Image == pictureBox16.Image)
                {
                    pictureBox4.Image = null;

                }
                else if (pictureBox5.Image == pictureBox7.Image || pictureBox5.Image == pictureBox8.Image || pictureBox5.Image == pictureBox9.Image
               || pictureBox5.Image == pictureBox10.Image || pictureBox5.Image == pictureBox11.Image || pictureBox5.Image == pictureBox12.Image
                    || pictureBox5.Image == pictureBox13.Image || pictureBox5.Image == pictureBox14.Image || pictureBox5.Image == pictureBox15.Image
                    || pictureBox5.Image == pictureBox16.Image)
                {
                    pictureBox5.Image = null;

                }
                else if (pictureBox6.Image == pictureBox7.Image || pictureBox6.Image == pictureBox8.Image || pictureBox6.Image == pictureBox9.Image
              || pictureBox6.Image == pictureBox10.Image || pictureBox6.Image == pictureBox11.Image || pictureBox6.Image == pictureBox12.Image
                   || pictureBox6.Image == pictureBox13.Image || pictureBox6.Image == pictureBox14.Image || pictureBox6.Image == pictureBox15.Image
                   || pictureBox6.Image == pictureBox16.Image)
                {
                    pictureBox6.Image = null;

                }
                else if (pictureBox2.Image == pictureBox7.Image || pictureBox2.Image == pictureBox8.Image || pictureBox2.Image == pictureBox9.Image
              || pictureBox2.Image == pictureBox10.Image || pictureBox2.Image == pictureBox11.Image || pictureBox2.Image == pictureBox12.Image
                   || pictureBox2.Image == pictureBox13.Image || pictureBox2.Image == pictureBox14.Image || pictureBox2.Image == pictureBox15.Image
                   || pictureBox2.Image == pictureBox16.Image)
                {
                    pictureBox2.Image = null;

                }

            }

            else
            {

                
                axWindowsMediaPlayer1.URL = "fail-trombone-01.wav";
                String str1 = Convert.ToString(wrongans);
                label15.Text = str1;
                wrongans++;
            }
            if (radioButton3.Checked == true && label13.Text.Equals("1"))
            {
               // Form8 frm = new Form8();
                //this.Close();
               // timer1.Enabled = false;
               // frm.Show();
            }
            else if (radioButton1.Checked == true && label13.Text.Equals("2"))
            {
               // Form8 frm = new Form8();
                //this.Close();
                //timer1.Enabled = false;
                //frm.Show();
            }
            else if (radioButton2.Checked == true && label13.Text.Equals("3"))
            {
               // Form8 frm = new Form8();
               // this.Close();
               // timer1.Enabled = false;
                //frm.Show();
            }
            else if (radioButton4.Checked == true && label13.Text.Equals("4"))
            {
               // Form8 frm = new Form8();
               // this.Close();
               // timer1.Enabled = false;
               // frm.Show();
            }
            else if (radioButton5.Checked == true && label13.Text.Equals("5"))
            {
               // Form8 frm = new Form8();
               // this.Close();
               // timer1.Enabled = false;
               // frm.Show();
            }


        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void pictureBox8_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox9_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox12_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox9_DragDrop(object sender, DragEventArgs e)
        {
            Image current = (Image)e.Data.GetData(DataFormats.Bitmap);
            if (current.Equals(imeges[2]))
            {
                pictureBox9.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                axWindowsMediaPlayer1.URL = "applause-01.wav";
                currentdrag.Visible = false;
                String str = Convert.ToString(Class1.correctans);

                label13.Text = str;
                Class1.correctans++;
                if (pictureBox3.Image == pictureBox7.Image || pictureBox3.Image == pictureBox8.Image || pictureBox3.Image == pictureBox9.Image
               || pictureBox3.Image == pictureBox10.Image || pictureBox3.Image == pictureBox11.Image || pictureBox3.Image == pictureBox12.Image
                    || pictureBox3.Image == pictureBox13.Image || pictureBox3.Image == pictureBox14.Image || pictureBox3.Image == pictureBox15.Image
                    || pictureBox3.Image == pictureBox16.Image)
                {
                    pictureBox3.Image = null;

                }
                else if (pictureBox4.Image == pictureBox7.Image || pictureBox4.Image == pictureBox8.Image || pictureBox4.Image == pictureBox9.Image
               || pictureBox4.Image == pictureBox10.Image || pictureBox4.Image == pictureBox11.Image || pictureBox4.Image == pictureBox12.Image
                    || pictureBox4.Image == pictureBox13.Image || pictureBox4.Image == pictureBox14.Image || pictureBox4.Image == pictureBox15.Image
                    || pictureBox4.Image == pictureBox16.Image)
                {
                    pictureBox4.Image = null;

                }
                else if (pictureBox5.Image == pictureBox7.Image || pictureBox5.Image == pictureBox8.Image || pictureBox5.Image == pictureBox9.Image
               || pictureBox5.Image == pictureBox10.Image || pictureBox5.Image == pictureBox11.Image || pictureBox5.Image == pictureBox12.Image
                    || pictureBox5.Image == pictureBox13.Image || pictureBox5.Image == pictureBox14.Image || pictureBox5.Image == pictureBox15.Image
                    || pictureBox5.Image == pictureBox16.Image)
                {
                    pictureBox5.Image = null;

                }
                else if (pictureBox6.Image == pictureBox7.Image || pictureBox6.Image == pictureBox8.Image || pictureBox6.Image == pictureBox9.Image
              || pictureBox6.Image == pictureBox10.Image || pictureBox6.Image == pictureBox11.Image || pictureBox6.Image == pictureBox12.Image
                   || pictureBox6.Image == pictureBox13.Image || pictureBox6.Image == pictureBox14.Image || pictureBox6.Image == pictureBox15.Image
                   || pictureBox6.Image == pictureBox16.Image)
                {
                    pictureBox6.Image = null;

                }
                else if (pictureBox2.Image == pictureBox7.Image || pictureBox2.Image == pictureBox8.Image || pictureBox2.Image == pictureBox9.Image
              || pictureBox2.Image == pictureBox10.Image || pictureBox2.Image == pictureBox11.Image || pictureBox2.Image == pictureBox12.Image
                   || pictureBox2.Image == pictureBox13.Image || pictureBox2.Image == pictureBox14.Image || pictureBox2.Image == pictureBox15.Image
                   || pictureBox2.Image == pictureBox16.Image)
                {
                    pictureBox2.Image = null;

                }

            }

            else
            {

                axWindowsMediaPlayer1.URL = "fail-trombone-01.wav";
                String str1 = Convert.ToString(wrongans);
                label15.Text = str1;
                wrongans++;
            }
            if (radioButton3.Checked == true && label13.Text.Equals("1"))
            {
               // Form8 frm = new Form8();
               // this.Close();
               // timer1.Enabled = false;
               // frm.Show();
            }
            else if (radioButton1.Checked == true && label13.Text.Equals("2"))
            {
               // Form8 frm = new Form8();
                //this.Close();
                //timer1.Enabled = false;
                //frm.Show();
            }
            else if (radioButton2.Checked == true && label13.Text.Equals("3"))
            {
                //Form8 frm = new Form8();
                //this.Close();
                //timer1.Enabled = false;
                //frm.Show();
            }
            else if (radioButton4.Checked == true && label13.Text.Equals("4"))
            {
                //Form8 frm = new Form8();
                //this.Close();
                //timer1.Enabled = false;
                //frm.Show();
            }
            else if (radioButton5.Checked == true && label13.Text.Equals("5"))
            {
               // Form8 frm = new Form8();
                //this.Close();
                //timer1.Enabled = false;
               // frm.Show();
            }


        }

        private void pictureBox9_DragEnter_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox10_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox11_DragDrop(object sender, DragEventArgs e)
        {
            Image current = (Image)e.Data.GetData(DataFormats.Bitmap);
            if (current.Equals(imeges[4]))
            {
                pictureBox11.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                axWindowsMediaPlayer1.URL = "applause-01.wav";
                currentdrag.Visible = false;
                String str = Convert.ToString(Class1.correctans);

                label13.Text = str;
                Class1.correctans++;
                if (pictureBox3.Image == pictureBox7.Image || pictureBox3.Image == pictureBox8.Image || pictureBox3.Image == pictureBox9.Image
               || pictureBox3.Image == pictureBox10.Image || pictureBox3.Image == pictureBox11.Image || pictureBox3.Image == pictureBox12.Image
                    || pictureBox3.Image == pictureBox13.Image || pictureBox3.Image == pictureBox14.Image || pictureBox3.Image == pictureBox15.Image
                    || pictureBox3.Image == pictureBox16.Image)
                {
                    pictureBox3.Image = null;

                }
                else if (pictureBox4.Image == pictureBox7.Image || pictureBox4.Image == pictureBox8.Image || pictureBox4.Image == pictureBox9.Image
               || pictureBox4.Image == pictureBox10.Image || pictureBox4.Image == pictureBox11.Image || pictureBox4.Image == pictureBox12.Image
                    || pictureBox4.Image == pictureBox13.Image || pictureBox4.Image == pictureBox14.Image || pictureBox4.Image == pictureBox15.Image
                    || pictureBox4.Image == pictureBox16.Image)
                {
                    pictureBox4.Image = null;

                }
                else if (pictureBox5.Image == pictureBox7.Image || pictureBox5.Image == pictureBox8.Image || pictureBox5.Image == pictureBox9.Image
               || pictureBox5.Image == pictureBox10.Image || pictureBox5.Image == pictureBox11.Image || pictureBox5.Image == pictureBox12.Image
                    || pictureBox5.Image == pictureBox13.Image || pictureBox5.Image == pictureBox14.Image || pictureBox5.Image == pictureBox15.Image
                    || pictureBox5.Image == pictureBox16.Image)
                {
                    pictureBox5.Image = null;

                }
                else if (pictureBox6.Image == pictureBox7.Image || pictureBox6.Image == pictureBox8.Image || pictureBox6.Image == pictureBox9.Image
              || pictureBox6.Image == pictureBox10.Image || pictureBox6.Image == pictureBox11.Image || pictureBox6.Image == pictureBox12.Image
                   || pictureBox6.Image == pictureBox13.Image || pictureBox6.Image == pictureBox14.Image || pictureBox6.Image == pictureBox15.Image
                   || pictureBox6.Image == pictureBox16.Image)
                {
                    pictureBox6.Image = null;

                }
                else if (pictureBox2.Image == pictureBox7.Image || pictureBox2.Image == pictureBox8.Image || pictureBox2.Image == pictureBox9.Image
              || pictureBox2.Image == pictureBox10.Image || pictureBox2.Image == pictureBox11.Image || pictureBox2.Image == pictureBox12.Image
                   || pictureBox2.Image == pictureBox13.Image || pictureBox2.Image == pictureBox14.Image || pictureBox2.Image == pictureBox15.Image
                   || pictureBox2.Image == pictureBox16.Image)
                {
                    pictureBox2.Image = null;

                }

            }

            else
            {

                axWindowsMediaPlayer1.URL = "fail-trombone-01.wav";
                String str1 = Convert.ToString(wrongans);
                label15.Text = str1;
                wrongans++;
            }
            if (radioButton3.Checked == true && label13.Text.Equals("1"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton1.Checked == true && label13.Text.Equals("2"))
            {/*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton2.Checked == true && label13.Text.Equals("3"))
            {
                /*
                 Form8 frm = new Form8();
                 this.Close();
                 timer1.Enabled = false;
                 frm.Show(); */
            }
            else if (radioButton4.Checked == true && label13.Text.Equals("4"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton5.Checked == true && label13.Text.Equals("5"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }


        }

        private void pictureBox12_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox13_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox14_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox15_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox16_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox8_DragEnter_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox11_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox10_DragDrop(object sender, DragEventArgs e)
        {
            Image current = (Image)e.Data.GetData(DataFormats.Bitmap);
            if (current.Equals(imeges[3]))
            {
                pictureBox10.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                axWindowsMediaPlayer1.URL = "applause-01.wav";
                currentdrag.Visible = false;
                String str = Convert.ToString(Class1.correctans);


                label13.Text = str;
                Class1.correctans++;


                if (pictureBox3.Image == pictureBox7.Image || pictureBox3.Image == pictureBox8.Image || pictureBox3.Image == pictureBox9.Image
               || pictureBox3.Image == pictureBox10.Image || pictureBox3.Image == pictureBox11.Image || pictureBox3.Image == pictureBox12.Image
                    || pictureBox3.Image == pictureBox13.Image || pictureBox3.Image == pictureBox14.Image || pictureBox3.Image == pictureBox15.Image
                    || pictureBox3.Image == pictureBox16.Image)
                {
                    pictureBox3.Image = null;

                }
                else if (pictureBox4.Image == pictureBox7.Image || pictureBox4.Image == pictureBox8.Image || pictureBox4.Image == pictureBox9.Image
               || pictureBox4.Image == pictureBox10.Image || pictureBox4.Image == pictureBox11.Image || pictureBox4.Image == pictureBox12.Image
                    || pictureBox4.Image == pictureBox13.Image || pictureBox4.Image == pictureBox14.Image || pictureBox4.Image == pictureBox15.Image
                    || pictureBox4.Image == pictureBox16.Image)
                {
                    pictureBox4.Image = null;

                }
                else if (pictureBox5.Image == pictureBox7.Image || pictureBox5.Image == pictureBox8.Image || pictureBox5.Image == pictureBox9.Image
               || pictureBox5.Image == pictureBox10.Image || pictureBox5.Image == pictureBox11.Image || pictureBox5.Image == pictureBox12.Image
                    || pictureBox5.Image == pictureBox13.Image || pictureBox5.Image == pictureBox14.Image || pictureBox5.Image == pictureBox15.Image
                    || pictureBox5.Image == pictureBox16.Image)
                {
                    pictureBox5.Image = null;

                }
                else if (pictureBox6.Image == pictureBox7.Image || pictureBox6.Image == pictureBox8.Image || pictureBox6.Image == pictureBox9.Image
              || pictureBox6.Image == pictureBox10.Image || pictureBox6.Image == pictureBox11.Image || pictureBox6.Image == pictureBox12.Image
                   || pictureBox6.Image == pictureBox13.Image || pictureBox6.Image == pictureBox14.Image || pictureBox6.Image == pictureBox15.Image
                   || pictureBox6.Image == pictureBox16.Image)
                {
                    pictureBox6.Image = null;

                }
                else if (pictureBox2.Image == pictureBox7.Image || pictureBox2.Image == pictureBox8.Image || pictureBox2.Image == pictureBox9.Image
              || pictureBox2.Image == pictureBox10.Image || pictureBox2.Image == pictureBox11.Image || pictureBox2.Image == pictureBox12.Image
                   || pictureBox2.Image == pictureBox13.Image || pictureBox2.Image == pictureBox14.Image || pictureBox2.Image == pictureBox15.Image
                   || pictureBox2.Image == pictureBox16.Image)
                {
                    pictureBox2.Image = null;

                }

            }

            else
            {

                axWindowsMediaPlayer1.URL = "fail-trombone-01.wav";
                String str1 = Convert.ToString(wrongans);
                label15.Text = str1;
                wrongans++;
            }
            if (radioButton3.Checked == true && label13.Text.Equals("1"))
            {
                /*
                 Form8 frm = new Form8();
                 this.Close();
                 timer1.Enabled = false;
                 frm.Show(); */
            }
            else if (radioButton1.Checked == true && label13.Text.Equals("2"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton2.Checked == true && label13.Text.Equals("3"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton4.Checked == true && label13.Text.Equals("4"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton5.Checked == true && label13.Text.Equals("5"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }


        }

        private void pictureBox12_DragDrop_1(object sender, DragEventArgs e)
        {
            Image current = (Image)e.Data.GetData(DataFormats.Bitmap);
            if (current.Equals(imeges[5]))
            {
                pictureBox12.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                axWindowsMediaPlayer1.URL = "applause-01.wav";
                currentdrag.Visible = false;
                String str = Convert.ToString(Class1.correctans);

                label13.Text = str;
                Class1.correctans++;
                if (pictureBox3.Image == pictureBox7.Image || pictureBox3.Image == pictureBox8.Image || pictureBox3.Image == pictureBox9.Image
               || pictureBox3.Image == pictureBox10.Image || pictureBox3.Image == pictureBox11.Image || pictureBox3.Image == pictureBox12.Image
                    || pictureBox3.Image == pictureBox13.Image || pictureBox3.Image == pictureBox14.Image || pictureBox3.Image == pictureBox15.Image
                    || pictureBox3.Image == pictureBox16.Image)
                {
                    pictureBox3.Image = null;

                }
                else if (pictureBox4.Image == pictureBox7.Image || pictureBox4.Image == pictureBox8.Image || pictureBox4.Image == pictureBox9.Image
               || pictureBox4.Image == pictureBox10.Image || pictureBox4.Image == pictureBox11.Image || pictureBox4.Image == pictureBox12.Image
                    || pictureBox4.Image == pictureBox13.Image || pictureBox4.Image == pictureBox14.Image || pictureBox4.Image == pictureBox15.Image
                    || pictureBox4.Image == pictureBox16.Image)
                {
                    pictureBox4.Image = null;

                }
                else if (pictureBox5.Image == pictureBox7.Image || pictureBox5.Image == pictureBox8.Image || pictureBox5.Image == pictureBox9.Image
               || pictureBox5.Image == pictureBox10.Image || pictureBox5.Image == pictureBox11.Image || pictureBox5.Image == pictureBox12.Image
                    || pictureBox5.Image == pictureBox13.Image || pictureBox5.Image == pictureBox14.Image || pictureBox5.Image == pictureBox15.Image
                    || pictureBox5.Image == pictureBox16.Image)
                {
                    pictureBox5.Image = null;

                }
                else if (pictureBox6.Image == pictureBox7.Image || pictureBox6.Image == pictureBox8.Image || pictureBox6.Image == pictureBox9.Image
              || pictureBox6.Image == pictureBox10.Image || pictureBox6.Image == pictureBox11.Image || pictureBox6.Image == pictureBox12.Image
                   || pictureBox6.Image == pictureBox13.Image || pictureBox6.Image == pictureBox14.Image || pictureBox6.Image == pictureBox15.Image
                   || pictureBox6.Image == pictureBox16.Image)
                {
                    pictureBox6.Image = null;

                }
                else if (pictureBox2.Image == pictureBox7.Image || pictureBox2.Image == pictureBox8.Image || pictureBox2.Image == pictureBox9.Image
              || pictureBox2.Image == pictureBox10.Image || pictureBox2.Image == pictureBox11.Image || pictureBox2.Image == pictureBox12.Image
                   || pictureBox2.Image == pictureBox13.Image || pictureBox2.Image == pictureBox14.Image || pictureBox2.Image == pictureBox15.Image
                   || pictureBox2.Image == pictureBox16.Image)
                {
                    pictureBox2.Image = null;

                }

            }

            else
            {

                axWindowsMediaPlayer1.URL = "fail-trombone-01.wav";
                String str1 = Convert.ToString(wrongans);
                label15.Text = str1;
                wrongans++;
            }

        }

        private void pictureBox13_DragDrop(object sender, DragEventArgs e)
        {
            Image current = (Image)e.Data.GetData(DataFormats.Bitmap);
            if (current.Equals(imeges[6]))
            {
                pictureBox13.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                axWindowsMediaPlayer1.URL = "applause-01.wav";
                currentdrag.Visible = false;
                String str = Convert.ToString(Class1.correctans);

                label13.Text = str;
                Class1.correctans++;
                if (pictureBox3.Image == pictureBox7.Image || pictureBox3.Image == pictureBox8.Image || pictureBox3.Image == pictureBox9.Image
               || pictureBox3.Image == pictureBox10.Image || pictureBox3.Image == pictureBox11.Image || pictureBox3.Image == pictureBox12.Image
                    || pictureBox3.Image == pictureBox13.Image || pictureBox3.Image == pictureBox14.Image || pictureBox3.Image == pictureBox15.Image
                    || pictureBox3.Image == pictureBox16.Image)
                {
                    pictureBox3.Image = null;

                }
                else if (pictureBox4.Image == pictureBox7.Image || pictureBox4.Image == pictureBox8.Image || pictureBox4.Image == pictureBox9.Image
               || pictureBox4.Image == pictureBox10.Image || pictureBox4.Image == pictureBox11.Image || pictureBox4.Image == pictureBox12.Image
                    || pictureBox4.Image == pictureBox13.Image || pictureBox4.Image == pictureBox14.Image || pictureBox4.Image == pictureBox15.Image
                    || pictureBox4.Image == pictureBox16.Image)
                {
                    pictureBox4.Image = null;

                }
                else if (pictureBox5.Image == pictureBox7.Image || pictureBox5.Image == pictureBox8.Image || pictureBox5.Image == pictureBox9.Image
               || pictureBox5.Image == pictureBox10.Image || pictureBox5.Image == pictureBox11.Image || pictureBox5.Image == pictureBox12.Image
                    || pictureBox5.Image == pictureBox13.Image || pictureBox5.Image == pictureBox14.Image || pictureBox5.Image == pictureBox15.Image
                    || pictureBox5.Image == pictureBox16.Image)
                {
                    pictureBox5.Image = null;

                }
                else if (pictureBox6.Image == pictureBox7.Image || pictureBox6.Image == pictureBox8.Image || pictureBox6.Image == pictureBox9.Image
              || pictureBox6.Image == pictureBox10.Image || pictureBox6.Image == pictureBox11.Image || pictureBox6.Image == pictureBox12.Image
                   || pictureBox6.Image == pictureBox13.Image || pictureBox6.Image == pictureBox14.Image || pictureBox6.Image == pictureBox15.Image
                   || pictureBox6.Image == pictureBox16.Image)
                {
                    pictureBox6.Image = null;

                }
                else if (pictureBox2.Image == pictureBox7.Image || pictureBox2.Image == pictureBox8.Image || pictureBox2.Image == pictureBox9.Image
              || pictureBox2.Image == pictureBox10.Image || pictureBox2.Image == pictureBox11.Image || pictureBox2.Image == pictureBox12.Image
                   || pictureBox2.Image == pictureBox13.Image || pictureBox2.Image == pictureBox14.Image || pictureBox2.Image == pictureBox15.Image
                   || pictureBox2.Image == pictureBox16.Image)
                {
                    pictureBox2.Image = null;

                }

            }

            else
            {

                axWindowsMediaPlayer1.URL = "fail-trombone-01.wav";
                String str1 = Convert.ToString(wrongans);
                label15.Text = str1;
                wrongans++;
            }
            if (radioButton3.Checked == true && label13.Text.Equals("1"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton1.Checked == true && label13.Text.Equals("2"))
            {
                /*
                 Form8 frm = new Form8();
                 this.Close();
                 timer1.Enabled = false;
                 frm.Show(); */
            }
            else if (radioButton2.Checked == true && label13.Text.Equals("3"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton4.Checked == true && label13.Text.Equals("4"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton5.Checked == true && label13.Text.Equals("5"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }


        }

        private void pictureBox14_DragDrop(object sender, DragEventArgs e)
        {
            Image current = (Image)e.Data.GetData(DataFormats.Bitmap);
            if (current.Equals(imeges[7]))
            {
                pictureBox14.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                axWindowsMediaPlayer1.URL = "applause-01.wav";
                currentdrag.Visible = false;
                String str = Convert.ToString(Class1.correctans);


                label13.Text = str;
                Class1.correctans++;
                if (pictureBox3.Image == pictureBox7.Image || pictureBox3.Image == pictureBox8.Image || pictureBox3.Image == pictureBox9.Image
               || pictureBox3.Image == pictureBox10.Image || pictureBox3.Image == pictureBox11.Image || pictureBox3.Image == pictureBox12.Image
                    || pictureBox3.Image == pictureBox13.Image || pictureBox3.Image == pictureBox14.Image || pictureBox3.Image == pictureBox15.Image
                    || pictureBox3.Image == pictureBox16.Image)
                {
                    pictureBox3.Image = null;

                }
                else if (pictureBox4.Image == pictureBox7.Image || pictureBox4.Image == pictureBox8.Image || pictureBox4.Image == pictureBox9.Image
               || pictureBox4.Image == pictureBox10.Image || pictureBox4.Image == pictureBox11.Image || pictureBox4.Image == pictureBox12.Image
                    || pictureBox4.Image == pictureBox13.Image || pictureBox4.Image == pictureBox14.Image || pictureBox4.Image == pictureBox15.Image
                    || pictureBox4.Image == pictureBox16.Image)
                {
                    pictureBox4.Image = null;

                }
                else if (pictureBox5.Image == pictureBox7.Image || pictureBox5.Image == pictureBox8.Image || pictureBox5.Image == pictureBox9.Image
               || pictureBox5.Image == pictureBox10.Image || pictureBox5.Image == pictureBox11.Image || pictureBox5.Image == pictureBox12.Image
                    || pictureBox5.Image == pictureBox13.Image || pictureBox5.Image == pictureBox14.Image || pictureBox5.Image == pictureBox15.Image
                    || pictureBox5.Image == pictureBox16.Image)
                {
                    pictureBox5.Image = null;

                }
                else if (pictureBox6.Image == pictureBox7.Image || pictureBox6.Image == pictureBox8.Image || pictureBox6.Image == pictureBox9.Image
              || pictureBox6.Image == pictureBox10.Image || pictureBox6.Image == pictureBox11.Image || pictureBox6.Image == pictureBox12.Image
                   || pictureBox6.Image == pictureBox13.Image || pictureBox6.Image == pictureBox14.Image || pictureBox6.Image == pictureBox15.Image
                   || pictureBox6.Image == pictureBox16.Image)
                {
                    pictureBox6.Image = null;

                }
                else if (pictureBox2.Image == pictureBox7.Image || pictureBox2.Image == pictureBox8.Image || pictureBox2.Image == pictureBox9.Image
              || pictureBox2.Image == pictureBox10.Image || pictureBox2.Image == pictureBox11.Image || pictureBox2.Image == pictureBox12.Image
                   || pictureBox2.Image == pictureBox13.Image || pictureBox2.Image == pictureBox14.Image || pictureBox2.Image == pictureBox15.Image
                   || pictureBox2.Image == pictureBox16.Image)
                {
                    pictureBox2.Image = null;

                }

            }

            else
            {

                axWindowsMediaPlayer1.URL = "fail-trombone-01.wav";
                String str1 = Convert.ToString(wrongans);
                label15.Text = str1;
                wrongans++;
            }
            if (radioButton3.Checked == true && label13.Text.Equals("1"))
            {
                /*
                 Form8 frm = new Form8();
                 this.Close();
                 timer1.Enabled = false;
                 frm.Show(); */
            }
            else if (radioButton1.Checked == true && label13.Text.Equals("2"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton2.Checked == true && label13.Text.Equals("3"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton4.Checked == true && label13.Text.Equals("4"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton5.Checked == true && label13.Text.Equals("5"))
            {
                /*
                 Form8 frm = new Form8();
                 this.Close();
                 timer1.Enabled = false;
                 frm.Show(); */
            }


        }

        private void pictureBox15_DragDrop(object sender, DragEventArgs e)
        {
            Image current = (Image)e.Data.GetData(DataFormats.Bitmap);
            if (current.Equals(imeges[8]))
            {
                pictureBox15.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                axWindowsMediaPlayer1.URL = "applause-01.wav";
                currentdrag.Visible = false;
                String str = Convert.ToString(Class1.correctans);


                label13.Text = str;
                Class1.correctans++;
                if (pictureBox3.Image == pictureBox7.Image || pictureBox3.Image == pictureBox8.Image || pictureBox3.Image == pictureBox9.Image
               || pictureBox3.Image == pictureBox10.Image || pictureBox3.Image == pictureBox11.Image || pictureBox3.Image == pictureBox12.Image
                    || pictureBox3.Image == pictureBox13.Image || pictureBox3.Image == pictureBox14.Image || pictureBox3.Image == pictureBox15.Image
                    || pictureBox3.Image == pictureBox16.Image)
                {
                    pictureBox3.Image = null;

                }
                else if (pictureBox4.Image == pictureBox7.Image || pictureBox4.Image == pictureBox8.Image || pictureBox4.Image == pictureBox9.Image
               || pictureBox4.Image == pictureBox10.Image || pictureBox4.Image == pictureBox11.Image || pictureBox4.Image == pictureBox12.Image
                    || pictureBox4.Image == pictureBox13.Image || pictureBox4.Image == pictureBox14.Image || pictureBox4.Image == pictureBox15.Image
                    || pictureBox4.Image == pictureBox16.Image)
                {
                    pictureBox4.Image = null;

                }
                else if (pictureBox5.Image == pictureBox7.Image || pictureBox5.Image == pictureBox8.Image || pictureBox5.Image == pictureBox9.Image
               || pictureBox5.Image == pictureBox10.Image || pictureBox5.Image == pictureBox11.Image || pictureBox5.Image == pictureBox12.Image
                    || pictureBox5.Image == pictureBox13.Image || pictureBox5.Image == pictureBox14.Image || pictureBox5.Image == pictureBox15.Image
                    || pictureBox5.Image == pictureBox16.Image)
                {
                    pictureBox5.Image = null;

                }
                else if (pictureBox6.Image == pictureBox7.Image || pictureBox6.Image == pictureBox8.Image || pictureBox6.Image == pictureBox9.Image
              || pictureBox6.Image == pictureBox10.Image || pictureBox6.Image == pictureBox11.Image || pictureBox6.Image == pictureBox12.Image
                   || pictureBox6.Image == pictureBox13.Image || pictureBox6.Image == pictureBox14.Image || pictureBox6.Image == pictureBox15.Image
                   || pictureBox6.Image == pictureBox16.Image)
                {
                    pictureBox6.Image = null;

                }
                else if (pictureBox2.Image == pictureBox7.Image || pictureBox2.Image == pictureBox8.Image || pictureBox2.Image == pictureBox9.Image
              || pictureBox2.Image == pictureBox10.Image || pictureBox2.Image == pictureBox11.Image || pictureBox2.Image == pictureBox12.Image
                   || pictureBox2.Image == pictureBox13.Image || pictureBox2.Image == pictureBox14.Image || pictureBox2.Image == pictureBox15.Image
                   || pictureBox2.Image == pictureBox16.Image)
                {
                    pictureBox2.Image = null;

                }

            }

            else
            {

                axWindowsMediaPlayer1.URL = "fail-trombone-01.wav";
                String str1 = Convert.ToString(wrongans);
                label15.Text = str1;
                wrongans++;
            }
            if (radioButton3.Checked == true && label13.Text.Equals("1"))
            {
                /*
                 Form8 frm = new Form8();
                 this.Close();
                 timer1.Enabled = false;
                 frm.Show(); */
            }
            else if (radioButton1.Checked == true && label13.Text.Equals("2"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton2.Checked == true && label13.Text.Equals("3"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton4.Checked == true && label13.Text.Equals("4"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton5.Checked == true && label13.Text.Equals("5"))
            {
                /*
                 Form8 frm = new Form8();
                 this.Close();
                 timer1.Enabled = false;
                 frm.Show(); */
            }


        }

        private void pictureBox16_DragDrop(object sender, DragEventArgs e)
        {
            Image current = (Image)e.Data.GetData(DataFormats.Bitmap);
            if (current.Equals(imeges[9]))
            {
                pictureBox16.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                axWindowsMediaPlayer1.URL = "applause-01.wav";
                currentdrag.Visible = false;
                String str = Convert.ToString(Class1.correctans);


                label13.Text = str;
                Class1.correctans++;

                
                if (pictureBox3.Image == pictureBox7.Image || pictureBox3.Image == pictureBox8.Image || pictureBox3.Image == pictureBox9.Image
               || pictureBox3.Image == pictureBox10.Image || pictureBox3.Image == pictureBox11.Image || pictureBox3.Image == pictureBox12.Image
                    || pictureBox3.Image == pictureBox13.Image || pictureBox3.Image == pictureBox14.Image || pictureBox3.Image == pictureBox15.Image
                    || pictureBox3.Image == pictureBox16.Image)
                {
                    pictureBox3.Image = null;

                }
                else if (pictureBox4.Image == pictureBox7.Image || pictureBox4.Image == pictureBox8.Image || pictureBox4.Image == pictureBox9.Image
               || pictureBox4.Image == pictureBox10.Image || pictureBox4.Image == pictureBox11.Image || pictureBox4.Image == pictureBox12.Image
                    || pictureBox4.Image == pictureBox13.Image || pictureBox4.Image == pictureBox14.Image || pictureBox4.Image == pictureBox15.Image
                    || pictureBox4.Image == pictureBox16.Image)
                {
                    pictureBox4.Image = null;

                }
                else if (pictureBox5.Image == pictureBox7.Image || pictureBox5.Image == pictureBox8.Image || pictureBox5.Image == pictureBox9.Image
               || pictureBox5.Image == pictureBox10.Image || pictureBox5.Image == pictureBox11.Image || pictureBox5.Image == pictureBox12.Image
                    || pictureBox5.Image == pictureBox13.Image || pictureBox5.Image == pictureBox14.Image || pictureBox5.Image == pictureBox15.Image
                    || pictureBox5.Image == pictureBox16.Image)
                {
                    pictureBox5.Image = null;

                }
                else if (pictureBox6.Image == pictureBox7.Image || pictureBox6.Image == pictureBox8.Image || pictureBox6.Image == pictureBox9.Image
              || pictureBox6.Image == pictureBox10.Image || pictureBox6.Image == pictureBox11.Image || pictureBox6.Image == pictureBox12.Image
                   || pictureBox6.Image == pictureBox13.Image || pictureBox6.Image == pictureBox14.Image || pictureBox6.Image == pictureBox15.Image
                   || pictureBox6.Image == pictureBox16.Image)
                {
                    pictureBox6.Image = null;

                }
                else if (pictureBox2.Image == pictureBox7.Image || pictureBox2.Image == pictureBox8.Image || pictureBox2.Image == pictureBox9.Image
              || pictureBox2.Image == pictureBox10.Image || pictureBox2.Image == pictureBox11.Image || pictureBox2.Image == pictureBox12.Image
                   || pictureBox2.Image == pictureBox13.Image || pictureBox2.Image == pictureBox14.Image || pictureBox2.Image == pictureBox15.Image
                   || pictureBox2.Image == pictureBox16.Image)
                {
                    pictureBox2.Image = null;

                }

            }

            else
            {

                axWindowsMediaPlayer1.URL = "fail-trombone-01.wav";
                String str1 = Convert.ToString(wrongans);
                label15.Text = str1;
                wrongans++;
            }
            if (radioButton3.Checked == true && label13.Text.Equals("1"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton1.Checked == true && label13.Text.Equals("2"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton2.Checked == true && label13.Text.Equals("3"))
            {
                /*
                 Form8 frm = new Form8();
                 this.Close();
                 timer1.Enabled = false;
                 frm.Show(); */
            }
            else if (radioButton4.Checked == true && label13.Text.Equals("4"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
            else if (radioButton5.Checked == true && label13.Text.Equals("5"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }


        }
        //--------------------------------------------------------------------------------------------------------
       

       
        

       
        private void label13_Click(object sender, EventArgs e)
        {
            if (label13.Text.Equals("5"))
            {
                /*
                Form8 frm = new Form8();
                this.Close();
                timer1.Enabled = false;
                frm.Show(); */
            }
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
    }
}


