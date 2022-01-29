using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//allways add this to work.
using System.Xml;
using System.Xml.Linq;//use this to allow lingq to read xml files.
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace ffm
{
    

    public partial class Purchase : Form
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

        
        public Purchase()
        {
            InitializeComponent();
        }

       


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        string pp1, pp2, pp3, pp4, pp5, pp6, ss1, ss2, ss3, ss4, ss5, ss6;
        string id1, id2, id3;
        

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        
      

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

       

       
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void des1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click_1(object sender, EventArgs e)
        {

        }

        

        private void bk2_Click(object sender, EventArgs e)
        {

        }

        
       
        private void PDispy3_Click(object sender, EventArgs e)
        {

        }

        private void valDispy3_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            transQuantity = valDispy.Text;
            transPrice = PDispy.Text;
            transStck = st1.Text;
            transID = id1;
            Buy log = new Buy();
            log.ShowDialog();
            this.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            Products log = new Products();
            log.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Purchase_Activated(object sender, EventArgs e)
        {
            p1.Text = myRoot.student[0].FirstName;
            XmlTextReader doc = new XmlTextReader(allbooks);
            doc.Read();

            while (doc.ReadToFollowing("products"))
            {
                doc.ReadToFollowing("BookID");
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

                doc.ReadToFollowing("BookID");
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

                doc.ReadToFollowing("BookID");
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
                button7.Visible = false;
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
            
        }

        private void valDispy2_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            transQuantity = valDispy2.Text;
            transPrice = PDispy2.Text;
            transStck = st2.Text;
            transID = id2;
            Buy log = new Buy();
            log.ShowDialog();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            transQuantity = valDispy3.Text;
            transPrice = PDispy3.Text;
            transStck = st3.Text;
            transID = id3;
            Buy log = new Buy();
            log.ShowDialog();
            this.Show();
        }

        private void st3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }


        //-----First Item Quantity Buttons-----
        private int a = 1, s, pr;   

        private void incBtn_Click(object sender, EventArgs e)
        {
            PDispy.Text = null;

            bool isParsable = Int32.TryParse(ss1, out s);
            bool isVarsable = Int32.TryParse(pp1, out pr);
            
            if (a < s)
                a++;
            valDispy.Text = a.ToString();
            PDispy.Text = (pr * a).ToString();
        }

        private void PDispy_Click(object sender, EventArgs e)
        {

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
        //--------------------END-------------------

        //-----Second Item Quantity Buttons-----
        private int b = 1, s2, pr2;
        
        private void incBtn2_Click(object sender, EventArgs e)
        {
            PDispy2.Text = null;

            bool isParsable = Int32.TryParse(ss2, out s2);  //s2 = Int32.Parse(ss2);
            bool isVarsable = Int32.TryParse(pp2, out pr2);


            if (b < s2)
                b++;
            valDispy2.Text = b.ToString();
            PDispy2.Text = (pr2 * b).ToString();
        }

        private void decBtn2_Click(object sender, EventArgs e)
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
        private int c = 1, s3, pr3;
        private void invBtn3_Click(object sender, EventArgs e)
        {
            PDispy3.Text = null;

            bool isParsable = Int32.TryParse(ss3, out s3);
            bool isVarsable = Int32.TryParse(pp3, out pr3);

            if (c < s3)
                c++;
            valDispy3.Text = c.ToString();
            PDispy3.Text = (pr3 * c).ToString();
        }


        private void decBtn3_Click_1(object sender, EventArgs e)
        {
            if (c > 1)
            {
                c--;
            }
            valDispy3.Text = c.ToString();
            PDispy3.Text = (pr3 * c).ToString();
        }

        //---------------------END-------------------------
    }
}
