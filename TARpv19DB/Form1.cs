using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TARpv19DB
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =C:\Users\morgo\source\repos\TARpv19DB\TARpv19DB\AppData\opilased.mdf; Integrated Security = True");
        SqlCommand command;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
        }

        private void avtorizatsiaBTN_Click(object sender, EventArgs e)
        {
            if(loginTXT.Text != "" && passTXT.Text != "")
            {
                string login_ = loginTXT.Text;
                string password_ = passTXT.Text;

                connect.Open();

                DataTable table = new DataTable();

                adapter = new SqlDataAdapter();

                command = new SqlCommand("SELECT * FROM avtorizatsia WHERE login = @log AND password = @pass", connect);
                
                command.Parameters.AddWithValue("@log", login_);
                command.Parameters.AddWithValue("@pass", password_);

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Вход не совершен");
                }

                connect.Close();
            }
        }
    }
}
