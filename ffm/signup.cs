using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;//allways add this to work.
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;//use this to be able to make xml files.
using System.Xml.Linq;//use this to allow lingq to read xml files.

namespace ffm
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_Load(object sender, EventArgs e)
        {

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


        //string student = @"C:\Users\Osinachi\Documents\Visual Studio 2015\Projects\Library Store(Visual Studio)\ffm\Student.xml";
        //string items = "flag";
        
        public static string transName = "";

        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        static Regex rEmail = email_validation();

        bool check;
        private void button2_Click(object sender, EventArgs e)
        {
            if (FName.Text != "" && SName.Text != "" && Email.Text != "" && comboBox1.Text != "Gender" && UName.Text != "" && TextBoxPassword.Text != "")
            {
                if (rEmail.IsMatch(Email.Text) == true) //  (IsValidEmail(Email.Text) == true) 
                {
                    string emailID = Email.Text;

                    //...............XML Update...............
                    /*XDocument xDoc = XDocument.Load(student);
                    var aNode = xDoc.Descendants("student").Where(x => (string)x.Element("Email") == emailID).FirstOrDefault(); //Checks if the email exit in the file and returns null if it doesn't exist
                    if (aNode == null)
                    {
                        DataSet obj = new DataSet();
                        obj.ReadXml(student);
                        DataRow objrow = obj.Tables["student"].NewRow();


                        objrow["FirstName"] = FName.Text;
                        objrow["Surname"] = SName.Text;
                        objrow["Email"] = Email.Text;
                        objrow["Gender"] = comboBox1.Text;
                        objrow["Username"] = UName.Text;
                        objrow["Password"] = TextBoxPassword.Text;


                        obj.Tables["student"].Rows.Add(objrow);
                        obj.AcceptChanges();
                        obj.WriteXml(student);
                        obj.ReadXml(student);
                        

                        transName = FName.Text;
                        Purchase log = new Purchase();
                        this.Hide();
                        log.Show();
                    }
                    else
                    {
                        MessageBox.Show("This account already exist, Login instead.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBoxPassword.Focus();
                    }*/
                    //....................................

                    //...........JSON Update..........
                    string file = @"C:\Users\Osinachi\Documents\Visual Studio 2015\Projects\Library Store(Visual Studio)\ffm\Student.json";
                   
                    string jsonStng = File.ReadAllText(file);
                    Root myRoot = JsonConvert.DeserializeObject<Root>(jsonStng);
                    for (int i = 0; i < myRoot.student.Count; i++)
                    {
                        if (myRoot.student[i].Email == emailID)
                        {
                            check = true;
                        }
                    }

                    if (check == true)
                    {
                        MessageBox.Show("This account already exist, Login instead.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBoxPassword.Clear();
                        Email.Focus();
                    }
                    else
                    {
                        DataSet jsonset = JsonConvert.DeserializeObject<DataSet>(jsonStng);
                        DataTable dataTable = jsonset.Tables["student"];
                        DataRow jsonrow;
                        jsonrow = dataTable.NewRow();
                        jsonrow["FirstName"] = FName.Text;
                        jsonrow["Surname"] = SName.Text;
                        jsonrow["Email"] = Email.Text;
                        jsonrow["Gender"] = comboBox1.Text;
                        jsonrow["Username"] = UName.Text;
                        jsonrow["Password"] = TextBoxPassword.Text;

                        dataTable.Rows.Add(jsonrow);
                        jsonset.AcceptChanges();
                        JsonSerializerSettings settings = new JsonSerializerSettings();
                        settings.Formatting = Newtonsoft.Json.Formatting.Indented;

                        string newjson = JsonConvert.SerializeObject(jsonset, settings);
                        File.WriteAllText(file, newjson);

                        transName = FName.Text;
                        SecProducts log = new SecProducts();
                        this.Hide();
                        log.Show();
                    }
                    //..........................................................


                }
                else
                {
                    MessageBox.Show("Invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Complete the form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxPassword.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 options = new Form1();
            this.Hide();
            options.Show();
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void Email_Validating(object sender, CancelEventArgs e)
        {
    
        }

        
    }
}
