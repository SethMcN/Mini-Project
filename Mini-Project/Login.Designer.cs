namespace Mini_Project
{
    partial class Login
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
            UserList = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SubmitBtn = new Button();
            PasswdBox = new TextBox();
            RegisterBtn = new Button();
            SuspendLayout();
            // 
            // UserList
            // 
            UserList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserList.FormattingEnabled = true;
            UserList.Location = new Point(331, 44);
            UserList.Name = "UserList";
            UserList.Size = new Size(121, 23);
            UserList.TabIndex = 0;
            UserList.SelectedIndexChanged += UserList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(331, 26);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(331, 87);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // SubmitBtn
            // 
            SubmitBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubmitBtn.BackColor = Color.LightCoral;
            SubmitBtn.Location = new Point(331, 163);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(121, 46);
            SubmitBtn.TabIndex = 4;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // PasswdBox
            // 
            PasswdBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswdBox.Location = new Point(331, 105);
            PasswdBox.Name = "PasswdBox";
            PasswdBox.PasswordChar = '*';
            PasswdBox.Size = new Size(121, 23);
            PasswdBox.TabIndex = 2;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegisterBtn.BackColor = Color.LightCoral;
            RegisterBtn.ForeColor = SystemColors.ControlText;
            RegisterBtn.Location = new Point(331, 215);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(121, 32);
            RegisterBtn.TabIndex = 5;
            RegisterBtn.Text = "Register here";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(RegisterBtn);
            Controls.Add(SubmitBtn);
            Controls.Add(label2);
            Controls.Add(PasswdBox);
            Controls.Add(label1);
            Controls.Add(UserList);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox UserList;
        private Label label1;
        private Label label2;
        private Button SubmitBtn;
        private TextBox PasswdBox;
        private Button RegisterBtn;
    }
}