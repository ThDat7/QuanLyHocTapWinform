using BUS_QLHT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLHT
{
    public partial class fManager : Form
    {
        BindingSource studentList = new BindingSource();
        BindingSource subjectList = new BindingSource();
        BindingSource classroomList = new BindingSource();

        StudentService studentService = new StudentService();
        SubjectService subjectService = new SubjectService();
        ClassroomService classroomService = new ClassroomService();

        public fManager()
        {
            InitializeComponent();
            LoadData();
        }


        void LoadData()
        {
            dtgvStudent.DataSource = studentList;
            LoadStudent();
            AddStudentBinding();

            dtgvSubject.DataSource = subjectList;
            LoadSubject();
            AddSubjectBinding();

            dtgvClassroom.DataSource = classroomList;
            LoadClassroom();
            AddClassroomBinding();

        }

        // student
        void AddStudentBinding()
        {
            txbStudentId.DataBindings.Add(new Binding("Text", dtgvStudent.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txbStudentLastname.DataBindings.Add(new Binding("Text", dtgvStudent.DataSource, "LastName", true, DataSourceUpdateMode.Never));
            txbStudentFirstname.DataBindings.Add(new Binding("Text", dtgvStudent.DataSource, "FirstName", true, DataSourceUpdateMode.Never));
            dtpkDob.DataBindings.Add(new Binding("Value", dtgvStudent.DataSource, "Dob", true, DataSourceUpdateMode.Never));
            txbStudentSex.DataBindings.Add(new Binding("Text", dtgvStudent.DataSource, "Sex", true, DataSourceUpdateMode.Never));
            txbStudentAddress.DataBindings.Add(new Binding("Text", dtgvStudent.DataSource, "Address", true, DataSourceUpdateMode.Never));
            txbStudentPhone.DataBindings.Add(new Binding("Text", dtgvStudent.DataSource, "Phone", true, DataSourceUpdateMode.Never));
            txbStudentEmail.DataBindings.Add(new Binding("Text", dtgvStudent.DataSource, "Email", true, DataSourceUpdateMode.Never));
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {

        }

        private Student GetStudent()
        {
            string lastname = txbStudentLastname.Text;
            string firstname = txbStudentFirstname.Text;
            DateTime dob = dtpkDob.Value;
            SexEnum sex = SexEnum.Male;
            string address = txbStudentAddress.Text;
            string email = txbStudentEmail.Text;
            string phone = txbStudentPhone.Text;

            if (txbStudentSex.Text == "Nam")
                sex = SexEnum.Male;
            else if (txbStudentSex.Text == "Nữ")
                sex = SexEnum.Female;

            Student student = new Student() { LastName = lastname, FirstName = firstname, Dob = dob, Sex = sex, Address = address, Email = email, Phone = phone };
            return student;
        }

        private void LoadStudent()
        {
            List<Object> students = studentService.GetStudents();
            studentList.DataSource = students;
        }

        private void btnShowStudent_Click(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student student = GetStudent();
            if (studentService.CreateStudent(student))
            {
                LoadStudent();
            }
            else;
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            Student student = GetStudent();
            student.Id = int.Parse(txbStudentId.Text);
            if (studentService.UpdateStudent(student))
            {
                LoadStudent();
            }
            else;
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            int studentId = int.Parse(txbStudentId.Text);
            if (studentService.DeleteStudent(studentId))
            {
                LoadStudent();
            }
            else;
        }

        // subject

        void AddSubjectBinding()
        {
            txbSubjectId.DataBindings.Add(new Binding("Text", dtgvSubject.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txbSubjectName.DataBindings.Add(new Binding("Text", dtgvSubject.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbSubjectGrade.DataBindings.Add(new Binding("Text", dtgvSubject.DataSource, "Grade", true, DataSourceUpdateMode.Never));
        }

        private void btnSearchSubject_Click(object sender, EventArgs e)
        {

        }

        private Subject GetSubject()
        {
            string name = txbSubjectName.Text;
            GradeEnum grade = GradeEnum.TENTH;

            if (txbSubjectGrade.Text == "TENTH")
                grade = GradeEnum.TENTH;
            else if (txbSubjectGrade.Text == "ELEVENTH")
                grade = GradeEnum.ELEVENTH;
            else if (txbSubjectGrade.Text == "TWELVETH")
                grade = GradeEnum.TWELVETH;

            Subject subject = new Subject() { Name = name, Grade = grade };
            return subject;
        }

        private void LoadSubject()
        {
            String gradeText = cbSubjectGrade.Text;
            GradeEnum grade = GradeEnum.TENTH;
            if (gradeText == "10")
                grade = GradeEnum.TENTH;
            else if (gradeText == "11")
                grade = GradeEnum.ELEVENTH;
            else if (gradeText == "12")
                grade = GradeEnum.TWELVETH;
            List<Object> subjects = subjectService.GetSubjectByGrade(grade);
            subjectList.DataSource = subjects;
        }

        private void btnShowSubject_Click(object sender, EventArgs e)
        {
            LoadSubject();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            Subject subject = GetSubject();
            if (subjectService.CreateSubject(subject))
            {
                LoadSubject();
            }
            else;
        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            Subject subject = GetSubject();
            subject.Id = int.Parse(txbSubjectId.Text);
            if (subjectService.UpdateSubject(subject))
            {
                LoadSubject();
            }
            else;
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            int subjectId = int.Parse(txbSubjectId.Text);
            if (subjectService.DeleteSubject(subjectId))
            {
                LoadSubject();
            }
            else;
        }

        //classroom

        void AddClassroomBinding()
        {
            txbClassroomId.DataBindings.Add(new Binding("Text", dtgvClassroom.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txbClassroomGrade.DataBindings.Add(new Binding("Text", dtgvClassroom.DataSource, "Grade", true, DataSourceUpdateMode.Never));
            txbClassroomOrder.DataBindings.Add(new Binding("Text", dtgvClassroom.DataSource, "Order", true, DataSourceUpdateMode.Never));
            txbClassroomYear.DataBindings.Add(new Binding("Text", dtgvClassroom.DataSource, "Year", true, DataSourceUpdateMode.Never));
        }

        private void btnSearchClassroom_Click(object sender, EventArgs e)
        {

        }

        private Classroom GetClassroom()
        {
            int order = int.Parse(txbClassroomOrder.Text);
            int year = int.Parse(txbClassroomYear.Text);
            GradeEnum grade = GradeEnum.TENTH;

            if (txbClassroomGrade.Text == "TENTH")
                grade = GradeEnum.TENTH;
            else if (txbClassroomGrade.Text == "ELEVENTH")
                grade = GradeEnum.ELEVENTH;
            else if (txbClassroomGrade.Text == "TWELVETH")
                grade = GradeEnum.TWELVETH;

            Classroom classroom = new Classroom() { Grade = grade, Order = order, Year = year };
            return classroom;
        }

        private void LoadYear()
        {
            cbClassroomYear.Items.Clear();
            List<int> years = classroomService.GetYearsClassroom();
            foreach (int year in years)
            {
                cbClassroomYear.Items.Add(year);
            }
        }

        private void LoadClassroom()
        {
            LoadYear();
            if (cbClassroomYear.Text == "")
                cbClassroomYear.SelectedIndex = 0;
            int year = int.Parse(cbClassroomYear.Text);
            List<Object> classrooms = classroomService.GetClassroomByYear(year);
            classroomList.DataSource = classrooms;
        }

        private void btnShowClassroom_Click(object sender, EventArgs e)
        {
            LoadClassroom();
        }

        private void btnAddClassroom_Click(object sender, EventArgs e)
        {
            Classroom classroom = GetClassroom();
            if (classroomService.CreateClassroom(classroom))
            {
                LoadClassroom();
            }
            else;
        }

        private void btnEditClassroom_Click(object sender, EventArgs e)
        {
            Classroom classroom = GetClassroom();
            classroom.Id = int.Parse(txbClassroomId.Text);
            if (classroomService.UpdateClassroom(classroom))
            {
                LoadClassroom();
            }
            else;
        }

        private void btnDeleteClassroom_Click(object sender, EventArgs e)
        {
            int classroomId = int.Parse(txbClassroomId.Text);
            if (classroomService.DeleteClassroom(classroomId))
            {
                LoadClassroom();
            }
            else;
        }
    }
}
