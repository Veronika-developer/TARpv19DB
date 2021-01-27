using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TARpv19DB
{
    public partial class emailForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =C:\Users\morgo\source\repos\TARpv19DB\TARpv19DB\AppData\opilased.mdf; Integrated Security = True");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;
        OpenFileDialog open;
        public string email_address;
        List<string> avaldused, opilased;
        string name;
        public emailForm(string email_address)
        {
            InitializeComponent();
            avaldused = new List<string>();
            show_email();
            this.email_address = email_address;
            if(email_address != "")
            {
                to_.Text = email_address;
            }
        }

        private void Send_Email_Click(object sender, EventArgs e)
        {
            if(from_.Text != "" && to_.Text != "" && topic_.Text != "" && main_text.Text != "")
            {
                if(IsValidEmail(from_.Text) == true && IsValidEmail(to_.Text) == true)
                {
                    try
                    {
                        MailMessage mail = new MailMessage(); //использовать можно не только этот плагин для отправления письма

                        //string password = Interaction.InputBox("Sisesta salasõna", "Salasõna", "12345");

                        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                        {
                            Port = 587,
                            Credentials = new System.Net.NetworkCredential("veronika.jefimova03@gmail.com", "v140220033"), // почта и пароль отправителя
                            EnableSsl = true
                        };

                        mail.From = new MailAddress(from_.Text);
                        mail.To.Add(to_.Text);//адресат
                        mail.Subject = topic_.Text;//тема письма
                        mail.Body = main_text.Text; //тело письма
                        foreach (var item in avaldused) //заявления
                        {
                            mail.Attachments.Add(new Attachment(item));
                        }
                        smtpClient.Send(mail);
                        MessageBox.Show("Письмо отправлено");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка");
                    }
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.ShowDialog();

            foreach(string filePath in open.FileNames)
            {
                if (File.Exists(filePath))
                {
                    avaldused.Add(filePath);
                    name = Path.GetFileName(filePath);
                    files_lbl.Text = name;
                }
            }
        }

        private void Send_to_parents_CheckedChanged(object sender, EventArgs e)
        {
            if(Send_to_parents.Checked == true)
            {
                to_.Items.Clear();
                connect.Open();
                table = new DataTable();
                adapter = new SqlDataAdapter("SELECT email FROM Parents", connect);
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    to_.Items.Add(row["email"]);
                }
                connect.Close();
            }
            else
            {
                show_email();
            }
        }

        private void show_email()
        {
            to_.Items.Clear();
            connect.Open();
            table = new DataTable();
            adapter = new SqlDataAdapter("SELECT email FROM students", connect);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                to_.Items.Add(row["email"]);
            }
            connect.Close();
        }
    }
}
