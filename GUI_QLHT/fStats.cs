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
    public partial class fStats : Form
    {
        private ClassroomService classroomService = new ClassroomService();
        private BindingSource classroomBinding = new BindingSource();

        public fStats()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dtgvClass.DataSource = classroomBinding;
            cbYear.Items.Clear();
            List<int> years = classroomService.GetYearsClassroom();
            foreach (int year in years)
            {
                cbYear.Items.Add(year);
            }
            LoadClassroom();
        }

        private void LoadClassroom()
        {
            if (cbYear.Text == "")
                cbYear.SelectedIndex = 0;
            int year = int.Parse(cbYear.Text);
            List<Object> classrooms = classroomService.GetClassroomByYear(year);
            classroomBinding.DataSource = classrooms;
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadClassroom();
        }

        private void btnViewStats_Click(object sender, EventArgs e)
        {
            int classroomId = int.Parse(dtgvClass.CurrentRow.Cells[0].Value.ToString());
            this.Hide();
            fStatsDetail fStatsDetail = new fStatsDetail(classroomId);
            fStatsDetail.ShowDialog();
            this.Show();
        }
    }
}
