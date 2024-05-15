namespace GUI_QLHT
{
    partial class fMenu
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
            btnAcademic = new Button();
            btnUser = new Button();
            btnStudy = new Button();
            btnStats = new Button();
            SuspendLayout();
            // 
            // btnAcademic
            // 
            btnAcademic.Location = new Point(485, 261);
            btnAcademic.Name = "btnAcademic";
            btnAcademic.Size = new Size(154, 61);
            btnAcademic.TabIndex = 4;
            btnAcademic.Text = "Quản lý học vụ";
            btnAcademic.UseVisualStyleBackColor = true;
            btnAcademic.Visible = false;
            btnAcademic.Click += btnAcademic_Click;
            // 
            // btnUser
            // 
            btnUser.Location = new Point(256, 261);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(154, 61);
            btnUser.TabIndex = 5;
            btnUser.Text = "Quản lý tài khoản";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Visible = false;
            btnUser.Click += btnUser_Click;
            // 
            // btnStudy
            // 
            btnStudy.Location = new Point(717, 261);
            btnStudy.Name = "btnStudy";
            btnStudy.Size = new Size(154, 61);
            btnStudy.TabIndex = 6;
            btnStudy.Text = "Quản lý điểm";
            btnStudy.UseVisualStyleBackColor = true;
            btnStudy.Visible = false;
            btnStudy.Click += btnStudy_Click;
            // 
            // btnStats
            // 
            btnStats.Location = new Point(485, 392);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(154, 61);
            btnStats.TabIndex = 7;
            btnStats.Text = "Thống kê";
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Visible = false;
            btnStats.Click += btnStats_Click;
            // 
            // fMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 583);
            Controls.Add(btnStats);
            Controls.Add(btnStudy);
            Controls.Add(btnUser);
            Controls.Add(btnAcademic);
            Name = "fMenu";
            Text = "fMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAcademic;
        private Button btnUser;
        private Button btnStudy;
        private Button btnStats;
    }
}