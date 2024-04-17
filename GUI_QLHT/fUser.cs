using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLHT;
using DAL_QLHT;
using Microsoft.VisualBasic.ApplicationServices;

namespace GUI_QLHT
{
    public partial class fUser : Form
    {
        BindingSource userList = new BindingSource();
        UserService userService = new UserService();
        public fUser()
        {
            InitializeComponent();
            LoadData();
        }


        void LoadData()
        {
            dtgvUser.DataSource = userList;
            LoadUser();
            AddUserBinding();
        }

        void AddUserBinding()
        {
            txbUserId.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txbUserUsername.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "Username", true, DataSourceUpdateMode.Never));
            txbUserLastname.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "LastName", true, DataSourceUpdateMode.Never));
            txbUserFirstname.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "FirstName", true, DataSourceUpdateMode.Never));
            dtpkDob.DataBindings.Add(new Binding("Value", dtgvUser.DataSource, "Dob", true, DataSourceUpdateMode.Never));
            txbUserSex.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "Sex", true, DataSourceUpdateMode.Never));
            txbUserAddress.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "Address", true, DataSourceUpdateMode.Never));
            txbUserPhone.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "Phone", true, DataSourceUpdateMode.Never));
            txbUserEmail.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "Email", true, DataSourceUpdateMode.Never));
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {

        }

        private User GetUser()
        {
            string username = txbUserUsername.Text;
            string password = txbUserPassword.Text;
            string lastname = txbUserLastname.Text;
            string firstname = txbUserFirstname.Text;
            DateTime dob = dtpkDob.Value;
            SexEnum sex = SexEnum.Male;
            string address = txbUserAddress.Text;
            string email = txbUserEmail.Text;
            string phone = txbUserPhone.Text;

            String type = cbTypeUser.Text;
            RoleEnum role = RoleEnum.TEACHER;
            if (type == "Giáo viên")
                role = RoleEnum.TEACHER;
            else if (type == "Giáo vụ")
                role = RoleEnum.STAFF;
            else if (type == "Quản trị viên")
                role = RoleEnum.ADMIN;

            if (txbUserSex.Text == "Nam")
                sex = SexEnum.Male;
            else if (txbUserSex.Text == "Nữ")
                sex = SexEnum.Female;

            User user = new User() { Username = username, Password = password, LastName = lastname, FirstName = firstname, Dob = dob, Sex = sex, Address = address, Email = email, Phone = phone, Role = role };
            return user;
        }

        private void LoadUser()
        {
            String type = cbTypeUser.Text;
            RoleEnum role = RoleEnum.TEACHER;
            if (type == "Giáo viên")
                role = RoleEnum.TEACHER;
            else if (type == "Giáo vụ")
                role = RoleEnum.STAFF;
            else if (type == "Quản trị viên")
                role = RoleEnum.ADMIN;


            List<User> users = userService.GetUserByRole(role);
            userList.DataSource = users;
        }

        private void btnShowUser_Click(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User user = GetUser();
            if (userService.CreateUser(user))
            {
                LoadUser();
            }
            else;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            User user = GetUser();
            user.Id = int.Parse(txbUserId.Text);
            if (userService.UpdateUser(user))
            {
                LoadUser();
            }
            else;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(txbUserId.Text);
            if (userService.DeleteUser(userId))
            {
                LoadUser();
            }
            else;
        }
    }
}
