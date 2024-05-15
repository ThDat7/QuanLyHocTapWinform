namespace GUI_QLHT
{
    partial class fStudy
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
            dtgvTeach = new DataGridView();
            btnEditExam = new Button();
            TeachId = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            Order = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvTeach).BeginInit();
            SuspendLayout();
            // 
            // dtgvTeach
            // 
            dtgvTeach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvTeach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTeach.Columns.AddRange(new DataGridViewColumn[] { TeachId, Year, Grade, Order, Name });
            dtgvTeach.Location = new Point(-1, 227);
            dtgvTeach.Name = "dtgvTeach";
            dtgvTeach.RowHeadersWidth = 62;
            dtgvTeach.Size = new Size(1078, 413);
            dtgvTeach.TabIndex = 4;
            // 
            // btnEditExam
            // 
            btnEditExam.Location = new Point(468, 68);
            btnEditExam.Name = "btnEditExam";
            btnEditExam.Size = new Size(136, 61);
            btnEditExam.TabIndex = 5;
            btnEditExam.Text = "Nhập điểm";
            btnEditExam.UseVisualStyleBackColor = true;
            btnEditExam.Click += btnEditExam_Click;
            // 
            // TeachId
            // 
            TeachId.DataPropertyName = "TeachId";
            TeachId.HeaderText = "Mã";
            TeachId.MinimumWidth = 8;
            TeachId.Name = "TeachId";
            TeachId.Width = 150;
            // 
            // Year
            // 
            Year.DataPropertyName = "Year";
            Year.HeaderText = "Năm học";
            Year.MinimumWidth = 8;
            Year.Name = "Year";
            Year.Width = 150;
            // 
            // Grade
            // 
            Grade.DataPropertyName = "Grade";
            Grade.HeaderText = "Khối";
            Grade.MinimumWidth = 8;
            Grade.Name = "Grade";
            Grade.Width = 150;
            // 
            // Order
            // 
            Order.DataPropertyName = "Order";
            Order.HeaderText = "Thứ tự";
            Order.MinimumWidth = 8;
            Order.Name = "Order";
            Order.Width = 150;
            // 
            // Name
            // 
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Tên môn";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.Width = 150;
            // 
            // fStudy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 640);
            Controls.Add(btnEditExam);
            Controls.Add(dtgvTeach);
            //Name = "fStudy";
            Text = "fStudy";
            ((System.ComponentModel.ISupportInitialize)dtgvTeach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvTeach;
        private Button btnEditExam;
        private DataGridViewTextBoxColumn TeachId;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn Order;
        private DataGridViewTextBoxColumn Name;
    }
}