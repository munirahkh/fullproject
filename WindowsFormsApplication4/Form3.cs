using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; 

namespace WindowsFormsApplication4
{
    public partial class Form3 : Form
    {

        public string[] info = { "تجمعت من سحابة وغبار حراري كثيف كان في كوننا منذ حوالي 4.6 مليار سنة  . بدأت هذه السحابة تتكثف أكثر فأكثر في أماكن مختلفة في الكون لتكون كرات هائلة من النجوم وكان منها شمسنا. وتنتج الشمس حرارة تقدر ببلايين الدرجات ",
                                          "  أقرب الكواكب للشمس  , هو أصغر كواكب مجموعتنا الشمسية  , يصبح بالليل بارداَ جداً لدرجة التجمد لأنه يدور حول نفسه ببطء شديد , اجوائه تحتوي على العديد من الغازات",
                                           " ثاني أقرب الكواكب للشمس  , شبيه بكوكب الأرض من حيث الحجم والتركيب. يتميز بارتفاع درجة حرارته  وبالرياح الشديدة . لا يسمح للحياة فوقه , وقد  اكتشف الغلاف الجوي لهذا الكوكب في القرن الثامن عاشر"
                                           , " ثالث أقرب الكواكب للشمس , يدورُ حولَ نفسه مرةً كل 24 ساعة , يعتبر كوكب الأرض هو الكوكب الوحيد الذي توجد عليه حياة , ويقدر عمر الارض بنحو 4.5 مليار عام.  وله تابع طبيعي وحيد وهو القمر"
                                           , " الكوكب الرابع في البعد عن الشمس في النظام الشمسي وهو الجار الخارجي للأرض . وقد سمي هذا الكوكب بهذا الاسم نسبةً إلى لونه المائل إلى الحمره. ثاني أصغر كواكب النظام الشمسي بعد عطارد.  يعتقد العلماء أن كوكب المريخ احتوى على الماء قبل 3.8 مليار سنة ، مما يجعل فرضية وجود حياة عليه متداولة نظرياً على الأقل. "
                                           , " الخامس بعداً عن الشمس  , يعتبر من أكبر وأضخم كواكب مجموعتنا الشمسية , يبلغ حجمه 1300 مرة من حجم الأرض , اليوم على المشتري يقارب عشر ساعات أرضية ،على سطحه تظهر بقعة حمراء كبيرة وهي عبارة عن عاصفة عنيفة تهب منذ 300 سنة . "
                                           , " الكوكب السادس بعداً عن الشمس , ثاني أكبر كوكب في المجموعة الشمسية , أغلب العناصر المكونة لهذا الكوكب عبارة عن سائل  , اليوم على سطح زحل يساوي 11 ساعة على سطح الأرض , عدد أقماره  30 قمراً , يوجد حوله حلقات مكونه من  ثلوج وتراب وأقمار صغيرة . "
                                           , "الكوكب السابع بعداً عن الشمس , كوكب عملاق يتكون من الغاز , الكوكب الوحيد الذي يميل على جانبه وليس معتدلاً "
                                           , " الكوكب الثامن في النظام الشمسي ,  يطلق عليه الكوكب الأزرق   , يجتاح نبتون عاصفة  أشبه بالعاصفة التي تجتاح كوكب المشتري ويطلق عليها البقعة المظلمة العظمى" ,
                                           " أبعد الكواكب عن المجموعة الشمسية , هو الكوكب الوحيد الذي لم تزره مركبة فضائية لبعده , لا توجد له صور واضحة المعالم كبقية الكواكب"  };


        public static int counter = 0; //counter for lessones 
         

        public Image [] imeges = new Image [10] ;
        public string [] names = { "الشمس", "عطارد", "الزهرة", "الأرض", "المِرِّيخ", "المشتري", "زُحل ", "أورانوس", "نبتون", "بلوتو" };
        public string[] sound = { "Voice_001_001.wav", "Voice_002_001.wav", "Voice_003_001 (1).wav", "Voice_004_001 (1).wav", "Voice_005_001 (1).wav", "Voice_006_001 (1).wav", "Voice_007_001 (1).wav" ,
                                "Voice_008_001 (1).wav","Voice_009_001 (1).wav","Voice_010_001 (1).wav"};
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Show an image in exit button
            Image img1 = Image.FromFile(Application.StartupPath + @"\image\exitb.png");
            button1.Image = img1;

            Image img2 = Image.FromFile(Application.StartupPath + @"\image\boutonplanet.png");
            button2.Image = img2;

            
            // Image img3 = Image.FromFile(Application.StartupPath + @"\image\boutonfront.png");
            // button4.Image = img3;

             // Show an image in home button
             Image img4 = Image.FromFile(Application.StartupPath + @"\image\home-icon.png");
             button6.Image = img4;

            //planet pic 
             imeges[0]  = Image.FromFile(Application.StartupPath + @"\image\pc1.JPG");
             imeges[1] = Image.FromFile(Application.StartupPath + @"\image\pc2.JPG");
             imeges[2] = Image.FromFile(Application.StartupPath + @"\image\pc3.JPG");
             imeges[3] = Image.FromFile(Application.StartupPath + @"\image\pc4.JPG");
             imeges[4] = Image.FromFile(Application.StartupPath + @"\image\pc5.JPG");
             imeges[5] = Image.FromFile(Application.StartupPath + @"\image\pc6.JPG");
             imeges[6] = Image.FromFile(Application.StartupPath + @"\image\pc7.JPG");
             imeges[7] = Image.FromFile(Application.StartupPath + @"\image\pc8.JPG");
             imeges[8] = Image.FromFile(Application.StartupPath + @"\image\pc9.JPG");
             imeges[9] = Image.FromFile(Application.StartupPath + @"\image\pc10.JPG");


             counter = 0;  //reset counter to zero when the form is load 

           //display Hello message 
             string getForm1Value = "";
             getForm1Value = Form1.name;
             label2.Text = label2.Text + getForm1Value;

          //display first planet and information ot it   
             pictureBox1.Image = imeges[0] ;
            richTextBox1.AppendText( info[0]) ;
            label3.Text = names[0];
            axWindowsMediaPlayer1.URL = sound[0];


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 other = new Form2();
            other.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 other = new Form4();
            other.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try {  
            counter++;
            
            richTextBox1.Clear(); 

            
            if (counter < 10)      //display info , sound , pic and planet name  
            {
                pictureBox1.Image = imeges[counter]; 
                richTextBox1.AppendText(info[counter]);
                label3.Text = names[counter];
                axWindowsMediaPlayer1.URL = sound[counter];

            }
            if (counter == 10  )
            {
                this.Close();
                Form4 other = new Form4();
                other.Show();
                counter = 0; 
            } }//end try 
            catch (NullReferenceException)
            {
                this.Close(); 
            }


        }
    }
}
