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

        public Subject(string code, string name, int lecHr, int tutHr, int labHr, int evalHr)
        {
            this.code = code;
            this.name = name;
            this.lecHr = lecHr;
            this.tutHr = tutHr;
            this.labHr = labHr;
            this.EvalHr = evalHr;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public int LecHrs { get => lecHr; set => lecHr = value; }
        public int TutHrs { get => tutHr; set => tutHr = value; }
        public int LabHr { get => labHr; set => labHr = value; }
        public int evalHr { get => EvalHr; set => EvalHr = value; }

    }

}
