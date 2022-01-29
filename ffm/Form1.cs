using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace ffm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string username = "";
        public string password = "";
        public string name = "";
        public string surname = "";
        public string firstname = "";
        public string m_email = "";


        //...................................
        
        //....................................

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public static string transferName = "";
        //bool check;
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "ADMIN")
            {
                if (TextBoxName.Text != "" && TextBoxPassword.Text != "")
                {
                    string user = TextBoxName.Text;
                    string pwd = TextBoxPassword.Text;
                    //XDocument doc = XDocument.Load(Application.StartupPath.ToString() + @"\Admin Logins.xml");
                    XDocument doc = XDocument.Load(@"C:\Users\Osinachi\Documents\Visual Studio 2015\Projects\Library Store(Visual Studio)\ffm\Admin.xml");
                    var adminUser = from x in doc.Descendants("logins")
                                .Where(x => (string)x.Element("username") == TextBoxName.Text)
                                select new
                                {
                                    XMLuser = x.Element("username").Value,
                                    XMLpws = x.Element("password").Value,
                                    XMLname = x.Element("name").Value,
                                    XMLsurname = x.Element("surname").Value
                                };
                   foreach (var x in adminUser)
                   {
                       username = x.XMLuser;
                       password = x.XMLpws;
                       name = x.XMLname;
                       surname = x.XMLsurname;
                   }
                   if (user == username)
                   {
                       if (pwd == password)
                       {
                           MessageBox.Show(name + " " + "Welcome!", "Admin");
                           Admin options = new Admin();
                           this.Hide();
                           options.Show();
                       }
                       else
                       {
                           MessageBox.Show("Wrong Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           TextBoxName.Clear();
                           TextBoxPassword.Clear();
                           TextBoxName.Focus();
                       }
                   }
                   else
                   {
                       MessageBox.Show("Wrong Username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       TextBoxName.Clear();
                       TextBoxPassword.Clear();
                       TextBoxName.Focus();
                   }
               }
               else
               {
                   if (TextBoxName.Text != "")
                   {
                       MessageBox.Show("Password Is Required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       TextBoxPassword.Focus();
                   }
                   else
                   {
                       MessageBox.Show("Username & Password Is Required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       TextBoxName.Focus();
                   }
               }
            }
            else if (comboBox1.Text == "STUDENT")
            {
                if (TextBoxName.Text != "" && TextBoxPassword.Text != "")
                {
                    string user = TextBoxName.Text;
                    string email = TextBoxName.Text;
                    string pwd = TextBoxPassword.Text;


                    //-------Compare in XML file---------------------
                    /*XDocument doc = XDocument.Load(@"C:\Users\Osinachi\Documents\Visual Studio 2015\Projects\Library Store(Visual Studio)\ffm\Student.xml");
                    var adminUser = from x in doc.Descendants("student")
                                .Where(x => (string)x.Element("Username") == TextBoxName.Text || (string)x.Element("Email") == TextBoxName.Text)
                                    select new
                                    {
                                        XMLuser = x.Element("Username").Value,
                                        XMLpws = x.Element("Password").Value,
                                        XMLname = x.Element("FirstName").Value,
                                        XMLsurname = x.Element("Surname").Value,
                                        XMLemail = x.Element("Email").Value
                                    };
                    foreach (var x in adminUser)
                    {
                        username = x.XMLuser;
                        password = x.XMLpws;
                        firstname = x.XMLname;
                        surname = x.XMLsurname;
                        m_email = x.XMLemail;
                    }*/
                    //..............................................................

                    //-------Compare in Json file---------------------
                    string file = @"C:\Users\Osinachi\Documents\Visual Studio 2015\Projects\Library Store(Visual Studio)\ffm\Student.json";
                    string jsonStng = File.ReadAllText(file);
                    Root myRoot = JsonConvert.DeserializeObject<Root>(jsonStng);
                    for (int i = 0; i < myRoot.student.Count; i++)
                    {
                        if(myRoot.student[i].Username == user || myRoot.student[i].Email == email)
                        {
                            username = myRoot.student[i].Username;
                            password = myRoot.student[i].Password;
                            firstname = myRoot.student[i].FirstName;
                            surname = myRoot.student[i].Surname;
                            m_email = myRoot.student[i].Email;
                            //check = true;
                        }
                    }
                    //................................................
                    if (user == username || email == m_email)
                    {
                        if (pwd == password)
                        {
                            MessageBox.Show(firstname + " " + "Welcome!", "Student");
                            transferName = firstname;
                            SecProducts options = new SecProducts();
                            this.Hide();
                            options.Show();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TextBoxName.Clear();
                            TextBoxPassword.Clear();
                            TextBoxName.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBoxName.Clear();
                        TextBoxPassword.Clear();
                        TextBoxName.Focus();
                    }
                }
                else
                {
                    if (TextBoxName.Text != "")
                    {
                        MessageBox.Show("Password Is Required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBoxPassword.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Username & Password Is Required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBoxName.Focus();
                    }
                }
            }
            else
            {
                 MessageBox.Show("Select Role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TextBoxPassword.UseSystemPasswordChar = false;
                var CheckBox = (CheckBox)sender;
                CheckBox.Text = "HIDE";

            }
            else
            {
                TextBoxPassword.UseSystemPasswordChar = true;
                var CheckBox = (CheckBox)sender;
                CheckBox.Text = "SHOW";
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            
            signup log = new signup();
            this.Hide();
            log.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
