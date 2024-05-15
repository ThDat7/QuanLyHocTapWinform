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
            Id = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            Order = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvClass).BeginInit();
            SuspendLayout();
            // 
            // btnViewStats
            // 
            btnViewStats.Location = new Point(469, 33);
            btnViewStats.Name = "btnViewStats";
            btnViewStats.Size = new Size(136, 62);
            btnViewStats.TabIndex = 7;
            btnViewStats.Text = "Xem điểm";
            btnViewStats.UseVisualStyleBackColor = true;
            btnViewStats.Click += btnViewStats_Click;
            // 
            // dtgvClass
            // 
            dtgvClass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvClass.Columns.AddRange(new DataGridViewColumn[] { Id, Grade, Order, Year });
            dtgvClass.Location = new Point(-1, 193);
            dtgvClass.Name = "dtgvClass";
            dtgvClass.ReadOnly = true;
            dtgvClass.RowHeadersWidth = 62;
            dtgvClass.Size = new Size(1079, 448);
            dtgvClass.TabIndex = 6;
            // 
            // cbYear
            // 
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(93, 33);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(183, 33);
            cbYear.TabIndex = 9;
            cbYear.SelectedIndexChanged += cbYear_SelectedIndexChanged;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Mã";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 150;
            // 
            // Grade
            // 
            Grade.DataPropertyName = "Grade";
            Grade.HeaderText = "Khối";
            Grade.MinimumWidth = 8;
            Grade.Name = "Grade";
            Grade.ReadOnly = true;
            Grade.Width = 150;
            // 
            // Order
            // 
            Order.DataPropertyName = "Order";
            Order.HeaderText = "Thứ tự";
            Order.MinimumWidth = 8;
            Order.Name = "Order";
            Order.ReadOnly = true;
            Order.Width = 150;
            // 
            // Year
            // 
            Year.DataPropertyName = "Year";
            Year.HeaderText = "Năm học";
            Year.MinimumWidth = 8;
            Year.Name = "Year";
            Year.ReadOnly = true;
            Year.Width = 150;
            // 
            // fStats
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 640);
            Controls.Add(cbYear);
            Controls.Add(btnViewStats);
            Controls.Add(dtgvClass);
            Name = "fStats";
            Text = "fStats";
            ((System.ComponentModel.ISupportInitialize)dtgvClass).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewStats;
        private DataGridView dtgvClass;
        private ComboBox cbYear;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn Order;
        private DataGridViewTextBoxColumn Year;
    }
}