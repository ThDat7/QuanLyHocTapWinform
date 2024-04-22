namespace GUI_QLHT
{
    partial class fStats
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
            btnViewStats = new Button();
            dtgvClass = new DataGridView();
            cbYear = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgvClass).BeginInit();
            SuspendLayout();
            // 
            // btnViewStats
            // 
            btnViewStats.Location = new Point(328, 20);
            btnViewStats.Margin = new Padding(2);
            btnViewStats.Name = "btnViewStats";
            btnViewStats.Size = new Size(95, 37);
            btnViewStats.TabIndex = 7;
            btnViewStats.Text = "Xem điểm";
            btnViewStats.UseVisualStyleBackColor = true;
            btnViewStats.Click += btnViewStats_Click;
            // 
            // dtgvClass
            // 
            dtgvClass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvClass.Location = new Point(-1, 116);
            dtgvClass.Margin = new Padding(2);
            dtgvClass.Name = "dtgvClass";
            dtgvClass.ReadOnly = true;
            dtgvClass.RowHeadersWidth = 62;
            dtgvClass.Size = new Size(755, 269);
            dtgvClass.TabIndex = 6;
            // 
            // cbYear
            // 
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(65, 20);
            cbYear.Margin = new Padding(2);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(129, 23);
            cbYear.TabIndex = 9;
            cbYear.SelectedIndexChanged += cbYear_SelectedIndexChanged;
            // 
            // fStats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 384);
            Controls.Add(cbYear);
            Controls.Add(btnViewStats);
            Controls.Add(dtgvClass);
            Margin = new Padding(2);
            Name = "fStats";
            Text = "fStats";
            ((System.ComponentModel.ISupportInitialize)dtgvClass).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewStats;
        private DataGridView dtgvClass;
        private ComboBox cbYear;
    }
}