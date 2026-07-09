namespace Student_Registration_System
{
    partial class LoginForm
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            btnLogin = new Button();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnClear = new Button();
            btnExit = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Location = new Point(61, 204);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 221);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "LOG IN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 56);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaptionText;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(16, 166);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(365, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 115);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(158, 112);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '.';
            txtPassword.Size = new Size(223, 30);
            txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(158, 53);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(223, 30);
            txtUsername.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.png_clipart_computer_icons_encapsulated_postscript_unlocked_lock_s_area_иконки;
            pictureBox3.Location = new Point(16, 112);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images__1_;
            pictureBox2.Location = new Point(16, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_upaosyupaosyupao_removebg_preview;
            pictureBox1.Location = new Point(155, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(325, 449);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 40);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(61, 449);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(140, 40);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 153);
            label3.Name = "label3";
            label3.Size = new Size(458, 44);
            label3.TabIndex = 3;
            label3.Text = "Skills International";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 523);
            Controls.Add(label3);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "LoginForm";
            Text = "LoginForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnClear;
        private Button btnExit;
        private Button btnLogin;
        private Label label3;
    }
}
