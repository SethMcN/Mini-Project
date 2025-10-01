using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Mini_Project
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string passwd = PasswdBox.Text.Trim();
                string confirmPasswd = ConfirmPasswdBox.Text.Trim();

                // Check passwords match
                if (passwd != confirmPasswd)
                {
                    throw new Exception("Passwords don't match");
                }

                // Check username isnt in use
                string dbPath = @"C:\Users\seth-mcnaughton\OneDrive - York College\Desktop\SchoolDate.db";
                string connectionString = $"Data Source={dbPath};Version=3;";

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM users";

                    using (var command = new SQLiteCommand(query, connection))
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string UserName = reader["User_Name"].ToString();
                                string EnteredName = UserNameBox.Text.ToLower();
                                if (UserName == EnteredName)
                                {
                                    throw new Exception("Username already in use");
                                }
                            }
                        }
                    }
                }

                // Write to DB 
                using (var connection = new SQLiteConnection(connectionString))
                {
                    string userName = UserNameBox.Text.Trim();
                    string password = PasswdBox.Text.Trim();

                    connection.Open();
                    string query = "INSERT INTO users (User_Name, Password) VALUES (@userName, @password)";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userName", userName);
                        command.Parameters.AddWithValue("@password", password);
                        command.ExecuteNonQuery();
                    }
                }

                Login Login = new Login();
                Login.Show();
                this.Hide();

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
