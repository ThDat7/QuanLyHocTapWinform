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
    public partial class fStatsDetail : Form
    {
        private SubjectGradeService subjectGradeService = new SubjectGradeService();
        private BindingSource statsBinding = new BindingSource();
        private int classroomId;

        public fStatsDetail(int classroomId)
        {
            InitializeComponent();
            this.classroomId = classroomId;
            LoadData();
        }

        private void LoadData()
        {
            dtgvStats.DataSource = statsBinding;
            cbSemester.SelectedIndex = 0;
            DataTable dttb = ToDataTable(subjectGradeService.GetAvgExamByClass(classroomId, SemesterEnum.I));
            statsBinding.DataSource = dttb;
        }

        private DataTable ToDataTable(List<Dictionary<string, object>> items)
        {
            var data = new DataTable();
            if (items.Count == 0) return data;

            var dict = items[0];
            foreach (var key in dict.Keys)
            {
                data.Columns.Add(key);
            }

            foreach (var item in items)
            {
                var row = data.NewRow();
                foreach (var key in item.Keys)
                {
                    row[key] = item[key];
                }
                data.Rows.Add(row);
            }

            return data;
        }

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable? dttb = null;
            String text = cbSemester.Text;
            SemesterEnum? semester = null;
            if (text == "Học kỳ 1")
                semester = SemesterEnum.I;
            else if (text == "Học kỳ 2")
                semester = SemesterEnum.II;

            if (semester != null)
                dttb = ToDataTable(subjectGradeService.GetAvgExamByClass(classroomId, semester));
            else
                ;

            statsBinding.DataSource = dttb;
        }
    }
}
