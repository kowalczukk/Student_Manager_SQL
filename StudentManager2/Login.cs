using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace StudentManager2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        static public string Who = "";
        static public int StudentId;
        static public int TeacherId;

        List<Password> passes = new List<Password>();

        private void Login_Load(object sender, EventArgs e)
        {
            passes.Add(new Password("student", 1, "s1", "123"));
            passes.Add(new Password("student", 2, "s2", "123"));
            passes.Add(new Password("student", 3, "s3", "123"));
            passes.Add(new Password("teacher", 1, "t1", "123"));
            passes.Add(new Password("teacher", 2, "t2", "123"));
            passes.Add(new Password("teacher", 3, "t3", "123"));            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Security.Login(userNameBox.Text, passwordBox.Text);
                if (Security.Who == "teacher")
                {
                    Main m = new Main();
                    m.Show();
                    this.Hide();
                }
                else if (Security.Who == "student")
                {
                    StudentDetails sd = new StudentDetails();
                    sd.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Podany identyfikator lub hasło jest niepoprawne.",
                                            "Błąd", MessageBoxButtons.OK);
            }
 
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(userNameBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Podany login lub hasło jest niepoprawne.",
                        "Błąd logowania", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }



        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                logInButton.PerformClick();
            }
        }

        private void userNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logInButton.PerformClick();
            }
        }
    }
}
