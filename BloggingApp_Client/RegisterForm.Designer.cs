namespace BloggingApp_Client
{
    partial class RegisterForm
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
            this.textBoxUsernameR = new System.Windows.Forms.TextBox();
            this.textBoxEmailR = new System.Windows.Forms.TextBox();
            this.textBoxPasswordR = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPasswordR = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonCloseRF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(282, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Register Page!";
            // 
            // textBoxUsernameR
            // 
            this.textBoxUsernameR.Location = new System.Drawing.Point(285, 128);
            this.textBoxUsernameR.Name = "textBoxUsernameR";
            this.textBoxUsernameR.Size = new System.Drawing.Size(196, 22);
            this.textBoxUsernameR.TabIndex = 1;
            // 
            // textBoxEmailR
            // 
            this.textBoxEmailR.Location = new System.Drawing.Point(285, 192);
            this.textBoxEmailR.Name = "textBoxEmailR";
            this.textBoxEmailR.Size = new System.Drawing.Size(196, 22);
            this.textBoxEmailR.TabIndex = 2;
            // 
            // textBoxPasswordR
            // 
            this.textBoxPasswordR.Location = new System.Drawing.Point(285, 251);
            this.textBoxPasswordR.Name = "textBoxPasswordR";
            this.textBoxPasswordR.PasswordChar = '*';
            this.textBoxPasswordR.Size = new System.Drawing.Size(196, 22);
            this.textBoxPasswordR.TabIndex = 3;
            // 
            // textBoxConfirmPasswordR
            // 
            this.textBoxConfirmPasswordR.Location = new System.Drawing.Point(285, 309);
            this.textBoxConfirmPasswordR.Name = "textBoxConfirmPasswordR";
            this.textBoxConfirmPasswordR.PasswordChar = '*';
            this.textBoxConfirmPasswordR.Size = new System.Drawing.Size(196, 22);
            this.textBoxConfirmPasswordR.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(488, 252);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(488, 311);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(62, 20);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Show";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirm password";
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(332, 367);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(92, 40);
            this.buttonRegister.TabIndex = 11;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonCloseRF
            // 
            this.buttonCloseRF.Location = new System.Drawing.Point(661, 376);
            this.buttonCloseRF.Name = "buttonCloseRF";
            this.buttonCloseRF.Size = new System.Drawing.Size(82, 31);
            this.buttonCloseRF.TabIndex = 12;
            this.buttonCloseRF.Text = "Close";
            this.buttonCloseRF.UseVisualStyleBackColor = true;
            this.buttonCloseRF.Click += new System.EventHandler(this.buttonCloseRF_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCloseRF);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxConfirmPasswordR);
            this.Controls.Add(this.textBoxPasswordR);
            this.Controls.Add(this.textBoxEmailR);
            this.Controls.Add(this.textBoxUsernameR);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsernameR;
        private System.Windows.Forms.TextBox textBoxEmailR;
        private System.Windows.Forms.TextBox textBoxPasswordR;
        private System.Windows.Forms.TextBox textBoxConfirmPasswordR;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonCloseRF;
    }
}