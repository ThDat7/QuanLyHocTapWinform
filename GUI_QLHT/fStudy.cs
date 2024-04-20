using BUS_QLHT;
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
    public partial class fStudy : Form
    {
        BindingSource teachList = new BindingSource();
        TeachService teachService = new TeachService();
        public fStudy()
        {
            InitializeComponent();
            LoadData();
        }


        void LoadData()
        {
            dtgvTeach.DataSource = teachList;
            LoadTeach();
        }

        private void LoadTeach()
        {
            List<Object> teaches = teachService.GetTeachesByUserId(3);
            teachList.DataSource = teaches;
        }

        private void btnEditExam_Click(object sender, EventArgs e)
        {

        }
    }
}
