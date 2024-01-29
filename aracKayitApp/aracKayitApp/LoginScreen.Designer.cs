namespace aracKayitApp
{
    partial class LoginScreen
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
            passwodTextBox = new TextBox();
            loginBut = new Button();
            nickNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            AdminBut = new Button();
            checkBox1 = new CheckBox();
            uyariLabel = new Label();
            SuspendLayout();
            // 
            // passwodTextBox
            // 
            passwodTextBox.Location = new Point(65, 157);
            passwodTextBox.Name = "passwodTextBox";
            passwodTextBox.Size = new Size(251, 27);
            passwodTextBox.TabIndex = 1;
            // 
            // loginBut
            // 
            loginBut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginBut.Location = new Point(113, 211);
            loginBut.Name = "loginBut";
            loginBut.Size = new Size(156, 49);
            loginBut.TabIndex = 2;
            loginBut.Text = "Giriş Yap";
            loginBut.UseVisualStyleBackColor = true;
            loginBut.Click += loginBut_Click;
            // 
            // nickNameTextBox
            // 
            nickNameTextBox.Location = new Point(65, 79);
            nickNameTextBox.Name = "nickNameTextBox";
            nickNameTextBox.Size = new Size(251, 27);
            nickNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(129, 48);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(162, 126);
            label2.Name = "label2";
            label2.Size = new Size(53, 28);
            label2.TabIndex = 4;
            label2.Text = "Şifre";
            // 
            // AdminBut
            // 
            AdminBut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AdminBut.Location = new Point(113, 288);
            AdminBut.Name = "AdminBut";
            AdminBut.Size = new Size(156, 49);
            AdminBut.TabIndex = 5;
            AdminBut.Text = "Yönetici Girişi";
            AdminBut.UseVisualStyleBackColor = true;
            AdminBut.Click += AdminBut_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(83, 356);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(233, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Bu Bilgisyarda Hesabı Açık tut ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // uyariLabel
            // 
            uyariLabel.AutoSize = true;
            uyariLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            uyariLabel.ForeColor = Color.Red;
            uyariLabel.Location = new Point(65, 21);
            uyariLabel.Name = "uyariLabel";
            uyariLabel.Size = new Size(0, 28);
            uyariLabel.TabIndex = 7;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(397, 415);
            Controls.Add(uyariLabel);
            Controls.Add(checkBox1);
            Controls.Add(AdminBut);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nickNameTextBox);
            Controls.Add(loginBut);
            Controls.Add(passwodTextBox);
            Name = "LoginScreen";
            Text = "GirişEkranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwodTextBox;
        private Button loginBut;
        private TextBox nickNameTextBox;
        private Label label1;
        private Label label2;
        private Button AdminBut;
        private CheckBox checkBox1;
        private Label uyariLabel;
    }
}