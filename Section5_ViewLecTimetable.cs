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
    public partial class Section5_ViewLecTimetable : Form
    {

        String lecname;
        public Section5_ViewLecTimetable(String lecname)
        {
            InitializeComponent();
            this.lecname = lecname;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Section5_ViewLecTimetable_Load(object sender, EventArgs e)
        {
            Section5_LecTimetable timetable = new Section5_LecTimetable();

            timetable.SetParameterValue("LecName", lecname);

            hlecTimetableView.ReportSource = timetable;

            hlecTimetableView.Refresh();

        }
    }
}
