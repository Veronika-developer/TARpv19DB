
namespace TARpv19DB
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.data_ = new System.Windows.Forms.DataGridView();
            this.nimiTXT = new System.Windows.Forms.TextBox();
            this.eesnimiTXT = new System.Windows.Forms.TextBox();
            this.nimiLBL = new System.Windows.Forms.Label();
            this.famLBL = new System.Windows.Forms.Label();
            this.fotoLBL = new System.Windows.Forms.Label();
            this.fotobox = new System.Windows.Forms.PictureBox();
            this.Insert_ = new System.Windows.Forms.Button();
            this.change_ = new System.Windows.Forms.Button();
            this.delete_ = new System.Windows.Forms.Button();
            this.add_foto_ = new System.Windows.Forms.Button();
            this.ryhmBox = new System.Windows.Forms.ComboBox();
            this.ryhmLBL = new System.Windows.Forms.Label();
            this.vali_ryhmBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailBtn = new System.Windows.Forms.Button();
            this.emailTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ageLBL = new System.Windows.Forms.Label();
            this.vanemad_check = new System.Windows.Forms.CheckBox();
            this.info_parents = new System.Windows.Forms.CheckBox();
            this.show_parents = new System.Windows.Forms.CheckBox();
            this.synniaeg_picker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.data_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotobox)).BeginInit();
            this.SuspendLayout();
            // 
            // data_
            // 
            this.data_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_.Location = new System.Drawing.Point(298, 52);
            this.data_.Name = "data_";
            this.data_.RowHeadersWidth = 51;
            this.data_.RowTemplate.Height = 24;
            this.data_.Size = new System.Drawing.Size(691, 653);
            this.data_.TabIndex = 0;
            this.data_.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data__RowHeaderMouseClick);
            // 
            // nimiTXT
            // 
            this.nimiTXT.Location = new System.Drawing.Point(26, 60);
            this.nimiTXT.Name = "nimiTXT";
            this.nimiTXT.Size = new System.Drawing.Size(223, 22);
            this.nimiTXT.TabIndex = 1;
            // 
            // eesnimiTXT
            // 
            this.eesnimiTXT.Location = new System.Drawing.Point(26, 105);
            this.eesnimiTXT.Name = "eesnimiTXT";
            this.eesnimiTXT.Size = new System.Drawing.Size(223, 22);
            this.eesnimiTXT.TabIndex = 3;
            // 
            // nimiLBL
            // 
            this.nimiLBL.AutoSize = true;
            this.nimiLBL.Location = new System.Drawing.Point(126, 40);
            this.nimiLBL.Name = "nimiLBL";
            this.nimiLBL.Size = new System.Drawing.Size(35, 17);
            this.nimiLBL.TabIndex = 4;
            this.nimiLBL.Text = "Имя";
            // 
            // famLBL
            // 
            this.famLBL.AutoSize = true;
            this.famLBL.Location = new System.Drawing.Point(106, 85);
            this.famLBL.Name = "famLBL";
            this.famLBL.Size = new System.Drawing.Size(70, 17);
            this.famLBL.TabIndex = 5;
            this.famLBL.Text = "Фамилия";
            // 
            // fotoLBL
            // 
            this.fotoLBL.AutoSize = true;
            this.fotoLBL.Location = new System.Drawing.Point(95, 267);
            this.fotoLBL.Name = "fotoLBL";
            this.fotoLBL.Size = new System.Drawing.Size(92, 17);
            this.fotoLBL.TabIndex = 6;
            this.fotoLBL.Text = "Фотография";
            // 
            // fotobox
            // 
            this.fotobox.Location = new System.Drawing.Point(29, 287);
            this.fotobox.Name = "fotobox";
            this.fotobox.Size = new System.Drawing.Size(223, 205);
            this.fotobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotobox.TabIndex = 7;
            this.fotobox.TabStop = false;
            // 
            // Insert_
            // 
            this.Insert_.Location = new System.Drawing.Point(26, 600);
            this.Insert_.Name = "Insert_";
            this.Insert_.Size = new System.Drawing.Size(100, 30);
            this.Insert_.TabIndex = 8;
            this.Insert_.Text = "Добавить";
            this.Insert_.UseVisualStyleBackColor = true;
            this.Insert_.Click += new System.EventHandler(this.Insert__Click);
            // 
            // change_
            // 
            this.change_.Location = new System.Drawing.Point(149, 600);
            this.change_.Name = "change_";
            this.change_.Size = new System.Drawing.Size(100, 30);
            this.change_.TabIndex = 9;
            this.change_.Text = "Изменить";
            this.change_.UseVisualStyleBackColor = true;
            this.change_.Click += new System.EventHandler(this.change__Click);
            // 
            // delete_
            // 
            this.delete_.Location = new System.Drawing.Point(87, 636);
            this.delete_.Name = "delete_";
            this.delete_.Size = new System.Drawing.Size(100, 30);
            this.delete_.TabIndex = 10;
            this.delete_.Text = "Удалить";
            this.delete_.UseVisualStyleBackColor = true;
            this.delete_.Click += new System.EventHandler(this.delete__Click);
            // 
            // add_foto_
            // 
            this.add_foto_.Location = new System.Drawing.Point(72, 498);
            this.add_foto_.Name = "add_foto_";
            this.add_foto_.Size = new System.Drawing.Size(134, 30);
            this.add_foto_.TabIndex = 11;
            this.add_foto_.Text = "Добавить файл";
            this.add_foto_.UseVisualStyleBackColor = true;
            this.add_foto_.Click += new System.EventHandler(this.add_foto__Click);
            // 
            // ryhmBox
            // 
            this.ryhmBox.FormattingEnabled = true;
            this.ryhmBox.Location = new System.Drawing.Point(26, 195);
            this.ryhmBox.Name = "ryhmBox";
            this.ryhmBox.Size = new System.Drawing.Size(223, 24);
            this.ryhmBox.TabIndex = 12;
            // 
            // ryhmLBL
            // 
            this.ryhmLBL.AutoSize = true;
            this.ryhmLBL.Location = new System.Drawing.Point(113, 175);
            this.ryhmLBL.Name = "ryhmLBL";
            this.ryhmLBL.Size = new System.Drawing.Size(55, 17);
            this.ryhmLBL.TabIndex = 13;
            this.ryhmLBL.Text = "Группа";
            // 
            // vali_ryhmBox
            // 
            this.vali_ryhmBox.FormattingEnabled = true;
            this.vali_ryhmBox.Location = new System.Drawing.Point(803, 15);
            this.vali_ryhmBox.Name = "vali_ryhmBox";
            this.vali_ryhmBox.Size = new System.Drawing.Size(145, 24);
            this.vali_ryhmBox.TabIndex = 14;
            this.vali_ryhmBox.SelectedIndexChanged += new System.EventHandler(this.vali_ryhmBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Выбрать группу:";
            // 
            // emailBtn
            // 
            this.emailBtn.Location = new System.Drawing.Point(26, 672);
            this.emailBtn.Name = "emailBtn";
            this.emailBtn.Size = new System.Drawing.Size(226, 33);
            this.emailBtn.TabIndex = 16;
            this.emailBtn.Text = "Отправка письма на почту";
            this.emailBtn.UseVisualStyleBackColor = true;
            this.emailBtn.Click += new System.EventHandler(this.emailBtn_Click);
            // 
            // emailTXT
            // 
            this.emailTXT.Location = new System.Drawing.Point(29, 150);
            this.emailTXT.Name = "emailTXT";
            this.emailTXT.Size = new System.Drawing.Size(223, 22);
            this.emailTXT.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Э-почта";
            // 
            // ageLBL
            // 
            this.ageLBL.AutoSize = true;
            this.ageLBL.Location = new System.Drawing.Point(84, 222);
            this.ageLBL.Name = "ageLBL";
            this.ageLBL.Size = new System.Drawing.Size(111, 17);
            this.ageLBL.TabIndex = 20;
            this.ageLBL.Text = "Дата рождения";
            // 
            // vanemad_check
            // 
            this.vanemad_check.AutoSize = true;
            this.vanemad_check.Location = new System.Drawing.Point(516, 17);
            this.vanemad_check.Name = "vanemad_check";
            this.vanemad_check.Size = new System.Drawing.Size(159, 21);
            this.vanemad_check.TabIndex = 21;
            this.vanemad_check.Text = "Родители учеников";
            this.vanemad_check.UseVisualStyleBackColor = true;
            this.vanemad_check.CheckedChanged += new System.EventHandler(this.vanemad_check_CheckedChanged);
            // 
            // info_parents
            // 
            this.info_parents.AutoSize = true;
            this.info_parents.Location = new System.Drawing.Point(12, 534);
            this.info_parents.Name = "info_parents";
            this.info_parents.Size = new System.Drawing.Size(260, 21);
            this.info_parents.TabIndex = 22;
            this.info_parents.Text = "Хранить информацию о родителях";
            this.info_parents.UseVisualStyleBackColor = true;
            // 
            // show_parents
            // 
            this.show_parents.AutoSize = true;
            this.show_parents.Location = new System.Drawing.Point(12, 561);
            this.show_parents.Name = "show_parents";
            this.show_parents.Size = new System.Drawing.Size(234, 21);
            this.show_parents.TabIndex = 23;
            this.show_parents.Text = "Показать родителя/родителей";
            this.show_parents.UseVisualStyleBackColor = true;
            this.show_parents.CheckedChanged += new System.EventHandler(this.show_parents_CheckedChanged);
            // 
            // synniaeg_picker
            // 
            this.synniaeg_picker.Location = new System.Drawing.Point(27, 242);
            this.synniaeg_picker.Name = "synniaeg_picker";
            this.synniaeg_picker.Size = new System.Drawing.Size(222, 22);
            this.synniaeg_picker.TabIndex = 24;
            this.synniaeg_picker.Value = new System.DateTime(2021, 1, 22, 13, 6, 27, 0);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 717);
            this.Controls.Add(this.synniaeg_picker);
            this.Controls.Add(this.show_parents);
            this.Controls.Add(this.info_parents);
            this.Controls.Add(this.vanemad_check);
            this.Controls.Add(this.ageLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTXT);
            this.Controls.Add(this.emailBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vali_ryhmBox);
            this.Controls.Add(this.ryhmLBL);
            this.Controls.Add(this.ryhmBox);
            this.Controls.Add(this.add_foto_);
            this.Controls.Add(this.delete_);
            this.Controls.Add(this.change_);
            this.Controls.Add(this.Insert_);
            this.Controls.Add(this.fotobox);
            this.Controls.Add(this.fotoLBL);
            this.Controls.Add(this.famLBL);
            this.Controls.Add(this.nimiLBL);
            this.Controls.Add(this.eesnimiTXT);
            this.Controls.Add(this.nimiTXT);
            this.Controls.Add(this.data_);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Информация об учениках TARpv19";
            ((System.ComponentModel.ISupportInitialize)(this.data_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotobox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_;
        private System.Windows.Forms.TextBox nimiTXT;
        private System.Windows.Forms.TextBox eesnimiTXT;
        private System.Windows.Forms.Label nimiLBL;
        private System.Windows.Forms.Label famLBL;
        private System.Windows.Forms.Label fotoLBL;
        private System.Windows.Forms.PictureBox fotobox;
        private System.Windows.Forms.Button Insert_;
        private System.Windows.Forms.Button change_;
        private System.Windows.Forms.Button delete_;
        private System.Windows.Forms.Button add_foto_;
        private System.Windows.Forms.ComboBox ryhmBox;
        private System.Windows.Forms.Label ryhmLBL;
        private System.Windows.Forms.ComboBox vali_ryhmBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button emailBtn;
        private System.Windows.Forms.TextBox emailTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ageLBL;
        private System.Windows.Forms.CheckBox vanemad_check;
        private System.Windows.Forms.CheckBox info_parents;
        private System.Windows.Forms.CheckBox show_parents;
        private System.Windows.Forms.DateTimePicker synniaeg_picker;
    }
}