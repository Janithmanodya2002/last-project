namespace last_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            btnLogin = new Button();
            btnClear = new Button();
            label3 = new Label();
            label2 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(231, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 88);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 133);
            label1.Name = "label1";
            label1.Size = new Size(287, 32);
            label1.TabIndex = 1;
            label1.Text = "SKILL INTERNATIONAL";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(162, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 210);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(133, 78);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(133, 31);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 4;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(194, 142);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button2_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(47, 142);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 86);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 39);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 0;
            label2.Text = "UserName";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(49, 415);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(81, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnLogin;
        private Button btnClear;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnExit;
    }
}
