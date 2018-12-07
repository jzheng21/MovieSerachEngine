using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieSearchEngine
{
    public partial class LoginInterface : Form
    {
        private string username;
        private string password;
        private int id;
        private string query;
        private DataAccess dataAccess = new DataAccess();
        List<UserInfo> users = new List<UserInfo>();
        public LoginInterface()
        {
            InitializeComponent();
            updateUsers();
        }



        private void LoginInButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(uxUsernameTextBox.Text))
            {
                if (!String.IsNullOrEmpty(uxPassWordTextbox.Text))
                {
                    username = uxUsernameTextBox.Text;
                    password = uxPassWordTextbox.Text;
                    int found = 0;
                    foreach(UserInfo user in users)
                    {
                        if(user.Login(username, password) == 0)
                        {
                            continue;
                        }
                        else if(user.Login(username, password) == -1)
                        {
                            MessageBox.Show("Username or Password are inaccuracy.");
                            found = -1;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Login Successful!");
                            id = user.Login(username, password);
                            found = 1;
                            this.Hide();
                            Form form1 = new userInterface(username, id);
                            form1.ShowDialog();
                            this.Close();
                        }
                    }
                    if(found == 0) MessageBox.Show("Username is not exist. If you need a new account, please sign up.");
                }
                else
                {
                    MessageBox.Show("Enter the Password.");
                }
            }
            else
            {
                MessageBox.Show("Enter the Username.");
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(uxUsernameTextBox.Text))
            {
                if (!String.IsNullOrEmpty(uxPassWordTextbox.Text))
                {
                    username = uxUsernameTextBox.Text;
                    password = uxPassWordTextbox.Text;
                    int found = 0;
                    foreach (UserInfo user in users)
                    {
                        if (user.Login(username, password) != 0)
                        {
                            MessageBox.Show("Username already exist!");
                            found = 1;
                            break;
                        }
                    }
                    if(found != 1)
                    {
                        query = ($"INSERT FinalProject.Users(UserName, UserPassword) " +
                            $"SELECT u.UserName, u.UserPassword " +
                            $"FROM " +
                            $"(" +
                            $"VALUES " +
                            $"(N'{username}', N'{password}') " +
                            $") u (UserName, UserPassword);");
                        dataAccess.pushReview(query.ToString());
                        MessageBox.Show("Sign Up Successed!");
                        updateUsers();
                    }
                }
                else
                {
                    MessageBox.Show("Enter the Password.");
                }
            }
            else
            {
                MessageBox.Show("Enter the Username.");
            }
        }

        private void updateUsers()
        {
            query = "SELECT FU.UserId, FU.UserName, FU.UserPassword " +
                "FROM FinalProject.Users FU ";
            users = dataAccess.GetUsername(query);
        }
    }
}
