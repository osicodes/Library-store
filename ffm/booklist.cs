using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ffm
{
    public partial class booklist : UserControl
    {
        string allbooks = @"C:\Users\Osinachi\Documents\Visual Studio 2015\Projects\Library Store(Visual Studio)\ffm\AllBooks.xml";
        public booklist()
        {
            InitializeComponent();
        }

        private void booklist_Load(object sender, EventArgs e)
        {
            XmlTextReader doc = new XmlTextReader(allbooks);
            doc.Read();

            while (doc.ReadToFollowing("products"))
            {
                doc.ReadToFollowing("BookName");
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
                pictureBox5.ImageLocation = doc.ReadElementContentAsString();
                

            }

            if (st1.Text == 0.ToString())
            {
                label1.Text = "Out of Stock";
            }
            else
            {
                label1.Visible = false;
            }
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
