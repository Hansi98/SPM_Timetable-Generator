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
    public partial class Section5_ViewGrpTimetable : Form
    {
        String grpname;
        public Section5_ViewGrpTimetable(String grpname)
        {
            InitializeComponent();
            this.grpname = grpname;

        }

        private void Section5_ViewGrpTimetable_Load(object sender, EventArgs e)
        {
            if (grpname == "Y2.S1.IT.01")
            {
                Section5_GroupTimetable timetablegrp = new Section5_GroupTimetable();

               // timetablegrp.SetParameterValue("GrpNo", grpname);

                hgrpreportViewer.ReportSource = timetablegrp;

                hgrpreportViewer.Refresh();
            }
            else if (grpname == "Y3.S2.SE.09")
            {
                Section5_GroupTimetable_1 timetablegrp = new Section5_GroupTimetable_1();

                //timetablegrp.SetParameterValue("GrpNo", grpname);

                hgrpreportViewer.ReportSource = timetablegrp;

                hgrpreportViewer.Refresh();
            }
            else if (grpname == "Y2.S1.CS.01")
            {
                Section5_GroupTimetable_2 timetablegrp = new Section5_GroupTimetable_2();

                //timetablegrp.SetParameterValue("GrpNo", grpname);

                hgrpreportViewer.ReportSource = timetablegrp;

                hgrpreportViewer.Refresh();
            }
        }

    }
}
