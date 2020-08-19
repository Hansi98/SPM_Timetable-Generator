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
    public partial class Section1_UpdateLecturer : Form
    {
        Lecturer L;
        LecturerServiceImpl Lservice = new LecturerServiceImpl();
        public Section1_UpdateLecturer()
        {
            InitializeComponent();
        }

        public Section1_UpdateLecturer(Object obj)
        {
            InitializeComponent();
            this.L = (Lecturer)obj;
            drawData(this.L);
            this.Text = this.Text + " " + L.ID1;
        }

        public void drawData(Object L)
        {

            Lecturer l2 = (Lecturer) L;

            RS1_upLecEmpID.Text = l2.ID1;
            RS1_upLecFName.Text = l2.FName;
            RS1_upLecMName.Text = l2.mName;
            RS1_upLecLName.Text = l2.lName;
            RS1_upLecFaculty.Text = l2.Faculty;
            RS1_upLecDepartment.Text = l2.Dept;
            RS1_upLecCenter.Text = l2.Center;
            RS1_upLecBuilding.Text = l2.Building;
            RS1_upLecLevel.Text = l2.Level;
            RS1_upLecRank.Text = l2.Rank;

           

            //faculty combobox changes
            if (RS1_upLecFaculty.Text=="Faculty of Computing")
            {


                RS1_upLecDepartment.Items.Clear();
               
                RS1_upLecDepartment.Items.Add("Software Engineering");
                RS1_upLecDepartment.Items.Add("Cyber Security");
                RS1_upLecDepartment.Items.Add("IT");
                RS1_upLecDepartment.Items.Add("Computer Network");

                if (l2.Dept == "Software Engineering")
                {
                    RS1_upLecDepartment.SelectedIndex = 0;
                }
                else if (l2.Dept == "Cyber Security")
                {
                    RS1_upLecDepartment.SelectedIndex = 1;
                }
                else if (l2.Dept == "IT")
                {
                    RS1_upLecDepartment.SelectedIndex = 2;
                }
               else
                {
                    RS1_upLecDepartment.SelectedIndex = 3;
                }

            }
            else if (RS1_upLecFaculty.Text == "Faculty of Engineering")
            {

                RS1_upLecDepartment.Items.Clear();
                RS1_upLecDepartment.Items.Add("Civil Engineering");
                RS1_upLecDepartment.Items.Add("Mechanical Engineering");
                RS1_upLecDepartment.Items.Add("Eletronic Engineering");
                RS1_upLecDepartment.Items.Add("Materials Engineering");

                if (l2.Dept == "Civil Engineering")
                {
                    RS1_upLecDepartment.SelectedIndex = 0;
                }
                else if (l2.Dept == "Mechanical Engineering")
                {
                    RS1_upLecDepartment.SelectedIndex = 1;
                }
                else if (l2.Dept == "Eletronic Engineering")
                {
                    RS1_upLecDepartment.SelectedIndex = 2;
                }
                else
                {
                    RS1_upLecDepartment.SelectedIndex = 3;
                }
            }
            else
            {

                RS1_upLecDepartment.Items.Clear();
                RS1_upLecDepartment.Items.Add("Management");
                RS1_upLecDepartment.Items.Add("Human Resourse");
                RS1_upLecDepartment.Items.Add("Marketing");
                RS1_upLecDepartment.Items.Add("Supply Chain Management");

                if (l2.Dept == "Management")
                {
                    RS1_upLecDepartment.SelectedIndex = 0;
                }
                else if (l2.Dept == "Human Resourse")
                {
                    RS1_upLecDepartment.SelectedIndex = 1;
                }
                else if (l2.Dept == "Marketing")
                {
                    RS1_upLecDepartment.SelectedIndex = 2;
                }
                else
                {
                    RS1_upLecDepartment.SelectedIndex = 3;
                }
            }
        

            

            //center combobox changes
            if (RS1_upLecCenter.Text == "Malabe")
            {

                RS1_upLecBuilding.Items.Clear();
                RS1_upLecBuilding.Items.Add("New Building");
                RS1_upLecBuilding.Items.Add("Computing Building");
                RS1_upLecBuilding.Items.Add("Businnes Building");
                RS1_upLecBuilding.Items.Add("Engineering Building");

                if (l2.Building == "New Building")
                {
                    RS1_upLecBuilding.SelectedIndex = 0;
                }
                else if (l2.Building == "Computing Building")
                {
                    RS1_upLecBuilding.SelectedIndex = 1;
                }
                else if (l2.Building == "Businnes Building")
                {
                    RS1_upLecBuilding.SelectedIndex = 2;
                }
                else
                {
                    RS1_upLecBuilding.SelectedIndex = 3;
                }

            }
            else if (RS1_upLecCenter.Text == "Metro")
            {

                RS1_upLecBuilding.Items.Clear();
                RS1_upLecBuilding.Items.Add("Main Building");
                RS1_upLecBuilding.Items.Add("A5 Building");

                if (l2.Building == "Main Building")
                {
                    RS1_upLecBuilding.SelectedIndex = 0;
                }
                else
                {
                    RS1_upLecBuilding.SelectedIndex = 1;
                }
                
                
            }
            else
            {
                RS1_upLecBuilding.Items.Clear();

                RS1_upLecBuilding.Items.Add("B5 Building");
                RS1_upLecBuilding.Items.Add("New Building");
                RS1_upLecBuilding.Items.Add("Tower Building");

                if (l2.Building == "B5 Building")
                {
                    RS1_upLecBuilding.SelectedIndex = 0;
                }
                else if (l2.Building == "New Building")
                {
                    RS1_upLecBuilding.SelectedIndex = 1;
                }
                else
                {
                    RS1_upLecBuilding.SelectedIndex = 2;
                }

            }


        }

        private void RS1_upLecFaculty_SelectedIndexChanged(object sender, EventArgs e)

        {
            RS1_upLecDepartment.SelectedItem = null;
            RS1_upLecDepartment.Text = "Please Choose ...";



            if (RS1_upLecFaculty.SelectedIndex == 0)
            {
                RS1_upLecDepartment.Items.Clear();

                RS1_upLecDepartment.Items.Add("Software Engineering");
                RS1_upLecDepartment.Items.Add("Cyber Security");
                RS1_upLecDepartment.Items.Add("IT");
                RS1_upLecDepartment.Items.Add("Computer Network");
            }

            if (RS1_upLecFaculty.SelectedIndex == 1)
            {
                RS1_upLecDepartment.Items.Clear();

                RS1_upLecDepartment.Items.Add("Civil Engineering");
                RS1_upLecDepartment.Items.Add("Mechanical Engineering");
                RS1_upLecDepartment.Items.Add("Eletronic Engineering");
                RS1_upLecDepartment.Items.Add("Materials Engineering");
            }

            if (RS1_upLecFaculty.SelectedIndex == 2)
            {
                RS1_upLecDepartment.Items.Clear();

                RS1_upLecDepartment.Items.Add("Management");
                RS1_upLecDepartment.Items.Add("Human Resourse");
                RS1_upLecDepartment.Items.Add("Marketing");
                RS1_upLecDepartment.Items.Add("Supply Chain Management");
            }
        }

        private void RS1_addLecCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

       

        private void RS1_upLecCenter_SelectedIndexChanged(object sender, EventArgs e)
        {

            RS1_upLecBuilding.SelectedItem = null;
            
            RS1_upLecBuilding.Text = "Please Choose ...";




            if (RS1_upLecCenter.SelectedIndex == 0)
            {
                RS1_upLecBuilding.Items.Clear();

                RS1_upLecBuilding.Items.Add("New Building");
                RS1_upLecBuilding.Items.Add("Computing Building");
                RS1_upLecBuilding.Items.Add("Businnes Building");
                RS1_upLecBuilding.Items.Add("Engineering Building");
            }

            if (RS1_upLecCenter.SelectedIndex == 1)
            {
                RS1_upLecBuilding.Items.Clear();

                RS1_upLecBuilding.Items.Add("Main Building");
                RS1_upLecBuilding.Items.Add("A5 Building");

            }

            if (RS1_upLecCenter.SelectedIndex == 2)
            {
                RS1_upLecBuilding.Items.Clear();

                RS1_upLecBuilding.Items.Add("B5 Building");
                RS1_upLecBuilding.Items.Add("New Building");
                RS1_upLecBuilding.Items.Add("Tower Building");

            }
        }

        private void RS1_upLecLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

            RS1_upLecRank.Text = RS1_upLecLevel.Text + "." + L.ID1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawData(this.L);
        }

        private void RS1_addLecCancel_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void RS1_addLecADD_Click(object sender, EventArgs e)
        {
            if ((RS1_upLecFName.Text.Trim() == "") || (RS1_upLecLName.Text.Trim() == "") || (RS1_upLecFaculty.SelectedItem==null) || (RS1_upLecDepartment.SelectedItem == null) || (RS1_upLecCenter.SelectedItem == null) || (RS1_upLecBuilding.SelectedItem == null) || (RS1_upLecLevel.SelectedItem == null) || (RS1_upLecRank.Text.Trim() == ""))
            {
                MessageBox.Show("Please Fill all the Fields! (Middle Name is Optional)", "Neccessary Fields are Empty!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
            else
            {

             
                    



                    Lecturer L = new Lecturer(this.L.ID1, RS1_upLecFName.Text.Trim(), RS1_upLecMName.Text.Trim(), RS1_upLecLName.Text.Trim(), RS1_upLecFaculty.Text.Trim(), RS1_upLecDepartment.Text.Trim(), RS1_upLecCenter.Text.Trim(), RS1_upLecBuilding.Text.Trim(), RS1_upLecLevel.Text.Trim(), RS1_upLecRank.Text.Trim());

                   
                        if (Lservice.updateLecturer(L))
                        {
                            MessageBox.Show("Lecturer Updated Successfully", "Success!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                            Dispose();


                        }
                        else
                        {
                            MessageBox.Show("Some Error Occured During the Lecturer Updating, Please Re-Try", "Error!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

                        }
                    
                
               


            }
        }
    }
}
