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
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =C:\Users\morgo\source\repos\TARpv19DB\TARpv19DB\AppData\opilased.mdf; Integrated Security = True");
        private SqlCommand command,command1;
        private SqlDataAdapter adapter, adapter2, adapter3;
        public string email_address = "";
        emailForm email;
        private int Id = 0;
        public MainForm()
        {
            InitializeComponent();
            info_parents.Hide();
            change_.Hide();
            delete_.Hide();
            show_parents.Hide();
            DisplayData();
            vali_ryhmBox.SelectedItem = "Все";
        }

        private void DisplayData()
        {
            ryhmBox.Items.Clear();
            vali_ryhmBox.Items.Clear();
            vali_ryhmBox.Items.Add("Все");

            if (vanemad_check.Checked == true)
            {
                connect.Open();

                DataTable table = new DataTable();
                adapter = new SqlDataAdapter("SELECT * FROM Parents", connect);
                adapter.Fill(table);
                data_.DataSource = table;

                adapter2 = new SqlDataAdapter("SELECT nimi + eesnimi as dataStudent FROM students ", connect);
                DataTable R_table = new DataTable();
                adapter2.Fill(R_table);
                foreach (DataRow row in R_table.Rows)
                {
                    ryhmBox.Items.Add(row["dataStudent"]);
                }

                connect.Close();
            }
            else
            {
                connect.Open();

                DataTable table = new DataTable();
                adapter = new SqlDataAdapter("SELECT nimi, eesnimi FROM students", connect);
                adapter.Fill(table);
                data_.DataSource = table;

                adapter2 = new SqlDataAdapter("SELECT ryhma FROM ryhmad", connect);
                DataTable R_table = new DataTable();
                adapter2.Fill(R_table);
                foreach (DataRow row in R_table.Rows)
                {
                    ryhmBox.Items.Add(row["ryhma"]);
                    vali_ryhmBox.Items.Add(row["ryhma"]);
                }

                connect.Close();
                fotobox.Image = Image.FromFile("../../images/nikto.jpg");
            }
        }

        private void ClearData()
        {
            Id = 0;
            nimiTXT.Text = "";
            eesnimiTXT.Text = "";
            emailTXT.Text = "";
            synniaeg_picker.Text = "";
            ryhmBox.SelectedIndex = 0;
            fotobox.Image = Image.FromFile("../../images/nikto.jpg");

        }

        private void Insert__Click(object sender, System.EventArgs e)
        {
            if (nimiTXT.Text != "" && eesnimiTXT.Text != "" && emailTXT.Text != "")
            {
                if(vanemad_check.Checked == true)
                {
                    command = new SqlCommand("insert into Parents(name,surname,student, email) values(@n,@sur,@s,@em)", connect);
                    connect.Open();
                    command.Parameters.AddWithValue("@n", nimiTXT.Text);
                    command.Parameters.AddWithValue("@sur", eesnimiTXT.Text);
                    command.Parameters.AddWithValue("@s", (ryhmBox.SelectedIndex + 1));
                    command.Parameters.AddWithValue("@em", emailTXT.Text);
                    command.ExecuteNonQuery();
                    connect.Close();
                    ClearData();
                    DisplayData();
                    MessageBox.Show("Данные добавлены");
                }
                else
                {
                    command = new SqlCommand("insert into students(nimi,eesnimi,foto,ryhm,email,vanus,vanemad) values(@n,@ees,@f,@r,@e,@v,@vane)", connect);
                    connect.Open();
                    command.Parameters.AddWithValue("@n", nimiTXT.Text);
                    command.Parameters.AddWithValue("@ees", eesnimiTXT.Text);
                    string file_pilt = nimiTXT.Text + ".jpg";
                    command.Parameters.AddWithValue("@f", file_pilt);
                    command.Parameters.AddWithValue("@r", (ryhmBox.SelectedIndex + 1));
                    command.Parameters.AddWithValue("@e", emailTXT.Text);
                    var dateTime = DateTime.Parse(synniaeg_picker.Text);
                    command.Parameters.AddWithValue("@v", dateTime);
                    command.Parameters.AddWithValue("@vane", 1);
                    command.ExecuteNonQuery();
                    connect.Close();
                    ClearData();
                    DisplayData();
                    MessageBox.Show("Данные добавлены");
                }
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void data__RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (vanemad_check.Checked == true)
            {
                Id = Convert.ToInt32(data_.Rows[e.RowIndex].Cells[0].Value.ToString());
                nimiTXT.Text = data_.Rows[e.RowIndex].Cells[1].Value.ToString();
                eesnimiTXT.Text = data_.Rows[e.RowIndex].Cells[2].Value.ToString();
                string v = data_.Rows[e.RowIndex].Cells[3].Value.ToString();
                ryhmBox.SelectedIndex = Int32.Parse(v) - 1;
                emailTXT.Text = data_.Rows[e.RowIndex].Cells[4].Value.ToString();
                change_.Show();
                delete_.Show();
                email_address = data_.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            else
            {
                Id = Convert.ToInt32(data_.Rows[e.RowIndex].Cells[0].Value.ToString());
                nimiTXT.Text = data_.Rows[e.RowIndex].Cells[1].Value.ToString();
                eesnimiTXT.Text = data_.Rows[e.RowIndex].Cells[2].Value.ToString();
                fotobox.Image = Image.FromFile(@"C:\Users\morgo\source\repos\TARpv19DB\TARpv19DB\Images\" + data_.Rows[e.RowIndex].Cells[3].Value.ToString());
                string v = data_.Rows[e.RowIndex].Cells[4].Value.ToString();
                ryhmBox.SelectedIndex = Int32.Parse(v)-1;
                emailTXT.Text = data_.Rows[e.RowIndex].Cells[5].Value.ToString();
                synniaeg_picker.Text = data_.Rows[e.RowIndex].Cells[6].Value.ToString();
                string da_net = data_.Rows[e.RowIndex].Cells[7].Value.ToString();

                DateTime Today = DateTime.Today;

                DateTime Birthday = (DateTime)data_.Rows[e.RowIndex].Cells[6].Value;

                int age = Today.Year - Birthday.Year;
                if (age >= 18)
                {
                    info_parents.Show();
                    if (da_net == "1")
                        info_parents.Checked = true;
                    else
                        info_parents.Checked = false;
                }
                else
                {
                    info_parents.Hide();
                    info_parents.Checked = true;
                }

                change_.Show();
                show_parents.Show();
                delete_.Show();

                email_address = data_.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
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
                connect.Open();

                if (vanemad_check.Checked == true)
                {
                    command = new SqlCommand("DELETE Parents WHERE Id=@id", connect);
                }
                else
                {
                    command = new SqlCommand("DELETE students WHERE Id=@id", connect);
                }
                
                command.Parameters.AddWithValue("@id", Id);

                command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
                ClearData();

                MessageBox.Show("Запись удалена");

            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void vali_ryhmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(vali_ryhmBox.SelectedItem == "Все")
            {
                DisplayData();
            }
            else
            {
                connect.Open();

                DataTable table = new DataTable();

                adapter = new SqlDataAdapter();

                command = new SqlCommand("SELECT * FROM students WHERE ryhm=@r", connect);
                command.Parameters.AddWithValue("@r", vali_ryhmBox.SelectedIndex);

                adapter.SelectCommand = command;

                adapter.Fill(table);
                data_.DataSource = table;

                connect.Close();
            }
        }

        private void show_parents_CheckedChanged(object sender, EventArgs e)
        {
            if(show_parents.Checked == true)
            {
                connect.Open();

                DataTable table = new DataTable();
                adapter = new SqlDataAdapter();
                command = new SqlCommand("SELECT name,surname FROM Parents WHERE student=@id", connect);
                command.Parameters.AddWithValue("@id", Id);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                data_.DataSource = table;

                connect.Close();
            }
            else
            {
                DisplayData();
            }
        }

        private void vanemad_check_CheckedChanged(object sender, EventArgs e)
        {
            if(vanemad_check.Checked == true)
            {
                ageLBL.Hide();
                synniaeg_picker.Hide();
                fotoLBL.Hide();
                fotobox.Hide();
                add_foto_.Hide();
                vali_ryhmBox.Hide();
                label1.Hide();
                info_parents.Hide();
                ryhmLBL.Text = "Ученик:";
                DisplayData();
            }
            else
            {
                ageLBL.Show();
                synniaeg_picker.Show();
                fotoLBL.Show();
                fotobox.Show();
                add_foto_.Show();
                vali_ryhmBox.Show();
                label1.Show();
                info_parents.Show();
                ryhmLBL.Text = "Группа:";
                DisplayData();
            }
        }

        private void emailBtn_Click(object sender, EventArgs e)
        {
            email = new emailForm(email_address);
            email.ShowDialog();
        }

        private void change__Click(object sender, EventArgs e)
        {
            if (nimiTXT.Text != "" && eesnimiTXT.Text != "")
            {
                if(vanemad_check.Checked == true)
                {
                    command = new SqlCommand("UPDATE Parents SET name=@n,surname=@s,student=@st,email=@e WHERE Id=@id", connect);
                    connect.Open();
                    command.Parameters.AddWithValue("@id", Id);
                    command.Parameters.AddWithValue("@n", nimiTXT.Text);
                    command.Parameters.AddWithValue("@s", eesnimiTXT.Text);
                    command.Parameters.AddWithValue("@st", (ryhmBox.SelectedIndex + 1));
                    command.Parameters.AddWithValue("@e", emailTXT.Text);
                    command.ExecuteNonQuery();
                    connect.Close();
                    ClearData();
                    DisplayData();
                    MessageBox.Show("Данные изменены");
                }
                else
                {
                    command = new SqlCommand("UPDATE students SET nimi=@n,eesnimi=@ees,foto=@f,ryhm=@r, email=@e,vanus=@v, vanemad=@van WHERE Id=@id", connect);
                    connect.Open();
                    command.Parameters.AddWithValue("@id", Id);
                    command.Parameters.AddWithValue("@n", nimiTXT.Text);
                    command.Parameters.AddWithValue("@ees", eesnimiTXT.Text);
                    string file_pilt = fotobox.Image.ToString();
                    command.Parameters.AddWithValue("@f", file_pilt);
                    command.Parameters.AddWithValue("@r", (ryhmBox.SelectedIndex + 1));
                    command.Parameters.AddWithValue("@e", emailTXT.Text);
                    var dateTime = DateTime.Parse(synniaeg_picker.Text);
                    command.Parameters.AddWithValue("@v", dateTime);
                    if (info_parents.Checked == true)
                        command.Parameters.AddWithValue("@van", 1);
                    else
                    {
                        DialogResult result = MessageBox.Show(
                            "Родители этого ученика будут удалены. Вы уверены?",
                            "Сообщение",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        if (result == DialogResult.Yes)
                        {
                            command.Parameters.AddWithValue("@van", 2);
                            command1 = new SqlCommand("DELETE Parents WHERE student=@id", connect);
                            command1.Parameters.AddWithValue("@id", Id);
                            command1.ExecuteNonQuery();
                        }
                        else
                            command.Parameters.AddWithValue("@van", 1);
                    }
                        
                    command.ExecuteNonQuery();
                    connect.Close();
                    ClearData();
                    DisplayData();
                    MessageBox.Show("Данные изменены");
                }

            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
