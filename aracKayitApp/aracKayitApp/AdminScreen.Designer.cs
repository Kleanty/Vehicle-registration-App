namespace aracKayitApp
{
    partial class AdminScreen
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
            UserNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            UserPassTextBox = new TextBox();
            DBadderBut = new Button();
            BackAppBut = new Button();
            UserDeleterBut = new Button();
            label4 = new Label();
            DelUserNameTextBox = new TextBox();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            SafeExit = new Button();
            SuspendLayout();
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(12, 37);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(281, 27);
            UserNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(53, 28);
            label2.TabIndex = 2;
            label2.Text = "Şifre";
            // 
            // UserPassTextBox
            // 
            UserPassTextBox.Location = new Point(12, 98);
            UserPassTextBox.Name = "UserPassTextBox";
            UserPassTextBox.Size = new Size(281, 27);
            UserPassTextBox.TabIndex = 3;
            // 
            // DBadderBut
            // 
            DBadderBut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DBadderBut.Location = new Point(12, 143);
            DBadderBut.Name = "DBadderBut";
            DBadderBut.Size = new Size(281, 43);
            DBadderBut.TabIndex = 4;
            DBadderBut.Text = "Kulllanıcıyı Sisteme Ekle";
            DBadderBut.UseVisualStyleBackColor = true;
            DBadderBut.Click += DBadderBut_Click;
            // 
            // BackAppBut
            // 
            BackAppBut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BackAppBut.Location = new Point(12, 395);
            BackAppBut.Name = "BackAppBut";
            BackAppBut.Size = new Size(281, 43);
            BackAppBut.TabIndex = 5;
            BackAppBut.Text = "Kayıt sistemine geri dön";
            BackAppBut.UseVisualStyleBackColor = true;
            BackAppBut.Click += BackAppBut_Click;
            // 
            // UserDeleterBut
            // 
            UserDeleterBut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UserDeleterBut.Location = new Point(317, 87);
            UserDeleterBut.Name = "UserDeleterBut";
            UserDeleterBut.Size = new Size(281, 43);
            UserDeleterBut.TabIndex = 10;
            UserDeleterBut.Text = "Kullanıcısını Sistemden sil ";
            UserDeleterBut.UseVisualStyleBackColor = true;
            UserDeleterBut.Click += UserDeleterBut_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(317, 6);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 7;
            label4.Text = "Kullanıcı Adı";
            // 
            // DelUserNameTextBox
            // 
            DelUserNameTextBox.Location = new Point(317, 37);
            DelUserNameTextBox.Name = "DelUserNameTextBox";
            DelUserNameTextBox.Size = new Size(281, 27);
            DelUserNameTextBox.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(629, 143);
            button1.Name = "button1";
            button1.Size = new Size(322, 40);
            button1.TabIndex = 13;
            button1.Text = "Kullanıcısınının şifresini değiştir";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(629, 9);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 12;
            label3.Text = "Kullanıcı Adı";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(629, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(629, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 27);
            textBox2.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(629, 72);
            label5.Name = "label5";
            label5.Size = new Size(95, 28);
            label5.TabIndex = 15;
            label5.Text = "yeni şifre";
            // 
            // SafeExit
            // 
            SafeExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SafeExit.Location = new Point(749, 402);
            SafeExit.Name = "SafeExit";
            SafeExit.Size = new Size(202, 36);
            SafeExit.TabIndex = 24;
            SafeExit.Text = "Hesaptan Çıkış Yap";
            SafeExit.UseVisualStyleBackColor = true;
            // 
            // AdminScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(963, 450);
            Controls.Add(SafeExit);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(UserDeleterBut);
            Controls.Add(label4);
            Controls.Add(DelUserNameTextBox);
            Controls.Add(BackAppBut);
            Controls.Add(DBadderBut);
            Controls.Add(UserPassTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UserNameTextBox);
            Name = "AdminScreen";
            Text = "Yönetici Paneli";
            Load += AdminScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserNameTextBox;
        private Label label1;
        private Label label2;
        private TextBox UserPassTextBox;
        private Button DBadderBut;
        private Button BackAppBut;
        private Button UserDeleterBut;
        private Label label4;
        private TextBox DelUserNameTextBox;
        private Button button1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private Button SafeExit;
    }
}