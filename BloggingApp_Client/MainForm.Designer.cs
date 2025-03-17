namespace BloggingApp_Client
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreatePost = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDeletePost = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonCloseMF = new System.Windows.Forms.Button();
            this.listBoxContent = new System.Windows.Forms.ListBox();
            this.buttonSeeUsers = new System.Windows.Forms.Button();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "It\'s blogging time!";
            // 
            // buttonCreatePost
            // 
            this.buttonCreatePost.Location = new System.Drawing.Point(162, 89);
            this.buttonCreatePost.Name = "buttonCreatePost";
            this.buttonCreatePost.Size = new System.Drawing.Size(111, 34);
            this.buttonCreatePost.TabIndex = 1;
            this.buttonCreatePost.Text = "Create Post";
            this.buttonCreatePost.UseVisualStyleBackColor = true;
            this.buttonCreatePost.Click += new System.EventHandler(this.buttonCreatePost_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(358, 90);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(97, 34);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeletePost
            // 
            this.buttonDeletePost.Location = new System.Drawing.Point(555, 88);
            this.buttonDeletePost.Name = "buttonDeletePost";
            this.buttonDeletePost.Size = new System.Drawing.Size(98, 35);
            this.buttonDeletePost.TabIndex = 3;
            this.buttonDeletePost.Text = "Delete Post";
            this.buttonDeletePost.UseVisualStyleBackColor = true;
            this.buttonDeletePost.Click += new System.EventHandler(this.buttonDeletePost_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(272, 150);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(259, 148);
            this.listBoxPosts.TabIndex = 4;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // buttonCloseMF
            // 
            this.buttonCloseMF.Location = new System.Drawing.Point(680, 383);
            this.buttonCloseMF.Name = "buttonCloseMF";
            this.buttonCloseMF.Size = new System.Drawing.Size(79, 30);
            this.buttonCloseMF.TabIndex = 5;
            this.buttonCloseMF.Text = "Close";
            this.buttonCloseMF.UseVisualStyleBackColor = true;
            this.buttonCloseMF.Click += new System.EventHandler(this.buttonCloseMF_Click);
            // 
            // listBoxContent
            // 
            this.listBoxContent.FormattingEnabled = true;
            this.listBoxContent.ItemHeight = 16;
            this.listBoxContent.Location = new System.Drawing.Point(272, 333);
            this.listBoxContent.Name = "listBoxContent";
            this.listBoxContent.Size = new System.Drawing.Size(259, 84);
            this.listBoxContent.TabIndex = 6;
            this.listBoxContent.SelectedIndexChanged += new System.EventHandler(this.listBoxContent_SelectedIndexChanged);
            // 
            // buttonSeeUsers
            // 
            this.buttonSeeUsers.Location = new System.Drawing.Point(26, 106);
            this.buttonSeeUsers.Name = "buttonSeeUsers";
            this.buttonSeeUsers.Size = new System.Drawing.Size(83, 37);
            this.buttonSeeUsers.TabIndex = 7;
            this.buttonSeeUsers.Text = "See users";
            this.buttonSeeUsers.UseVisualStyleBackColor = true;
            this.buttonSeeUsers.Click += new System.EventHandler(this.buttonSeeUsers_Click);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 16;
            this.listBoxUsers.Location = new System.Drawing.Point(26, 162);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(83, 228);
            this.listBoxUsers.TabIndex = 8;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.buttonSeeUsers);
            this.Controls.Add(this.listBoxContent);
            this.Controls.Add(this.buttonCloseMF);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.buttonDeletePost);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonCreatePost);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreatePost;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDeletePost;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button buttonCloseMF;
        private System.Windows.Forms.ListBox listBoxContent;
        private System.Windows.Forms.Button buttonSeeUsers;
        private System.Windows.Forms.ListBox listBoxUsers;
    }
}