using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloggingApp_Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BloggingApp_Client
{
    public partial class LoginForm : Form
    {
        private readonly PostService postService;
        public LoginForm()
        {
            InitializeComponent();
            postService = new PostService();
        }

        private void checkBoxShowL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowL.Checked)
            {
                textBoxPasswordL.PasswordChar = '\0';
            }
            else
            {
                textBoxPasswordL.PasswordChar = '*';
            }
        }

        private void buttonRegisterLF_Click(object sender, EventArgs e)
        {
            RegisterForm registrationForm = new RegisterForm();
            registrationForm.Show();
        }

        private void buttonCloseLF_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsernameL.Text;
            string password = textBoxPasswordL.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PostService postService = new PostService();
            postService.createConnection();
            if (postService.validateUser(username, password))
            {
                // If login is successful, open the main form
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // Show an error message if login fails
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateCredentials(string username, string password)
        {
            // Hardcoded username and password for demonstration purposes
            if (username == "admin" && password == "admin")
            {
                return true;
            }
            return false;
        }
    }
}
