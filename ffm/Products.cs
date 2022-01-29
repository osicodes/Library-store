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
using MaterialSkin;
using MaterialSkin.Controls;

namespace ffm
{
    public partial class Products : Form
    {
        string allbooks = @"C:\Users\Osinachi\Documents\Visual Studio 2015\Projects\Library Store(Visual Studio)\ffm\AllBooks.xml";
        //string allbooks = Application.StartupPath.ToString() + @"\All Cars.xml";
        

        public Products()
        {

            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            this.Hide();
            log.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            signup log = new signup();
            this.Hide();
            log.Show();
        }

        //StringBuilder sb = new StringBuilder();
        private void Products_Load(object sender, EventArgs e)
        {
            XmlTextReader doc = new XmlTextReader(allbooks);
            doc.Read();

            while (doc.ReadToFollowing("products"))
            {
                if (doc.ReadToFollowing("BookName") == true)
                {
                    bk1.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct1.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    st1.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    p1.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des1.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox6.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel7.Visible = false;
                }

                if (doc.ReadToFollowing("BookName") == true)
                {
                    bk2.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct2.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    st2.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    p2.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des2.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox3.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel2.Visible = false;
                }

                if (doc.ReadToFollowing("BookName") == true)
                {
                    bk3.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct3.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    st3.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    p3.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des3.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox4.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel4.Visible = false;
                }

                if (doc.ReadToFollowing("BookName") == true)
                {
                    bk4.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct4.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    st4.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    p4.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des4.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox1.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel6.Visible = false;
                }

                if (doc.ReadToFollowing("BookName") == true)
                {
                    bk5.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct5.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    st5.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    p5.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des5.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox2.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel10.Visible = false;
                }


                if (doc.ReadToFollowing("BookName") == true)
                {
                    bk6.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct6.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    st6.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    p6.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des6.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox5.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel12.Visible = false;
                }

                if (doc.ReadToFollowing("BookName") == true)
                {
                    bk7.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct7.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    st7.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    p7.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des7.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox7.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel1.Visible = false;
                }

                if (doc.ReadToFollowing("BookName") == true)
                {
                    bk8.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct8.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    st8.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    p8.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des8.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox8.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel15.Visible = false;
                }

                if (doc.ReadToFollowing("BookName") == true)
                {
                    bk9.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct9.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    st9.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    p9.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des9.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox9.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel17.Visible = false;
                }

                if (doc.ReadToFollowing("BookName") == true)
                {
                    bk10.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Category");
                    ct10.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Stock");
                    st10.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Price");
                    p10.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Description");
                    des10.Text = doc.ReadElementContentAsString();
                    doc.ReadToFollowing("Image");
                    pictureBox11.ImageLocation = doc.ReadElementContentAsString();
                }
                else
                {
                    roundRectPanel19.Visible = false;
                }


            }

            if (st1.Text == 0.ToString())
            {
                oos1.Text = "Out of Stock";
            }
            else
            {
                oos1.Visible = false;
            }

            if (st2.Text == 0.ToString())
            {
                oos2.Text = "Out of Stock";
            }
            else
            {
                oos2.Visible = false;
            }

            if (st3.Text == 0.ToString())
            {
                oos3.Text = "Out of Stock";
            }
            else
            {
                oos3.Visible = false;
            }

            if (st4.Text == 0.ToString())
            {
                oos4.Text = "Out of Stock";
            }
            else
            {
                oos4.Visible = false;
            }

            if (st5.Text == 0.ToString())
            {
                oos5.Text = "Out of Stock";
            }
            else
            {
                oos5.Visible = false;
            }

            if (st6.Text == 0.ToString())
            {
                oos6.Text = "Out of Stock";
            }
            else
            {
                oos6.Visible = false;
            }

            if (st7.Text == 0.ToString())
            {
                oos7.Text = "Out of Stock";
            }
            else
            {
                oos7.Visible = false;
            }

            if (st8.Text == 0.ToString())
            {
                oos8.Text = "Out of Stock";
            }
            else
            {
                oos8.Visible = false;
            }

            if (st9.Text == 0.ToString())
            {
                oos9.Text = "Out of Stock";
            }
            else
            {
                oos9.Visible = false;
            }

            if (st10.Text == 0.ToString())
            {
                oos10.Text = "Out of Stock";
            }
            else
            {
                oos10.Visible = false;
            }

            /*Panel pnl = new Panel();
            pnl.Location = System.Drawing.Point(72, 250);
            pnl.BackColor = panel1.BackColor;
            pnl.Size = System.Drawing.Size(232, 20);
            pnl.Visible = true;*/
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
                
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void roundRectPanel10_ClientSizeChanged(object sender, EventArgs e)
        {
            bk5.MaximumSize = new Size((sender as Control).ClientSize.Width - bk5.Left, 10000);
        }
    }
}
