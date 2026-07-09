namespace Student_Registration_System
{
    partial class RegistrationForm
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
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnRegister = new Button();
            groupBox4 = new GroupBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtEmail = new TextBox();
            txtMobilePhone = new TextBox();
            txtHomePhone = new TextBox();
            label13 = new Label();
            txtAddress = new TextBox();
            groupBox3 = new GroupBox();
            label9 = new Label();
            label7 = new Label();
            txtNIC = new TextBox();
            txtContactNo = new TextBox();
            label6 = new Label();
            txtParentName = new TextBox();
            groupBox2 = new GroupBox();
            rdbMale = new RadioButton();
            rdbFemale = new RadioButton();
            dtpDateOfBirth = new DateTimePicker();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            lael2 = new Label();
            cmbRegNo = new ComboBox();
            label1 = new Label();
            llblExit = new LinkLabel();
            llblLogout = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(256, 19);
            label3.Name = "label3";
            label3.Size = new Size(536, 52);
            label3.TabIndex = 3;
            label3.Text = "Skills International";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cmbRegNo);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(36, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(979, 861);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Registration";
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Location = new Point(739, 792);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 44);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Location = new Point(541, 792);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 44);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Location = new Point(292, 792);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 44);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRegister
            // 
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Location = new Point(97, 792);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(145, 44);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(txtEmail);
            groupBox4.Controls.Add(txtMobilePhone);
            groupBox4.Controls.Add(txtHomePhone);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(txtAddress);
            groupBox4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(93, 327);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(787, 235);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Contact Details";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 179);
            label10.Name = "label10";
            label10.Size = new Size(121, 22);
            label10.TabIndex = 0;
            label10.Text = "Mobile Phone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(424, 179);
            label11.Name = "label11";
            label11.Size = new Size(110, 22);
            label11.TabIndex = 0;
            label11.Text = "Home Phone";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 128);
            label12.Name = "label12";
            label12.Size = new Size(57, 22);
            label12.TabIndex = 0;
            label12.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(181, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(573, 30);
            txtEmail.TabIndex = 1;
            // 
            // txtMobilePhone
            // 
            txtMobilePhone.Location = new Point(181, 176);
            txtMobilePhone.Name = "txtMobilePhone";
            txtMobilePhone.Size = new Size(218, 30);
            txtMobilePhone.TabIndex = 1;
            // 
            // txtHomePhone
            // 
            txtHomePhone.Location = new Point(536, 176);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(218, 30);
            txtHomePhone.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(26, 56);
            label13.Name = "label13";
            label13.Size = new Size(76, 22);
            label13.TabIndex = 0;
            label13.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(181, 38);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(573, 59);
            txtAddress.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtNIC);
            groupBox3.Controls.Add(txtContactNo);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtParentName);
            groupBox3.Location = new Point(97, 572);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(787, 201);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Parent Details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 148);
            label9.Name = "label9";
            label9.Size = new Size(99, 22);
            label9.TabIndex = 0;
            label9.Text = "Contact No";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 92);
            label7.Name = "label7";
            label7.Size = new Size(43, 22);
            label7.TabIndex = 0;
            label7.Text = "NIC";
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(181, 89);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(319, 30);
            txtNIC.TabIndex = 1;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(181, 145);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(319, 30);
            txtContactNo.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 40);
            label6.Name = "label6";
            label6.Size = new Size(116, 22);
            label6.TabIndex = 0;
            label6.Text = "Parent Name ";
            // 
            // txtParentName
            // 
            txtParentName.Location = new Point(181, 37);
            txtParentName.Name = "txtParentName";
            txtParentName.Size = new Size(573, 30);
            txtParentName.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbMale);
            groupBox2.Controls.Add(rdbFemale);
            groupBox2.Controls.Add(dtpDateOfBirth);
            groupBox2.Controls.Add(txtFirstName);
            groupBox2.Controls.Add(txtLastName);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lael2);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(93, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(787, 231);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Details";
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(181, 189);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(72, 26);
            rdbMale.TabIndex = 3;
            rdbMale.TabStop = true;
            rdbMale.Text = "Male";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(354, 189);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(89, 26);
            rdbFemale.TabIndex = 3;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "Female";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(181, 146);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(302, 30);
            dtpDateOfBirth.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(181, 42);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(573, 30);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(181, 98);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(573, 30);
            txtLastName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 152);
            label5.Name = "label5";
            label5.Size = new Size(117, 22);
            label5.TabIndex = 0;
            label5.Text = "Date Of Birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 191);
            label2.Name = "label2";
            label2.Size = new Size(68, 22);
            label2.TabIndex = 0;
            label2.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 101);
            label4.Name = "label4";
            label4.Size = new Size(89, 22);
            label4.TabIndex = 0;
            label4.Text = "LastName";
            // 
            // lael2
            // 
            lael2.AutoSize = true;
            lael2.Location = new Point(26, 45);
            lael2.Name = "lael2";
            lael2.Size = new Size(93, 22);
            lael2.TabIndex = 0;
            lael2.Text = "FirstName";
            // 
            // cmbRegNo
            // 
            cmbRegNo.FormattingEnabled = true;
            cmbRegNo.Location = new Point(274, 40);
            cmbRegNo.Name = "cmbRegNo";
            cmbRegNo.Size = new Size(238, 30);
            cmbRegNo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 43);
            label1.Name = "label1";
            label1.Size = new Size(70, 22);
            label1.TabIndex = 0;
            label1.Text = "Reg No";
            // 
            // llblExit
            // 
            llblExit.AutoSize = true;
            llblExit.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblExit.Location = new Point(967, 948);
            llblExit.Name = "llblExit";
            llblExit.Size = new Size(48, 26);
            llblExit.TabIndex = 5;
            llblExit.TabStop = true;
            llblExit.Text = "Exit";
            llblExit.LinkClicked += llblExit_LinkClicked;
            // 
            // llblLogout
            // 
            llblLogout.AutoSize = true;
            llblLogout.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblLogout.Location = new Point(36, 37);
            llblLogout.Name = "llblLogout";
            llblLogout.Size = new Size(84, 26);
            llblLogout.TabIndex = 6;
            llblLogout.TabStop = true;
            llblLogout.Text = "Log out";
            llblLogout.LinkClicked += llblLogout_LinkClicked;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 996);
            Controls.Add(llblLogout);
            Controls.Add(llblExit);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TextBox txtLastName;
        private TextBox txtParentName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lael2;
        private ComboBox cmbRegNo;
        private Label label1;
        private Label label9;
        private Label label7;
        private RadioButton rdbMale;
        private RadioButton rdbFemale;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtFirstName;
        private GroupBox groupBox4;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtEmail;
        private TextBox txtMobilePhone;
        private TextBox txtHomePhone;
        private Label label13;
        private TextBox txtAddress;
        private TextBox txtNIC;
        private TextBox txtContactNo;
        private Button btnDelete;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnRegister;
        private LinkLabel llblExit;
        private LinkLabel llblLogout;
        private Label label2;
    }
}