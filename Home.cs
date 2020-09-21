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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            customizeddesign();
            customizesessionddesign();
        }

        //slide bar
        private void customizeddesign()
        {
            panelslidebar.Visible = false;
        }

        //session dropdown
        private void customizesessionddesign()
        {
            sessionslidebar.Visible = false;
        }

        private void hidesubmenu()
        {
            if(panelslidebar.Visible == true)
            {
                panelslidebar.Visible = false;
            }
        }

        //session dropdown
        private void hidesessionsubmenu()
        {
            if (sessionslidebar.Visible == true)
            {
                sessionslidebar.Visible = false;
            }
        }

        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        //session dropdown
        private void showsessionsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesessionsubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void slidebar(Control btn)
        {
            panelslidebar.Width = btn.Width;
            panelslidebar.Left = btn.Left;
        }

        //session dropdown

        private void slidebarsession(Control btn)
        {
            sessionslidebar.Width = btn.Width;
            sessionslidebar.Left = btn.Left;
        }

        //session dropdown
        private void Homebtnsessions_Click(object sender, EventArgs e)
        {
            showsessionsubmenu(sessionslidebar);
            slidebarsession(homenavbtnsessions);
        }

        private void Homebtnlocations_Click(object sender, EventArgs e)
        {
            
        }

        private void Homebtntimetables_Click(object sender, EventArgs e)
        {
        }
        
        
        private void Panelslide_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Homebtnworkingdnh_Click(object sender, EventArgs e)
        {
            openchildform(new Section1_WorkingDays());
            //..codes
            hidesubmenu();
        }

        private void Homebtnlecturers_Click(object sender, EventArgs e)
        {
            openchildform(new Section1_Lecturers());
            //..codes
            hidesubmenu();
        }

        private void Homebtnsubjects_Click(object sender, EventArgs e)
        {
            openchildform(new Section1_Subjects());
            //..codes
            hidesubmenu();
        }

        private void Homebtnstudents_Click(object sender, EventArgs e)
        {
            openchildform(new Section1_Students());
            //..codes
            hidesubmenu();
        }

        private void Homebtntags_Click(object sender, EventArgs e)
        {
            openchildform(new Section1_tags());
            //..codes
            hidesubmenu();
        }

        private void Homebtnlocations_Click_1(object sender, EventArgs e)
        {
            //open the child form for the relevant button. set your every child form size to '1043, 450'
            openchildform(new Section1_Location());
            //
            hidesubmenu();
        }

        private void Homebtnstatistics_Click(object sender, EventArgs e)
        {
            openchildform(new Section1_Statistics());
            //..codes
            hidesubmenu();
        }
        private Form activeform = null;

        private void openchildform(Form childform)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelchildform.Controls.Add(childform);
            panelchildform.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void Panelslide_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            showsubmenu(panelslidebar);
            slidebar(homenavbtndetails);
        }

        private void Panelchildform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnVsessionunavailability_Click(object sender, EventArgs e)
        {
            openchildform(new Section3_MarkUnavailabily());
            //
            hidesessionsubmenu();
        }

        private void BtnVsessionconsecutive_Click(object sender, EventArgs e)
        {
            openchildform(new Section3_consecutiveSessions());
            //
            hidesessionsubmenu();
        }

        private void BtnVsessionparallel_Click(object sender, EventArgs e)
        {
            openchildform(new Section3_parallelSessions());
            //
            hidesessionsubmenu();
        }

        private void BtnVsessionnooverlapping_Click(object sender, EventArgs e)
        {
            openchildform(new Section3_nooverlappingSessions());
            //
            hidesessionsubmenu();
        }
    }
}
