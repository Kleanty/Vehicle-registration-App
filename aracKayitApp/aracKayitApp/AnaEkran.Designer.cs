namespace aracKayitApp
{
    partial class AnaEkran
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
            name = new Label();
            plaka = new Label();
            model = new Label();
            arıza = new Label();
            nameText = new TextBox();
            plakaText = new TextBox();
            modelText = new TextBox();
            arizaText = new RichTextBox();
            Kayıt = new Button();
            label1 = new Label();
            kodLabel = new Label();
            telTex = new TextBox();
            tel = new Label();
            dateTimePicker1 = new DateTimePicker();
            tarih = new Label();
            ExeleAktarBut = new Button();
            label2 = new Label();
            exelLabel = new Label();
            label3 = new Label();
            AraBut = new Button();
            aramaTextBox = new TextBox();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            SafeExit = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(12, 20);
            name.Name = "name";
            name.Size = new Size(130, 28);
            name.TabIndex = 0;
            name.Text = "İsim Soyisim";
            // 
            // plaka
            // 
            plaka.AutoSize = true;
            plaka.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            plaka.Location = new Point(12, 108);
            plaka.Name = "plaka";
            plaka.Size = new Size(127, 28);
            plaka.TabIndex = 1;
            plaka.Text = "Araç Plakası";
            // 
            // model
            // 
            model.AutoSize = true;
            model.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            model.Location = new Point(12, 161);
            model.Name = "model";
            model.Size = new Size(127, 28);
            model.TabIndex = 2;
            model.Text = "Araç Modeli";
            // 
            // arıza
            // 
            arıza.AutoSize = true;
            arıza.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            arıza.Location = new Point(12, 202);
            arıza.Name = "arıza";
            arıza.Size = new Size(61, 28);
            arıza.TabIndex = 3;
            arıza.Text = "Arıza";
            // 
            // nameText
            // 
            nameText.Location = new Point(148, 20);
            nameText.Name = "nameText";
            nameText.Size = new Size(281, 27);
            nameText.TabIndex = 1;
            // 
            // plakaText
            // 
            plakaText.Location = new Point(148, 109);
            plakaText.Name = "plakaText";
            plakaText.Size = new Size(281, 27);
            plakaText.TabIndex = 4;
            // 
            // modelText
            // 
            modelText.Location = new Point(148, 161);
            modelText.Name = "modelText";
            modelText.Size = new Size(281, 27);
            modelText.TabIndex = 5;
            // 
            // arizaText
            // 
            arizaText.Location = new Point(12, 233);
            arizaText.Name = "arizaText";
            arizaText.Size = new Size(417, 193);
            arizaText.TabIndex = 6;
            arizaText.Text = "";
            // 
            // Kayıt
            // 
            Kayıt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Kayıt.Location = new Point(12, 432);
            Kayıt.Name = "Kayıt";
            Kayıt.Size = new Size(96, 47);
            Kayıt.TabIndex = 7;
            Kayıt.Text = "kaydet";
            Kayıt.UseVisualStyleBackColor = true;
            Kayıt.Click += Kayıt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(114, 441);
            label1.Name = "label1";
            label1.Size = new Size(210, 28);
            label1.TabIndex = 9;
            label1.Text = "Araç Kayıt Kodunuz :";
            // 
            // kodLabel
            // 
            kodLabel.AutoSize = true;
            kodLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            kodLabel.Location = new Point(330, 441);
            kodLabel.Name = "kodLabel";
            kodLabel.Size = new Size(84, 28);
            kodLabel.TabIndex = 10;
            kodLabel.Text = "000000";
            // 
            // telTex
            // 
            telTex.Location = new Point(148, 64);
            telTex.Name = "telTex";
            telTex.Size = new Size(281, 27);
            telTex.TabIndex = 2;
            // 
            // tel
            // 
            tel.AutoSize = true;
            tel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tel.Location = new Point(12, 64);
            tel.Name = "tel";
            tel.Size = new Size(116, 28);
            tel.TabIndex = 11;
            tel.Text = "Telefon No";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(677, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // tarih
            // 
            tarih.AutoSize = true;
            tarih.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tarih.Location = new Point(490, 23);
            tarih.Name = "tarih";
            tarih.Size = new Size(161, 28);
            tarih.TabIndex = 13;
            tarih.Text = "Bugünün Tarihi :";
            // 
            // ExeleAktarBut
            // 
            ExeleAktarBut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExeleAktarBut.Location = new Point(715, 64);
            ExeleAktarBut.Name = "ExeleAktarBut";
            ExeleAktarBut.Size = new Size(132, 42);
            ExeleAktarBut.TabIndex = 14;
            ExeleAktarBut.Text = "Exele Aktar";
            ExeleAktarBut.UseVisualStyleBackColor = true;
            ExeleAktarBut.Click += ExeleAktarBut_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(490, 71);
            label2.Name = "label2";
            label2.Size = new Size(219, 28);
            label2.TabIndex = 15;
            label2.Text = "Tüm Kayıtlı Kullanıcıları";
            // 
            // exelLabel
            // 
            exelLabel.AutoSize = true;
            exelLabel.Location = new Point(490, 115);
            exelLabel.Name = "exelLabel";
            exelLabel.Size = new Size(45, 20);
            exelLabel.TabIndex = 16;
            exelLabel.Text = "------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(490, 161);
            label3.Name = "label3";
            label3.Size = new Size(247, 28);
            label3.TabIndex = 18;
            label3.Text = "Veri Tabanında Arama Yap";
            // 
            // AraBut
            // 
            AraBut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AraBut.Location = new Point(892, 184);
            AraBut.Name = "AraBut";
            AraBut.Size = new Size(123, 37);
            AraBut.TabIndex = 19;
            AraBut.Text = "Arama Yap";
            AraBut.UseVisualStyleBackColor = true;
            AraBut.Click += AraBut_Click;
            // 
            // aramaTextBox
            // 
            aramaTextBox.Location = new Point(490, 194);
            aramaTextBox.Name = "aramaTextBox";
            aramaTextBox.Size = new Size(292, 27);
            aramaTextBox.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(788, 190);
            label4.Name = "label4";
            label4.Size = new Size(98, 28);
            label4.TabIndex = 21;
            label4.Text = "Hakkında";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(490, 233);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(525, 194);
            richTextBox1.TabIndex = 22;
            richTextBox1.Text = "";
            // 
            // SafeExit
            // 
            SafeExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SafeExit.Location = new Point(813, 443);
            SafeExit.Name = "SafeExit";
            SafeExit.Size = new Size(202, 36);
            SafeExit.TabIndex = 23;
            SafeExit.Text = "Hesaptan Çıkış Yap";
            SafeExit.UseVisualStyleBackColor = true;
            SafeExit.Click += SafeExit_Click;
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1027, 487);
            Controls.Add(SafeExit);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(aramaTextBox);
            Controls.Add(AraBut);
            Controls.Add(label3);
            Controls.Add(exelLabel);
            Controls.Add(label2);
            Controls.Add(ExeleAktarBut);
            Controls.Add(tarih);
            Controls.Add(dateTimePicker1);
            Controls.Add(telTex);
            Controls.Add(tel);
            Controls.Add(kodLabel);
            Controls.Add(label1);
            Controls.Add(Kayıt);
            Controls.Add(arizaText);
            Controls.Add(modelText);
            Controls.Add(plakaText);
            Controls.Add(nameText);
            Controls.Add(arıza);
            Controls.Add(model);
            Controls.Add(plaka);
            Controls.Add(name);
            Name = "AnaEkran";
            Text = "Araç Kayıt Programı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label plaka;
        private Label model;
        private Label arıza;
        private TextBox nameText;
        private TextBox plakaText;
        private TextBox modelText;
        private RichTextBox arizaText;
        private Button Kayıt;
        private Label label1;
        private Label kodLabel;
        private TextBox telTex;
        private Label tel;
        private DateTimePicker dateTimePicker1;
        private Label tarih;
        private Button ExeleAktarBut;
        private Label label2;
        private Label exelLabel;
        private Label label3;
        private Button AraBut;
        private TextBox aramaTextBox;
        private Label label4;
        private RichTextBox richTextBox1;
        private Button SafeExit;
    }
}