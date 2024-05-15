namespace GUI_QLHT
{
    partial class fUser
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
            tpTeacher = new TabPage();
            cbTypeUser = new ComboBox();
            panel4 = new Panel();
            dtpkDob = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txbUserEmail = new TextBox();
            txbUserSex = new TextBox();
            txbUserPhone = new TextBox();
            txbUserUsername = new TextBox();
            txbUserPassword = new TextBox();
            txbUserFirstname = new TextBox();
            txbUserLastname = new TextBox();
            txbUserId = new TextBox();
            label1 = new Label();
            txbUserAddress = new TextBox();
            panel3 = new Panel();
            dtgvUser = new DataGridView();
            panel2 = new Panel();
            btnSearchUser = new Button();
            txbSearchUser = new TextBox();
            panel1 = new Panel();
            btnShowUser = new Button();
            btnDeleteUser = new Button();
            btnEditUser = new Button();
            btnAddUser = new Button();
            Id = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            Dob = new DataGridViewTextBoxColumn();
            Sex = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tpTeacher.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvUser).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tpTeacher);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1077, 639);
            tabControl1.TabIndex = 0;
            // 
            // tpTeacher
            // 
            tpTeacher.Controls.Add(cbTypeUser);
            tpTeacher.Controls.Add(panel4);
            tpTeacher.Controls.Add(panel3);
            tpTeacher.Controls.Add(panel2);
            tpTeacher.Controls.Add(panel1);
            tpTeacher.Location = new Point(4, 34);
            tpTeacher.Name = "tpTeacher";
            tpTeacher.Padding = new Padding(3);
            tpTeacher.Size = new Size(1069, 601);
            tpTeacher.TabIndex = 0;
            tpTeacher.UseVisualStyleBackColor = true;
            // 
            // cbTypeUser
            // 
            cbTypeUser.FormattingEnabled = true;
            cbTypeUser.Items.AddRange(new object[] { "Giáo viên", "Giáo vụ", "Quản trị viên" });
            cbTypeUser.Location = new Point(543, 25);
            cbTypeUser.Name = "cbTypeUser";
            cbTypeUser.Size = new Size(182, 33);
            cbTypeUser.TabIndex = 4;
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
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txbUserEmail);
            panel4.Controls.Add(txbUserSex);
            panel4.Controls.Add(txbUserPhone);
            panel4.Controls.Add(txbUserUsername);
            panel4.Controls.Add(txbUserPassword);
            panel4.Controls.Add(txbUserFirstname);
            panel4.Controls.Add(txbUserLastname);
            panel4.Controls.Add(txbUserId);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txbUserAddress);
            panel4.Location = new Point(576, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(475, 499);
            panel4.TabIndex = 3;
            // 
            // dtpkDob
            // 
            dtpkDob.Location = new Point(156, 253);
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
            label9.Location = new Point(17, 405);
            label9.Name = "label9";
            label9.Size = new Size(97, 25);
            label9.TabIndex = 22;
            label9.Text = "Điện thoại:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 356);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 21;
            label8.Text = "Địa chỉ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 307);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 20;
            label7.Text = "Giới tính:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 258);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 19;
            label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 209);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 18;
            label5.Text = "Tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 160);
            label4.Name = "label4";
            label4.Size = new Size(40, 25);
            label4.TabIndex = 17;
            label4.Text = "Họ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 111);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 16;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 62);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 15;
            label2.Text = "Tên đăng nhập:";
            // 
            // txbUserEmail
            // 
            txbUserEmail.Location = new Point(156, 445);
            txbUserEmail.Name = "txbUserEmail";
            txbUserEmail.Size = new Size(303, 31);
            txbUserEmail.TabIndex = 4;
            // 
            // txbUserSex
            // 
            txbUserSex.Location = new Point(156, 301);
            txbUserSex.Name = "txbUserSex";
            txbUserSex.Size = new Size(303, 31);
            txbUserSex.TabIndex = 11;
            // 
            // txbUserPhone
            // 
            txbUserPhone.Location = new Point(156, 397);
            txbUserPhone.Name = "txbUserPhone";
            txbUserPhone.Size = new Size(303, 31);
            txbUserPhone.TabIndex = 6;
            // 
            // txbUserUsername
            // 
            txbUserUsername.Location = new Point(156, 61);
            txbUserUsername.Name = "txbUserUsername";
            txbUserUsername.Size = new Size(303, 31);
            txbUserUsername.TabIndex = 7;
            // 
            // txbUserPassword
            // 
            txbUserPassword.Location = new Point(156, 109);
            txbUserPassword.Name = "txbUserPassword";
            txbUserPassword.Size = new Size(303, 31);
            txbUserPassword.TabIndex = 8;
            // 
            // txbUserFirstname
            // 
            txbUserFirstname.Location = new Point(156, 205);
            txbUserFirstname.Name = "txbUserFirstname";
            txbUserFirstname.Size = new Size(303, 31);
            txbUserFirstname.TabIndex = 12;
            // 
            // txbUserLastname
            // 
            txbUserLastname.Location = new Point(156, 157);
            txbUserLastname.Name = "txbUserLastname";
            txbUserLastname.Size = new Size(303, 31);
            txbUserLastname.TabIndex = 13;
            // 
            // txbUserId
            // 
            txbUserId.Location = new Point(156, 13);
            txbUserId.Name = "txbUserId";
            txbUserId.Size = new Size(303, 31);
            txbUserId.TabIndex = 14;
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
            // txbUserAddress
            // 
            txbUserAddress.Location = new Point(156, 349);
            txbUserAddress.Name = "txbUserAddress";
            txbUserAddress.Size = new Size(303, 31);
            txbUserAddress.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvUser);
            panel3.Location = new Point(0, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(537, 496);
            panel3.TabIndex = 2;
            // 
            // dtgvUser
            // 
            dtgvUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvUser.Columns.AddRange(new DataGridViewColumn[] { Id, Username, Password, LastName, FirstName, Dob, Sex, Address, Phone, Email, Role });
            dtgvUser.Location = new Point(0, 3);
            dtgvUser.Name = "dtgvUser";
            dtgvUser.RowHeadersWidth = 62;
            dtgvUser.Size = new Size(534, 489);
            dtgvUser.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSearchUser);
            panel2.Controls.Add(txbSearchUser);
            panel2.Location = new Point(732, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 79);
            panel2.TabIndex = 1;
            // 
            // btnSearchUser
            // 
            btnSearchUser.Location = new Point(231, 9);
            btnSearchUser.Name = "btnSearchUser";
            btnSearchUser.Size = new Size(82, 61);
            btnSearchUser.TabIndex = 3;
            btnSearchUser.Text = "Tìm";
            btnSearchUser.UseVisualStyleBackColor = true;
            btnSearchUser.Click += btnSearchUser_Click;
            // 
            // txbSearchUser
            // 
            txbSearchUser.Location = new Point(31, 24);
            txbSearchUser.Name = "txbSearchUser";
            txbSearchUser.Size = new Size(176, 31);
            txbSearchUser.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnShowUser);
            panel1.Controls.Add(btnDeleteUser);
            panel1.Controls.Add(btnEditUser);
            panel1.Controls.Add(btnAddUser);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 79);
            panel1.TabIndex = 0;
            // 
            // btnShowUser
            // 
            btnShowUser.Location = new Point(404, 9);
            btnShowUser.Name = "btnShowUser";
            btnShowUser.Size = new Size(82, 61);
            btnShowUser.TabIndex = 3;
            btnShowUser.Text = "Xem";
            btnShowUser.UseVisualStyleBackColor = true;
            btnShowUser.Click += btnShowUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(281, 9);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(82, 61);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "Xóa";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(158, 9);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(82, 61);
            btnEditUser.TabIndex = 1;
            btnEditUser.Text = "Sửa";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(35, 9);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(82, 61);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Thêm";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Mã";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Width = 150;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Tên đăng nhập";
            Username.MinimumWidth = 8;
            Username.Name = "Username";
            Username.Width = 150;
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Mật khẩu";
            Password.MinimumWidth = 8;
            Password.Name = "Password";
            Password.Visible = false;
            Password.Width = 150;
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
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Số điện thoại";
            Phone.MinimumWidth = 8;
            Phone.Name = "Phone";
            Phone.Width = 150;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.Width = 150;
            // 
            // Role
            // 
            Role.DataPropertyName = "Role";
            Role.HeaderText = "Chức vụ";
            Role.MinimumWidth = 8;
            Role.Name = "Role";
            Role.Width = 150;
            // 
            // fUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 640);
            Controls.Add(tabControl1);
            Name = "fUser";
            Text = "fUser";
            tabControl1.ResumeLayout(false);
            tpTeacher.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvUser).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpTeacher;
        private Panel panel4;
        private Panel panel3;
        private DataGridView dtgvUser;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnAddUser;
        private TextBox txbSearchUser;
        private Button btnSearchUser;
        private TextBox txbUserEmail;
        private TextBox txbUserSex;
        private TextBox txbUserPhone;
        private TextBox txbUserUsername;
        private TextBox txbUserPassword;
        private TextBox txbUserFirstname;
        private TextBox txbUserLastname;
        private TextBox txbUserId;
        private TextBox txbUserAddress;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnShowUser;
        private ComboBox cbTypeUser;
        private DateTimePicker dtpkDob;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Dob;
        private DataGridViewTextBoxColumn Sex;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Role;
    }
}