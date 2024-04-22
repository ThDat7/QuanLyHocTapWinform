using BUS_QLHT;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLHT
{
    public partial class fExam : Form
    {
        TeachService teachService = new TeachService();
        private Teach teach;

        public fExam(int teachId)
        {
            InitializeComponent();
            LoadData(teachId);

            InitTabPage(dtgvTeach1, SemesterEnum.I);
            InitTabPage(dtgvTeach2, SemesterEnum.II);

            SetTextButton(dtgvTeach1, btnToggle15Sem1, SemesterEnum.I, FactorEnum.I);
            SetTextButton(dtgvTeach1, btnToggle45Sem1, SemesterEnum.I, FactorEnum.II);

            SetTextButton(dtgvTeach2, btnToggle15Sem2, SemesterEnum.II, FactorEnum.I);
            SetTextButton(dtgvTeach2, btnToggle45Sem2, SemesterEnum.II, FactorEnum.II);
        }

        public void SetTextButton(DataGridView dtgv, Button btn, SemesterEnum semester, FactorEnum factor)
        {
            string labelText;
            int columnIndex;
            int semesterInt = semester == SemesterEnum.I ? 1 : 2;

            if (factor == FactorEnum.I)
            {
                labelText = "15p";
                columnIndex = 2;
            }
            else
            {
                labelText = "45p";
                columnIndex = 4;
            }
            string columnDataPropertyName = $"Semester{semesterInt}NormalGrade{labelText}2";

            int count = teach
                .SubjectGrade[0]
                .SubjectGradeSemesters
                .Where(sgs => sgs.Semester == semester)
                .First<SubjectGradeSemester>()
                .NormalGrades
                .Where(ng => ng.Factor == factor)
                .ToList<NormalGrade>().Count;

            if (count == 1)
            {
                btn.Text = $"Thêm cột {labelText}";
            }
            else if (count == 2)
            {
                btn.Text = $"Xóa cột {labelText}";
                dtgv.Columns[columnIndex].Visible = true;
                dtgv.Columns[columnIndex].DataPropertyName = columnDataPropertyName;
            }
        }


        private void HandleToggle(DataGridView dtgv, Button btn, SemesterEnum semester, FactorEnum factor)
        {
            string labelText;
            int columnIndex;
            int semesterInt = semester == SemesterEnum.I ? 1 : 2;

            if (factor == FactorEnum.I)
            {
                labelText = "15p";
                columnIndex = 2;
            }
            else
            {
                labelText = "45p";
                columnIndex = 4;
            }
            string columnDataPropertyName = $"Semester{semesterInt}NormalGrade{labelText}2";

            int count = teach
                .SubjectGrade[0]
                .SubjectGradeSemesters
                .Where(sgs => sgs.Semester == semester)
                .First<SubjectGradeSemester>()
                .NormalGrades
                .Where(ng => ng.Factor == factor)
                .ToList<NormalGrade>().Count;

            if (count == 1)
            {
                btn.Text = $"Xoá cột {labelText}";
                foreach (var sg in teach.SubjectGrade)
                {
                    sg.SubjectGradeSemesters
                    .Where(sgs => sgs.Semester == semester)
                    .First<SubjectGradeSemester>()
                    .NormalGrades
                    .Add(new NormalGrade() { Factor = factor });
                }
                dtgv.Columns[columnIndex].Visible = true;
                dtgv.Columns[columnIndex].DataPropertyName = columnDataPropertyName;
            }
            else if (count == 2)
            {
                dtgv.Columns[columnIndex].Visible = false;
                dtgv.Columns[columnIndex].DataPropertyName = "";

                btn.Text = $"Thêm cột {labelText}";
                foreach (var sg in teach.SubjectGrade)
                {
                    NormalGrade remove = sg.SubjectGradeSemesters
                        .Where(sgs => sgs.Semester == semester)
                        .First<SubjectGradeSemester>()
                        .NormalGrades
                        .Where(ng => ng.Factor == factor)
                        .ToList<NormalGrade>()[1];

                    sg.SubjectGradeSemesters
                        .Where(sgs => sgs.Semester == semester)
                        .First<SubjectGradeSemester>()
                        .NormalGrades
                        .Remove(remove);

                }
            }
        }

        public void LoadData(int teachId)
        {
            teach = (Teach)teachService.GetExamByTeachId(2);
        }

        public void InitTabPage(DataGridView dtgv, SemesterEnum semester)
        {
            int semesterInt = semester == SemesterEnum.I ? 1 : 2;
            dtgv.AutoGenerateColumns = false;
            dtgv.ColumnCount = 6;

            List<StudyData> dtSource = teach.SubjectGrade.Select(sg => new StudyData(ref sg)).ToList<StudyData>();
            dtgv.DataSource = dtSource;

            dtgv.Columns[0].DataPropertyName = "StudentName";
            dtgv.Columns[0].HeaderText = "Tên học sinh";

            dtgv.Columns[1].DataPropertyName = $"Semester{semesterInt}NormalGrade15p1";
            dtgv.Columns[1].HeaderText = "15p (1)";

            dtgv.Columns[2].DataPropertyName = "";
            dtgv.Columns[2].HeaderText = "15p (2)";
            dtgv.Columns[2].Visible = false;

            dtgv.Columns[3].DataPropertyName = $"Semester{semesterInt}NormalGrade45p1";
            dtgv.Columns[3].HeaderText = "45p (1)";

            dtgv.Columns[4].DataPropertyName = "";
            dtgv.Columns[4].HeaderText = "45p (2)";
            dtgv.Columns[4].Visible = false;

            dtgv.Columns[5].DataPropertyName = $"Semester{semesterInt}FinalGrade";
            dtgv.Columns[5].HeaderText = "Cuối kỳ";

            //AddIndexColumn();
        }

        //private void AddIndexColumn()
        //{
        //    var indexColumn = new DataGridViewTextBoxColumn();
        //    indexColumn.Name = "IndexColumn";
        //    indexColumn.HeaderText = "Index";

        //    indexColumn.ReadOnly = true;

        //    dtgv.Columns.Insert(0, indexColumn);

        //    for (int i = 0; i < dtgv.Rows.Count; i++)
        //    {
        //        dtgv.Rows[i].Cells["IndexColumn"].Value = (i + 1).ToString();
        //    }
        //}

        private void btnSaveSe1_Click(object sender, EventArgs e)
        {
            teachService.UpdateTeach(teach);
        }

        private void btnToggle15Sem1_Click(object sender, EventArgs e)
        {
            HandleToggle(dtgvTeach1, btnToggle15Sem1, SemesterEnum.I, FactorEnum.I);
        }

        private void btnToggle45Sem1_Click(object sender, EventArgs e)
        {
            HandleToggle(dtgvTeach1, btnToggle45Sem1, SemesterEnum.I, FactorEnum.II);
        }


        private void btnSaveSe2_Click(object sender, EventArgs e)
        {
            teachService.UpdateTeach(teach);
        }

        private void btnToggle15Sem2_Click(object sender, EventArgs e)
        {
            HandleToggle(dtgvTeach2, btnToggle15Sem2, SemesterEnum.II, FactorEnum.I);
        }

        private void btnToggle45Sem2_Click(object sender, EventArgs e)
        {
            HandleToggle(dtgvTeach2, btnToggle45Sem2, SemesterEnum.II, FactorEnum.II);
        }
    }

    class StudyData
    {
        private SubjectGrade subjectGrade;

        public StudyData(ref SubjectGrade subjectgrade)
        {
            this.subjectGrade = subjectgrade;
        }

        public String StudentName
        {
            get { return subjectGrade.Student.LastName + " " + subjectGrade.Student.FirstName; }
        }

        public float? Semester1NormalGrade15p1
        {
            get { return GetNormalGrade(SemesterEnum.I, FactorEnum.I, 1); }
            set { SetNormalGrade(value, SemesterEnum.I, FactorEnum.I, 1); }
        }

        public float? Semester1NormalGrade45p1
        {
            get { return GetNormalGrade(SemesterEnum.I, FactorEnum.II, 1); }
            set { SetNormalGrade(value, SemesterEnum.I, FactorEnum.II, 1); }
        }

        public float? Semester1NormalGrade15p2
        {
            get { return GetNormalGrade(SemesterEnum.I, FactorEnum.I, 2); }
            set { SetNormalGrade(value, SemesterEnum.I, FactorEnum.I, 2); }
        }

        public float? Semester1NormalGrade45p2
        {
            get { return GetNormalGrade(SemesterEnum.I, FactorEnum.II, 2); }
            set { SetNormalGrade(value, SemesterEnum.I, FactorEnum.II, 2); }
        }

        public float? Semester2NormalGrade15p1
        {
            get { return GetNormalGrade(SemesterEnum.II, FactorEnum.I, 1); }
            set { SetNormalGrade(value, SemesterEnum.II, FactorEnum.I, 1); }
        }

        public float? Semester2NormalGrade45p1
        {
            get { return GetNormalGrade(SemesterEnum.II, FactorEnum.II, 1); }
            set { SetNormalGrade(value, SemesterEnum.II, FactorEnum.II, 1); }
        }

        public float? Semester2NormalGrade15p2
        {
            get { return GetNormalGrade(SemesterEnum.II, FactorEnum.I, 2); }
            set { SetNormalGrade(value, SemesterEnum.II, FactorEnum.I, 2); }
        }

        public float? Semester2NormalGrade45p2
        {
            get { return GetNormalGrade(SemesterEnum.II, FactorEnum.II, 2); }
            set { SetNormalGrade(value, SemesterEnum.II, FactorEnum.II, 2); }
        }

        public float? Semester1FinalGrade
        {
            get { return GetFinalGrade(SemesterEnum.I); }
            set { SetFinalGrade(value, SemesterEnum.I); }
        }

        public float? Semester2FinalGrade
        {
            get { return GetFinalGrade(SemesterEnum.II); }
            set { SetFinalGrade(value, SemesterEnum.II); }
        }

        private float? GetNormalGrade(SemesterEnum semester, FactorEnum factor, int order)
        {
            return subjectGrade
                .SubjectGradeSemesters
                .Where(sgs => sgs.Semester == semester)
                .First<SubjectGradeSemester>()
                .NormalGrades
                .Where(ng => ng.Factor == factor)
                .ToList<NormalGrade>()[order - 1].Score;
        }

        private void SetNormalGrade(float? value, SemesterEnum semester, FactorEnum factor, int order)
        {
            subjectGrade
                .SubjectGradeSemesters
                .Where(sgs => sgs.Semester == semester)
                .First<SubjectGradeSemester>()
                .NormalGrades
                .Where(ng => ng.Factor == factor)
                .ToList<NormalGrade>()[order - 1].Score = value;
        }

        private float? GetFinalGrade(SemesterEnum semester)
        {
            return subjectGrade
                .SubjectGradeSemesters
                .Where(sgs => sgs.Semester == semester)
                .First<SubjectGradeSemester>()
            .FinalGrade.Score;
        }

        private void SetFinalGrade(float? value, SemesterEnum semester)
        {
            subjectGrade
                .SubjectGradeSemesters
                .Where(sgs => sgs.Semester == semester)
                .First<SubjectGradeSemester>()
            .FinalGrade.Score = value;
        }
    }
}
