using ABC_Institute___Timetable_Generator.ServiceImpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Institute___Timetable_Generator
{
    public partial class Section1_Subjects : Form
    {
        SubjectServiceImpl Sservice = new SubjectServiceImpl();
        public Section1_Subjects()
        {
            InitializeComponent();
            draw();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RS1_addSubject_Click(object sender, EventArgs e)
        {
            new Section1_addSubject().Show();
        }

        public void R1S1changeHeader()
        {
            if (R1S1SubDataGrid.Columns["code"] != null)
                R1S1SubDataGrid.Columns["code"].HeaderText = "Subject Code";

            if (R1S1SubDataGrid.Columns["name"] != null)
                R1S1SubDataGrid.Columns["name"].HeaderText = "Subject Name";

            if (R1S1SubDataGrid.Columns["lecHr"] != null)
                R1S1SubDataGrid.Columns["lecHr"].HeaderText = "Lecture Hours";

            if (R1S1SubDataGrid.Columns["tutHr"] != null)
                R1S1SubDataGrid.Columns["tutHr"].HeaderText = "Tutorial Hours";

            if (R1S1SubDataGrid.Columns["labHr"] != null)
                R1S1SubDataGrid.Columns["labHr"].HeaderText = "Lab Hours";

            if (R1S1SubDataGrid.Columns["EvalHr"] != null)
                R1S1SubDataGrid.Columns["EvalHr"].HeaderText = "Evaluation Hours";

               
        }

        public void draw()
        {
            R1S1SubDataGrid.DataSource = Sservice.getAllSubject();
            this.R1S1changeHeader();
          //  RS1_totLecs.Text = Lservice.getAllCount().ToString();
        }
    }
}
