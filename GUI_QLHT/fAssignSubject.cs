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
    public partial class fAssignSubject : Form
    {
        private int teacherId;
        private SubjectService subjectService = new SubjectService();
        private TeacherService teacherService = new TeacherService();

        BindingSource subjectAssigned = new BindingSource();
        BindingSource subjectSearch = new BindingSource();

        public fAssignSubject(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            BindingData();
            LoadData();
        }

        private void BindingData()
        {
            dtgvSubjectAssigned.DataSource = subjectAssigned;
            dtgvSearch.DataSource = subjectSearch;
        }

        private void LoadData()
        {
            Object teacher = teacherService.Get(teacherId);
            subjectAssigned.DataSource = ((Teacher)teacher).Subjects;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txbSearch.Text;
            subjectSearch.DataSource = subjectService.SearchForAssign(keyword, teacherId);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int idAdd = int.Parse(dtgvSearch.CurrentRow.Cells[0].Value.ToString());
            teacherService.AssignSubject(teacherId, idAdd);

            Object student = dtgvSearch.CurrentRow.DataBoundItem;
            subjectAssigned.Add(student);
            subjectSearch.Remove(student);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int idRemove = int.Parse(dtgvSubjectAssigned.CurrentRow.Cells[0].Value.ToString());
            teacherService.RemoveSubjectToTeacher(teacherId, idRemove);

            Object student = dtgvSubjectAssigned.CurrentRow.DataBoundItem;
            subjectAssigned.Remove(student);
        }
    }
}
