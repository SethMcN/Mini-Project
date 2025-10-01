using Microsoft.Identity.Client;
using System;
using System.Data.SQLite;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace Mini_Project
{

    public partial class Form1 : Form
    {
        public Dictionary<string, (string Count, string Description)> DB = new();
        public Form1()
        {
            InitializeComponent();

            AddTime();

            string dbPath = @"C:\Users\seth-mcnaughton\OneDrive - York College\Desktop\SchoolDate.db";
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Items";

                using (var command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string Item = reader["Name"].ToString();
                            string count = reader["Num_Items"].ToString();
                            string Description = reader["Description"].ToString();

                            ItemList.Items.Add(Item);
                            DB.Add(Item,(count, Description));
                        }
                    }
                }

                query = "SELECT * FROM Rooms";

                using (var command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string Item = reader["Room_Name"].ToString();

                            RoomList.Items.Add(Item);
                        }
                    }
                }
            }
        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedItem = ItemList.Text;
            if (DB.TryGetValue(selectedItem, out var itemData))
            {
                CountBox.Text = itemData.Count.ToString();
                DescriptionBox.Text = itemData.Description;
            };
        }

        private void CountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddTime()
        {
            for (int i = 1; i <= 2; i++)
            {
                Hours.Items.Add($"0{i}");
            }

            for (int i = 1; i <= 9; i++)
            {
                Minutes.Items.Add($"0{i}");
            }

            for (int i = 10; i <= 59; i++)
            {
                Minutes.Items.Add(i);
            }
        }

        private void DatePicker_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            DateTime today = DateTime.Today;

            if (selectedDate < today)
            {
                MessageBox.Show("Please select a future date only.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DatePicker.SetDate(today);
                DateTextHolder.Text = today.ToShortDateString();
            }

            else
            {
                DateTextHolder.Text = selectedDate.ToShortDateString();
            }
        }

        private void DateShower_Click(object sender, EventArgs e)
        {
            DatePicker.Show();
        }

        private void DateTextHolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RoomList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AmountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = int.Parse(AmountBox.Text);
                int availble = int.Parse(CountBox.Text);

                if (amount > availble | amount <= 0)
                {
                    MessageBox.Show("Not enough items or invalid amount", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //string dbPath = @"C:\Users\seth-mcnaughton\OneDrive - York College\Desktop\SchoolDate.db";
                //string connectionString = $"Data Source={dbPath};Version=3;";

                //using (var connection = new SQLiteConnection(connectionString))
                //{
                //    connection.Open();
                //    string query = "INSERT INTO users (User_Name, Password) VALUES (@userName, @password)";
                //    using (var command = new SQLiteCommand(query, connection))
                //    {
                //        command.Parameters.AddWithValue("@userName", userName);
                //        command.Parameters.AddWithValue("@password", password);
                //        command.ExecuteNonQuery();
                //    }
                //}



            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Hours_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hours = Hours.Text;
            string minutes = Minutes.Text;

            TimeShower.Text = $"{hours}:{minutes}";

        }

        private void Minutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hours = Hours.Text;
            string minutes = Minutes.Text;

            TimeShower.Text = $"{hours}:{minutes}";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
