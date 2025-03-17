namespace BloggingApp_Client
{
    partial class LoginForm
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
            this.textBoxUsernameL = new System.Windows.Forms.TextBox();
            this.textBoxPasswordL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCloseLF = new System.Windows.Forms.Button();
            this.buttonRegisterLF = new System.Windows.Forms.Button();
            this.checkBoxShowL = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(313, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Login Page!";
            // 
            // textBoxUsernameL
            // 
            this.textBoxUsernameL.Location = new System.Drawing.Point(300, 149);
            this.textBoxUsernameL.Name = "textBoxUsernameL";
            this.textBoxUsernameL.Size = new System.Drawing.Size(202, 22);
            this.textBoxUsernameL.TabIndex = 1;
            // 
            // textBoxPasswordL
            // 
            this.textBoxPasswordL.Location = new System.Drawing.Point(300, 216);
            this.textBoxPasswordL.Name = "textBoxPasswordL";
            this.textBoxPasswordL.PasswordChar = '*';
            this.textBoxPasswordL.Size = new System.Drawing.Size(202, 22);
            this.textBoxPasswordL.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogin.Location = new System.Drawing.Point(359, 268);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(88, 37);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCloseLF
            // 
            this.buttonCloseLF.Location = new System.Drawing.Point(665, 375);
            this.buttonCloseLF.Name = "buttonCloseLF";
            this.buttonCloseLF.Size = new System.Drawing.Size(84, 32);
            this.buttonCloseLF.TabIndex = 6;
            this.buttonCloseLF.Text = "Close";
            this.buttonCloseLF.UseVisualStyleBackColor = true;
            this.buttonCloseLF.Click += new System.EventHandler(this.buttonCloseLF_Click);
            // 
            // buttonRegisterLF
            // 
            this.buttonRegisterLF.Location = new System.Drawing.Point(48, 375);
            this.buttonRegisterLF.Name = "buttonRegisterLF";
            this.buttonRegisterLF.Size = new System.Drawing.Size(91, 32);
            this.buttonRegisterLF.TabIndex = 7;
            this.buttonRegisterLF.Text = "Register ";
            this.buttonRegisterLF.UseVisualStyleBackColor = true;
            this.buttonRegisterLF.Click += new System.EventHandler(this.buttonRegisterLF_Click);
            // 
            // checkBoxShowL
            // 
            this.checkBoxShowL.AutoSize = true;
            this.checkBoxShowL.Location = new System.Drawing.Point(508, 218);
            this.checkBoxShowL.Name = "checkBoxShowL";
            this.checkBoxShowL.Size = new System.Drawing.Size(62, 20);
            this.checkBoxShowL.TabIndex = 8;
            this.checkBoxShowL.Text = "Show";
            this.checkBoxShowL.UseVisualStyleBackColor = true;
            this.checkBoxShowL.CheckedChanged += new System.EventHandler(this.checkBoxShowL_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxShowL);
            this.Controls.Add(this.buttonRegisterLF);
            this.Controls.Add(this.buttonCloseLF);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPasswordL);
            this.Controls.Add(this.textBoxUsernameL);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsernameL;
        private System.Windows.Forms.TextBox textBoxPasswordL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCloseLF;
        private System.Windows.Forms.Button buttonRegisterLF;
        private System.Windows.Forms.CheckBox checkBoxShowL;
    }
}