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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + @"\image\FIRSTC.png");
            // Show an image in picture box
            pictureBox1.Image = img;

            Image img2 = Image.FromFile(Application.StartupPath + @"\image\CLOUDnew.png");
            // Show an image in picture box
            pictureBox2.Image = img2;

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

             
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //to resize pic
          
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
           
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;  //to resize pic 
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 other = new Form3();
            other.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 other = new Form4();
            other.Show();
        }
    }
}
