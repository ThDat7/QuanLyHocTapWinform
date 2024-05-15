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
            dtgvStats.Location = new Point(-1, 93);
            dtgvStats.Name = "dtgvStats";
            dtgvStats.ReadOnly = true;
            dtgvStats.RowHeadersWidth = 62;
            dtgvStats.Size = new Size(1080, 548);
            dtgvStats.TabIndex = 7;
            dtgvStats.RowsAdded += dtgvStats_RowsAdded;
            // 
            // cbSemester
            // 
            cbSemester.FormattingEnabled = true;
            cbSemester.Items.AddRange(new object[] { "Học kỳ 1", "Học kỳ 2", "Cả năm" });
            cbSemester.Location = new Point(477, 18);
            cbSemester.Name = "cbSemester";
            cbSemester.Size = new Size(183, 33);
            cbSemester.TabIndex = 8;
            cbSemester.SelectedIndexChanged += cbSemester_SelectedIndexChanged;
            // 
            // fStatsDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 640);
            Controls.Add(cbSemester);
            Controls.Add(dtgvStats);
            Margin = new Padding(4, 5, 4, 5);
            Name = "fStatsDetail";
            Text = "fStatsDetail";
            ((System.ComponentModel.ISupportInitialize)dtgvStats).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvStats;
        private ComboBox cbSemester;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn Order;
        private DataGridViewTextBoxColumn Year;
    }
}