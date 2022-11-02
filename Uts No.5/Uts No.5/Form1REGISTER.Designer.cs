namespace Uts_No._5
{
    partial class Form1REGISTER
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRegistrasi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtKonfirmasiPassword = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(252, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jawaban UTS No.5";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Konfirmasi Password";
            // 
            // BtnRegistrasi
            // 
            this.BtnRegistrasi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnRegistrasi.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRegistrasi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRegistrasi.Location = new System.Drawing.Point(428, 147);
            this.BtnRegistrasi.Name = "BtnRegistrasi";
            this.BtnRegistrasi.Size = new System.Drawing.Size(75, 31);
            this.BtnRegistrasi.TabIndex = 4;
            this.BtnRegistrasi.Text = "Registrasi";
            this.BtnRegistrasi.UseVisualStyleBackColor = false;
            this.BtnRegistrasi.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.TxtKonfirmasiPassword);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.BtnRegistrasi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 218);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // TxtKonfirmasiPassword
            // 
            this.TxtKonfirmasiPassword.Location = new System.Drawing.Point(230, 120);
            this.TxtKonfirmasiPassword.Name = "TxtKonfirmasiPassword";
            this.TxtKonfirmasiPassword.PasswordChar = '*';
            this.TxtKonfirmasiPassword.Size = new System.Drawing.Size(273, 21);
            this.TxtKonfirmasiPassword.TabIndex = 7;
            this.TxtKonfirmasiPassword.UseSystemPasswordChar = true;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(230, 89);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(273, 21);
            this.TxtPassword.TabIndex = 6;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtEmail
            // 
            this.TxtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtEmail.Location = new System.Drawing.Point(230, 61);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(273, 21);
            this.TxtEmail.TabIndex = 5;
            this.TxtEmail.TextChanged += new System.EventHandler(this.emai_TextChanged);
            // 
            // Form1REGISTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(693, 244);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1REGISTER";
            this.Text = "PEMROGRAMAN PLATFORM KHUSUS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnRegistrasi;
        private GroupBox groupBox1;
        private TextBox TxtEmail;
        private TextBox TxtKonfirmasiPassword;
        private TextBox TxtPassword;
    }
}