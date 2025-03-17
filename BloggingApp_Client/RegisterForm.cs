using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace BloggingApp_Client
{
    public partial class RegisterForm : Form
    {
        private readonly HttpClient httpClient;

        public RegisterForm()
        {
            InitializeComponent();
            httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:8083/") };
        }

        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            string email = textBoxEmailR.Text;
            string username = textBoxUsernameR.Text;
            string password = textBoxPasswordR.Text;
            string confirmPassword = textBoxConfirmPasswordR.Text;
            if (!ValidateUser(email, username, password, confirmPassword))
            {
                return;
            }

            var user = new User
            {
                Email = email,
                Username = username,
                Password = password,
                Name = username
            };

            try
            {
                var json = JsonConvert.SerializeObject(user);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("user/create", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("User registered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("User registration failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("User registration failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Validating user input for registration
        private bool ValidateUser(string email, string username, string password, string confirmPassword)
        {
            //Email
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Username
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username.Length < 3 || username.Length > 20)
            {
                MessageBox.Show("Username must be between 3 and 20 characters", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Password
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain a number and a special character", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Confirm Password
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //Email validation
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        //Password validation
        private bool IsValidPassword(string password)
        {
            // Password must be at least 8 characters long, contain at least one digit and one special character
            return password.Length >= 8 &&
                   password.Any(char.IsDigit) &&
                   password.Any(ch => !char.IsLetterOrDigit(ch));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxPasswordR.PasswordChar = '\0';
            }
            else
            {
                textBoxPasswordR.PasswordChar = '*';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBoxConfirmPasswordR.PasswordChar = '\0';
            }
            else
            {
                textBoxConfirmPasswordR.PasswordChar = '*';
            }
        }

        private void buttonCloseRF_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
