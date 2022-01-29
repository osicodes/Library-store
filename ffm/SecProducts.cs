using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//allways add this to work.
using System.Xml;
using System.Xml.Linq;//use this to allow lingq to read xml files.
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ffm
{
    public partial class SecProducts : Form
    {
        //................TEST Json.............
        private static string file = @"C:\Users\Osinachi\Documents\Visual Studio 2015\Projects\Library Store(Visual Studio)\ffm\Student.json";

        private static string jsonStng = File.ReadAllText(file);
        Root myRoot = JsonConvert.DeserializeObject<Root>(jsonStng);

        //..........START.......
        string allbooks = @"C:\Users\Osinachi\Documents\Visual Studio 2015\Projects\Library Store(Visual Studio)\ffm\AllBooks.xml";
        //string allbooks = Application.StartupPath.ToString() + @"\All Cars.xml";
        
        public static string transPrice = "", transID = "";

        public static string transQuantity = "";

        public static string transStck = "";
        string id1, id2, id3, id4, id5, id6, id7, id8, id9, id10;
        string pp1, pp2, pp3, pp4, pp5, pp6, pp7, pp8, pp9, pp10, ss1, ss2, ss3, ss4, ss5, ss6, ss7, ss8, ss9, ss10;


        //-----First Item Quantity Buttons-----
        private int a = 1, s;
        private double pr;
        private void incBtn_Click(object sender, EventArgs e)
        {
            PDispy.Text = null;

            bool isParsable = Int32.TryParse(ss1, out s);
            bool isVarsable = Double.TryParse(pp1, out pr);

            if (a < s)
                a++;
            valDispy.Text = a.ToString();
            PDispy.Text = (pr * a).ToString();
        }

        private void decBtn_Click(object sender, EventArgs e)
        {
            if (a > 1)
            {
                a--;
            }
            valDispy.Text = a.ToString();
            PDispy.Text = (pr * a).ToString();
        }

        private void valDispy3_Click(object sender, EventArgs e)
        {

        }

        private void PDispy3_Click(object sender, EventArgs e)
        {

        }

        //--------------------END-------------------

        //-----Second Item Quantity Buttons-----
        private int b = 1, s2;
        private double pr2;

        private void incBtn2_Click_1(object sender, EventArgs e)
        {
            PDispy2.Text = null;

            bool isParsable = Int32.TryParse(ss2, out s2);  //s2 = Int32.Parse(ss2);
            bool isVarsable = Double.TryParse(pp2, out pr2);


            if (b < s2)
                b++;
            valDispy2.Text = b.ToString();
            PDispy2.Text = (pr2 * b).ToString();
        }
        private void decBtn2_Click_1(object sender, EventArgs e)
        {
            if (b > 1)
            {
                b--;
            }
            valDispy2.Text = b.ToString();
            PDispy2.Text = (pr2 * b).ToString();
        }
        //---------------------END-------------------------


        //-----Third Item Quantity Buttons-----
        private int c = 1, s3;
        private double pr3;

        private void incBtn3_Click_1(object sender, EventArgs e)
        {
            PDispy3.Text = null;

            bool isParsable = Int32.TryParse(ss3, out s3);
            bool isVarsable = Double.TryParse(pp3, out pr3);

            if (c < s3)
                c++;
            valDispy3.Text = c.ToString();
            PDispy3.Text = (pr3 * c).ToString();
        }

        private void decBtn3_Click(object sender, EventArgs e)
        {
            if (c > 1)
            {
                c--;
            }
            valDispy3.Text = c.ToString();
            PDispy3.Text = (pr3 * c).ToString();
        }
        //---------------------END-------------------------


        //-----Forth Item Quantity Buttons-----
        private int d = 1, s4;
        private double pr4;
        private void incBtn4_Click_1(object sender, EventArgs e)
        {
            PDispy3.Text = null;

            bool isParsable = Int32.TryParse(ss4, out s4);
            bool isVarsable = Double.TryParse(pp4, out pr4);

            if (d < s4)
                d++;
            valDispy4.Text = d.ToString();
            PDispy4.Text = (pr4 * d).ToString();
        }

        private void decBtn4_Click(object sender, EventArgs e)
        {
            if (d > 1)
            {
                d--;
            }
            valDispy4.Text = d.ToString();
            PDispy4.Text = (pr4 * d).ToString();
        }

        //---------------------END-------------------------

        //-----Fifth Item Quantity Buttons-----
        private int eb = 1, s5;
        private double pr5;
        private void incBtn5_Click_1(object sender, EventArgs e)
        {
            PDispy5.Text = null;

            bool isParsable = Int32.TryParse(ss5, out s5);
            bool isVarsable = Double.TryParse(pp5, out pr5);

            if (eb < s5)
                eb++;
            valDispy5.Text = eb.ToString();
            PDispy5.Text = (pr5 * eb).ToString();
        }

        private void decBtn5_Click(object sender, EventArgs e)
        {
            if (eb > 1)
            {
                eb--;
            }
            valDispy5.Text = eb.ToString();
            PDispy5.Text = (pr5 * eb).ToString();
        }

        //---------------------END-------------------------

        //-----Sixth Item Quantity Buttons-----
        private int f = 1, s6;

        private void PDispy8_Click(object sender, EventArgs e)
        {

        }

        private void roundRectPanel9_ClientSizeChanged(object sender, EventArgs e)
        {
            bk5.MaximumSize = new Size((sender as Control).ClientSize.Width - bk5.Left, 10000);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private double pr6;
        private void incBtn6_Click_1(object sender, EventArgs e)
        {
            PDispy6.Text = null;

            bool isParsable = Int32.TryParse(ss6, out s6);
            bool isVarsable = Double.TryParse(pp6, out pr6);

            if (f < s6)
                f++;
            valDispy6.Text = f.ToString();
            PDispy6.Text = (pr6 * f).ToString();
        }

        private void decBtn6_Click(object sender, EventArgs e)
        {
            if (f > 1)
            {
                f--;
            }
            valDispy6.Text = f.ToString();
            PDispy6.Text = (pr6 * f).ToString();
        }
        //---------------------END-------------------------


        //-----Seventh Item Quantity Buttons-----
        private int g = 1, s7;
        private double pr7;
        private void incBtn7_Click(object sender, EventArgs e)
        {
            PDispy7.Text = null;

            bool isParsable = Int32.TryParse(ss7, out s7);
            bool isVarsable = Double.TryParse(pp7, out pr7);

            if (g < s7)
                g++;
            valDispy7.Text = g.ToString();
            PDispy7.Text = (pr7 * g).ToString();
        }
        
        private void decBtn7_Click(object sender, EventArgs e)
        {
            if (g > 1)
            {
                g--;
            }
            valDispy7.Text = g.ToString();
            PDispy7.Text = (pr7 * g).ToString();
        }
        //---------------------END-------------------------


        //-----Eighth Item Quantity Buttons-----
        private int h = 1, s8;
            private double pr8;
        private void incBtn8_Click(object sender, EventArgs e)
        {
            PDispy8.Text = null;

            bool isParsable = Int32.TryParse(ss8, out s8);
            bool isVarsable = Double.TryParse(pp8, out pr8);

            if (h < s8)
                h++;
            valDispy8.Text = h.ToString();
            PDispy8.Text = (pr8 * h).ToString();
        }
        private void decBtn8_Click(object sender, EventArgs e)
        {
            if (h > 1)
            {
                h--;
            }
            valDispy8.Text = h.ToString();
            PDispy8.Text = (pr8 * h).ToString();
        }

        //---------------------END-------------------------


        //-----Nineth Item Quantity Buttons-----
        private int i = 1, s9;
        private double pr9;
        private void incBtn9_Click(object sender, EventArgs e)
        {
            PDispy9.Text = null;

            bool isParsable = Int32.TryParse(ss9, out s9);
            bool isVarsable = Double.TryParse(pp9, out pr9);

            if (i < s9)
                i++;
            valDispy9.Text = i.ToString();
            PDispy9.Text = (pr9 * i).ToString();
        }
        private void decBtn9_Click(object sender, EventArgs e)
        {
            if (i > 1)
            {
                i--;
            }
            valDispy9.Text = i.ToString();
            PDispy9.Text = (pr9 * i).ToString();
        }
        //---------------------END-------------------------

        //-----Tenth Item Quantity Buttons-----
        private int j = 1, s10;
        private double pr10;
        private void incBtn10_Click(object sender, EventArgs e)
        {
            PDispy10.Text = null;

            bool isParsable = Int32.TryParse(ss10, out s10);
            bool isVarsable = Double.TryParse(pp10, out pr10);

            if (j < s10)
                j++;
            valDispy10.Text = j.ToString();
            PDispy10.Text = (pr10 * j).ToString();
        }

        private void decBtn10_Click(object sender, EventArgs e)
        {
            if (j > 1)
            {
                j--;
            }
            valDispy10.Text = j.ToString();
            PDispy10.Text = (pr10 * j).ToString();
        }
        //---------------------END-------------------------

        private void SecProducts_Activated(object sender, EventArgs e)
        {
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Products log = new Products();
            log.Show();
            this.Hide();
        }

        

           


        public SecProducts()
        {
            InitializeComponent();
        }

        private void SecProducts_Load(object sender, EventArgs e)
        {
            p1.Text = myRoot.student[0].FirstName;
            XmlTextReader doc = new XmlTextReader(allbooks);
            doc.Read();

            while (doc.ReadToFollowing("products"))
            {
                if (doc.ReadToFollowing("BookID") == true)
                {
                    id1 = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("BookName");
                    bk1.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct1.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    ss1 = st1.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    pp1 = PDispy.Text = p1.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des1.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox5.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel4.Visible = false;
                }

                if (doc.ReadToFollowing("BookID") == true)
                {
                    id2 = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("BookName");
                    bk2.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct2.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    ss2 = st2.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    pp2 = PDispy2.Text = p2.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des2.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox1.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel1.Visible = false;
                }

                if (doc.ReadToFollowing("BookID") == true)
                {
                    id3 = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("BookName");
                    bk3.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct3.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    ss3 = st3.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    pp3 = PDispy3.Text = p3.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des3.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox2.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel3.Visible = false;
                }

                if (doc.ReadToFollowing("BookID") == true)
                {
                    id4 = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("BookName");
                    bk4.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct4.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    ss4 = st4.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    pp4 = PDispy4.Text = p4.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des4.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox3.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel7.Visible = false;
                }

                if (doc.ReadToFollowing("BookID") == true)
                {
                    id5 = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("BookName");
                    bk5.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct5.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    ss5 = st5.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    pp5 = PDispy5.Text = p5.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des5.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox4.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel9.Visible = false;
                }

                if (doc.ReadToFollowing("BookID") == true)
                {
                    id6 = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("BookName");
                    bk6.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct6.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    ss6 = st6.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    pp6 = PDispy6.Text = p6.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des6.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox6.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel11.Visible = false;
                }

                if (doc.ReadToFollowing("BookID") == true)
                {
                    id7 = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("BookName");
                    bk7.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct7.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    ss7 = st7.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    pp7 = PDispy7.Text = p7.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des7.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox7.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel13.Visible = false;
                }

                if (doc.ReadToFollowing("BookID") == true)
                {
                    id8 = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("BookName");
                    bk8.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct8.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    ss8 = st8.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    pp8 = PDispy8.Text = p8.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des8.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox8.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel15.Visible = false;
                }

                if (doc.ReadToFollowing("BookID") == true)
                {
                    id9 = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("BookName");
                    bk9.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct9.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    ss9 = st9.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    pp9 = PDispy9.Text = p9.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des9.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox9.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel17.Visible = false;
                }

                if (doc.ReadToFollowing("BookID") == true)
                {
                    id10 = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("BookName");
                    bk10.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct10.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    ss10 = st10.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    pp10 = PDispy10.Text = p10.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des10.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox10.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel19.Visible = false;
                }
            }

            label15.Text = Form1.transferName;
            label6.Text = signup.transName;

            if (st1.Text == 0.ToString())
            {
                valDispy.ForeColor = Color.Red;
                valDispy.Text = "Out of Stock";
                incBtn.Visible = false;
                decBtn.Visible = false;
                button1.Visible = false;
            }
            else
            {
                valDispy.Text = 1.ToString();
            }

            if (st2.Text == 0.ToString())
            {
                valDispy2.ForeColor = Color.Red;
                valDispy2.Text = "Out of Stock";
                incBtn2.Visible = false;
                decBtn2.Visible = false;
                button9.Visible = false;
            }
            else
            {
                valDispy2.Text = 1.ToString();
            }

            if (st3.Text == 0.ToString())
            {
                valDispy3.ForeColor = Color.Red;
                valDispy3.Text = "Out of Stock";
                incBtn3.Visible = false;
                decBtn3.Visible = false;
                button9.Visible = false;
            }
            else
            {
                valDispy3.Text = 1.ToString();
            }

            if (st4.Text == 0.ToString())
            {
                valDispy4.ForeColor = Color.Red;
                valDispy4.Text = "Out of Stock";
                incBtn4.Visible = false;
                decBtn4.Visible = false;
                button4.Visible = false;
            }
            else
            {
                valDispy4.Text = 1.ToString();
            }

            if (st5.Text == 0.ToString())
            {
                valDispy5.ForeColor = Color.Red;
                valDispy5.Text = "Out of Stock";
                incBtn5.Visible = false;
                decBtn5.Visible = false;
                button8.Visible = false;
            }
            else
            {
                valDispy5.Text = 1.ToString();
            }

            if (st6.Text == 0.ToString())
            {
                valDispy6.ForeColor = Color.Red;
                valDispy6.Text = "Out of Stock";
                incBtn6.Visible = false;
                decBtn6.Visible = false;
                button12.Visible = false;
            }
            else
            {
                valDispy6.Text = 1.ToString();
            }

            if (st7.Text == 0.ToString())
            {
                valDispy7.ForeColor = Color.Red;
                valDispy7.Text = "Out of Stock";
                incBtn7.Visible = false;
                decBtn7.Visible = false;
                button15.Visible = false;
            }
            else
            {
                valDispy7.Text = 1.ToString();
            }

            if (st8.Text == 0.ToString())
            {
                valDispy8.ForeColor = Color.Red;
                valDispy8.Text = "Out of Stock";
                incBtn8.Visible = false;
                decBtn8.Visible = false;
                button18.Visible = false;
            }
            else
            {
                valDispy8.Text = 1.ToString();
            }

            if (st9.Text == 0.ToString())
            {
                valDispy9.ForeColor = Color.Red;
                valDispy9.Text = "Out of Stock";
                incBtn9.Visible = false;
                decBtn9.Visible = false;
                button21.Visible = false;
            }
            else
            {
                valDispy9.Text = 1.ToString();
            }

            if (st10.Text == 0.ToString())
            {
                valDispy10.ForeColor = Color.Red;
                valDispy10.Text = "Out of Stock";
                incBtn10.Visible = false;
                decBtn10.Visible = false;
                button24.Visible = false;
            }
            else
            {
                valDispy10.Text = 1.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            transQuantity = valDispy.Text;
            transPrice = PDispy.Text;
            transStck = st1.Text;
            transID = id1;
            Buy log = new Buy();
            this.Hide();
            log.Show(); //log.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            transQuantity = valDispy2.Text;
            transPrice = PDispy2.Text;
            transStck = st2.Text;
            transID = id2;
            Buy log = new Buy();
            this.Hide();
            log.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            transQuantity = valDispy3.Text;
            transPrice = PDispy3.Text;
            transStck = st3.Text;
            transID = id3;
            Buy log = new Buy();
            this.Hide();
            log.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            transQuantity = valDispy4.Text;
            transPrice = PDispy4.Text;
            transStck = st4.Text;
            transID = id4;
            Buy log = new Buy();
            this.Hide();
            log.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            transQuantity = valDispy5.Text;
            transPrice = PDispy5.Text;
            transStck = st5.Text;
            transID = id5;
            Buy log = new Buy();
            this.Hide();
            log.Show();
        }
        private void button12_Click_1(object sender, EventArgs e)
        {
            transQuantity = valDispy6.Text;
            transPrice = PDispy6.Text;
            transStck = st6.Text;
            transID = id6;
            Buy log = new Buy();
            this.Hide();
            log.Show();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            transQuantity = valDispy7.Text;
            transPrice = PDispy7.Text;
            transStck = st7.Text;
            transID = id7;
            Buy log = new Buy();
            this.Hide();
            log.Show();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            transQuantity = valDispy8.Text;
            transPrice = PDispy8.Text;
            transStck = st8.Text;
            transID = id8;
            Buy log = new Buy();
            this.Hide();
            log.Show();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            transQuantity = valDispy9.Text;
            transPrice = PDispy9.Text;
            transStck = st9.Text;
            transID = id9;
            Buy log = new Buy();
            this.Hide();
            log.Show();
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            transQuantity = valDispy10.Text;
            transPrice = PDispy10.Text;
            transStck = st10.Text;
            transID = id10;
            Buy log = new Buy();
            this.Hide();
            log.Show();
        }
        private void PDispy2_Click(object sender, EventArgs e)
        {

        }

        private void valDispy2_Click(object sender, EventArgs e)
        {

        }


    }
}
