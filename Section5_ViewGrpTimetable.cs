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
            Section5_GroupTimetable timetablegrp = new Section5_GroupTimetable();

            timetablegrp.SetParameterValue("GrpNo", grpname);

            hgrpreportViewer.ReportSource = timetablegrp;

            hgrpreportViewer.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
