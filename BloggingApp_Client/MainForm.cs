using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloggingApp_FR;

namespace BloggingApp_Client
{
    public partial class MainForm : Form
    {
        private readonly PostService postService;
        private List<Post> postsList;
        public MainForm()
        {
            InitializeComponent();
            postService = new PostService();
        }

        private void buttonCloseMF_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreatePost_Click(object sender, EventArgs e)
        {
            CreatePostForm postForm = new CreatePostForm();
            postForm.Show();
            this.Hide();
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var posts = await Task.Run(() => postService.getAllPosts());
                listBoxPosts.Items.Clear();

                listBoxPosts.DisplayMember = "Title";

                foreach (var post in posts)
                {
                    listBoxPosts.Items.Add(post);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading posts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonDeletePost_Click(object sender, EventArgs e)
        {
            // Check if a post is selected
            if (listBoxPosts.SelectedItem == null)
            {
                MessageBox.Show("Please select a post to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Get the selected post from the ListBox
            Post selectedPost = (Post)listBoxPosts.SelectedItem;

            // Confirm before deleting
            var result = MessageBox.Show($"Are you sure you want to delete the post '{selectedPost.Title}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Delete the post from the backend
                    await postService.deletePost(selectedPost.postId);

                    // Remove the post and its content from the ListBox
                    listBoxPosts.Items.Remove(selectedPost);
                    listBoxContent.Items.Clear();

                    MessageBox.Show("Post deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to delete post: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listBoxContent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPosts.SelectedItem != null)
            {
                // Cast the selected item to a Post object
                Post selectedPost = listBoxPosts.SelectedItem as Post;

                if (selectedPost != null)
                {
                    // Clear the content ListBox
                    listBoxContent.Items.Clear();

                    // Add the content of the selected post to the second ListBox
                    listBoxContent.Items.Add("Title: " + selectedPost.Title + "\n");
                    listBoxContent.Items.Add("Content: " + selectedPost.Content + "\n");
                    listBoxContent.Items.Add("User: " + selectedPost.User.Name + "\n");
                    listBoxContent.Items.Add("Date: " + selectedPost.Date + "\n");
                    // Add any other details you want to show from the Post
                }
            }
        }

        private async void buttonSeeUsers_Click(object sender, EventArgs e)
        {
            try
            {
                List<User> users = await postService.getAllUsers(); // Get all users
                listBoxUsers.Items.Clear(); // Clear previous items

                foreach (var user in users)
                {
                    listBoxUsers.Items.Add(user.Name); // Assuming `User` has a `Name` property
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
