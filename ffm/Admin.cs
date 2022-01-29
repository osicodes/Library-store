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
using System.Xml;//use this to be able to make xml files.
using System.Xml.Linq;//use this to allow lingq to read xml files.

namespace ffm
{
    public partial class Admin : Form
    {
        string allbooks = @"C:\Users\Osinachi\Documents\Visual Studio 2015\Projects\Library Store(Visual Studio)\ffm\AllBooks.xml";
        //string allbooks = Application.StartupPath.ToString() + @"\All Cars.xml";
        string allcategories = @"C:\Users\Osinachi\Documents\Visual Studio 2015\Projects\Library Store(Visual Studio)\ffm\Categories.xml";

        string imagelocation = "";
        public Admin()
        {
            InitializeComponent();
           
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)   //ADD Button
        {
            Random random = new Random();
            int rand = random.Next(5000, 60000);
            using (Add_Item testDialog = new Add_Item())
            {
                if (testDialog.ShowDialog() == DialogResult.OK)
                {

                    XDocument doc = XDocument.Load(allbooks);
                    DataSet obj = new DataSet();
                    obj.ReadXml(allbooks);
                    DataRow objrow = obj.Tables["books"].NewRow();

                    objrow["BookID"] = testDialog.id;
                    objrow["BookName"] = testDialog.name;
                    objrow["Category"] = testDialog.catgry;
                    objrow["Stock"] = testDialog.stock;
                    objrow["Price"] = testDialog.price;
                    objrow["Description"] = testDialog.description;
                    objrow["Image"] = testDialog.image;


                    obj.Tables["books"].Rows.Add(objrow);
                    obj.AcceptChanges();
                    obj.WriteXml(allbooks);
                    obj.ReadXml(allbooks);

                    listView1.Items.Clear();
                    DataSet ob = new DataSet();
                    ob.ReadXml(allbooks);


                    ListViewItem item;

                    foreach (DataRow ndr in ob.Tables["books"].Rows)//putting into the rows
                    {
                        //This will take an item from the doc that has been created and in the tags
                        //and put them into the table that has been made.
                        item = new ListViewItem(new string[] { ndr["BookID"].ToString(),
                                        ndr["BookName"].ToString(), ndr["Category"].ToString(), ndr["Stock"].ToString(), ndr["Price"].ToString(),
                                        ndr["Description"].ToString(), ndr["Image"].ToString()});
                        //takes it
                        listView1.Items.Add(item);//then add to the listview box
                    }
                }
                testDialog.Dispose();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pictureBox.Text = "Change Image";
            BookIDbox.Text = listView1.FocusedItem.SubItems[0].Text;
            BookNAMEbox.Text = listView1.FocusedItem.SubItems[1].Text;
            comboBox1.Text = listView1.FocusedItem.SubItems[2].Text;
            STOCKbox.Text = listView1.FocusedItem.SubItems[3].Text;
            PRICEbox.Text = listView1.FocusedItem.SubItems[4].Text;
            DESbox.Text = listView1.FocusedItem.SubItems[5].Text;
            pictureBox.ImageLocation = listView1.FocusedItem.SubItems[6].Text;
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)    //Upload Image
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open Image file";
            dialog.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg"; ;
            //dialog.Filter = "jpg files(*.jpg)|*.jpg|  PNG files(*.png)|*.png| All Files(*.*)|*.*|";
            if (dialog.ShowDialog() == DialogResult.OK)   //System.Windows.Forms.DialogResult.OK
            {
                imagelocation = dialog.FileName;
                pictureBox.ImageLocation = imagelocation;
            }
        }

        private void loadCategory()
        {
            DataSet cat = new DataSet();
            cat.ReadXml(allcategories);
            DataTable dt = cat.Tables["group"];
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "categories";
            comboBox1.Text = "Select Category";
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();
            loadCategory();

            //-------------------------------------------------------------------
            listView1.Items.Clear();
            DataSet ob = new DataSet();
            ob.ReadXml(allbooks);


            ListViewItem item;

            foreach (DataRow ndr in ob.Tables["books"].Rows)//putting into the rows
            {
                //This will take an item from the doc that has been created and in the tags
                //and put them into the table that has been made.
                item = new ListViewItem(new string[] { ndr["BookID"].ToString(), ndr["BookName"].ToString(), ndr["Category"].ToString(),
                                                        ndr["Stock"].ToString(), ndr["Price"].ToString(), ndr["Description"].ToString(), ndr["Image"].ToString()});
                //takes it
                listView1.Items.Add(item);//then add to the listview box
            }
            BookIDbox.Clear();
            BookNAMEbox.Clear();
            BookNAMEbox.Focus();
            STOCKbox.Clear();
            PRICEbox.Clear();
            DESbox.Clear();
            pictureBox.Image = null;
            /* IDbox.Clear();
            NAMEbox.Clear();
            NAMEbox.Focus();
            MILESbox.Clear();
            PRICEbox.Clear();
            DESbox.Clear();
            pictureBox.Image = null;*/
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox.Text = "Change Image";
            BookIDbox.Text = listView1.FocusedItem.SubItems[0].Text;
            BookNAMEbox.Text = listView1.FocusedItem.SubItems[1].Text;
            PRICEbox.Text = listView1.FocusedItem.SubItems[2].Text;
            DESbox.Text = listView1.FocusedItem.SubItems[3].Text;
            pictureBox.ImageLocation = listView1.FocusedItem.SubItems[4].Text;
            STOCKbox.Text = listView1.FocusedItem.SubItems[5].Text;
        }

