namespace Mini_Project
{
    partial class Register
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
            Button LoginBtn;
            SubmitBtn = new Button();
            label2 = new Label();
            PasswdBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            ConfirmPasswdBox = new TextBox();
            UserNameBox = new TextBox();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginBtn.BackColor = Color.LightCoral;
            LoginBtn.ForeColor = SystemColors.ControlText;
            LoginBtn.Location = new Point(328, 266);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(121, 32);
            LoginBtn.TabIndex = 11;
            LoginBtn.Text = "Login here";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubmitBtn.BackColor = Color.LightCoral;
            SubmitBtn.Location = new Point(328, 214);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(121, 46);
            SubmitBtn.TabIndex = 10;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(328, 123);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // PasswdBox
            // 
            PasswdBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswdBox.Location = new Point(328, 141);
            PasswdBox.Name = "PasswdBox";
            PasswdBox.PasswordChar = '*';
            PasswdBox.Size = new Size(121, 23);
            PasswdBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(328, 79);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 7;
            label1.Text = "User";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(328, 167);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 13;
            label3.Text = "Confirm Password";
            // 
            // ConfirmPasswdBox
            // 
            ConfirmPasswdBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ConfirmPasswdBox.Location = new Point(328, 185);
            ConfirmPasswdBox.Name = "ConfirmPasswdBox";
            ConfirmPasswdBox.PasswordChar = '*';
            ConfirmPasswdBox.Size = new Size(121, 23);
            ConfirmPasswdBox.TabIndex = 12;
            // 
            // UserNameBox
            // 
            UserNameBox.Location = new Point(328, 97);
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(121, 23);
            UserNameBox.TabIndex = 14;
            UserNameBox.TextChanged += UserNameBox_TextChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(UserNameBox);
            Controls.Add(label3);
            Controls.Add(ConfirmPasswdBox);
            Controls.Add(LoginBtn);
            Controls.Add(SubmitBtn);
            Controls.Add(label2);
            Controls.Add(PasswdBox);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterBtn;
        private Button SubmitBtn;
        private Label label2;
        private TextBox PasswdBox;
        private Label label1;
        private ComboBox UserBox;
        private Label label3;
        private TextBox ConfirmPasswdBox;
        private TextBox UserNameBox;
    }
}