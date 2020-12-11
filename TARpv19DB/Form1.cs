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
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\opilased.mdf; Integrated Security = True");
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
        }

        private void avtorizatsiaBTN_Click(object sender, EventArgs e)
        {
            if(loginTXT.Text != "" && passTXT.Text != "")
            {
                connect.Open();
                command = new SqlCommand("SELECT * FROM avtorizatsia WHERE login=@log,password=@pass", connect);
                command.Parameters.AddWithValue("@log",loginTXT);
                command.Parameters.AddWithValue("@pass", passTXT);

                connect.Close();
            }
        }
    }
}