        private void button2_Click(object sender, EventArgs e)  //DELETE
        {
            if (BookIDbox.Text != "")
            {
                XDocument doc = XDocument.Load(allbooks);
                string deleteID = BookIDbox.Text;

                listView1.FocusedItem.SubItems[0].Text = "";
                listView1.FocusedItem.SubItems[1].Text = "";
                listView1.FocusedItem.SubItems[2].Text = "";
                listView1.FocusedItem.SubItems[3].Text = "";
                listView1.FocusedItem.SubItems[4].Text = "";
                listView1.FocusedItem.SubItems[5].Text = "";
                listView1.FocusedItem.SubItems[6].Text = "";


                doc.Descendants("books")
                    .Where(x => (string)x.Element("BookID") == deleteID)
                    .Remove();
                doc.Save(allbooks);

                listView1.Items.Clear();
                DataSet ob = new DataSet();
                ob.ReadXml(allbooks);


                ListViewItem item;

                foreach (DataRow ndr in ob.Tables["books"].Rows)//putting into the rows
                {
                    //This will take an item from the doc that has been created and in the tags
                    //and put them into the table that has been made.
                    item = new ListViewItem(new string[] { ndr["BookID"].ToString(),
                                        ndr["BookName"].ToString(), ndr["Category"].ToString(), ndr["Stock"].ToString(), ndr["Price"].ToString(),
                                        ndr["Description"].ToString(), ndr["Image"].ToString()});
                    //takes it
                    listView1.Items.Add(item);//then add to the listview box
                }
                BookIDbox.Clear();
                BookNAMEbox.Clear();
                BookNAMEbox.Focus();
                STOCKbox.Clear();
                PRICEbox.Clear();
                DESbox.Clear();
                pictureBox.Image = null;

            }
            else
            {
                MessageBox.Show("Please select an item from the list to delete.", "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)  //EDIT INVENTORY
        {
            
            if (BookIDbox.Text != "" && BookNAMEbox.Text != "" && STOCKbox.Text != "" && PRICEbox.Text != "" && DESbox.Text != ""
                && pictureBox.Image != null)
            {
                string updateID = BookIDbox.Text;
                XDocument doc = XDocument.Load(allbooks);

                var items = from itemss in doc.Descendants("books")
                            where itemss.Element("BookID").Value == updateID
                            select itemss;
                foreach (XElement itemElement in items)
                {
                    itemElement.SetElementValue("BookID", BookIDbox.Text);
                    itemElement.SetElementValue("BookName", BookNAMEbox.Text);
                    itemElement.SetElementValue("Category", comboBox1.Text);
                    itemElement.SetElementValue("Stock", STOCKbox.Text);
                    itemElement.SetElementValue("Price", PRICEbox.Text);
                    itemElement.SetElementValue("Description", DESbox.Text);
                    itemElement.SetElementValue("Image", pictureBox.ImageLocation);
                }
                doc.Save(allbooks);


                listView1.Items.Clear();
                DataSet ob = new DataSet();
                ob.ReadXml(allbooks);


                ListViewItem item;

                foreach (DataRow ndr in ob.Tables["books"].Rows)//putting into the rows
                {
                    //This will take an item from the doc that has been created and in the tags
                    //and put them into the table that has been made.
                    item = new ListViewItem(new string[] { ndr["BookID"].ToString(),
                                        ndr["BookName"].ToString(), ndr["Category"].ToString(), ndr["Stock"].ToString(), ndr["Price"].ToString(),
                                        ndr["Description"].ToString(), ndr["Image"].ToString()});
                    //takes it
                    listView1.Items.Add(item);//then add to the listview box
                }
                BookIDbox.Clear();
                BookNAMEbox.Clear();
                BookNAMEbox.Focus();
                STOCKbox.Clear();
                PRICEbox.Clear();
                DESbox.Clear();
                pictureBox.Image = null;
            }
            else
            {
                MessageBox.Show("Please select the book image " +
                    "and then change the information for it", "Update Error");
            }
        }

        private void MILESbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        


        private void button2_Click_1(object sender, EventArgs e)   //UPDATE CATEGORY
        {
           //comboBox1.Items.Cast<Object>().ToArray(); //convert items to array
            //testDialog.comboBox1.Items.AddRange(comboBox1.Items.Cast<Object>().ToArray());
            using (Category testDialog = new Category())
            {
                if (testDialog.ShowDialog() == DialogResult.OK)
                {
                    //comboBox1.Items.Add(testDialog.selText);
                    XDocument dcc = XDocument.Load(allcategories);
                   DataSet obj = new DataSet();
                    obj.ReadXml(allcategories);
                    DataRow obb = obj.Tables["group"].NewRow();
                    obb["categories"] = testDialog.selText;


                    obj.Tables["group"].Rows.Add(obb);
                    obj.AcceptChanges();
                    obj.WriteXml(allcategories);
                    obj.ReadXml(allcategories);

                    loadCategory();
                }
                testDialog.Dispose();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e) //DELETE CATEGORY
        {
            if (comboBox1.Text != "Select Category")
            {
                XDocument doc = XDocument.Load(allcategories);
                string deleteID = comboBox1.Text;

                doc.Descendants("group")
                    .Where(x => (string)x.Element("categories") == deleteID)
                    .Remove();
                doc.Save(allcategories);
                loadCategory();
            }
            else
            {
                MessageBox.Show("Please select the category to delete from the category list on the left.", "Error");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Products options = new Products();
            this.Hide();
            options.Show();
        }
        
    }
}
