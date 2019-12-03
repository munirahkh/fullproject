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
    public partial class Form6 : Form
    {
       
        public string[] info = { "تنتج  حرارة تقدر ببلايين الدرجات ",
                                          "  هو أصغر كواكب مجموعتنا الشمسية  ",
                                           " يتميز بارتفاع درجة حرارته  وبالرياح الشديدة "
                                           , "  هو الكوكب الوحيد الذي توجد عليه حياة "
                                           , "   سمي هذا الكوكب بهذا الاسم نسبةً إلى لونه المائل إلى الحمره "
                                           , "  يعتبر من أكبر وأضخم كواكب مجموعتنا الشمسية "
                                           , " يوجد حوله حلقات مكونه من  ثلوج وتراب وأقمار صغيرة  "
                                           , " كوكب عملاق يتكون من الغاز  "
                                           , "  يطلق عليه الكوكب الأزرق  " ,
                                           "  لا توجد له صور واضحة المعالم كبقية الكواكب"  };
        public static int rb = 0;
        

        public RichTextBox chosen = new RichTextBox();
        public PictureBox chosen2 = new PictureBox();
        public Image[] imeges = new Image[10];
     
        public static int calc = 3;

        public static int correctans1 = 1;
        public static int wrongans1 = 1;

       // public static int time1 = Form4.time; 

        //=========================================================
        List<string> qus = new List<string>();
        List<Point> point = new List<Point>();
        List<Image> listofpic = new List<Image>();
     
     
        public static int choise = 0;
        public int pos;
        Random location = new Random();
        public PictureBox[] arrofpictuerbox = new PictureBox[3];
        public RichTextBox[] arrofrich = new RichTextBox[3]; 
        //========================================================



        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Image img2 = Image.FromFile(Application.StartupPath + @"\image\exitb.png");
            button1.Image = img2;

            Image img4 = Image.FromFile(Application.StartupPath + @"\image\home-icon.png");
            button2.Image = img4;

            Image img3 = Image.FromFile(Application.StartupPath + @"\image\BACKp.png");
            button3.Image = img3;
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

            string getForm1Value = "";
            getForm1Value = Form1.name;
            label2.Text = label2.Text + getForm1Value;
         

            button4.Visible = false; 

          /*  if (wrongans == 3)
            {
                String wr = Convert.ToString(wrongans);
                label3.Text = wr + "/" + calc;
            } */ 

            //==================================================
            qus.Add("تنتج  حرارة تقدر ببلايين الدرجات ");
            qus.Add("  هو أصغر كواكب مجموعتنا الشمسية  ");
            qus.Add(" يتميز بارتفاع درجة حرارته  وبالرياح الشديدة ");
            qus.Add("  هو الكوكب الوحيد الذي توجد عليه حياة ");
            qus.Add("   سمي هذا الكوكب بهذا الاسم نسبةً إلى لونه المائل إلى الحمره ");
            qus.Add("  يعتبر من أكبر وأضخم كواكب مجموعتنا الشمسية ");
            qus.Add(" يوجد حوله حلقات مكونه من  ثلوج وتراب وأقمار صغيرة  ");
            qus.Add(" كوكب عملاق يتكون من الغاز  ");
            qus.Add("  يطلق عليه الكوكب الأزرق  ");
            qus.Add("  لا توجد له صور واضحة المعالم كبقية الكواكب"); 

            for (int i = 0; i < imeges.Length; i++)
            {

                listofpic.Add(imeges[i]);
            }

            point.Add(richTextBox1.Location);
            point.Add(richTextBox2.Location);
            point.Add(richTextBox3.Location);

            choise = 0;
           

            arrofpictuerbox[0] = pictureBox1;
            arrofpictuerbox[1] = pictureBox2;
            arrofpictuerbox[2] = pictureBox3;
            arrofrich[0] = richTextBox1;
            arrofrich[1] = richTextBox2;
            arrofrich[2] = richTextBox3;


            radioButton3.Text = ConvertToArabicNumerals(radioButton3.Text);
            radioButton1.Text = ConvertToArabicNumerals(radioButton1.Text);
            radioButton2.Text = ConvertToArabicNumerals(radioButton2.Text); 

           


            //=================================================





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

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            Form1 other = new Form1();
            other.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            this.Close();
            frm.Show();
            correctans1 = 0;
            wrongans1 = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label3.Text = ConvertToArabicNumerals(label3.Text);
            label4.Visible = true;
            label4.Text = ConvertToArabicNumerals(label4.Text);
            label7.Visible = true;
            label6.Visible = true;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            button5.Visible = false;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            richTextBox1.Visible = true;
            richTextBox2.Visible = true;
            richTextBox3.Visible = true;
            label1.Visible = true;


            label5.Visible = false;
            panel1.Visible = false;

            timer1.Enabled = true;

         

           for (int i = 0; i < 3; i++)
            {
                 pos = location.Next(listofpic.Count);
            if (arrofpictuerbox[i] != null && arrofrich[i] != null) {
                arrofpictuerbox[i].Image = listofpic[pos];
                arrofrich[i].Text = qus[pos];
                listofpic.Remove(listofpic[pos]);
                qus.Remove(qus[pos]);
                    }
                

            }  


          foreach (RichTextBox rich in panel3.Controls)
            {
                pos = location.Next(point.Count);
                Point p = point[pos];
                rich.Location = p;
                point.Remove(p);
            }

            if (radioButton1.Checked || radioButton2.Checked)
            {
                button4.Visible = true; 
            }

          

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            choise = 2;
            rb = 9;
            
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Click(object sender, EventArgs e)
        {
            chosen = (RichTextBox)sender;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }


        //هنا تشتغلين على النتائج 
        private void Form6_Click_1(object sender, EventArgs e)
        {
            try // try to check if there is a n excption
            {
                chosen2 = (PictureBox)sender;
                int pos = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (chosen2.Image == imeges[i])
                        pos = i;


                }


                if (chosen.Text == info[pos])
                {
                    axWindowsMediaPlayer1.URL = "applause-01.wav";

                    String str = Convert.ToString(correctans1++) ;
                    label3.Text = ConvertToArabicNumerals(str);
                }
                else
                {
                    axWindowsMediaPlayer1.URL = "fail-trombone-01.wav";
                    String str = Convert.ToString(wrongans1++);
                    label4.Text = ConvertToArabicNumerals(str);
                    


                }

                /*  if (wrongans1 == 3) // if wrong answers is = to 3 this message should display
                  {
                      axWindowsMediaPlayer1.URL = "fail-trombone-01.wav";

                      timer1.Enabled = false;
                      Form8 f = new Form8();
                      this.Close();
                      f.Show();
                  }
               
                  if (correctans1 == 3) // if correct answers is = to 3 this message should display and form 8 is showed
                  {
                      axWindowsMediaPlayer1.URL = "applause-01.wav";
                      timer1.Enabled = false;
                      Form8 f = new Form8();
                      this.Close();
                      f.Show();

                  }
                  if (radioButton3.Checked && correctans1 == 1) // if radio button3 is checked and correctnas is 1 
                  {

                      timer1.Enabled = false;
                      Form8 f = new Form8();
                      this.Close();
                      f.Show();

                  }
                  if (radioButton1.Checked && correctans1 == 2)// if radio button1 is checked and correctnas is 2 
                  {


                      timer1.Enabled = false;
                      Form8 f = new Form8();
                      this.Close();
                      f.Show();
                      // time is stop
                  } */
            }

            catch (Exception)// catching the exeption
            {
                MessageBox.Show("خطأ يجب عليك الضغط على صورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); // catch the exeption
            }



        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            choise = 1;
            rb = 6;
        }
        /*
        private void timer1_Tick(object sender, EventArgs e)
        {
            --time1; 
            if (time1 == 0)
            {
                timer1.Enabled = false; 
                Form8 frm = new Form8();
                this.Hide();
                frm.Show();

            }
        } */

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            rb = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
              if (choise > 0)
                {

                    point.Add(richTextBox1.Location);
                    point.Add(richTextBox2.Location);
                    point.Add(richTextBox3.Location);

                    for (int i = 0; i < 3; i++)
                    {
                        pos = location.Next(listofpic.Count);
                        if (arrofpictuerbox[i] != null && arrofrich[i] != null)
                        {
                            arrofpictuerbox[i].Image = listofpic[pos];
                            arrofrich[i].Text = qus[pos];
                            listofpic.Remove(listofpic[pos]);
                            qus.Remove(qus[pos]);
                        }  }  

       
                foreach (RichTextBox rich in panel3.Controls)
                {
                    pos = location.Next(point.Count);
                    Point p = point[pos];
                    rich.Location = p;
                    point.Remove(p);
                }
                 choise -- ;
                 if (choise == 0)
                 {
                     button4.Visible = false; 
                 }
         
                }//end if 
                
            } //end method 

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }



    }


