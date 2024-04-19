namespace GUI_QLHT
{
    partial class fExam
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnToggle45Sem1 = new Button();
            btnToggle15Sem1 = new Button();
            btnSaveSe1 = new Button();
            dtgvTeach1 = new DataGridView();
            tabPage2 = new TabPage();
            btnToggle45Sem2 = new Button();
            btnToggle15Sem2 = new Button();
            btnSaveSe2 = new Button();
            dtgvTeach2 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTeach1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTeach2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1067, 620);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnToggle45Sem1);
            tabPage1.Controls.Add(btnToggle15Sem1);
            tabPage1.Controls.Add(btnSaveSe1);
            tabPage1.Controls.Add(dtgvTeach1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1059, 582);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Học kỳ 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnToggle45Sem1
            // 
            btnToggle45Sem1.Location = new Point(430, 11);
            btnToggle45Sem1.Name = "btnToggle45Sem1";
            btnToggle45Sem1.Size = new Size(145, 34);
            btnToggle45Sem1.TabIndex = 17;
            btnToggle45Sem1.UseVisualStyleBackColor = true;
            btnToggle45Sem1.Click += btnToggle45Sem1_Click;
            // 
            // btnToggle15Sem1
            // 
            btnToggle15Sem1.Location = new Point(191, 11);
            btnToggle15Sem1.Name = "btnToggle15Sem1";
            btnToggle15Sem1.Size = new Size(145, 34);
            btnToggle15Sem1.TabIndex = 16;
            btnToggle15Sem1.UseVisualStyleBackColor = true;
            btnToggle15Sem1.Click += btnToggle15Sem1_Click;
            // 
            // btnSaveSe1
            // 
            btnSaveSe1.Location = new Point(858, 11);
            btnSaveSe1.Name = "btnSaveSe1";
            btnSaveSe1.Size = new Size(112, 34);
            btnSaveSe1.TabIndex = 15;
            btnSaveSe1.Text = "Xử lý";
            btnSaveSe1.UseVisualStyleBackColor = true;
            btnSaveSe1.Click += btnSaveSe1_Click;
            // 
            // dtgvTeach1
            // 
            dtgvTeach1.AllowUserToResizeColumns = false;
            dtgvTeach1.AllowUserToResizeRows = false;
            dtgvTeach1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvTeach1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dtgvTeach1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTeach1.Location = new Point(-4, 83);
            dtgvTeach1.Name = "dtgvTeach1";
            dtgvTeach1.RowHeadersWidth = 62;
            dtgvTeach1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgvTeach1.Size = new Size(1058, 488);
            dtgvTeach1.TabIndex = 14;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnToggle45Sem2);
            tabPage2.Controls.Add(btnToggle15Sem2);
            tabPage2.Controls.Add(btnSaveSe2);
            tabPage2.Controls.Add(dtgvTeach2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1059, 582);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Học kỳ 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnToggle45Sem2
            // 
            btnToggle45Sem2.Location = new Point(430, 11);
            btnToggle45Sem2.Name = "btnToggle45Sem2";
            btnToggle45Sem2.Size = new Size(145, 34);
            btnToggle45Sem2.TabIndex = 21;
            btnToggle45Sem2.UseVisualStyleBackColor = true;
            btnToggle45Sem2.Click += btnToggle45Sem2_Click;
            // 
            // btnToggle15Sem2
            // 
            btnToggle15Sem2.Location = new Point(191, 11);
            btnToggle15Sem2.Name = "btnToggle15Sem2";
            btnToggle15Sem2.Size = new Size(145, 34);
            btnToggle15Sem2.TabIndex = 20;
            btnToggle15Sem2.UseVisualStyleBackColor = true;
            btnToggle15Sem2.Click += btnToggle15Sem2_Click;
            // 
            // btnSaveSe2
            // 
            btnSaveSe2.Location = new Point(858, 11);
            btnSaveSe2.Name = "btnSaveSe2";
            btnSaveSe2.Size = new Size(112, 34);
            btnSaveSe2.TabIndex = 19;
            btnSaveSe2.Text = "Xử lý";
            btnSaveSe2.UseVisualStyleBackColor = true;
            btnSaveSe2.Click += btnSaveSe2_Click;
            // 
            // dtgvTeach2
            // 
            dtgvTeach2.AllowUserToResizeColumns = false;
            dtgvTeach2.AllowUserToResizeRows = false;
            dtgvTeach2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvTeach2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dtgvTeach2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTeach2.Location = new Point(-4, 83);
            dtgvTeach2.Name = "dtgvTeach2";
            dtgvTeach2.RowHeadersWidth = 62;
            dtgvTeach2.Size = new Size(1058, 488);
            dtgvTeach2.TabIndex = 18;
            // 
            // fExam
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 640);
            Controls.Add(tabControl1);
            Name = "fExam";
            Text = "fExam";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTeach1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTeach2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnToggle45Sem1;
        private Button btnToggle15Sem1;
        private Button btnSaveSe1;
        private DataGridView dtgvTeach1;
        private TabPage tabPage2;
        private Button btnToggle45Sem2;
        private Button btnToggle15Sem2;
        private Button btnSaveSe2;
        private DataGridView dtgvTeach2;
    }
}