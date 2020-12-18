
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fotobox = new System.Windows.Forms.PictureBox();
            this.Insert_ = new System.Windows.Forms.Button();
            this.change_ = new System.Windows.Forms.Button();
            this.delete_ = new System.Windows.Forms.Button();
            this.add_foto_ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotobox)).BeginInit();
            this.SuspendLayout();
            // 
            // data_
            // 
            this.data_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_.Location = new System.Drawing.Point(283, 12);
            this.data_.Name = "data_";
            this.data_.RowHeadersWidth = 51;
            this.data_.RowTemplate.Height = 24;
            this.data_.Size = new System.Drawing.Size(670, 640);
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
            this.eesnimiTXT.Location = new System.Drawing.Point(26, 128);
            this.eesnimiTXT.Name = "eesnimiTXT";
            this.eesnimiTXT.Size = new System.Drawing.Size(223, 22);
            this.eesnimiTXT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Фотография";
            // 
            // fotobox
            // 
            this.fotobox.Location = new System.Drawing.Point(12, 199);
            this.fotobox.Name = "fotobox";
            this.fotobox.Size = new System.Drawing.Size(246, 237);
            this.fotobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotobox.TabIndex = 7;
            this.fotobox.TabStop = false;
            // 
            // Insert_
            // 
            this.Insert_.Location = new System.Drawing.Point(26, 503);
            this.Insert_.Name = "Insert_";
            this.Insert_.Size = new System.Drawing.Size(100, 30);
            this.Insert_.TabIndex = 8;
            this.Insert_.Text = "Добавить";
            this.Insert_.UseVisualStyleBackColor = true;
            this.Insert_.Click += new System.EventHandler(this.Insert__Click);
            // 
            // change_
            // 
            this.change_.Location = new System.Drawing.Point(149, 503);
            this.change_.Name = "change_";
            this.change_.Size = new System.Drawing.Size(100, 30);
            this.change_.TabIndex = 9;
            this.change_.Text = "Изменить";
            this.change_.UseVisualStyleBackColor = true;
            this.change_.Click += new System.EventHandler(this.change__Click);
            // 
            // delete_
            // 
            this.delete_.Location = new System.Drawing.Point(87, 550);
            this.delete_.Name = "delete_";
            this.delete_.Size = new System.Drawing.Size(100, 30);
            this.delete_.TabIndex = 10;
            this.delete_.Text = "Удалить";
            this.delete_.UseVisualStyleBackColor = true;
            this.delete_.Click += new System.EventHandler(this.delete__Click);
            // 
            // add_foto_
            // 
            this.add_foto_.Location = new System.Drawing.Point(70, 442);
            this.add_foto_.Name = "add_foto_";
            this.add_foto_.Size = new System.Drawing.Size(134, 30);
            this.add_foto_.TabIndex = 11;
            this.add_foto_.Text = "Добавить файл";
            this.add_foto_.UseVisualStyleBackColor = true;
            this.add_foto_.Click += new System.EventHandler(this.add_foto__Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 664);
            this.Controls.Add(this.add_foto_);
            this.Controls.Add(this.delete_);
            this.Controls.Add(this.change_);
            this.Controls.Add(this.Insert_);
            this.Controls.Add(this.fotobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox fotobox;
        private System.Windows.Forms.Button Insert_;
        private System.Windows.Forms.Button change_;
        private System.Windows.Forms.Button delete_;
        private System.Windows.Forms.Button add_foto_;
    }
}