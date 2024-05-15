namespace GUI_QLHT
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
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvStudent);
            panel3.Location = new Point(0, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(537, 496);
            panel3.TabIndex = 2;
            // 
            // dtgvStudent
            // 
            dtgvStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStudent.Location = new Point(0, 0);
            dtgvStudent.Name = "dtgvStudent";
            dtgvStudent.RowHeadersWidth = 62;
            dtgvStudent.Size = new Size(537, 496);
            dtgvStudent.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSearchStudent);
            panel2.Controls.Add(txbSearchStudent);
            panel2.Location = new Point(732, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 79);
            panel2.TabIndex = 1;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.Location = new Point(233, 9);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(82, 61);
            btnSearchStudent.TabIndex = 3;
            btnSearchStudent.Text = "Tìm";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // txbSearchStudent
            // 
            txbSearchStudent.Location = new Point(14, 24);
            txbSearchStudent.Name = "txbSearchStudent";
            txbSearchStudent.Size = new Size(204, 31);
            txbSearchStudent.TabIndex = 1;
            // 
            // dtpkDob
            // 
            dtpkDob.Location = new Point(156, 196);
            dtpkDob.Name = "dtpkDob";
            dtpkDob.Size = new Size(303, 31);
            dtpkDob.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 454);
            label10.Name = "label10";
            label10.Size = new Size(58, 25);
            label10.TabIndex = 23;
            label10.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 391);
            label9.Name = "label9";
            label9.Size = new Size(97, 25);
            label9.TabIndex = 22;
            label9.Text = "Điện thoại:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 328);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 21;
            label8.Text = "Địa chỉ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 265);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 20;
            label7.Text = "Giới tính:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 202);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 19;
            label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 139);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 79);
            panel1.TabIndex = 0;
            // 
            // btnShowStudent
            // 
            btnShowStudent.Location = new Point(404, 9);
            btnShowStudent.Name = "btnShowStudent";
            btnShowStudent.Size = new Size(82, 61);
            btnShowStudent.TabIndex = 3;
            btnShowStudent.Text = "Xem";
            btnShowStudent.UseVisualStyleBackColor = true;
            btnShowStudent.Click += btnShowStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(281, 9);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(82, 61);
            btnDeleteStudent.TabIndex = 2;
            btnDeleteStudent.Text = "Xóa";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnEditStudent
            // 
            btnEditStudent.Location = new Point(158, 9);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new Size(82, 61);
            btnEditStudent.TabIndex = 1;
            btnEditStudent.Text = "Sửa";
            btnEditStudent.UseVisualStyleBackColor = true;
            btnEditStudent.Click += btnEditStudent_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(35, 9);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(82, 61);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Thêm";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 76);
            label4.Name = "label4";
            label4.Size = new Size(40, 25);
            label4.TabIndex = 17;
            label4.Text = "Họ:";
            // 
            // txbStudentEmail
            // 
            txbStudentEmail.Location = new Point(156, 440);
            txbStudentEmail.Name = "txbStudentEmail";
            txbStudentEmail.Size = new Size(303, 31);
            txbStudentEmail.TabIndex = 4;
            // 
            // txbStudentSex
            // 
            txbStudentSex.Location = new Point(156, 257);
            txbStudentSex.Name = "txbStudentSex";
            txbStudentSex.Size = new Size(303, 31);
            txbStudentSex.TabIndex = 11;
            // 
            // txbStudentPhone
            // 
            txbStudentPhone.Location = new Point(156, 379);
            txbStudentPhone.Name = "txbStudentPhone";
            txbStudentPhone.Size = new Size(303, 31);
            txbStudentPhone.TabIndex = 6;
            // 
            // tpClassroom
            // 
            tpClassroom.Controls.Add(cbClassroomYear);
            tpClassroom.Controls.Add(panel12);
            tpClassroom.Controls.Add(panel9);
            tpClassroom.Controls.Add(panel10);
            tpClassroom.Controls.Add(panel11);
            tpClassroom.Location = new Point(4, 34);
            tpClassroom.Name = "tpClassroom";
            tpClassroom.Padding = new Padding(3);
            tpClassroom.Size = new Size(1069, 601);
            tpClassroom.TabIndex = 2;
            tpClassroom.Text = "Lớp học";
            tpClassroom.UseVisualStyleBackColor = true;
            // 
            // cbClassroomYear
            // 
            cbClassroomYear.FormattingEnabled = true;
            cbClassroomYear.Location = new Point(552, 24);
            cbClassroomYear.Name = "cbClassroomYear";
            cbClassroomYear.Size = new Size(182, 33);
            cbClassroomYear.TabIndex = 5;
            // 
            // panel12
            // 
            panel12.Controls.Add(dtgvClassroom);
            panel12.Location = new Point(9, 102);
            panel12.Name = "panel12";
            panel12.Size = new Size(537, 503);
            panel12.TabIndex = 8;
            // 
            // dtgvClassroom
            // 
            dtgvClassroom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvClassroom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvClassroom.Location = new Point(0, 0);
            dtgvClassroom.Name = "dtgvClassroom";
            dtgvClassroom.RowHeadersWidth = 62;
            dtgvClassroom.Size = new Size(534, 503);
            dtgvClassroom.TabIndex = 3;
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
            panel9.Location = new Point(585, 102);
            panel9.Name = "panel9";
            panel9.Size = new Size(475, 499);
            panel9.TabIndex = 6;
            // 
            // btnClassroomDetail
            // 
            btnClassroomDetail.Location = new Point(112, 327);
            btnClassroomDetail.Name = "btnClassroomDetail";
            btnClassroomDetail.Size = new Size(288, 67);
            btnClassroomDetail.TabIndex = 9;
            btnClassroomDetail.Text = "Chi tiết lớp học";
            btnClassroomDetail.UseVisualStyleBackColor = true;
            btnClassroomDetail.Click += btnClassroomDetail_Click;
            // 
            // txbClassroomYear
            // 
            txbClassroomYear.Location = new Point(156, 198);
            txbClassroomYear.Name = "txbClassroomYear";
            txbClassroomYear.Size = new Size(303, 31);
            txbClassroomYear.TabIndex = 25;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(17, 202);
            label21.Name = "label21";
            label21.Size = new Size(88, 25);
            label21.TabIndex = 19;
            label21.Text = "Năm học:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(17, 139);
            label22.Name = "label22";
            label22.Size = new Size(99, 25);
            label22.TabIndex = 18;
            label22.Text = "Thứ tự lớp:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(17, 76);
            label23.Name = "label23";
            label23.Size = new Size(51, 25);
            label23.TabIndex = 17;
            label23.Text = "Khối:";
            // 
            // txbClassroomOrder
            // 
            txbClassroomOrder.Location = new Point(156, 135);
            txbClassroomOrder.Name = "txbClassroomOrder";
            txbClassroomOrder.Size = new Size(303, 31);
            txbClassroomOrder.TabIndex = 12;
            // 
            // txbClassroomGrade
            // 
            txbClassroomGrade.Location = new Point(156, 74);
            txbClassroomGrade.Name = "txbClassroomGrade";
            txbClassroomGrade.Size = new Size(303, 31);
            txbClassroomGrade.TabIndex = 13;
            // 
            // txbClassroomId
            // 
            txbClassroomId.Location = new Point(156, 13);
            txbClassroomId.Name = "txbClassroomId";
            txbClassroomId.ReadOnly = true;
            txbClassroomId.Size = new Size(303, 31);
            txbClassroomId.TabIndex = 14;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(17, 13);
            label24.Name = "label24";
            label24.Size = new Size(34, 25);
            label24.TabIndex = 2;
            label24.Text = "ID:";
            // 
            // panel10
            // 
            panel10.Controls.Add(btnSearchClassroom);
            panel10.Controls.Add(txbSearchClassroom);
            panel10.Location = new Point(741, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(319, 79);
            panel10.TabIndex = 5;
            // 
            // btnSearchClassroom
            // 
            btnSearchClassroom.Location = new Point(204, 9);
            btnSearchClassroom.Name = "btnSearchClassroom";
            btnSearchClassroom.Size = new Size(82, 61);
            btnSearchClassroom.TabIndex = 3;
            btnSearchClassroom.Text = "Tìm";
            btnSearchClassroom.UseVisualStyleBackColor = true;
            btnSearchClassroom.Click += btnSearchClassroom_Click;
            // 
            // txbSearchClassroom
            // 
            txbSearchClassroom.Location = new Point(18, 24);
            txbSearchClassroom.Name = "txbSearchClassroom";
            txbSearchClassroom.Size = new Size(159, 31);
            txbSearchClassroom.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnShowClassroom);
            panel11.Controls.Add(btnDeleteClassroom);
            panel11.Controls.Add(btnEditClassroom);
            panel11.Controls.Add(btnAddClassroom);
            panel11.Location = new Point(9, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(537, 79);
            panel11.TabIndex = 4;
            // 
            // btnShowClassroom
            // 
            btnShowClassroom.Location = new Point(404, 9);
            btnShowClassroom.Name = "btnShowClassroom";
            btnShowClassroom.Size = new Size(82, 61);
            btnShowClassroom.TabIndex = 3;
            btnShowClassroom.Text = "Xem";
            btnShowClassroom.UseVisualStyleBackColor = true;
            btnShowClassroom.Click += btnShowClassroom_Click;
            // 
            // btnDeleteClassroom
            // 
            btnDeleteClassroom.Location = new Point(281, 9);
            btnDeleteClassroom.Name = "btnDeleteClassroom";
            btnDeleteClassroom.Size = new Size(82, 61);
            btnDeleteClassroom.TabIndex = 2;
            btnDeleteClassroom.Text = "Xóa";
            btnDeleteClassroom.UseVisualStyleBackColor = true;
            btnDeleteClassroom.Click += btnDeleteClassroom_Click;
            // 
            // btnEditClassroom
            // 
            btnEditClassroom.Location = new Point(158, 9);
            btnEditClassroom.Name = "btnEditClassroom";
            btnEditClassroom.Size = new Size(82, 61);
            btnEditClassroom.TabIndex = 1;
            btnEditClassroom.Text = "Sửa";
            btnEditClassroom.UseVisualStyleBackColor = true;
            btnEditClassroom.Click += btnEditClassroom_Click;
            // 
            // btnAddClassroom
            // 
            btnAddClassroom.Location = new Point(35, 9);
            btnAddClassroom.Name = "btnAddClassroom";
            btnAddClassroom.Size = new Size(82, 61);
            btnAddClassroom.TabIndex = 0;
            btnAddClassroom.Text = "Thêm";
            btnAddClassroom.UseVisualStyleBackColor = true;
            btnAddClassroom.Click += btnAddClassroom_Click;
            // 
            // txbStudentFirstname
            // 
            txbStudentFirstname.Location = new Point(156, 135);
            txbStudentFirstname.Name = "txbStudentFirstname";
            txbStudentFirstname.Size = new Size(303, 31);
            txbStudentFirstname.TabIndex = 12;
            // 
            // txbStudentLastname
            // 
            txbStudentLastname.Location = new Point(156, 74);
            txbStudentLastname.Name = "txbStudentLastname";
            txbStudentLastname.Size = new Size(303, 31);
            txbStudentLastname.TabIndex = 13;
            // 
            // txbStudentId
            // 
            txbStudentId.Location = new Point(156, 13);
            txbStudentId.Name = "txbStudentId";
            txbStudentId.ReadOnly = true;
            txbStudentId.Size = new Size(303, 31);
            txbStudentId.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
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
            panel4.Location = new Point(576, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(475, 499);
            panel4.TabIndex = 3;
            // 
            // txbStudentAddress
            // 
            txbStudentAddress.Location = new Point(156, 318);
            txbStudentAddress.Name = "txbStudentAddress";
            txbStudentAddress.Size = new Size(303, 31);
            txbStudentAddress.TabIndex = 5;
            // 
            // tpStudent
            // 
            tpStudent.Controls.Add(panel4);
            tpStudent.Controls.Add(panel3);
            tpStudent.Controls.Add(panel2);
            tpStudent.Controls.Add(panel1);
            tpStudent.Location = new Point(4, 34);
            tpStudent.Name = "tpStudent";
            tpStudent.Padding = new Padding(3);
            tpStudent.Size = new Size(1069, 601);
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
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1077, 639);
            tabControl1.TabIndex = 1;
            // 
            // tpSubject
            // 
            tpSubject.Controls.Add(cbSubjectGrade);
            tpSubject.Controls.Add(panel8);
            tpSubject.Controls.Add(panel5);
            tpSubject.Controls.Add(panel6);
            tpSubject.Controls.Add(panel7);
            tpSubject.Location = new Point(4, 34);
            tpSubject.Name = "tpSubject";
            tpSubject.Padding = new Padding(3);
            tpSubject.Size = new Size(1069, 601);
            tpSubject.TabIndex = 1;
            tpSubject.Text = "Môn học";
            tpSubject.UseVisualStyleBackColor = true;
            // 
            // cbSubjectGrade
            // 
            cbSubjectGrade.FormattingEnabled = true;
            cbSubjectGrade.Items.AddRange(new object[] { "10", "11", "12" });
            cbSubjectGrade.Location = new Point(553, 24);
            cbSubjectGrade.Name = "cbSubjectGrade";
            cbSubjectGrade.Size = new Size(182, 33);
            cbSubjectGrade.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.Controls.Add(dtgvSubject);
            panel8.Location = new Point(9, 105);
            panel8.Name = "panel8";
            panel8.Size = new Size(537, 496);
            panel8.TabIndex = 8;
            // 
            // dtgvSubject
            // 
            dtgvSubject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSubject.Location = new Point(-1, 0);
            dtgvSubject.Name = "dtgvSubject";
            dtgvSubject.RowHeadersWidth = 62;
            dtgvSubject.Size = new Size(538, 496);
            dtgvSubject.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnShowSubject);
            panel5.Controls.Add(btnDeleteSubject);
            panel5.Controls.Add(btnEditSubject);
            panel5.Controls.Add(btnAddSubject);
            panel5.Location = new Point(9, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(537, 79);
            panel5.TabIndex = 4;
            // 
            // btnShowSubject
            // 
            btnShowSubject.Location = new Point(404, 9);
            btnShowSubject.Name = "btnShowSubject";
            btnShowSubject.Size = new Size(82, 61);
            btnShowSubject.TabIndex = 3;
            btnShowSubject.Text = "Xem";
            btnShowSubject.UseVisualStyleBackColor = true;
            btnShowSubject.Click += btnShowSubject_Click;
            // 
            // btnDeleteSubject
            // 
            btnDeleteSubject.Location = new Point(281, 9);
            btnDeleteSubject.Name = "btnDeleteSubject";
            btnDeleteSubject.Size = new Size(82, 61);
            btnDeleteSubject.TabIndex = 2;
            btnDeleteSubject.Text = "Xóa";
            btnDeleteSubject.UseVisualStyleBackColor = true;
            btnDeleteSubject.Click += btnDeleteSubject_Click;
            // 
            // btnEditSubject
            // 
            btnEditSubject.Location = new Point(158, 9);
            btnEditSubject.Name = "btnEditSubject";
            btnEditSubject.Size = new Size(82, 61);
            btnEditSubject.TabIndex = 1;
            btnEditSubject.Text = "Sửa";
            btnEditSubject.UseVisualStyleBackColor = true;
            btnEditSubject.Click += btnEditSubject_Click;
            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(35, 9);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(82, 61);
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
            panel6.Location = new Point(585, 102);
            panel6.Name = "panel6";
            panel6.Size = new Size(475, 499);
            panel6.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(17, 139);
            label14.Name = "label14";
            label14.Size = new Size(51, 25);
            label14.TabIndex = 18;
            label14.Text = "Khối:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(17, 76);
            label15.Name = "label15";
            label15.Size = new Size(42, 25);
            label15.TabIndex = 17;
            label15.Text = "Tên:";
            // 
            // txbSubjectGrade
            // 
            txbSubjectGrade.Location = new Point(156, 135);
            txbSubjectGrade.Name = "txbSubjectGrade";
            txbSubjectGrade.Size = new Size(303, 31);
            txbSubjectGrade.TabIndex = 12;
            // 
            // txbSubjectName
            // 
            txbSubjectName.Location = new Point(156, 74);
            txbSubjectName.Name = "txbSubjectName";
            txbSubjectName.Size = new Size(303, 31);
            txbSubjectName.TabIndex = 13;
            // 
            // txbSubjectId
            // 
            txbSubjectId.Location = new Point(156, 13);
            txbSubjectId.Name = "txbSubjectId";
            txbSubjectId.ReadOnly = true;
            txbSubjectId.Size = new Size(303, 31);
            txbSubjectId.TabIndex = 14;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 13);
            label16.Name = "label16";
            label16.Size = new Size(34, 25);
            label16.TabIndex = 2;
            label16.Text = "ID:";
            // 
            // panel7
            // 
            panel7.Controls.Add(btnSearchSubject);
            panel7.Controls.Add(txbSearchSubject);
            panel7.Location = new Point(741, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(319, 79);
            panel7.TabIndex = 5;
            // 
            // btnSearchSubject
            // 
            btnSearchSubject.Location = new Point(217, 9);
            btnSearchSubject.Name = "btnSearchSubject";
            btnSearchSubject.Size = new Size(82, 61);
            btnSearchSubject.TabIndex = 3;
            btnSearchSubject.Text = "Tìm";
            btnSearchSubject.UseVisualStyleBackColor = true;
            btnSearchSubject.Click += btnSearchSubject_Click;
            // 
            // txbSearchSubject
            // 
            txbSearchSubject.Location = new Point(20, 24);
            txbSearchSubject.Name = "txbSearchSubject";
            txbSearchSubject.Size = new Size(170, 31);
            txbSearchSubject.TabIndex = 1;
            // 
            // fManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 640);
            Controls.Add(tabControl1);
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
    }
}