using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Institute___Timetable_Generator.Models
{
    class Subject
    {
        private string code;
        private String name;
        private int lecHr;
        private int tutHr;
        private int labHr;
        private int EvalHr;
        private int year;
        private int sem;



        public Subject(string code, string name, int lecHr, int tutHr, int labHr, int evalHr,int year, int sem)
        {
            this.code = code;
            this.name = name;
            this.lecHr = lecHr;
            this.tutHr = tutHr;
            this.labHr = labHr;
            this.EvalHr = evalHr;
            this.year = year;
            this.sem = sem;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public int LecHrs { get => lecHr; set => lecHr = value; }
        public int TutHrs { get => tutHr; set => tutHr = value; }
        public int LabHr { get => labHr; set => labHr = value; }
        public int evalHr { get => EvalHr; set => EvalHr = value; }
        public int Year { get => year; set => year = value; }
        public int Sem { get => sem; set => sem = value; }

    }

}
