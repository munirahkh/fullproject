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
    public partial class Form7 : Form
    {
        string str ; 
        int time ; 
        public int scour ;
        public bool agine = false;
        Random location = new Random();
        PictureBox value1; //to save value of the  first clicked PictureBox     
        PictureBox value2; //to save value of the second clicked PictureBox 
        List<Point> point = new List<Point>(); 
      
        

        public Form7()
        {
            InitializeComponent();
           
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // Show an image in exit button 
            Image img3 = Image.FromFile(Application.StartupPath + @"\image\exitb.png");
            button1.Image = img3;

            // Show an image in home button
            Image img5 = Image.FromFile(Application.StartupPath + @"\image\home-icon.png");
            button3.Image = img5;

            //display Hello message 
            string getForm1Value = "";
            getForm1Value = Form1.name;
            label1.Text = label1.Text + getForm1Value; 

            //start timer 
           
            timer1.Start();

            label2.Visible = true; 
            str = "5";
            label2.Text = str;

            timer1.Interval = 1000;
            timer2.Interval = 1000;
            time = 30;  //total time of the game 
            scour = 0;  

           
                //set Enabled for all the PictureBoxes in panel to false  
                foreach (PictureBox pic in panel1.Controls)
                {
                    pic.Enabled = false;
                    pic.Visible = true; 
                    point.Add(pic.Location); 
                     
                 }

                foreach (PictureBox pic in panel1.Controls)
                {
                    int pos = location.Next(point.Count);
                    Point p = point[pos];
                    pic.Location = p;
                    point.Remove(p);
                } 
         


                
            //set pictuer boxes 
            pictureBox1.Image = Properties.Resources.card1;
            pictureBox2.Image = Properties.Resources.card1;
            pictureBox3.Image = Properties.Resources.card2;
            pictureBox4.Image = Properties.Resources.card2;
            pictureBox5.Image = Properties.Resources.card3;
            pictureBox6.Image = Properties.Resources.card3;
            pictureBox7.Image = Properties.Resources.card4;
            pictureBox8.Image = Properties.Resources.card4;
            pictureBox9.Image = Properties.Resources.card5;
            pictureBox10.Image = Properties.Resources.card5;
            pictureBox11.Image = Properties.Resources.card6;
            pictureBox12.Image = Properties.Resources.card6; 
        
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 other = new Form1();
            other.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          

            int time = Convert.ToInt32(label2.Text);

            time--;
            label2.Text = time.ToString();

            if (time == 0)
            {
                label2.Visible = false; 
            foreach (PictureBox pic in panel1.Controls) {
               pic.Enabled = true; 
               pic.Cursor = Cursors.Hand; 
               pic.Image = Properties.Resources.cover;
           }
            timer1.Stop();
            timer2.Start(); 
            }   }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time--;

           if (scour == 60)
            {
                axWindowsMediaPlayer1.URL = "applause-01.wav";

                timer2.Stop();
                string str = ConvertToArabicNumerals(scour.ToString());
                string s = ConvertToArabicNumerals("60"); 

                MessageBox.Show(s+"/"+str + "   نقاطك هي  ", "تهانينا  ", MessageBoxButtons.OK);
               timer4.Start(); 
            }
            if (time == 0)
            {
                timer2.Stop();
                foreach (PictureBox pic in panel1.Controls)
                {
                    pic.Visible = false;
                }

                string s = ConvertToArabicNumerals("60"); 
                MessageBox.Show(s+"/" + ConvertToArabicNumerals(scour.ToString()) + "  نقاطك هي  ", "انتهى الوقت ", MessageBoxButtons.OK);
                if (scour > 30)
                {
                    axWindowsMediaPlayer1.URL = "applause-01.wav";

                }
                else
                {
                    axWindowsMediaPlayer1.URL = "fail-trombone-01.wav";

                }
                timer4.Start(); 
                
            }

        }

        //change pictuer boxes 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.card1;

            if (value1 == null)
            {
                value1 = pictureBox1; 
            }
            else if (value1 != null && value2 == null)
            {
                value2 = pictureBox1; 
            }

            if (value1 != null && value2 != null)
            {
                timer3.Start(); 
              
            }
            }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.card1;

            if (value1 == null)
            {
                value1 = pictureBox2;
            }
            else if (value1 != null && value2 == null)
            {
                value2 = pictureBox2;
            }

            if (value1 != null && value2 != null)
            {
                timer3.Start();
               
            }

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.card2;
            if (value1 == null)
            {
                value1 = pictureBox3;
            }
            else if (value1 != null && value2 == null)
            {
                value2 = pictureBox3;
            }

            if (value1 != null && value2 != null)
            {
                timer3.Start();
               
            }

        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.card2;
            if (value1 == null)
            {
                value1 = pictureBox4;
            }
            else if (value1 != null && value2 == null)
            {
                value2 = pictureBox4;
            }

            if (value1 != null && value2 != null)
            {
                timer3.Start();
               
            }

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.card3;
            if (value1 == null)
            {
                value1 = pictureBox5;
            }
            else if (value1 != null && value2 == null)
            {
                value2 = pictureBox5;
            }

            if (value1 != null && value2 != null)
            {
                timer3.Start();
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.card3;
            if (value1 == null)
            {
                value1 = pictureBox6;
            }
            else if (value1 != null && value2 == null)
            {
                value2 = pictureBox6;
            }

            if (value1 != null && value2 != null)
            {
                timer3.Start();
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.card4;
            if (value1 == null)
            {
                value1 = pictureBox7;
            }
            else if (value1 != null && value2 == null)
            {
                value2 = pictureBox7;
            }

            if (value1 != null && value2 != null)
            {
                timer3.Start();
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.card4;
            if (value1 == null)
            {
                value1 = pictureBox8;
            }
            else if (value1 != null && value2 == null)
            {
                value2 = pictureBox8;
            }

            if (value1 != null && value2 != null)
            {
                timer3.Start();
            }

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.card5;
            if (value1 == null)
            {
                value1 = pictureBox9;
            }
            else if (value1 != null && value2 == null)
            {
                value2 = pictureBox9;
            }

            if (value1 != null && value2 != null)
            {
                timer3.Start();
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.card5;
            if (value1 == null)
            {
                value1 = pictureBox10;
            }
            else if (value1 != null && value2 == null)
            {
                value2 = pictureBox10;
            }

            if (value1 != null && value2 != null)
            {
                timer3.Start();
            }

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.card6;
            if (value1 == null)
            {
                value1 = pictureBox11;
            }
            else if (value1 != null && value2 == null)
            {
                value2 = pictureBox11;
            }

            if (value1 != null && value2 != null)
            {
                timer3.Start();
            }

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = Properties.Resources.card6;
            if (value1 == null)
            {
                value1 = pictureBox12;
            }
            else if (value1 != null && value2 == null)
            {
                value2 = pictureBox12;
            }

            if (value1 != null && value2 != null)
            {
                timer3.Start();
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            foreach (PictureBox pic in panel1.Controls)
            {
                pic.Enabled = false;
            }

            if (value1.Tag == value2.Tag)
            {
                axWindowsMediaPlayer1.URL = "chime_down.wav"; 

                value1.Visible = false;
                value2.Visible = false;
                value1 = null;
                value2 = null;
                scour = scour + 10;
                foreach (PictureBox pic in panel1.Controls)
                {
                    pic.Enabled = true;
                }

            }
            else
            {
                value1.Image = Properties.Resources.cover;
                value2.Image = Properties.Resources.cover;
                value1 = null;
                value2 = null;
                foreach (PictureBox pic in panel1.Controls)
                {
                    pic.Enabled = true;
                }
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            button2.Visible = true;  


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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7_Load(sender, e);  //call the form lode 
            button2.Visible = false; 

        }//end method convert arabic
  

      


    }
}
