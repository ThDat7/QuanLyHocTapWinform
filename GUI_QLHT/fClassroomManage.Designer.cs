namespace GUI_QLHT
{
    partial class fClassroomManage
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
            btnRemoveStudent = new Button();
            btnAddStudent = new Button();
            btnSearchStudent = new Button();
            txbSearchStudent = new TextBox();
            dtgvSearchStudent = new DataGridView();
            btnSaveSe1 = new Button();
            dtgvStudentInClass = new DataGridView();
            tabPage2 = new TabPage();
            txbHomeroomAddress = new TextBox();
            txbHomeroomDob = new TextBox();
            txbHomeroomName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSearchTeacher1 = new Button();
            txbSearchHomeroomTeacher = new TextBox();
            btnSetHomeroom = new Button();
            dtgvSearchTeacher1 = new DataGridView();
            tabPage3 = new TabPage();
            btnRemoveTeacher = new Button();
            btnAddTeacher = new Button();
            btnSearchTeacher2 = new Button();
            txbSearchSubjectTeacher = new TextBox();
            dtgvSearchTeacher2 = new DataGridView();
            button4 = new Button();
            dtgvSubjectTeachers = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvSearchStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvStudentInClass).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvSearchTeacher1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvSearchTeacher2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvSubjectTeachers).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1067, 620);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRemoveStudent);
            tabPage1.Controls.Add(btnAddStudent);
            tabPage1.Controls.Add(btnSearchStudent);
            tabPage1.Controls.Add(txbSearchStudent);
            tabPage1.Controls.Add(dtgvSearchStudent);
            tabPage1.Controls.Add(btnSaveSe1);
            tabPage1.Controls.Add(dtgvStudentInClass);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1059, 582);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Học sinh";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveStudent.Location = new Point(622, 403);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(50, 76);
            btnRemoveStudent.TabIndex = 22;
            btnRemoveStudent.Text = ">";
            btnRemoveStudent.UseVisualStyleBackColor = true;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddStudent.Location = new Point(622, 189);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(50, 76);
            btnAddStudent.TabIndex = 21;
            btnAddStudent.Text = "<";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.Location = new Point(955, 35);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(98, 34);
            btnSearchStudent.TabIndex = 20;
            btnSearchStudent.Text = "Tìm kiếm";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // txbSearchStudent
            // 
            txbSearchStudent.Location = new Point(678, 35);
            txbSearchStudent.Name = "txbSearchStudent";
            txbSearchStudent.Size = new Size(251, 31);
            txbSearchStudent.TabIndex = 19;
            // 
            // dtgvSearchStudent
            // 
            dtgvSearchStudent.AllowUserToResizeColumns = false;
            dtgvSearchStudent.AllowUserToResizeRows = false;
            dtgvSearchStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dtgvSearchStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSearchStudent.Location = new Point(678, 113);
            dtgvSearchStudent.Name = "dtgvSearchStudent";
            dtgvSearchStudent.RowHeadersWidth = 62;
            dtgvSearchStudent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgvSearchStudent.Size = new Size(385, 466);
            dtgvSearchStudent.TabIndex = 18;
            // 
            // btnSaveSe1
            // 
            btnSaveSe1.Location = new Point(239, 34);
            btnSaveSe1.Name = "btnSaveSe1";
            btnSaveSe1.Size = new Size(112, 34);
            btnSaveSe1.TabIndex = 15;
            btnSaveSe1.Text = "Xử lý";
            btnSaveSe1.UseVisualStyleBackColor = true;
            // 
            // dtgvStudentInClass
            // 
            dtgvStudentInClass.AllowUserToResizeColumns = false;
            dtgvStudentInClass.AllowUserToResizeRows = false;
            dtgvStudentInClass.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dtgvStudentInClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStudentInClass.Location = new Point(0, 109);
            dtgvStudentInClass.Name = "dtgvStudentInClass";
            dtgvStudentInClass.RowHeadersWidth = 62;
            dtgvStudentInClass.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgvStudentInClass.Size = new Size(616, 473);
            dtgvStudentInClass.TabIndex = 14;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txbHomeroomAddress);
            tabPage2.Controls.Add(txbHomeroomDob);
            tabPage2.Controls.Add(txbHomeroomName);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(btnSearchTeacher1);
            tabPage2.Controls.Add(txbSearchHomeroomTeacher);
            tabPage2.Controls.Add(btnSetHomeroom);
            tabPage2.Controls.Add(dtgvSearchTeacher1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1059, 582);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Chủ nhiệm";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txbHomeroomAddress
            // 
            txbHomeroomAddress.Enabled = false;
            txbHomeroomAddress.Location = new Point(410, 30);
            txbHomeroomAddress.Name = "txbHomeroomAddress";
            txbHomeroomAddress.ReadOnly = true;
            txbHomeroomAddress.Size = new Size(158, 31);
            txbHomeroomAddress.TabIndex = 28;
            // 
            // txbHomeroomDob
            // 
            txbHomeroomDob.Enabled = false;
            txbHomeroomDob.Location = new Point(150, 86);
            txbHomeroomDob.Name = "txbHomeroomDob";
            txbHomeroomDob.ReadOnly = true;
            txbHomeroomDob.Size = new Size(158, 31);
            txbHomeroomDob.TabIndex = 27;
            // 
            // txbHomeroomName
            // 
            txbHomeroomName.Location = new Point(113, 30);
            txbHomeroomName.Name = "txbHomeroomName";
            txbHomeroomName.Size = new Size(158, 31);
            txbHomeroomName.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 30);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 25;
            label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 86);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 24;
            label2.Text = "Ngày sinh:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 30);
            label1.Name = "label1";
            label1.Size = new Size(42, 25);
            label1.TabIndex = 23;
            label1.Text = "Tên:";
            // 
            // btnSearchTeacher1
            // 
            btnSearchTeacher1.Location = new Point(695, 86);
            btnSearchTeacher1.Name = "btnSearchTeacher1";
            btnSearchTeacher1.Size = new Size(98, 34);
            btnSearchTeacher1.TabIndex = 22;
            btnSearchTeacher1.Text = "Tìm kiếm";
            btnSearchTeacher1.UseVisualStyleBackColor = true;
            btnSearchTeacher1.Click += btnSearchTeacher1_Click;
            // 
            // txbSearchHomeroomTeacher
            // 
            txbSearchHomeroomTeacher.Location = new Point(418, 86);
            txbSearchHomeroomTeacher.Name = "txbSearchHomeroomTeacher";
            txbSearchHomeroomTeacher.Size = new Size(251, 31);
            txbSearchHomeroomTeacher.TabIndex = 21;
            // 
            // btnSetHomeroom
            // 
            btnSetHomeroom.Location = new Point(853, 60);
            btnSetHomeroom.Name = "btnSetHomeroom";
            btnSetHomeroom.Size = new Size(112, 60);
            btnSetHomeroom.TabIndex = 19;
            btnSetHomeroom.Text = "Chọn làm chủ nhiệm";
            btnSetHomeroom.UseVisualStyleBackColor = true;
            btnSetHomeroom.Click += btnSetHomeroom_Click;
            // 
            // dtgvSearchTeacher1
            // 
            dtgvSearchTeacher1.AllowUserToResizeColumns = false;
            dtgvSearchTeacher1.AllowUserToResizeRows = false;
            dtgvSearchTeacher1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dtgvSearchTeacher1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSearchTeacher1.Dock = DockStyle.Bottom;
            dtgvSearchTeacher1.Location = new Point(3, 135);
            dtgvSearchTeacher1.Name = "dtgvSearchTeacher1";
            dtgvSearchTeacher1.RowHeadersWidth = 62;
            dtgvSearchTeacher1.Size = new Size(1053, 444);
            dtgvSearchTeacher1.TabIndex = 18;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnRemoveTeacher);
            tabPage3.Controls.Add(btnAddTeacher);
            tabPage3.Controls.Add(btnSearchTeacher2);
            tabPage3.Controls.Add(txbSearchSubjectTeacher);
            tabPage3.Controls.Add(dtgvSearchTeacher2);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(dtgvSubjectTeachers);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1059, 582);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Giáo viên bộ môn";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTeacher
            // 
            btnRemoveTeacher.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveTeacher.Location = new Point(608, 404);
            btnRemoveTeacher.Name = "btnRemoveTeacher";
            btnRemoveTeacher.Size = new Size(50, 76);
            btnRemoveTeacher.TabIndex = 27;
            btnRemoveTeacher.Text = ">";
            btnRemoveTeacher.UseVisualStyleBackColor = true;
            btnRemoveTeacher.Click += btnRemoveTeacher_Click;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddTeacher.Location = new Point(608, 190);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(50, 76);
            btnAddTeacher.TabIndex = 26;
            btnAddTeacher.Text = "<";
            btnAddTeacher.UseVisualStyleBackColor = true;
            btnAddTeacher.Click += btnAddTeacher_Click;
            // 
            // btnSearchTeacher2
            // 
            btnSearchTeacher2.Location = new Point(953, 28);
            btnSearchTeacher2.Name = "btnSearchTeacher2";
            btnSearchTeacher2.Size = new Size(98, 34);
            btnSearchTeacher2.TabIndex = 25;
            btnSearchTeacher2.Text = "Tìm kiếm";
            btnSearchTeacher2.UseVisualStyleBackColor = true;
            btnSearchTeacher2.Click += btnSearchTeacher2_Click;
            // 
            // txbSearchSubjectTeacher
            // 
            txbSearchSubjectTeacher.Location = new Point(676, 28);
            txbSearchSubjectTeacher.Name = "txbSearchSubjectTeacher";
            txbSearchSubjectTeacher.Size = new Size(251, 31);
            txbSearchSubjectTeacher.TabIndex = 24;
            // 
            // dtgvSearchTeacher2
            // 
            dtgvSearchTeacher2.AllowUserToResizeColumns = false;
            dtgvSearchTeacher2.AllowUserToResizeRows = false;
            dtgvSearchTeacher2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dtgvSearchTeacher2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSearchTeacher2.Location = new Point(671, 104);
            dtgvSearchTeacher2.Name = "dtgvSearchTeacher2";
            dtgvSearchTeacher2.RowHeadersWidth = 62;
            dtgvSearchTeacher2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgvSearchTeacher2.Size = new Size(385, 482);
            dtgvSearchTeacher2.TabIndex = 23;
            // 
            // button4
            // 
            button4.Location = new Point(236, 24);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 22;
            button4.Text = "Xử lý";
            button4.UseVisualStyleBackColor = true;
            // 
            // dtgvSubjectTeachers
            // 
            dtgvSubjectTeachers.AllowUserToResizeColumns = false;
            dtgvSubjectTeachers.AllowUserToResizeRows = false;
            dtgvSubjectTeachers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dtgvSubjectTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSubjectTeachers.Location = new Point(0, 104);
            dtgvSubjectTeachers.Name = "dtgvSubjectTeachers";
            dtgvSubjectTeachers.RowHeadersWidth = 62;
            dtgvSubjectTeachers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgvSubjectTeachers.Size = new Size(596, 478);
            dtgvSubjectTeachers.TabIndex = 21;
            // 
            // fClassroomManage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 640);
            Controls.Add(tabControl1);
            Name = "fClassroomManage";
            Text = "fClassroomManage";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvSearchStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvStudentInClass).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvSearchTeacher1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvSearchTeacher2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvSubjectTeachers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnSaveSe1;
        private DataGridView dtgvStudentInClass;
        private TabPage tabPage2;
        private Button btnSetHomeroom;
        private DataGridView dtgvTeach2;
        private TabPage tabPage3;
        private Button btnRemoveStudent;
        private TextBox txbSearchStudent;
        private DataGridView dataGridView1;
        private Button btnSearchTeacher1;
        private TextBox txbSearchHomeroomTeacher;
        private Button btnSearchTeacher2;
        private TextBox txbSearchSubjectTeacher;
        private DataGridView dataGridView2;
        private Button button4;
        private DataGridView dtgvSubjectTeachers;
        private Label lbHomeroomAddress;
        private Label lbHomeroomDob;
        private Label lbHomeroomName;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dtgvSearchStudent;
        private DataGridView dtgvTeach1;
        private DataGridView dtgvSearchTeacher1;
        private DataGridView dtgvSearchTeacher2;
        private Button btnSearchStudent;
        private Button btnAddStudent;
        private Button btnRemoveTeacher;
        private Button btnAddTeacher;
        private TextBox txbHomeroomAddress;
        private TextBox txbHomeroomDob;
        private TextBox txbHomeroomName;
    }
}