namespace Mini_Project
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
            ItemList = new ComboBox();
            CountBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            DatePicker = new MonthCalendar();
            DateShower = new Button();
            DateTextHolder = new TextBox();
            RoomList = new ComboBox();
            label3 = new Label();
            Submit = new Button();
            AmountBox = new TextBox();
            Amount = new Label();
            Hours = new ComboBox();
            Minutes = new ComboBox();
            TimeShower = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            DescriptionBox = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // ItemList
            // 
            ItemList.FormattingEnabled = true;
            ItemList.Location = new Point(60, 50);
            ItemList.Name = "ItemList";
            ItemList.Size = new Size(121, 23);
            ItemList.TabIndex = 0;
            ItemList.SelectedIndexChanged += ItemList_SelectedIndexChanged;
            // 
            // CountBox
            // 
            CountBox.Location = new Point(568, 50);
            CountBox.Name = "CountBox";
            CountBox.ReadOnly = true;
            CountBox.Size = new Size(121, 23);
            CountBox.TabIndex = 1;
            CountBox.TextChanged += CountBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(568, 32);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "Items left";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 32);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Items";
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(60, 270);
            DatePicker.Name = "DatePicker";
            DatePicker.TabIndex = 4;
            DatePicker.Visible = false;
            DatePicker.DateChanged += DatePicker_DateChanged;
            // 
            // DateShower
            // 
            DateShower.BackColor = Color.LightCoral;
            DateShower.Location = new Point(60, 192);
            DateShower.Name = "DateShower";
            DateShower.Size = new Size(227, 43);
            DateShower.TabIndex = 5;
            DateShower.Text = "Date Shower";
            DateShower.UseVisualStyleBackColor = false;
            DateShower.Click += DateShower_Click;
            // 
            // DateTextHolder
            // 
            DateTextHolder.Location = new Point(60, 241);
            DateTextHolder.Name = "DateTextHolder";
            DateTextHolder.ReadOnly = true;
            DateTextHolder.Size = new Size(227, 23);
            DateTextHolder.TabIndex = 6;
            DateTextHolder.TextChanged += DateTextHolder_TextChanged;
            // 
            // RoomList
            // 
            RoomList.FormattingEnabled = true;
            RoomList.Location = new Point(60, 113);
            RoomList.Name = "RoomList";
            RoomList.Size = new Size(121, 23);
            RoomList.TabIndex = 7;
            RoomList.SelectedIndexChanged += RoomList_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 95);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Room";
            label3.Click += label3_Click;
            // 
            // Submit
            // 
            Submit.BackColor = Color.LightCoral;
            Submit.Location = new Point(276, 32);
            Submit.Name = "Submit";
            Submit.Size = new Size(209, 104);
            Submit.TabIndex = 9;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // AmountBox
            // 
            AmountBox.Location = new Point(568, 113);
            AmountBox.Name = "AmountBox";
            AmountBox.Size = new Size(121, 23);
            AmountBox.TabIndex = 10;
            AmountBox.TextChanged += AmountBox_TextChanged;
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.Location = new Point(568, 95);
            Amount.Name = "Amount";
            Amount.Size = new Size(51, 15);
            Amount.TabIndex = 11;
            Amount.Text = "Amount";
            // 
            // Hours
            // 
            Hours.FormattingEnabled = true;
            Hours.Location = new Point(568, 294);
            Hours.Name = "Hours";
            Hours.Size = new Size(121, 23);
            Hours.TabIndex = 12;
            Hours.SelectedIndexChanged += Hours_SelectedIndexChanged;
            // 
            // Minutes
            // 
            Minutes.FormattingEnabled = true;
            Minutes.Location = new Point(568, 250);
            Minutes.Name = "Minutes";
            Minutes.Size = new Size(121, 23);
            Minutes.TabIndex = 13;
            Minutes.SelectedIndexChanged += Minutes_SelectedIndexChanged;
            // 
            // TimeShower
            // 
            TimeShower.Location = new Point(568, 203);
            TimeShower.Name = "TimeShower";
            TimeShower.ReadOnly = true;
            TimeShower.Size = new Size(121, 23);
            TimeShower.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(607, 185);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 15;
            label4.Text = "Time ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(604, 276);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 16;
            label5.Text = "Hours";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(604, 232);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 18;
            label7.Text = "Minutes";
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(309, 203);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.ReadOnly = true;
            DescriptionBox.Size = new Size(236, 114);
            DescriptionBox.TabIndex = 19;
            DescriptionBox.TextChanged += DescriptionBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(309, 185);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 20;
            label6.Text = "Description";
            label6.Click += label6_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(309, 355);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 77);
            textBox2.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(309, 337);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 22;
            label8.Text = "Purpose";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(DescriptionBox);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TimeShower);
            Controls.Add(Minutes);
            Controls.Add(Hours);
            Controls.Add(Amount);
            Controls.Add(AmountBox);
            Controls.Add(Submit);
            Controls.Add(label3);
            Controls.Add(RoomList);
            Controls.Add(DateTextHolder);
            Controls.Add(DateShower);
            Controls.Add(DatePicker);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CountBox);
            Controls.Add(ItemList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ItemList;
        private TextBox CountBox;
        private Label label1;
        private Label label2;
        private MonthCalendar DatePicker;
        private Button DateShower;
        private TextBox DateText;
        private TextBox textBox1;
        private TextBox DateTextHolder;
        private ComboBox RoomList;
        private Label label3;
        private Button Submit;
        private TextBox AmountBox;
        private Label Amount;
        private ComboBox Hours;
        private ComboBox Minutes;
        private TextBox TimeShower;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox DescriptionBox;
        private Label label6;
        private TextBox textBox2;
        private Label label8;
    }
}
