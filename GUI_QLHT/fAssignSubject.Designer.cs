namespace GUI_QLHT
{
    partial class fAssignSubject
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
            btnSearch = new Button();
            txbSearch = new TextBox();
            dtgvSubjectAssigned = new DataGridView();
            StudentId = new DataGridViewTextBoxColumn();
            studentName = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            dtgvSearch = new DataGridView();
            subjectSearchId = new DataGridViewTextBoxColumn();
            subjectSearchName = new DataGridViewTextBoxColumn();
            subjectSearchGrade = new DataGridViewTextBoxColumn();
            btnRemove = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvSubjectAssigned).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvSearch).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(661, 11);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(69, 20);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txbSearch
            // 
            txbSearch.Location = new Point(468, 11);
            txbSearch.Margin = new Padding(2);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(177, 23);
            txbSearch.TabIndex = 25;
            // 
            // dtgvSubjectAssigned
            // 
            dtgvSubjectAssigned.AllowUserToResizeColumns = false;
            dtgvSubjectAssigned.AllowUserToResizeRows = false;
            dtgvSubjectAssigned.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvSubjectAssigned.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dtgvSubjectAssigned.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSubjectAssigned.Columns.AddRange(new DataGridViewColumn[] { StudentId, studentName, Grade });
            dtgvSubjectAssigned.Location = new Point(1, 78);
            dtgvSubjectAssigned.Margin = new Padding(2);
            dtgvSubjectAssigned.Name = "dtgvSubjectAssigned";
            dtgvSubjectAssigned.RowHeadersWidth = 62;
            dtgvSubjectAssigned.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgvSubjectAssigned.Size = new Size(354, 259);
            dtgvSubjectAssigned.TabIndex = 30;
            // 
            // StudentId
            // 
            StudentId.DataPropertyName = "Id";
            StudentId.HeaderText = "Mã";
            StudentId.MinimumWidth = 8;
            StudentId.Name = "StudentId";
            StudentId.Width = 150;
            // 
            // studentName
            // 
            studentName.DataPropertyName = "name";
            studentName.HeaderText = "Tên";
            studentName.MinimumWidth = 8;
            studentName.Name = "studentName";
            studentName.Width = 150;
            // 
            // Grade
            // 
            Grade.DataPropertyName = "Grade";
            Grade.HeaderText = "Khối";
            Grade.MinimumWidth = 8;
            Grade.Name = "Grade";
            Grade.Width = 150;
            // 
            // dtgvSearch
            // 
            dtgvSearch.AllowUserToResizeColumns = false;
            dtgvSearch.AllowUserToResizeRows = false;
            dtgvSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvSearch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dtgvSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSearch.Columns.AddRange(new DataGridViewColumn[] { subjectSearchId, subjectSearchName, subjectSearchGrade });
            dtgvSearch.Location = new Point(412, 78);
            dtgvSearch.Margin = new Padding(2);
            dtgvSearch.Name = "dtgvSearch";
            dtgvSearch.RowHeadersWidth = 62;
            dtgvSearch.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgvSearch.Size = new Size(318, 259);
            dtgvSearch.TabIndex = 32;
            // 
            // subjectSearchId
            // 
            subjectSearchId.DataPropertyName = "Id";
            subjectSearchId.HeaderText = "Mã";
            subjectSearchId.MinimumWidth = 8;
            subjectSearchId.Name = "subjectSearchId";
            subjectSearchId.Width = 150;
            // 
            // subjectSearchName
            // 
            subjectSearchName.DataPropertyName = "Name";
            subjectSearchName.HeaderText = "Tên";
            subjectSearchName.MinimumWidth = 8;
            subjectSearchName.Name = "subjectSearchName";
            subjectSearchName.Width = 150;
            // 
            // subjectSearchGrade
            // 
            subjectSearchGrade.DataPropertyName = "Grade";
            subjectSearchGrade.HeaderText = "Khối";
            subjectSearchGrade.MinimumWidth = 8;
            subjectSearchGrade.Name = "subjectSearchGrade";
            subjectSearchGrade.Width = 150;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.Location = new Point(367, 245);
            btnRemove.Margin = new Padding(2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(35, 46);
            btnRemove.TabIndex = 36;
            btnRemove.Text = ">";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(367, 116);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(35, 46);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "<";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // fAssignSubject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 338);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(dtgvSearch);
            Controls.Add(dtgvSubjectAssigned);
            Controls.Add(btnSearch);
            Controls.Add(txbSearch);
            Margin = new Padding(2);
            Name = "fAssignSubject";
            Text = "fAssignSubject";
            ((System.ComponentModel.ISupportInitialize)dtgvSubjectAssigned).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearch;
        private TextBox txbSearch;
        private DataGridView dtgvSubjectAssigned;
        private DataGridViewTextBoxColumn StudentId;
        private DataGridViewTextBoxColumn studentName;
        private DataGridViewTextBoxColumn Grade;
        private DataGridView dtgvSearch;
        private DataGridViewTextBoxColumn subjectSearchId;
        private DataGridViewTextBoxColumn subjectSearchName;
        private DataGridViewTextBoxColumn subjectSearchGrade;
        private Button btnRemove;
        private Button btnAdd;
    }
}