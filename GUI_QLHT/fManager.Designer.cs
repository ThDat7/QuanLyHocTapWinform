﻿namespace GUI_QLHT
{
    partial class fManager
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
            panel3 = new Panel();
            dtgvStudent = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            Dob = new DataGridViewTextBoxColumn();
            Sex = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Classrooms = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnSearchStudent = new Button();
            txbSearchStudent = new TextBox();
            dtpkDob = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            btnShowStudent = new Button();
            btnDeleteStudent = new Button();
            btnEditStudent = new Button();
            btnAddStudent = new Button();
            label4 = new Label();
            txbStudentEmail = new TextBox();
            txbStudentSex = new TextBox();
            txbStudentPhone = new TextBox();
            tpClassroom = new TabPage();
            cbClassroomYear = new ComboBox();
            panel12 = new Panel();
            dtgvClassroom = new DataGridView();
            classroomId = new DataGridViewTextBoxColumn();
            classroomGrade = new DataGridViewTextBoxColumn();
            classroomOrder = new DataGridViewTextBoxColumn();
            classroomYear = new DataGridViewTextBoxColumn();
            panel9 = new Panel();
            btnClassroomDetail = new Button();
            txbClassroomYear = new TextBox();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            txbClassroomOrder = new TextBox();
            txbClassroomGrade = new TextBox();
            txbClassroomId = new TextBox();
            label24 = new Label();
            panel10 = new Panel();
            btnSearchClassroom = new Button();
            txbSearchClassroom = new TextBox();
            panel11 = new Panel();
            btnShowClassroom = new Button();
            btnDeleteClassroom = new Button();
            btnEditClassroom = new Button();
            btnAddClassroom = new Button();
            txbStudentFirstname = new TextBox();
            txbStudentLastname = new TextBox();
            txbStudentId = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            txbStudentAddress = new TextBox();
            tpStudent = new TabPage();
            tabControl1 = new TabControl();
            tpSubject = new TabPage();
            cbSubjectGrade = new ComboBox();
            panel8 = new Panel();
            dtgvSubject = new DataGridView();
            subjetId = new DataGridViewTextBoxColumn();
            subjectName = new DataGridViewTextBoxColumn();
            subjectGrade = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            btnShowSubject = new Button();
            btnDeleteSubject = new Button();
            btnEditSubject = new Button();
            btnAddSubject = new Button();
            panel6 = new Panel();
            label14 = new Label();
            label15 = new Label();
            txbSubjectGrade = new TextBox();
            txbSubjectName = new TextBox();
            txbSubjectId = new TextBox();
            label16 = new Label();
            panel7 = new Panel();
            btnSearchSubject = new Button();
            txbSearchSubject = new TextBox();
            tpTeacher = new TabPage();
            dtgvTeacher = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            btnAssignSubject = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStudent).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tpClassroom.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvClassroom).BeginInit();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel4.SuspendLayout();
            tpStudent.SuspendLayout();
            tabControl1.SuspendLayout();
            tpSubject.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvSubject).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            tpTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTeacher).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvStudent);
            panel3.Location = new Point(0, 61);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(376, 298);
            panel3.TabIndex = 2;
            // 
            // dtgvStudent
            // 
            dtgvStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStudent.Columns.AddRange(new DataGridViewColumn[] { Id, LastName, FirstName, Dob, Sex, Address, Email, Phone, Classrooms });
            dtgvStudent.Location = new Point(0, 0);
            dtgvStudent.Margin = new Padding(2, 2, 2, 2);
            dtgvStudent.Name = "dtgvStudent";
            dtgvStudent.RowHeadersWidth = 62;
            dtgvStudent.Size = new Size(376, 298);
            dtgvStudent.TabIndex = 3;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Mã";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Width = 150;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "Họ";
            LastName.MinimumWidth = 8;
            LastName.Name = "LastName";
            LastName.Width = 150;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "Tên";
            FirstName.MinimumWidth = 8;
            FirstName.Name = "FirstName";
            FirstName.Width = 150;
            // 
            // Dob
            // 
            Dob.DataPropertyName = "Dob";
            Dob.HeaderText = "Ngày sinh";
            Dob.MinimumWidth = 8;
            Dob.Name = "Dob";
            Dob.Width = 150;
            // 
            // Sex
            // 
            Sex.DataPropertyName = "Sex";
            Sex.HeaderText = "Giới tính";
            Sex.MinimumWidth = 8;
            Sex.Name = "Sex";
            Sex.Width = 150;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Địa chỉ";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            Address.Width = 150;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.Width = 150;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Số điện thoại";
            Phone.MinimumWidth = 8;
            Phone.Name = "Phone";
            Phone.Width = 150;
            // 
            // Classrooms
            // 
            Classrooms.DataPropertyName = "Classrooms";
            Classrooms.HeaderText = "Lớp học";
            Classrooms.MinimumWidth = 8;
            Classrooms.Name = "Classrooms";
            Classrooms.Width = 150;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSearchStudent);
            panel2.Controls.Add(txbSearchStudent);
            panel2.Location = new Point(512, 2);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 47);
            panel2.TabIndex = 1;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.Location = new Point(163, 5);
            btnSearchStudent.Margin = new Padding(2, 2, 2, 2);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(57, 37);
            btnSearchStudent.TabIndex = 3;
            btnSearchStudent.Text = "Tìm";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // txbSearchStudent
            // 
            txbSearchStudent.Location = new Point(10, 14);
            txbSearchStudent.Margin = new Padding(2, 2, 2, 2);
            txbSearchStudent.Name = "txbSearchStudent";
            txbSearchStudent.Size = new Size(144, 23);
            txbSearchStudent.TabIndex = 1;
            // 
            // dtpkDob
            // 
            dtpkDob.Location = new Point(109, 118);
            dtpkDob.Margin = new Padding(2, 2, 2, 2);
            dtpkDob.Name = "dtpkDob";
            dtpkDob.Size = new Size(213, 23);
            dtpkDob.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 272);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 23;
            label10.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 235);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 22;
            label9.Text = "Điện thoại:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 197);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 21;
            label8.Text = "Địa chỉ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 159);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 20;
            label7.Text = "Giới tính:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 121);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 19;
            label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 83);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 18;
            label5.Text = "Tên:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnShowStudent);
            panel1.Controls.Add(btnDeleteStudent);
            panel1.Controls.Add(btnEditStudent);
            panel1.Controls.Add(btnAddStudent);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 47);
            panel1.TabIndex = 0;
            // 
            // btnShowStudent
            // 
            btnShowStudent.Location = new Point(283, 5);
            btnShowStudent.Margin = new Padding(2, 2, 2, 2);
            btnShowStudent.Name = "btnShowStudent";
            btnShowStudent.Size = new Size(57, 37);
            btnShowStudent.TabIndex = 3;
            btnShowStudent.Text = "Xem";
            btnShowStudent.UseVisualStyleBackColor = true;
            btnShowStudent.Click += btnShowStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(197, 5);
            btnDeleteStudent.Margin = new Padding(2, 2, 2, 2);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(57, 37);
            btnDeleteStudent.TabIndex = 2;
            btnDeleteStudent.Text = "Xóa";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnEditStudent
            // 
            btnEditStudent.Location = new Point(111, 5);
            btnEditStudent.Margin = new Padding(2, 2, 2, 2);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new Size(57, 37);
            btnEditStudent.TabIndex = 1;
            btnEditStudent.Text = "Sửa";
            btnEditStudent.UseVisualStyleBackColor = true;
            btnEditStudent.Click += btnEditStudent_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(24, 5);
            btnAddStudent.Margin = new Padding(2, 2, 2, 2);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(57, 37);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Thêm";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 46);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 17;
            label4.Text = "Họ:";
            // 
            // txbStudentEmail
            // 
            txbStudentEmail.Location = new Point(109, 264);
            txbStudentEmail.Margin = new Padding(2, 2, 2, 2);
            txbStudentEmail.Name = "txbStudentEmail";
            txbStudentEmail.Size = new Size(213, 23);
            txbStudentEmail.TabIndex = 4;
            // 
            // txbStudentSex
            // 
            txbStudentSex.Location = new Point(109, 154);
            txbStudentSex.Margin = new Padding(2, 2, 2, 2);
            txbStudentSex.Name = "txbStudentSex";
            txbStudentSex.Size = new Size(213, 23);
            txbStudentSex.TabIndex = 11;
            // 
            // txbStudentPhone
            // 
            txbStudentPhone.Location = new Point(109, 227);
            txbStudentPhone.Margin = new Padding(2, 2, 2, 2);
            txbStudentPhone.Name = "txbStudentPhone";
            txbStudentPhone.Size = new Size(213, 23);
            txbStudentPhone.TabIndex = 6;
            // 
            // tpClassroom
            // 
            tpClassroom.Controls.Add(cbClassroomYear);
            tpClassroom.Controls.Add(panel12);
            tpClassroom.Controls.Add(panel9);
            tpClassroom.Controls.Add(panel10);
            tpClassroom.Controls.Add(panel11);
            tpClassroom.Location = new Point(4, 24);
            tpClassroom.Margin = new Padding(2, 2, 2, 2);
            tpClassroom.Name = "tpClassroom";
            tpClassroom.Padding = new Padding(2, 2, 2, 2);
            tpClassroom.Size = new Size(746, 355);
            tpClassroom.TabIndex = 2;
            tpClassroom.Text = "Lớp học";
            tpClassroom.UseVisualStyleBackColor = true;
            // 
            // cbClassroomYear
            // 
            cbClassroomYear.FormattingEnabled = true;
            cbClassroomYear.Location = new Point(386, 14);
            cbClassroomYear.Margin = new Padding(2, 2, 2, 2);
            cbClassroomYear.Name = "cbClassroomYear";
            cbClassroomYear.Size = new Size(129, 23);
            cbClassroomYear.TabIndex = 5;
            // 
            // panel12
            // 
            panel12.Controls.Add(dtgvClassroom);
            panel12.Location = new Point(6, 61);
            panel12.Margin = new Padding(2, 2, 2, 2);
            panel12.Name = "panel12";
            panel12.Size = new Size(376, 302);
            panel12.TabIndex = 8;
            // 
            // dtgvClassroom
            // 
            dtgvClassroom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvClassroom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvClassroom.Columns.AddRange(new DataGridViewColumn[] { classroomId, classroomGrade, classroomOrder, classroomYear });
            dtgvClassroom.Location = new Point(0, 0);
            dtgvClassroom.Margin = new Padding(2, 2, 2, 2);
            dtgvClassroom.Name = "dtgvClassroom";
            dtgvClassroom.RowHeadersWidth = 62;
            dtgvClassroom.Size = new Size(374, 302);
            dtgvClassroom.TabIndex = 3;
            // 
            // classroomId
            // 
            classroomId.DataPropertyName = "Id";
            classroomId.HeaderText = "Mã";
            classroomId.MinimumWidth = 8;
            classroomId.Name = "classroomId";
            classroomId.Width = 150;
            // 
            // classroomGrade
            // 
            classroomGrade.DataPropertyName = "Grade";
            classroomGrade.HeaderText = "Khối";
            classroomGrade.MinimumWidth = 8;
            classroomGrade.Name = "classroomGrade";
            classroomGrade.Width = 150;
            // 
            // classroomOrder
            // 
            classroomOrder.DataPropertyName = "Order";
            classroomOrder.HeaderText = "Thứ tự";
            classroomOrder.MinimumWidth = 8;
            classroomOrder.Name = "classroomOrder";
            classroomOrder.Width = 150;
            // 
            // classroomYear
            // 
            classroomYear.DataPropertyName = "Year";
            classroomYear.HeaderText = "Năm học";
            classroomYear.MinimumWidth = 8;
            classroomYear.Name = "classroomYear";
            classroomYear.Width = 150;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnClassroomDetail);
            panel9.Controls.Add(txbClassroomYear);
            panel9.Controls.Add(label21);
            panel9.Controls.Add(label22);
            panel9.Controls.Add(label23);
            panel9.Controls.Add(txbClassroomOrder);
            panel9.Controls.Add(txbClassroomGrade);
            panel9.Controls.Add(txbClassroomId);
            panel9.Controls.Add(label24);
            panel9.Location = new Point(410, 61);
            panel9.Margin = new Padding(2, 2, 2, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(332, 299);
            panel9.TabIndex = 6;
            // 
            // btnClassroomDetail
            // 
            btnClassroomDetail.Location = new Point(78, 196);
            btnClassroomDetail.Margin = new Padding(2, 2, 2, 2);
            btnClassroomDetail.Name = "btnClassroomDetail";
            btnClassroomDetail.Size = new Size(202, 40);
            btnClassroomDetail.TabIndex = 9;
            btnClassroomDetail.Text = "Chi tiết lớp học";
            btnClassroomDetail.UseVisualStyleBackColor = true;
            btnClassroomDetail.Click += btnClassroomDetail_Click;
            // 
            // txbClassroomYear
            // 
            txbClassroomYear.Location = new Point(109, 119);
            txbClassroomYear.Margin = new Padding(2, 2, 2, 2);
            txbClassroomYear.Name = "txbClassroomYear";
            txbClassroomYear.Size = new Size(213, 23);
            txbClassroomYear.TabIndex = 25;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(12, 121);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(59, 15);
            label21.TabIndex = 19;
            label21.Text = "Năm học:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(12, 83);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(64, 15);
            label22.TabIndex = 18;
            label22.Text = "Thứ tự lớp:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(12, 46);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(34, 15);
            label23.TabIndex = 17;
            label23.Text = "Khối:";
            // 
            // txbClassroomOrder
            // 
            txbClassroomOrder.Location = new Point(109, 81);
            txbClassroomOrder.Margin = new Padding(2, 2, 2, 2);
            txbClassroomOrder.Name = "txbClassroomOrder";
            txbClassroomOrder.Size = new Size(213, 23);
            txbClassroomOrder.TabIndex = 12;
            // 
            // txbClassroomGrade
            // 
            txbClassroomGrade.Location = new Point(109, 44);
            txbClassroomGrade.Margin = new Padding(2, 2, 2, 2);
            txbClassroomGrade.Name = "txbClassroomGrade";
            txbClassroomGrade.Size = new Size(213, 23);
            txbClassroomGrade.TabIndex = 13;
            // 
            // txbClassroomId
            // 
            txbClassroomId.Location = new Point(109, 8);
            txbClassroomId.Margin = new Padding(2, 2, 2, 2);
            txbClassroomId.Name = "txbClassroomId";
            txbClassroomId.ReadOnly = true;
            txbClassroomId.Size = new Size(213, 23);
            txbClassroomId.TabIndex = 14;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(12, 8);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(21, 15);
            label24.TabIndex = 2;
            label24.Text = "ID:";
            // 
            // panel10
            // 
            panel10.Controls.Add(btnSearchClassroom);
            panel10.Controls.Add(txbSearchClassroom);
            panel10.Location = new Point(519, 2);
            panel10.Margin = new Padding(2, 2, 2, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(223, 47);
            panel10.TabIndex = 5;
            // 
            // btnSearchClassroom
            // 
            btnSearchClassroom.Location = new Point(143, 5);
            btnSearchClassroom.Margin = new Padding(2, 2, 2, 2);
            btnSearchClassroom.Name = "btnSearchClassroom";
            btnSearchClassroom.Size = new Size(57, 37);
            btnSearchClassroom.TabIndex = 3;
            btnSearchClassroom.Text = "Tìm";
            btnSearchClassroom.UseVisualStyleBackColor = true;
            btnSearchClassroom.Click += btnSearchClassroom_Click;
            // 
            // txbSearchClassroom
            // 
            txbSearchClassroom.Location = new Point(13, 14);
            txbSearchClassroom.Margin = new Padding(2, 2, 2, 2);
            txbSearchClassroom.Name = "txbSearchClassroom";
            txbSearchClassroom.Size = new Size(112, 23);
            txbSearchClassroom.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnShowClassroom);
            panel11.Controls.Add(btnDeleteClassroom);
            panel11.Controls.Add(btnEditClassroom);
            panel11.Controls.Add(btnAddClassroom);
            panel11.Location = new Point(6, 0);
            panel11.Margin = new Padding(2, 2, 2, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(376, 47);
            panel11.TabIndex = 4;
            // 
            // btnShowClassroom
            // 
            btnShowClassroom.Location = new Point(283, 5);
            btnShowClassroom.Margin = new Padding(2, 2, 2, 2);
            btnShowClassroom.Name = "btnShowClassroom";
            btnShowClassroom.Size = new Size(57, 37);
            btnShowClassroom.TabIndex = 3;
            btnShowClassroom.Text = "Xem";
            btnShowClassroom.UseVisualStyleBackColor = true;
            btnShowClassroom.Click += btnShowClassroom_Click;
            // 
            // btnDeleteClassroom
            // 
            btnDeleteClassroom.Location = new Point(197, 5);
            btnDeleteClassroom.Margin = new Padding(2, 2, 2, 2);
            btnDeleteClassroom.Name = "btnDeleteClassroom";
            btnDeleteClassroom.Size = new Size(57, 37);
            btnDeleteClassroom.TabIndex = 2;
            btnDeleteClassroom.Text = "Xóa";
            btnDeleteClassroom.UseVisualStyleBackColor = true;
            btnDeleteClassroom.Click += btnDeleteClassroom_Click;
            // 
            // btnEditClassroom
            // 
            btnEditClassroom.Location = new Point(111, 5);
            btnEditClassroom.Margin = new Padding(2, 2, 2, 2);
            btnEditClassroom.Name = "btnEditClassroom";
            btnEditClassroom.Size = new Size(57, 37);
            btnEditClassroom.TabIndex = 1;
            btnEditClassroom.Text = "Sửa";
            btnEditClassroom.UseVisualStyleBackColor = true;
            btnEditClassroom.Click += btnEditClassroom_Click;
            // 
            // btnAddClassroom
            // 
            btnAddClassroom.Location = new Point(24, 5);
            btnAddClassroom.Margin = new Padding(2, 2, 2, 2);
            btnAddClassroom.Name = "btnAddClassroom";
            btnAddClassroom.Size = new Size(57, 37);
            btnAddClassroom.TabIndex = 0;
            btnAddClassroom.Text = "Thêm";
            btnAddClassroom.UseVisualStyleBackColor = true;
            btnAddClassroom.Click += btnAddClassroom_Click;
            // 
            // txbStudentFirstname
            // 
            txbStudentFirstname.Location = new Point(109, 81);
            txbStudentFirstname.Margin = new Padding(2, 2, 2, 2);
            txbStudentFirstname.Name = "txbStudentFirstname";
            txbStudentFirstname.Size = new Size(213, 23);
            txbStudentFirstname.TabIndex = 12;
            // 
            // txbStudentLastname
            // 
            txbStudentLastname.Location = new Point(109, 44);
            txbStudentLastname.Margin = new Padding(2, 2, 2, 2);
            txbStudentLastname.Name = "txbStudentLastname";
            txbStudentLastname.Size = new Size(213, 23);
            txbStudentLastname.TabIndex = 13;
            // 
            // txbStudentId
            // 
            txbStudentId.Location = new Point(109, 8);
            txbStudentId.Margin = new Padding(2, 2, 2, 2);
            txbStudentId.Name = "txbStudentId";
            txbStudentId.ReadOnly = true;
            txbStudentId.Size = new Size(213, 23);
            txbStudentId.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // panel4
            // 
            panel4.Controls.Add(dtpkDob);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txbStudentEmail);
            panel4.Controls.Add(txbStudentSex);
            panel4.Controls.Add(txbStudentPhone);
            panel4.Controls.Add(txbStudentFirstname);
            panel4.Controls.Add(txbStudentLastname);
            panel4.Controls.Add(txbStudentId);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txbStudentAddress);
            panel4.Location = new Point(403, 61);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(332, 299);
            panel4.TabIndex = 3;
            // 
            // txbStudentAddress
            // 
            txbStudentAddress.Location = new Point(109, 191);
            txbStudentAddress.Margin = new Padding(2, 2, 2, 2);
            txbStudentAddress.Name = "txbStudentAddress";
            txbStudentAddress.Size = new Size(213, 23);
            txbStudentAddress.TabIndex = 5;
            // 
            // tpStudent
            // 
            tpStudent.Controls.Add(panel4);
            tpStudent.Controls.Add(panel3);
            tpStudent.Controls.Add(panel2);
            tpStudent.Controls.Add(panel1);
            tpStudent.Location = new Point(4, 24);
            tpStudent.Margin = new Padding(2, 2, 2, 2);
            tpStudent.Name = "tpStudent";
            tpStudent.Padding = new Padding(2, 2, 2, 2);
            tpStudent.Size = new Size(746, 355);
            tpStudent.TabIndex = 0;
            tpStudent.Text = "Học sinh";
            tpStudent.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tpStudent);
            tabControl1.Controls.Add(tpSubject);
            tabControl1.Controls.Add(tpClassroom);
            tabControl1.Controls.Add(tpTeacher);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Margin = new Padding(2, 2, 2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(754, 383);
            tabControl1.TabIndex = 1;
            // 
            // tpSubject
            // 
            tpSubject.Controls.Add(cbSubjectGrade);
            tpSubject.Controls.Add(panel8);
            tpSubject.Controls.Add(panel5);
            tpSubject.Controls.Add(panel6);
            tpSubject.Controls.Add(panel7);
            tpSubject.Location = new Point(4, 24);
            tpSubject.Margin = new Padding(2, 2, 2, 2);
            tpSubject.Name = "tpSubject";
            tpSubject.Padding = new Padding(2, 2, 2, 2);
            tpSubject.Size = new Size(746, 355);
            tpSubject.TabIndex = 1;
            tpSubject.Text = "Môn học";
            tpSubject.UseVisualStyleBackColor = true;
            // 
            // cbSubjectGrade
            // 
            cbSubjectGrade.FormattingEnabled = true;
            cbSubjectGrade.Items.AddRange(new object[] { "10", "11", "12" });
            cbSubjectGrade.Location = new Point(387, 14);
            cbSubjectGrade.Margin = new Padding(2, 2, 2, 2);
            cbSubjectGrade.Name = "cbSubjectGrade";
            cbSubjectGrade.Size = new Size(129, 23);
            cbSubjectGrade.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.Controls.Add(dtgvSubject);
            panel8.Location = new Point(6, 63);
            panel8.Margin = new Padding(2, 2, 2, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(376, 298);
            panel8.TabIndex = 8;
            // 
            // dtgvSubject
            // 
            dtgvSubject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSubject.Columns.AddRange(new DataGridViewColumn[] { subjetId, subjectName, subjectGrade });
            dtgvSubject.Location = new Point(-1, 0);
            dtgvSubject.Margin = new Padding(2, 2, 2, 2);
            dtgvSubject.Name = "dtgvSubject";
            dtgvSubject.RowHeadersWidth = 62;
            dtgvSubject.Size = new Size(377, 298);
            dtgvSubject.TabIndex = 6;
            // 
            // subjetId
            // 
            subjetId.DataPropertyName = "Id";
            subjetId.HeaderText = "Mã";
            subjetId.MinimumWidth = 8;
            subjetId.Name = "subjetId";
            subjetId.Width = 150;
            // 
            // subjectName
            // 
            subjectName.DataPropertyName = "Name";
            subjectName.HeaderText = "Tên môn";
            subjectName.MinimumWidth = 8;
            subjectName.Name = "subjectName";
            subjectName.Width = 150;
            // 
            // subjectGrade
            // 
            subjectGrade.DataPropertyName = "Grade";
            subjectGrade.HeaderText = "Khối";
            subjectGrade.MinimumWidth = 8;
            subjectGrade.Name = "subjectGrade";
            subjectGrade.Width = 150;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnShowSubject);
            panel5.Controls.Add(btnDeleteSubject);
            panel5.Controls.Add(btnEditSubject);
            panel5.Controls.Add(btnAddSubject);
            panel5.Location = new Point(6, 0);
            panel5.Margin = new Padding(2, 2, 2, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(376, 47);
            panel5.TabIndex = 4;
            // 
            // btnShowSubject
            // 
            btnShowSubject.Location = new Point(283, 5);
            btnShowSubject.Margin = new Padding(2, 2, 2, 2);
            btnShowSubject.Name = "btnShowSubject";
            btnShowSubject.Size = new Size(57, 37);
            btnShowSubject.TabIndex = 3;
            btnShowSubject.Text = "Xem";
            btnShowSubject.UseVisualStyleBackColor = true;
            btnShowSubject.Click += btnShowSubject_Click;
            // 
            // btnDeleteSubject
            // 
            btnDeleteSubject.Location = new Point(197, 5);
            btnDeleteSubject.Margin = new Padding(2, 2, 2, 2);
            btnDeleteSubject.Name = "btnDeleteSubject";
            btnDeleteSubject.Size = new Size(57, 37);
            btnDeleteSubject.TabIndex = 2;
            btnDeleteSubject.Text = "Xóa";
            btnDeleteSubject.UseVisualStyleBackColor = true;
            btnDeleteSubject.Click += btnDeleteSubject_Click;
            // 
            // btnEditSubject
            // 
            btnEditSubject.Location = new Point(111, 5);
            btnEditSubject.Margin = new Padding(2, 2, 2, 2);
            btnEditSubject.Name = "btnEditSubject";
            btnEditSubject.Size = new Size(57, 37);
            btnEditSubject.TabIndex = 1;
            btnEditSubject.Text = "Sửa";
            btnEditSubject.UseVisualStyleBackColor = true;
            btnEditSubject.Click += btnEditSubject_Click;
            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(24, 5);
            btnAddSubject.Margin = new Padding(2, 2, 2, 2);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(57, 37);
            btnAddSubject.TabIndex = 0;
            btnAddSubject.Text = "Thêm";
            btnAddSubject.UseVisualStyleBackColor = true;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label15);
            panel6.Controls.Add(txbSubjectGrade);
            panel6.Controls.Add(txbSubjectName);
            panel6.Controls.Add(txbSubjectId);
            panel6.Controls.Add(label16);
            panel6.Location = new Point(410, 61);
            panel6.Margin = new Padding(2, 2, 2, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(332, 299);
            panel6.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 83);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(34, 15);
            label14.TabIndex = 18;
            label14.Text = "Khối:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 46);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(28, 15);
            label15.TabIndex = 17;
            label15.Text = "Tên:";
            // 
            // txbSubjectGrade
            // 
            txbSubjectGrade.Location = new Point(109, 81);
            txbSubjectGrade.Margin = new Padding(2, 2, 2, 2);
            txbSubjectGrade.Name = "txbSubjectGrade";
            txbSubjectGrade.Size = new Size(213, 23);
            txbSubjectGrade.TabIndex = 12;
            // 
            // txbSubjectName
            // 
            txbSubjectName.Location = new Point(109, 44);
            txbSubjectName.Margin = new Padding(2, 2, 2, 2);
            txbSubjectName.Name = "txbSubjectName";
            txbSubjectName.Size = new Size(213, 23);
            txbSubjectName.TabIndex = 13;
            // 
            // txbSubjectId
            // 
            txbSubjectId.Location = new Point(109, 8);
            txbSubjectId.Margin = new Padding(2, 2, 2, 2);
            txbSubjectId.Name = "txbSubjectId";
            txbSubjectId.ReadOnly = true;
            txbSubjectId.Size = new Size(213, 23);
            txbSubjectId.TabIndex = 14;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(12, 8);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(21, 15);
            label16.TabIndex = 2;
            label16.Text = "ID:";
            // 
            // panel7
            // 
            panel7.Controls.Add(btnSearchSubject);
            panel7.Controls.Add(txbSearchSubject);
            panel7.Location = new Point(519, 2);
            panel7.Margin = new Padding(2, 2, 2, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(223, 47);
            panel7.TabIndex = 5;
            // 
            // btnSearchSubject
            // 
            btnSearchSubject.Location = new Point(152, 5);
            btnSearchSubject.Margin = new Padding(2, 2, 2, 2);
            btnSearchSubject.Name = "btnSearchSubject";
            btnSearchSubject.Size = new Size(57, 37);
            btnSearchSubject.TabIndex = 3;
            btnSearchSubject.Text = "Tìm";
            btnSearchSubject.UseVisualStyleBackColor = true;
            btnSearchSubject.Click += btnSearchSubject_Click;
            // 
            // txbSearchSubject
            // 
            txbSearchSubject.Location = new Point(14, 14);
            txbSearchSubject.Margin = new Padding(2, 2, 2, 2);
            txbSearchSubject.Name = "txbSearchSubject";
            txbSearchSubject.Size = new Size(120, 23);
            txbSearchSubject.TabIndex = 1;
            // 
            // tpTeacher
            // 
            tpTeacher.Controls.Add(dtgvTeacher);
            tpTeacher.Controls.Add(btnAssignSubject);
            tpTeacher.Location = new Point(4, 24);
            tpTeacher.Margin = new Padding(2, 2, 2, 2);
            tpTeacher.Name = "tpTeacher";
            tpTeacher.Size = new Size(746, 355);
            tpTeacher.TabIndex = 3;
            tpTeacher.Text = "Giáo viên";
            tpTeacher.UseVisualStyleBackColor = true;
            // 
            // dtgvTeacher
            // 
            dtgvTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTeacher.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dtgvTeacher.Dock = DockStyle.Bottom;
            dtgvTeacher.Location = new Point(0, 59);
            dtgvTeacher.Margin = new Padding(2, 2, 2, 2);
            dtgvTeacher.Name = "dtgvTeacher";
            dtgvTeacher.RowHeadersWidth = 62;
            dtgvTeacher.Size = new Size(746, 296);
            dtgvTeacher.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Mã";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            dataGridViewTextBoxColumn3.HeaderText = "Tên";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Dob";
            dataGridViewTextBoxColumn4.HeaderText = "Ngày sinh";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Sex";
            dataGridViewTextBoxColumn5.HeaderText = "Giới tính";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Address";
            dataGridViewTextBoxColumn6.HeaderText = "Địa chỉ";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // btnAssignSubject
            // 
            btnAssignSubject.Location = new Point(281, 11);
            btnAssignSubject.Margin = new Padding(2, 2, 2, 2);
            btnAssignSubject.Name = "btnAssignSubject";
            btnAssignSubject.Size = new Size(202, 40);
            btnAssignSubject.TabIndex = 10;
            btnAssignSubject.Text = "Phân công giảng dạy";
            btnAssignSubject.UseVisualStyleBackColor = true;
            btnAssignSubject.Click += btnAssignSubject_Click;
            // 
            // fManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 384);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "fManager";
            Text = "fManager";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvStudent).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            tpClassroom.ResumeLayout(false);
            panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvClassroom).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tpStudent.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tpSubject.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvSubject).EndInit();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            tpTeacher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTeacher).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private DataGridView dtgvStudent;
        private Panel panel2;
        private Button btnSearchStudent;
        private TextBox txbSearchStudent;
        private DateTimePicker dtpkDob;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel1;
        private Button btnShowStudent;
        private Button btnDeleteStudent;
        private Button btnEditStudent;
        private Button btnAddStudent;
        private Label label4;
        private TextBox txbStudentEmail;
        private TextBox txbStudentSex;
        private TextBox txbStudentPhone;
        private TabPage tpClassroom;
        private TextBox txbStudentFirstname;
        private TextBox txbStudentLastname;
        private TextBox txbStudentId;
        private Label label1;
        private Panel panel4;
        private TextBox txbStudentAddress;
        private TabPage tpStudent;
        private TabControl tabControl1;
        private TabPage tpSubject;
        private Panel panel8;
        private DataGridView dtgvSubject;
        private Panel panel5;
        private Button btnShowSubject;
        private Button btnDeleteSubject;
        private Button btnEditSubject;
        private Button btnAddSubject;
        private Panel panel6;
        private Label label14;
        private Label label15;
        private TextBox txbSubjectGrade;
        private TextBox txbSubjectName;
        private TextBox txbSubjectId;
        private Label label16;
        private Panel panel7;
        private Button btnSearchSubject;
        private TextBox txbSearchSubject;
        private Panel panel12;
        private DataGridView dtgvClassroom;
        private Panel panel9;
        private DateTimePicker dateTimePicker2;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox txbClassroomOrder;
        private TextBox txbClassroomGrade;
        private TextBox txbClassroomId;
        private Label label24;
        private TextBox textBox15;
        private Panel panel10;
        private Button btnSearchClassroom;
        private TextBox txbSearchClassroom;
        private Panel panel11;
        private Button btnShowClassroom;
        private Button btnDeleteClassroom;
        private Button btnEditClassroom;
        private Button btnAddClassroom;
        private ComboBox cbSubjectGrade;
        private ComboBox cbClassroomYear;
        private TextBox txbClassroomYear;
        private Button btnClassroomDetail;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Dob;
        private DataGridViewTextBoxColumn Sex;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Classrooms;
        private DataGridViewTextBoxColumn classroomId;
        private DataGridViewTextBoxColumn classroomGrade;
        private DataGridViewTextBoxColumn classroomOrder;
        private DataGridViewTextBoxColumn classroomYear;
        private DataGridViewTextBoxColumn subjetId;
        private DataGridViewTextBoxColumn subjectName;
        private DataGridViewTextBoxColumn subjectGrade;
        private TabPage tpTeacher;
        private Button btnAssignSubject;
        private DataGridView dtgvTeacher;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}