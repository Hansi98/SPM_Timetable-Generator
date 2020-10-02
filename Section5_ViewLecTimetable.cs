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
            if (lecname == "Dr Nuwan Kodagoda")
            {
                Section5_LecTimetable timetable = new Section5_LecTimetable();

                //timetable.SetParameterValue("LecName", lecname);

                hlecTimetableView.ReportSource = timetable;

                hlecTimetableView.Refresh();
            }
            else if (lecname == "Dr. Anuradha Karunasena")
            {
                Section5_LecTimetable_1 timetable = new Section5_LecTimetable_1();

                //timetable.SetParameterValue("LecName", lecname);

                hlecTimetableView.ReportSource = timetable;

                hlecTimetableView.Refresh();
            }
            else if (lecname == "Mr. Dilshan Silva")
            {
                Section5_LecTimetable_3 timetable = new Section5_LecTimetable_3();

                //timetable.SetParameterValue("LecName", lecname);

                hlecTimetableView.ReportSource = timetable;

                hlecTimetableView.Refresh();
            }
            else if (lecname == "Mrs. Pradeepa Samarasinghe")
            {
                Section5_LecTimetable_2 timetable = new Section5_LecTimetable_2();

                //timetable.SetParameterValue("LecName", lecname);

                hlecTimetableView.ReportSource = timetable;

                hlecTimetableView.Refresh();
            }
        }

        private void Section5_ViewLecTimetable_Load(object sender, EventArgs e)
        {
            if(lecname == "Dr Nuwan Kodagoda")
            {
                Section5_LecTimetable timetable = new Section5_LecTimetable();

                //timetable.SetParameterValue("LecName", lecname);

                hlecTimetableView.ReportSource = timetable;

                hlecTimetableView.Refresh();
            }
            else if (lecname == "Dr. Anuradha Karunasena")
            {
                Section5_LecTimetable_1 timetable = new Section5_LecTimetable_1();

                //timetable.SetParameterValue("LecName", lecname);

                hlecTimetableView.ReportSource = timetable;

                hlecTimetableView.Refresh();
            }
            else if (lecname == "Mr. Dilshan Silva")
            {
                Section5_LecTimetable_2 timetable = new Section5_LecTimetable_2();

                //timetable.SetParameterValue("LecName", lecname);

                hlecTimetableView.ReportSource = timetable;

                hlecTimetableView.Refresh();
            }
            else if (lecname == "Mrs. Pradeepa Samarasinghe")
            {
                Section5_LecTimetable_3 timetable = new Section5_LecTimetable_3();

                //timetable.SetParameterValue("LecName", lecname);

                hlecTimetableView.ReportSource = timetable;

                hlecTimetableView.Refresh();
            }

        }
    }
}
