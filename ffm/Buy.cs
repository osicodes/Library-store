using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;//allways add this to work.
using System.Xml;
using System.Xml.Linq;//use this to allow lingq to read xml files.

namespace ffm
{
    public partial class Buy : Form
    {
        public static string allbooks = @"C:\Users\Osinachi\Documents\Visual Studio 2015\Projects\Library Store(Visual Studio)\ffm\AllBooks.xml";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );
        public Buy()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
            panel1.Height, 30, 30));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
            panel2.Height, 30, 30));
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SecProducts options = new SecProducts();
            this.Hide();
            options.Show();
            /*if (Application.OpenForms[options.Name] == null)
            {
                options.Show();
                this.Hide();
            }
            else
            {
                Application.OpenForms[options.Name].Focus();
                this.Hide();
            }*/
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            label4.Text = SecProducts.transPrice;
            label9.Text = SecProducts.transQuantity;
        }

        Point lastPoint;
        private void Buy_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Buy_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            if (button1.BackColor == Color.Red)
            {
                button2.BackColor = Color.Red;
                button1.BackColor = Color.Gray;
            }
            else
            {
                button2.BackColor = Color.Gray;
                button1.BackColor = Color.Red;
            }

            SecProducts options = new SecProducts();
            this.Hide();
            options.Show();
            /*if (Application.OpenForms[options.Name] == null)
            {
                options.Show();
                this.Hide();
            }
            else
            {
                Application.OpenForms[options.Name].Focus();
                this.Hide();
            }*/
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "" && maskedTextBox2.Text != "" && maskedTextBox3.Text != "" && textBox1.Text != "")
            {
                if (checkBox1.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false)
                {
                    MessageBox.Show("Select a payment option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (button2.BackColor == Color.Gray)
                    {
                        button1.BackColor = Color.Gray;
                        button2.BackColor = Color.Red;
                    }
                    else
                    {
                        button1.BackColor = Color.Red;
                        button2.BackColor = Color.Gray;
                    }


                    int st, qt;
                    //string stck = Purchase.transStck;
                    //string qty = Purchase.transQuantity;

                    
                    using (confirmOrder dialog = new confirmOrder())
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            st = Int32.Parse(SecProducts.transStck);
                            qt = Int32.Parse(SecProducts.transQuantity);
                            st = st - qt;

                            //string allbooks = @"C:\Users\Osinachi\Documents\Visual Studio 2015\Projects\Library Store(Visual Studio)\ffm\AllBooks.xml";
                            XDocument doc = XDocument.Load(allbooks);

                            var items = from itemss in doc.Descendants("books")
                                        where itemss.Element("BookID").Value == SecProducts.transID
                                        select itemss;
                            foreach (XElement itemElement in items)
                            {
                                itemElement.SetElementValue("Stock", st.ToString());
                            }
                            doc.Save(allbooks);

                            SecProducts options = new SecProducts();
                            this.Hide();
                            options.Show();
                            /*if (Application.OpenForms[options.Name] == null)
                            {
                                options.Show();
                                this.Hide();
                            }
                            else
                            {
                                Application.OpenForms[options.Name].Focus();
                                this.Hide();
                            }*/

                        }
                        dialog.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Complete your payment details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox1.SelectionStart = 0;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox2.SelectionStart = 0;
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //maskedTextBox3.SelectionStart = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_Click(object sender, MaskInputRejectedEventArgs e)
        {
            //maskedTextBox3.SelectionStart = 0;
            maskedTextBox3.Select(0, 0);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
