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
        }

        //slide bar
        private void customizeddesign()
        {
            panelslidebar.Visible = false;
        }

        private void hidesubmenu()
        {
            if(panelslidebar.Visible == true)
            {
                panelslidebar.Visible = false;
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

        private void slidebar(Control btn)
        {
            panelslidebar.Width = btn.Width;
            panelslidebar.Left = btn.Left;
        }
        /*
        private void Button1_Click(object sender, EventArgs e)
        {
            movepanel(homenavbtndetails);
            showsubmenu(panelslidebar);
        }
        */
        private void Homebtnsessions_Click(object sender, EventArgs e)
        {
        }

        private void Homebtnlocations_Click(object sender, EventArgs e)
        {
            openchildform(new Section1_Location());
        }

        private void Homebtntimetables_Click(object sender, EventArgs e)
        {
        }
        
        
        private void Panelslide_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void Home_Load(object sender, EventArgs e)
        {
            /*
            formorgsize = panelnav.Size;
            detailsrecorg = new Rectangle(homenavbtndetails.Location.X, homenavbtndetails.Location.Y,
                homenavbtndetails.Width, homenavbtndetails.Height);
            sessionsrecorg = new Rectangle(homenavbtnsessions.Location.X, homenavbtnsessions.Location.Y,
                homenavbtnsessions.Width, homenavbtnsessions.Height);
            locationsrecorg = new Rectangle(homenavbtnlocations.Location.X, homenavbtnlocations.Location.Y,
                homenavbtnlocations.Width, homenavbtnlocations.Height);
            timetablesrecorg = new Rectangle(homenavbtntimetables.Location.X, homenavbtntimetables.Location.Y,
                homenavbtntimetables.Width, homenavbtntimetables.Height);
*/


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
            //openchildform(new Section1_Statistics());
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
        /*
private void ResponsiveChildControls()
{
ResponsiveControl(detailsrecorg, homenavbtndetails);
ResponsiveControl(sessionsrecorg, homenavbtnsessions);
ResponsiveControl(locationsrecorg, homenavbtnlocations);
ResponsiveControl(timetablesrecorg, homenavbtntimetables);
}

private Rectangle detailsrecorg;
private Rectangle sessionsrecorg;
private Rectangle locationsrecorg;
private Rectangle timetablesrecorg;

private Size formorgsize;

private void ResponsiveControl(Rectangle rec, Control control)
{
float xratio = (float)(panelnav.Width) / (float)(formorgsize.Width);
float yratio = (float)(panelnav.Height) / (float)(formorgsize.Height);

int newX = (int)(rec.X * xratio);
int newY = (int)(rec.Y * yratio);
int newWidth = (int)(rec.Width * xratio);
int newHeight = (int)(rec.Height * xratio);

control.Location = new Point(newX, newY);
control.Size = new Size(newWidth, newHeight);
}
*/
    }
}
