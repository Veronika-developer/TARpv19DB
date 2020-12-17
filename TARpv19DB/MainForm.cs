using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TARpv19DB
{
    public partial class MainForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\opilased.mdf; Integrated Security = True");
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private int Id = 0;
        public MainForm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            connect.Open();
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM students", connect);
            adapter.Fill(table);
            data_.DataSource = table;
            connect.Close();
            fotobox.Image = Image.FromFile("../../images/nikto.jpg");
        }

        private void ClearData()
        {
            Id = 0;
            nimiTXT.Text = "";
            eesnimiTXT.Text = "";
            fotobox.Image = Image.FromFile("../../images/nikto.jpg");

        }

        private void Insert__Click(object sender, System.EventArgs e)
        {
            if (nimiTXT.Text != "" && eesnimiTXT.Text != "")
            {
                command = new SqlCommand("insert into students(nimi,eesnimi,foto) values(@n,@ees,@f)", connect);
                connect.Open();
                command.Parameters.AddWithValue("@n", nimiTXT.Text);
                command.Parameters.AddWithValue("@ees", eesnimiTXT.Text);
                string file_pilt = nimiTXT.Text + ".jpg";
                command.Parameters.AddWithValue("@f", file_pilt);
                command.ExecuteNonQuery();
                connect.Close();
                ClearData();
                DisplayData();
                MessageBox.Show("Данные добавлены");

            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void data__RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(data_.Rows[e.RowIndex].Cells[0].Value.ToString());
            nimiTXT.Text = data_.Rows[e.RowIndex].Cells[1].Value.ToString();
            eesnimiTXT.Text = data_.Rows[e.RowIndex].Cells[2].Value.ToString();
            fotobox.Image = Image.FromFile(@"C:\Users\morgo\source\repos\TARpv19DB\TARpv19DB\Images\" + data_.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void add_foto__Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = nimiTXT.Text + ".jpg";
            save.Filter = "Image Files (*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            save.InitialDirectory = Path.GetFullPath(@"C:\Users\morgo\source\repos\TARpv19DB\TARpv19DB\Images");
            if (save.ShowDialog() == DialogResult.OK)
            {
                save.RestoreDirectory = true;
                fotobox.Image = Image.FromFile(save.FileName);
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void delete__Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                command = new SqlCommand("DELETE students WHERE Id=@id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);

                command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
                ClearData();

                MessageBox.Show("Данные добавлены");

            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void change__Click(object sender, EventArgs e)
        {
            if (nimiTXT.Text != "" && eesnimiTXT.Text != "")
            {
                command = new SqlCommand("UPDATE students SET nimi=@n,eesnimi=@ees,foto=@f WHERE Id=@id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@n", nimiTXT.Text);
                command.Parameters.AddWithValue("@ees", eesnimiTXT.Text);
                string file_pilt = fotobox.Image.ToString();
                command.Parameters.AddWithValue("@f", file_pilt);
                command.ExecuteNonQuery();
                connect.Close();
                ClearData();
                DisplayData();
                MessageBox.Show("Данные изменены");

            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
