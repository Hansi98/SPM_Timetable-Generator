using ABC_Institute___Timetable_Generator.Models;
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
    public partial class section2_updateSession : Form
    {
        LecturerServiceImpl Lservice = new LecturerServiceImpl();
        SubjectServiceImpl SService = new SubjectServiceImpl();
        SessonServiceImpl SesService = new SessonServiceImpl();

        List<Lecturer> lecList;

        Session S;

        public section2_updateSession()
        {
            InitializeComponent();
        }

        public section2_updateSession(Object obj)
        {
            InitializeComponent();
            this.S = (Session) obj;
        }

        private void section2_updateSession_Load(object sender, EventArgs e)
        {

        }

        public void R1S2changeHeader()
        {
            if (R1S2LecDataGrid.Columns["Eid"] != null)
                R1S2LecDataGrid.Columns["Eid"].HeaderText = "Employee ID";

            if (R1S2LecDataGrid.Columns["fname"] != null)
                R1S2LecDataGrid.Columns["fname"].HeaderText = "First Name";

            if (R1S2LecDataGrid.Columns["mname"] != null)
                R1S2LecDataGrid.Columns["mname"].HeaderText = "Middle Name";

            if (R1S2LecDataGrid.Columns["lname"] != null)
                R1S2LecDataGrid.Columns["lname"].HeaderText = "Last Name";

            if (R1S2LecDataGrid.Columns["faculty"] != null)
                R1S2LecDataGrid.Columns["faculty"].HeaderText = "Faculty";

            if (R1S2LecDataGrid.Columns["dept"] != null)
                R1S2LecDataGrid.Columns["dept"].HeaderText = "Department";

            if (R1S2LecDataGrid.Columns["center"] != null)
                R1S2LecDataGrid.Columns["center"].HeaderText = "Center";

            if (R1S2LecDataGrid.Columns["building"] != null)
                R1S2LecDataGrid.Columns["building"].HeaderText = "Building";

            if (R1S2LecDataGrid.Columns["Llevel"] != null)
                R1S2LecDataGrid.Columns["Llevel"].HeaderText = "Level";

            if (R1S2LecDataGrid.Columns["Lrank"] != null)
                R1S2LecDataGrid.Columns["Lrank"].HeaderText = "Rank";
        }
        public void draw()
        {
            R1S2LecDataGrid.DataSource = Lservice.getAllLecturers();
            this.R1S2changeHeader();

        }

    }
}
