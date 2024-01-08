namespace StokGirisProje
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            buttonadmin = new Button();
            buttongirisyap = new Button();
            textsifre = new TextBox();
            textkadi = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonadmin
            // 
            buttonadmin.BackColor = Color.FromArgb(0, 0, 192);
            buttonadmin.BackgroundImageLayout = ImageLayout.Zoom;
            buttonadmin.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonadmin.ForeColor = Color.White;
            buttonadmin.Location = new Point(259, 440);
            buttonadmin.Name = "buttonadmin";
            buttonadmin.Size = new Size(221, 54);
            buttonadmin.TabIndex = 24;
            buttonadmin.Text = "Admin Girişi";
            buttonadmin.UseVisualStyleBackColor = false;
            buttonadmin.Click += buttonadmin_Click;
            // 
            // buttongirisyap
            // 
            buttongirisyap.BackColor = Color.FromArgb(0, 0, 192);
            buttongirisyap.BackgroundImageLayout = ImageLayout.Zoom;
            buttongirisyap.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttongirisyap.ForeColor = Color.White;
            buttongirisyap.Location = new Point(259, 359);
            buttongirisyap.Name = "buttongirisyap";
            buttongirisyap.Size = new Size(218, 75);
            buttongirisyap.TabIndex = 23;
            buttongirisyap.Text = "Giriş Yap";
            buttongirisyap.UseVisualStyleBackColor = false;
            buttongirisyap.Click += buttongirisyap_Click;
            // 
            // textsifre
            // 
            textsifre.Cursor = Cursors.IBeam;
            textsifre.Location = new Point(259, 299);
            textsifre.Multiline = true;
            textsifre.Name = "textsifre";
            textsifre.Size = new Size(254, 34);
            textsifre.TabIndex = 22;
            // 
            // textkadi
            // 
            textkadi.Cursor = Cursors.IBeam;
            textkadi.Location = new Point(259, 189);
            textkadi.Multiline = true;
            textkadi.Name = "textkadi";
            textkadi.Size = new Size(240, 34);
            textkadi.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 135);
            panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(200, 35);
            label4.Name = "label4";
            label4.Size = new Size(459, 65);
            label4.TabIndex = 9;
            label4.Text = "STOK GİRİŞ SİSTEMİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(158, 288);
            label2.Name = "label2";
            label2.Size = new Size(85, 45);
            label2.TabIndex = 19;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 189);
            label1.Name = "label1";
            label1.Size = new Size(199, 45);
            label1.TabIndex = 18;
            label1.Text = "Kullanıcı Adı";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 534);
            Controls.Add(buttonadmin);
            Controls.Add(buttongirisyap);
            Controls.Add(textsifre);
            Controls.Add(textkadi);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonadmin;
        private Button buttongirisyap;
        private TextBox textsifre;
        private TextBox textkadi;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}
