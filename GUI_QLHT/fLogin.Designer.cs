namespace GUI_QLHT
{
    partial class fLogin
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
            btnLogin = new Button();
            txbPassword = new TextBox();
            txbUsername = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(325, 261);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(325, 206);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(150, 31);
            txbPassword.TabIndex = 4;
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(325, 155);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(150, 31);
            txbUsername.TabIndex = 3;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txbPassword);
            Controls.Add(txbUsername);
            Name = "fLogin";
            Text = "fLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txbPassword;
        private TextBox txbUsername;
    }
}