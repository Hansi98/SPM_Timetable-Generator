using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Institute___Timetable_Generator.Models
{
    class Lecturer
    {
        private String ID;
        private String fName;
        private String MName;
        private String LName;
        private String faculty;
        private String dept;
        private String center;
        private String building;
        private int level;
        private double rank;

        public Lecturer(string iD, string fName, string mName, string lName, string faculty, string dept, string center, string building, int level, double rank)
        {
            ID1 = iD;
            this.FName = fName;
            MName = mName;
            LName = lName;
            this.Faculty = faculty;
            this.Dept = dept;
            this.Center = center;
            this.Building = building;
            this.Level = level;
            this.Rank = rank;
        }

        public string ID1 { get => ID; set => ID = value; }
        public string FName { get => fName; set => fName = value; }
        public string mName { get => MName; set => MName = value; }
        public string lName { get => LName; set => LName = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public string Dept { get => dept; set => dept = value; }
        public string Center { get => center; set => center = value; }
        public string Building { get => building; set => building = value; }
        public int Level { get => level; set => level = value; }
        public double Rank { get => rank; set => rank = value; }
    }

}
