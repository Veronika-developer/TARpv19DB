
namespace TARpv19DB
{
    partial class emailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emailForm));
            this.topic_ = new System.Windows.Forms.TextBox();
            this.main_text = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.Send_Email = new System.Windows.Forms.Button();
            this.from_ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.files_lbl = new System.Windows.Forms.Label();
            this.Send_to_parents = new System.Windows.Forms.CheckBox();
            this.to_ = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // topic_
            // 
            this.topic_.Location = new System.Drawing.Point(92, 145);
            this.topic_.Name = "topic_";
            this.topic_.Size = new System.Drawing.Size(220, 22);
            this.topic_.TabIndex = 1;
            // 
            // main_text
            // 
            this.main_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_text.Location = new System.Drawing.Point(26, 196);
            this.main_text.Name = "main_text";
            this.main_text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.main_text.Size = new System.Drawing.Size(612, 376);
            this.main_text.TabIndex = 2;
            this.main_text.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Кому:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тема:";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(26, 578);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(116, 43);
            this.btnFile.TabIndex = 6;
            this.btnFile.Text = "Приложить файл";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // Send_Email
            // 
            this.Send_Email.Location = new System.Drawing.Point(522, 627);
            this.Send_Email.Name = "Send_Email";
            this.Send_Email.Size = new System.Drawing.Size(116, 43);
            this.Send_Email.TabIndex = 8;
            this.Send_Email.Text = "Отправить";
            this.Send_Email.UseVisualStyleBackColor = true;
            this.Send_Email.Click += new System.EventHandler(this.Send_Email_Click);
            // 
            // from_
            // 
            this.from_.Location = new System.Drawing.Point(92, 63);
            this.from_.Name = "from_";
            this.from_.Size = new System.Drawing.Size(220, 22);
            this.from_.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "От кого:";
            // 
            // files_lbl
            // 
            this.files_lbl.AutoSize = true;
            this.files_lbl.Location = new System.Drawing.Point(23, 627);
            this.files_lbl.Name = "files_lbl";
            this.files_lbl.Size = new System.Drawing.Size(20, 17);
            this.files_lbl.TabIndex = 11;
            this.files_lbl.Text = "...";
            // 
            // Send_to_parents
            // 
            this.Send_to_parents.AutoSize = true;
            this.Send_to_parents.Location = new System.Drawing.Point(483, 144);
            this.Send_to_parents.Name = "Send_to_parents";
            this.Send_to_parents.Size = new System.Drawing.Size(169, 21);
            this.Send_to_parents.TabIndex = 13;
            this.Send_to_parents.Text = "Написать родителям";
            this.Send_to_parents.UseVisualStyleBackColor = true;
            this.Send_to_parents.CheckedChanged += new System.EventHandler(this.Send_to_parents_CheckedChanged);
            // 
            // to_
            // 
            this.to_.FormattingEnabled = true;
            this.to_.Location = new System.Drawing.Point(92, 105);
            this.to_.Name = "to_";
            this.to_.Size = new System.Drawing.Size(220, 24);
            this.to_.TabIndex = 12;
            // 
            // emailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 682);
            this.Controls.Add(this.Send_to_parents);
            this.Controls.Add(this.to_);
            this.Controls.Add(this.files_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.from_);
            this.Controls.Add(this.Send_Email);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.main_text);
            this.Controls.Add(this.topic_);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "emailForm";
            this.Text = "Отправка письма на э-почту";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox topic_;
        private System.Windows.Forms.RichTextBox main_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button Send_Email;
        private System.Windows.Forms.TextBox from_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label files_lbl;
        private System.Windows.Forms.CheckBox Send_to_parents;
        private System.Windows.Forms.ComboBox to_;
    }
}