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
    public partial class Form4 : Form
    {
        public static int time = 0;
        public int ch = 0;
        public static int correctans = 1;

        public static int wrongans = 1;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + @"\image\group.png");
            // Show an image in group boxs
            groupBox1.BackgroundImage = img;
           // groupBox2.BackgroundImage = img;

            Image img2 = Image.FromFile(Application.StartupPath + @"\image\exitb.png");
            button1.Image = img2;

            Image img4 = Image.FromFile(Application.StartupPath + @"\image\boutonplanet.png");
            button3.Image = img4;

            Image img5 = Image.FromFile(Application.StartupPath + @"\image\home-icon.png");
            button4.Image = img5;

            string getForm1Value = "";
            getForm1Value = Form1.name;
            label1.Text = label1.Text + getForm1Value;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            if (radioButton1.Checked == true && radioButton3.Checked == true)
            {
                time = 120; // this is for easy
                Form6 frm = new Form6();
                this.Hide();
                frm.Show();
                
            }
            if (radioButton1.Checked == true && radioButton4.Checked == true)
            {
                time = 60; // this is for middile
                Form6 frm = new Form6();
                this.Hide();
                frm.Show();
               
            }
            if (radioButton1.Checked == true && radioButton5.Checked == true)
            {
                time = 30;          // this is for deficultt     
                Form6 frm = new Form6();
                this.Hide();
                frm.Show();
               
            }


            if (radioButton2.Checked == true && radioButton3.Checked==true)
            {
                time = 120;
                Form5 frm = new Form5();
                this.Hide();
                frm.Show();
                
               
            }
            if (radioButton2.Checked == true && radioButton4.Checked == true)
            {
                time = 60;
                Form5 frm = new Form5();
                this.Hide();
                frm.Show();
                
                
            }
            if (radioButton2.Checked == true && radioButton5.Checked == true)
            {
                time = 30; 
                Form5 frm = new Form5();
                this.Hide();
                frm.Show();
                 
                
            }

            */

           if (radioButton2.Checked == true)
            { // for defult
                //time = 120; 
                Form5 frm1 = new Form5();
                this.Close();
                frm1.Show();
               
               
            }
           if (radioButton1.Checked == true)
           { // for defult
               //time = 120; 
               Form6 frm = new Form6();
               this.Close();
               frm.Show();
               
           }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); // go for home
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
                this.Show(); // for exit // button for exit

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 other = new Form2(); // for back button
            other.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Class1.ch = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Class1.ch = 2;
        }
    }
}
