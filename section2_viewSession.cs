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
    public partial class section2_viewSession : Form
    {
        SessonServiceImpl sService = new SessonServiceImpl();
        Session s;
        public section2_viewSession()
        {
            InitializeComponent();
        }

        public section2_viewSession(Object obj)
        {
            InitializeComponent();
            this.s = (Session) obj;
            draw();
            R1S1changeHeader();
            
        }

        private void RS1_lecInfoRemoveB_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void draw()
        {
            R1S1LecSesDataGrid.DataSource = sService.getLecturersbySessionID(s.SessionID.ToString());
            taglabel.Text = s.tag;
            studentGrpLabel.Text = s.groupID;
            subjectCodeLabel.Text = s.subCode;
            atdCountLabel.Text = s.studentCount;
            durationLabel.Text = s.duration;

        }

        public void R1S1changeHeader()
        {
            if (R1S1LecSesDataGrid.Columns["sessionID"] != null)
                R1S1LecSesDataGrid.Columns["sessionID"].HeaderText = "Session ID";

            if (R1S1LecSesDataGrid.Columns["lecID"] != null)
                R1S1LecSesDataGrid.Columns["lecID"].HeaderText = "Lecturer ID";

            if (R1S1LecSesDataGrid.Columns["lecturerName"] != null)
                R1S1LecSesDataGrid.Columns["lecturerName"].HeaderText = "Lecturer Name";

            if (R1S1LecSesDataGrid.Columns["fac"] != null)
                R1S1LecSesDataGrid.Columns["fac"].HeaderText = "Faculty";

            if (R1S1LecSesDataGrid.Columns["dept"] != null)
                R1S1LecSesDataGrid.Columns["dept"].HeaderText = "Department";

            if (R1S1LecSesDataGrid.Columns["building"] != null)
                R1S1LecSesDataGrid.Columns["building"].HeaderText = "Building";



        }

        private void RS1_lecInfoUpdateB_Click(object sender, EventArgs e)
        {
            new section2_updateSession(sService.getSingleSession(s.SessionID.ToString())).Show();
        }
    }
}
