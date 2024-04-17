using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyHocTap
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //System.Console.WriteLine("before");

            //using (var db = new student_managementContext())
            //{
            //}
            //student_managementContext db = new student_managementContext();
            //db.Users.Add(new User() { Username = "123", Password = "123" });
            //List<User> users = db.Users.ToList();
            //System.Console.WriteLine("123" + users.Count());

            string username = txbUsername.Text;
            string password = txbPassword.Text;
        }

        bool Login(string username, string password)
        {
            // is user exists 
            return true;
        }
    }
}