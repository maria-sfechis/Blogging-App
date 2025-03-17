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
using Newtonsoft.Json;

namespace BloggingApp_FR
{
    public partial class CreatePostForm : Form
    {
        private readonly PostService postService;

        public CreatePostForm()
        {
            InitializeComponent();
            postService = new PostService();
            postService.createConnection();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReturnToMain_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            string title = textBoxPostTitle.Text;
            string content = textBoxPostContent.Text;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Please enter title and content", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Post newPost = new Post
            {
                Title = title,
                Content = content,
                Date = DateTime.Now,
                CreatedAt = DateTime.Now.Ticks,
                UpdatedAt = DateTime.Now.Ticks,
                Published = true,
                User = new User { Id = 1 }
            };
            try
            {
                var json = JsonConvert.SerializeObject(newPost);
                MessageBox.Show(json, "JSON Payload", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var contentData = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await postService.PostAsync("http://localhost:8083/post/create", contentData);


                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Post created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear input fields
                    textBoxPostTitle.Clear();
                    textBoxPostContent.Clear();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"HTTP Status Code: {(int)response.StatusCode}\nError Response: {error}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //var error = await response.Content.ReadAsStringAsync();
                    //MessageBox.Show($"Failed to create post: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
