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
    interface SubjectServicesInt
    {
        Boolean addSubject(Subject L);
        Boolean updateSubject(Subject L);
        Boolean deleteSubject(String code);
        DataTable getAllSubject();
        Subject getSingleSubject(String code);
        DataTable searchSubject(String searchString);

        Boolean checkExist(Subject S);

        int getAllCount();





    }
}
