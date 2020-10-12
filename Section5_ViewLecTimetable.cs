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

        private void hlecreportViewer_Load(object sender, EventArgs e)
        {
            if (lecname == "Dr Nuwan Kodagoda")
            {
                Section5_LecTimetable timetable = new Section5_LecTimetable();
                hlecreportViewer.ReportSource = timetable;
                hlecreportViewer.Refresh();
            }
            else if (lecname == "Mr. Dilshan Silva")
            {
                Section5_LecTimetable_1 timetable = new Section5_LecTimetable_1();
                hlecreportViewer.ReportSource = timetable;
                hlecreportViewer.Refresh();
            }
            else if (lecname == "Mrs. Pradeepa Samarasinghe")
            {
                Section5_LecTimetable_2 timetable = new Section5_LecTimetable_2();
                hlecreportViewer.ReportSource = timetable;
                hlecreportViewer.Refresh();
            }
            else if (lecname == "Prof. Koliya Pulasinghe")
            {
                Section5_LecTimetable_3 timetable = new Section5_LecTimetable_3();
                hlecreportViewer.ReportSource = timetable;
                hlecreportViewer.Refresh(); 
            }
            else if (lecname == "Dr Jayantha Amaraachchi")
            {
                Section5_LecTimetable_4 timetable = new Section5_LecTimetable_4();
                hlecreportViewer.ReportSource = timetable;
                hlecreportViewer.Refresh();
            }
            else if (lecname == "Dr Manori Jayasinghe")
            {
                Section5_LecTimetable_5 timetable = new Section5_LecTimetable_5();
                hlecreportViewer.ReportSource = timetable;
                hlecreportViewer.Refresh(); 
            }
            else if (lecname == "Dr. Anuradha Karunasena")
            {
                Section5_LecTimetable_6 timetable = new Section5_LecTimetable_6();
                hlecreportViewer.ReportSource = timetable;
                hlecreportViewer.Refresh();
            }
            else
            {
                MessageBox.Show("No Sessions allocated for the selected Lecturer Name");
                this.Dispose();
            }
        }

        private void Section5_ViewLecTimetable_Load(object sender, EventArgs e)
        {
            if (lecname == "Dr Nuwan Kodagoda")
            {
                Section5_LecTimetable timetable = new Section5_LecTimetable();
                hlecreportViewer.ReportSource = timetable;
                hlecreportViewer.Refresh();
            }
            else if (lecname == "Mr. Dilshan Silva")
            {
                Section5_LecTimetable_1 timetable = new Section5_LecTimetable_1();
                hlecreportViewer.ReportSource = timetable;
                hlecreportViewer.Refresh();
            }
            else if (lecname == "Mrs. Pradeepa Samarasinghe")
            {
                Section5_LecTimetable_2 timetable = new Section5_LecTimetable_2();
                hlecreportViewer.ReportSource = timetable;
                hlecreportViewer.Refresh();
            }
            else if (lecname == "Prof. Koliya Pulasinghe")
            {
                Section5_LecTimetable_3 timetable = new Section5_LecTimetable_3();
                hlecreportViewer.ReportSource = timetable;
                hlecreportViewer.Refresh();
            }
            else if (lecname == "Dr Jayantha Amaraachchi")
            {
                Section5_LecTimetable_4 timetable = new Section5_LecTimetable_4();
                hlecreportViewer.ReportSource = timetable;
                hlecreportViewer.Refresh();
            }
            else if (lecname == "Dr Manori Jayasinghe")
            {
                Section5_LecTimetable_5 timetable = new Section5_LecTimetable_5();
                hlecreportViewer.ReportSource = timetable;
                hlecreportViewer.Refresh();
            }
            else if (lecname == "Dr. Anuradha Karunasena")
            {
                Section5_LecTimetable_6 timetable = new Section5_LecTimetable_6();
                hlecreportViewer.ReportSource = timetable;
                hlecreportViewer.Refresh();
            }
            else
            {
                MessageBox.Show("No Sessions allocated for the selected Lecturer Name");
                this.Dispose();
            }
        }
    }
}
