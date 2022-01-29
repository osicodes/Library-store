using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffm
{
    public partial class Add_Item : Form
    {
        public string id { get; set; }
        public string name { get; set; }
        public string stock { get; set; }
        public string price { get; set; }
        public string image { get; set; }
        public string description{ get; set; }
        public string catgry { get; set; }

        public Add_Item()
        {
            InitializeComponent();
        }

        string allcategories = @"C:\Users\Osinachi\Documents\Visual Studio 2015\Projects\Library Store(Visual Studio)\ffm\Categories.xml";
        string imagelocation = "";

        private void loadCategory()
        {
            DataSet cat = new DataSet();
            cat.ReadXml(allcategories);
            DataTable dt = cat.Tables["group"];
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "categories";
            comboBox1.Text = "Select Category";
        }


        private void roundRectPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Item_Load(object sender, EventArgs e)
        {
            loadCategory();
        }

        private void customTextbox1_Load(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (customTextbox1.Texts != "" && customTextbox2.Texts != "" && customTextbox3.Texts != "" && customTextbox4.Texts != ""
                 && customTextbox5.Texts != "" && comboBox1.Text != "" && pictureBox1.Image != null)
            {
                id = customTextbox1.Texts;
                name = customTextbox2.Texts;
                stock = customTextbox3.Texts;
                price = customTextbox4.Texts;
                image = pictureBox1.ImageLocation;
                description = customTextbox5.Texts;
                catgry = comboBox1.Text;
            }
            else
            {
                MessageBox.Show("Please fill in all the boxes.");
            }
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open Image file";
            dialog.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg"; ;
            //dialog.Filter = "jpg files(*.jpg)|*.jpg|  PNG files(*.png)|*.png| All Files(*.*)|*.*|";
            if (dialog.ShowDialog() == DialogResult.OK)   //System.Windows.Forms.DialogResult.OK
            {
                imagelocation = dialog.FileName;
                pictureBox1.ImageLocation = imagelocation;
            }
        }

        private void customTextbox5_Load(object sender, EventArgs e)
        {

        }
    }
}
