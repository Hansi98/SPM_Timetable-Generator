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
    public partial class Section5_ViewRoomTimetable : Form
    {
        String roomno;
        public Section5_ViewRoomTimetable(String roomno)
        {
            InitializeComponent();
            this.roomno = roomno;
        }

        private void Section5_ViewRoomTimetable_Load(object sender, EventArgs e)
        {
            Section5_RoomTimetable timetableroom = new Section5_RoomTimetable();

            timetableroom.SetParameterValue("RoomNo", roomno);

            hroomReportViewer.ReportSource = timetableroom;

            hroomReportViewer.Refresh();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            if (roomno == "A502")
            {
                Section5_RoomTimetable timetableroom = new Section5_RoomTimetable();

                // timetableroom.SetParameterValue("RoomNo", roomno);

                hroomReportViewer.ReportSource = timetableroom;

                hroomReportViewer.Refresh();
            }
            else if (roomno == "B303")
            {
                Section5_RoomTimetable_1 timetableroom = new Section5_RoomTimetable_1();

                // timetableroom.SetParameterValue("RoomNo", roomno);

                hroomReportViewer.ReportSource = timetableroom;

                hroomReportViewer.Refresh();
            }
            else if (roomno == "A509")
            {
                Section5_RoomTimetable_2 timetableroom = new Section5_RoomTimetable_2();

                // timetableroom.SetParameterValue("RoomNo", roomno);

                hroomReportViewer.ReportSource = timetableroom;

                hroomReportViewer.Refresh();
            }
        }
    }
}