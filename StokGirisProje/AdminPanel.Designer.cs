namespace StokGirisProje
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            panel1 = new Panel();
            linkLabelgeri = new LinkLabel();
            buttonadmin = new Button();
            pictureBox3 = new PictureBox();
            buttonanasayfa = new Button();
            pictureBox6 = new PictureBox();
            labellogout = new LinkLabel();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonaddproduct = new Button();
            buttonorders = new Button();
            buttoncategories = new Button();
            buttoncustomer = new Button();
            groupBox1 = new GroupBox();
            buttonsil = new Button();
            buttonkaydet = new Button();
            txtsifre = new TextBox();
            txtkullaniciadi = new TextBox();
            label3 = new Label();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridViewpersonel = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewpersonel).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(linkLabelgeri);
            panel1.Controls.Add(buttonadmin);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(buttonanasayfa);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(labellogout);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(buttonaddproduct);
            panel1.Controls.Add(buttonorders);
            panel1.Controls.Add(buttoncategories);
            panel1.Controls.Add(buttoncustomer);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 740);
            panel1.TabIndex = 51;
            // 
            // linkLabelgeri
            // 
            linkLabelgeri.AutoSize = true;
            linkLabelgeri.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabelgeri.ForeColor = Color.White;
            linkLabelgeri.LinkColor = Color.White;
            linkLabelgeri.Location = new Point(12, 686);
            linkLabelgeri.Name = "linkLabelgeri";
            linkLabelgeri.Size = new Size(88, 25);
            linkLabelgeri.TabIndex = 30;
            linkLabelgeri.TabStop = true;
            linkLabelgeri.Text = "Geri Dön";
            linkLabelgeri.LinkClicked += linkLabelgeri_LinkClicked;
            // 
            // buttonadmin
            // 
            buttonadmin.BackColor = Color.Red;
            buttonadmin.FlatAppearance.BorderColor = Color.Red;
            buttonadmin.Font = new Font("Segoe UI Semibold", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonadmin.ForeColor = Color.White;
            buttonadmin.Location = new Point(12, 612);
            buttonadmin.Name = "buttonadmin";
            buttonadmin.Size = new Size(238, 60);
            buttonadmin.TabIndex = 29;
            buttonadmin.Text = "Admin Panel";
            buttonadmin.UseVisualStyleBackColor = false;
            buttonadmin.Click += buttonadmin_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 165);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // buttonanasayfa
            // 
            buttonanasayfa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonanasayfa.BackColor = Color.Red;
            buttonanasayfa.FlatAppearance.BorderColor = Color.Red;
            buttonanasayfa.Font = new Font("Segoe UI Semibold", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonanasayfa.ForeColor = Color.White;
            buttonanasayfa.Location = new Point(96, 165);
            buttonanasayfa.Name = "buttonanasayfa";
            buttonanasayfa.Size = new Size(154, 60);
            buttonanasayfa.TabIndex = 27;
            buttonanasayfa.Text = "Ana Sayfa";
            buttonanasayfa.UseVisualStyleBackColor = false;
            buttonanasayfa.Click += buttonanasayfa_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 253);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(70, 60);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 26;
            pictureBox6.TabStop = false;
            // 
            // labellogout
            // 
            labellogout.AutoSize = true;
            labellogout.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labellogout.ForeColor = Color.White;
            labellogout.LinkColor = Color.White;
            labellogout.Location = new Point(163, 686);
            labellogout.Name = "labellogout";
            labellogout.Size = new Size(87, 25);
            labellogout.TabIndex = 1;
            labellogout.TabStop = true;
            labellogout.Text = "Çıkış Yap";
            labellogout.LinkClicked += labellogout_LinkClicked;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 525);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 60);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(132, 26);
            label1.Name = "label1";
            label1.Size = new Size(118, 126);
            label1.TabIndex = 1;
            label1.Text = "Stok\r\nGiriş\r\nSistemi\r\n";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 337);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(70, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 430);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // buttonaddproduct
            // 
            buttonaddproduct.BackColor = Color.Red;
            buttonaddproduct.FlatAppearance.BorderColor = Color.Red;
            buttonaddproduct.Font = new Font("Segoe UI Semibold", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonaddproduct.ForeColor = Color.White;
            buttonaddproduct.Location = new Point(96, 337);
            buttonaddproduct.Name = "buttonaddproduct";
            buttonaddproduct.Size = new Size(154, 60);
            buttonaddproduct.TabIndex = 22;
            buttonaddproduct.Text = "Ürün ekle";
            buttonaddproduct.UseVisualStyleBackColor = false;
            buttonaddproduct.Click += buttonaddproduct_Click;
            // 
            // buttonorders
            // 
            buttonorders.BackColor = Color.Red;
            buttonorders.FlatAppearance.BorderColor = Color.Red;
            buttonorders.Font = new Font("Segoe UI Semibold", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonorders.ForeColor = Color.White;
            buttonorders.Location = new Point(96, 430);
            buttonorders.Name = "buttonorders";
            buttonorders.Size = new Size(154, 60);
            buttonorders.TabIndex = 23;
            buttonorders.Text = "Siparişler";
            buttonorders.UseVisualStyleBackColor = false;
            buttonorders.Click += buttonorders_Click;
            // 
            // buttoncategories
            // 
            buttoncategories.BackColor = Color.Red;
            buttoncategories.FlatAppearance.BorderColor = Color.Red;
            buttoncategories.Font = new Font("Segoe UI Semibold", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttoncategories.ForeColor = Color.White;
            buttoncategories.Location = new Point(96, 253);
            buttoncategories.Name = "buttoncategories";
            buttoncategories.Size = new Size(154, 60);
            buttoncategories.TabIndex = 20;
            buttoncategories.Text = "Tedarikçiler";
            buttoncategories.UseVisualStyleBackColor = false;
            buttoncategories.Click += buttoncategories_Click;
            // 
            // buttoncustomer
            // 
            buttoncustomer.BackColor = Color.Red;
            buttoncustomer.FlatAppearance.BorderColor = Color.Red;
            buttoncustomer.Font = new Font("Segoe UI Semibold", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttoncustomer.ForeColor = Color.White;
            buttoncustomer.Location = new Point(96, 525);
            buttoncustomer.Name = "buttoncustomer";
            buttoncustomer.Size = new Size(154, 60);
            buttoncustomer.TabIndex = 21;
            buttoncustomer.Text = "Müşteriler";
            buttoncustomer.UseVisualStyleBackColor = false;
            buttoncustomer.Click += buttoncustomer_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonShadow;
            groupBox1.Controls.Add(buttonsil);
            groupBox1.Controls.Add(buttonkaydet);
            groupBox1.Controls.Add(txtsifre);
            groupBox1.Controls.Add(txtkullaniciadi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(329, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 273);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel  Ekleme";
            // 
            // buttonsil
            // 
            buttonsil.BackColor = Color.Blue;
            buttonsil.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonsil.ForeColor = Color.White;
            buttonsil.Location = new Point(100, 223);
            buttonsil.Name = "buttonsil";
            buttonsil.Size = new Size(130, 44);
            buttonsil.TabIndex = 69;
            buttonsil.Text = "Sil";
            buttonsil.UseVisualStyleBackColor = false;
            buttonsil.Click += buttonsil_Click;
            // 
            // buttonkaydet
            // 
            buttonkaydet.BackColor = Color.Blue;
            buttonkaydet.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonkaydet.ForeColor = Color.White;
            buttonkaydet.Location = new Point(100, 166);
            buttonkaydet.Name = "buttonkaydet";
            buttonkaydet.Size = new Size(130, 44);
            buttonkaydet.TabIndex = 68;
            buttonkaydet.Text = "Kaydet";
            buttonkaydet.UseVisualStyleBackColor = false;
            buttonkaydet.Click += buttonkaydet_Click;
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(139, 107);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(171, 23);
            txtsifre.TabIndex = 3;
            // 
            // txtkullaniciadi
            // 
            txtkullaniciadi.Location = new Point(139, 54);
            txtkullaniciadi.Name = "txtkullaniciadi";
            txtkullaniciadi.Size = new Size(171, 23);
            txtkullaniciadi.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(79, 100);
            label3.Name = "label3";
            label3.Size = new Size(54, 30);
            label3.TabIndex = 1;
            label3.Text = "Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 47);
            label2.Name = "label2";
            label2.Size = new Size(127, 30);
            label2.TabIndex = 0;
            label2.Text = "Kullanıcı Adı";
            // 
            // dataGridViewpersonel
            // 
            dataGridViewpersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewpersonel.Location = new Point(865, 40);
            dataGridViewpersonel.Name = "dataGridViewpersonel";
            dataGridViewpersonel.RowTemplate.Height = 25;
            dataGridViewpersonel.Size = new Size(397, 273);
            dataGridViewpersonel.TabIndex = 53;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 740);
            Controls.Add(dataGridViewpersonel);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "AdminPanel";
            Text = "AdminPanel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewpersonel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonadmin;
        private PictureBox pictureBox3;
        private Button buttonanasayfa;
        private PictureBox pictureBox6;
        private LinkLabel labellogout;
        private PictureBox pictureBox5;
        private Label label1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonaddproduct;
        private Button buttonorders;
        private Button buttoncategories;
        private Button buttoncustomer;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtsifre;
        private TextBox txtkullaniciadi;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonkaydet;
        private DataGridView dataGridViewpersonel;
        private LinkLabel linkLabelgeri;
        private Button buttonsil;
    }
}