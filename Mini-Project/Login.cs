using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Mini_Project
{

    public partial class Login : Form
    {
        public int wrong = 0;
        public Dictionary<string, string> DB = new Dictionary<string, string>();

        public Login()
        {
            InitializeComponent();
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
                            string Passwd = reader["Password"].ToString();

                            UserList.Items.Add(UserName);
                            DB.Add(UserName, Passwd);
                        }
                    }
                }
            }

        }

        private void UserList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            string Passwd = PasswdBox.Text;
            string User = UserList.Text;

            if (DB[User] == Passwd)
            {
                Form1 F1 = new Form1();
                F1.Show();
                this.Hide();
            } else 
            {
                wrong++;
            }

            if (wrong == 3)
            {
                MessageBox.Show("3 incorrect attempts, this program will now close");
                this.Hide();
            }
        }

        private void PasswdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }
    }
    public class SharedData
    {
        public static bool SignedIn = false;
    }
}
