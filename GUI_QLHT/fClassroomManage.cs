using BUS_QLHT;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI_QLHT
{
    public partial class fClassroomManage : Form
    {
        private int classroomId;
        private ClassroomService classroomService = new ClassroomService();
        private StudentService studentService = new StudentService();
        private TeacherService teacherService = new TeacherService();
        private TeachService teachService = new TeachService();

        BindingSource studentInClassBinding = new BindingSource();
        BindingSource homeroomTeacherBinding = new BindingSource();
        BindingSource subjectTeachersBinding = new BindingSource();
        BindingSource searchStudentsBinding = new BindingSource();
        BindingSource searchHomeroomTeachersBinding = new BindingSource();
        BindingSource searchSubjectTeachersBinding = new BindingSource();

        //private List<Object> studentInClass;
        //private Object homeroomTeacher;
        //private List<Object> subjectTeachers;

        //private List<Object> searchStudents;
        //private List<Object> searchHomeroomTeachers;
        //private List<Object> searchSubjectTeachers;




        public fClassroomManage(int classroomid)
        {
            InitializeComponent();
            this.classroomId = classroomid;
            BindingData();
            LoadData();
        }

        private void BindingData()
        {
            dtgvStudentInClass.DataSource = studentInClassBinding;
            dtgvSubjectTeachers.DataSource = subjectTeachersBinding;
            dtgvSearchStudent.DataSource = searchStudentsBinding;
            dtgvSearchTeacher1.DataSource = searchHomeroomTeachersBinding;
            dtgvSearchTeacher2.DataSource = searchSubjectTeachersBinding;
        }

        private void LoadData()
        {
            studentInClassBinding.DataSource = studentService.GetInClass(classroomId);
            homeroomTeacherBinding.DataSource = classroomService.GetHomeroomTeacher(classroomId);
            subjectTeachersBinding.DataSource = classroomService.GetSubjetTeachers(classroomId);

            if (homeroomTeacherBinding.DataSource != null)
            {
                txbHomeroomName.DataBindings.Add(new Binding("Text", homeroomTeacherBinding.DataSource, "Name", true, DataSourceUpdateMode.Never));
                txbHomeroomDob.DataBindings.Add(new Binding("Text", homeroomTeacherBinding.DataSource, "Dob", true, DataSourceUpdateMode.Never));
                txbHomeroomAddress.DataBindings.Add(new Binding("Text", homeroomTeacherBinding.DataSource, "Address", true, DataSourceUpdateMode.Never));
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            string keyword = txbSearchStudent.Text;
            searchStudentsBinding.DataSource = studentService.Search(keyword, new List<int>());
        }

        private void btnSearchTeacher1_Click(object sender, EventArgs e)
        {
            string keyword = txbSearchHomeroomTeacher.Text;
            searchHomeroomTeachersBinding.DataSource = teacherService.Search(keyword, new List<int>());
        }

        private void btnSearchTeacher2_Click(object sender, EventArgs e)
        {
            string keyword = txbSearchSubjectTeacher.Text;
            searchSubjectTeachersBinding.DataSource = teacherService.Search(keyword, new List<int>());
        }

        private int GetFirstCellSelectedRow(DataGridView dtgv)
        {
            return int.Parse(dtgv.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            int idAdd = GetFirstCellSelectedRow(dtgvSearchStudent);
            classroomService.AddStudentToClass(classroomId, idAdd);

            Object student = dtgvSearchStudent.CurrentRow.DataBoundItem;
            studentInClassBinding.Add(student);
            searchStudentsBinding.Remove(student);
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            int idRemove = GetFirstCellSelectedRow(dtgvStudentInClass);
            classroomService.RemoveStudentInClass(classroomId, idRemove);

            Object student = dtgvStudentInClass.CurrentRow.DataBoundItem;
            studentInClassBinding.Remove(student);
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            int idAdd = GetFirstCellSelectedRow(dtgvSearchTeacher2);
            teachService.AddTeach(classroomId, idAdd, 3);

            DataGridViewRow teacherRow = dtgvSearchTeacher2.CurrentRow;
            Object subjectTeacher = new
            {
                Id = int.Parse(teacherRow.Cells[0].Value.ToString()),
                Name = teacherRow.Cells[1].Value.ToString(),
                Dob = teacherRow.Cells[2].Value.ToString(),
                Address = teacherRow.Cells[3].Value.ToString(),
                SubjectName = ""
            };

            subjectTeachersBinding.Add(subjectTeacher);
            searchSubjectTeachersBinding.Remove(teacherRow.DataBoundItem);
        }

        private void btnRemoveTeacher_Click(object sender, EventArgs e)
        {
            int idRemove = GetFirstCellSelectedRow(dtgvSearchTeacher2);
        }

        private void btnSetHomeroom_Click(object sender, EventArgs e)
        {
            int idSet = GetFirstCellSelectedRow(dtgvSearchTeacher1);
            classroomService.SetHomeroomTeacher(classroomId, idSet);

            object teacher = dtgvSearchTeacher1.CurrentRow.DataBoundItem;
            searchHomeroomTeachersBinding.Remove(teacher);

            homeroomTeacherBinding.DataSource = teacher;

        }
    }
}
