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
    public partial class Form1 : Form
    {
      
        public static string name = "";    //put adefult valu of user name 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + @"\image\planet.jpg");
            // Show an image in picture box
            pictureBox3.Image = img;

            Image img3 = Image.FromFile(Application.StartupPath + @"\image\cartoon-cube.jpg");
            // Show an image in picture box
            pictureBox1.Image = img3;

            // Show an image in exit button 
            Image img5 = Image.FromFile(Application.StartupPath + @"\image\exitb.png");
            button1.Image = img5;

          

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage; //to resize pic 
            
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;   

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;  //to resize pic  
           
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
            Form2 other = new Form2();
            other.Show();
            this.Hide();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 other = new Form7();
            other.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          name= textBox1.Text  ;   //save user name 
        
        }
      
    }
     
}
