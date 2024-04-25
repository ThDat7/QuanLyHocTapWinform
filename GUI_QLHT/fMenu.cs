using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLHT
{
    public partial class fMenu : Form
    {

        public static User currentUser;
        public fMenu(User user)
        {
            InitializeComponent();

            fMenu.currentUser = user;
            //if (user == null ) 
            //    this.Close();

            VisibleBtnByRole();
        }

        private void VisibleBtnByRole()
        {
            switch (currentUser.Role)
            {
                case RoleEnum.ADMIN:
                    btnUser.Visible = true;
                    btnAcademic.Visible = true;
                    btnStudy.Visible = true;
                    break;
                case RoleEnum.STAFF:
                    btnAcademic.Visible = true;
                    break;
                case RoleEnum.TEACHER:
                    btnStudy.Visible = true;
                    break;
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            fUser fUser = new fUser();
            this.Hide();
            fUser.ShowDialog();
            this.Show();
        }

        private void btnAcademic_Click(object sender, EventArgs e)
        {
            fManager fManager = new fManager();
            this.Hide();
            fManager.ShowDialog();
            this.Show();
        }

        private void btnStudy_Click(object sender, EventArgs e)
        {
            fStudy fStudy = new fStudy();
            this.Hide();
            fStudy.ShowDialog();
            this.Show();
        }
    }
}
