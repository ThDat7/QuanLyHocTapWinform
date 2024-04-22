namespace GUI_QLHT
{
    partial class fStatsDetail
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
            dtgvStats = new DataGridView();
            cbSemester = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgvStats).BeginInit();
            SuspendLayout();
            // 
            // dtgvStats
            // 
            dtgvStats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStats.Location = new Point(-1, 56);
            dtgvStats.Margin = new Padding(2);
            dtgvStats.Name = "dtgvStats";
            dtgvStats.ReadOnly = true;
            dtgvStats.RowHeadersWidth = 62;
            dtgvStats.Size = new Size(756, 329);
            dtgvStats.TabIndex = 7;
            // 
            // cbSemester
            // 
            cbSemester.FormattingEnabled = true;
            cbSemester.Items.AddRange(new object[] { "Học kỳ 1", "Học kỳ 2", "Cả năm" });
            cbSemester.Location = new Point(334, 11);
            cbSemester.Margin = new Padding(2);
            cbSemester.Name = "cbSemester";
            cbSemester.Size = new Size(129, 23);
            cbSemester.TabIndex = 8;
            cbSemester.SelectedIndexChanged += cbSemester_SelectedIndexChanged;
            // 
            // fStatsDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 384);
            Controls.Add(cbSemester);
            Controls.Add(dtgvStats);
            Name = "fStatsDetail";
            Text = "fStatsDetail";
            ((System.ComponentModel.ISupportInitialize)dtgvStats).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvStats;
        private ComboBox cbSemester;
    }
}