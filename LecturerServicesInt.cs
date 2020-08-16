using ABC_Institute___Timetable_Generator.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Institute___Timetable_Generator.Services
{
    interface LecturerServicesInt
    {
        Boolean addLecturer(Lecturer L);
        Boolean updateLecturer(Lecturer L);
        Boolean deleteLecturer(String EmpID);
        DataTable getAllLecturers();
        Lecturer getSingleLecturer(String EmpID);
        ArrayList searchLecturer(String searchString);
        String getNextEmpID();

        int getAllCount();





    }
}
