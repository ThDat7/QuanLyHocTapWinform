﻿using BUS_QLHT;
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

            List<Object> teaches = teachService.GetTeachForManage(fMenu.currentUser);
            teachList.DataSource = teaches;
        }

        private void btnEditExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            int selectedId = int.Parse(dtgvTeach.CurrentRow.Cells[0].Value.ToString());
            fExam fexam = new fExam(selectedId);
            fexam.ShowDialog();
            this.Show();
        }
    }
}
