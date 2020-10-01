using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Institute___Timetable_Generator
{
    interface sessionServiceInt
    {
        Boolean addSession(Session S);

        //Boolean checkExist(Lecturer L);
        Boolean updateSession(Session S);
        Boolean deleteSession(String ID);
        DataTable getAllSessions();
        Session getSingleSession(String ID);
        DataTable searchSession(String searchString);

        DataTable getLecturersbySessionID(String sesID);
        List<string> getSubGroups();

        List<string> getMainGroups();
        int getAllCount();
    }
}
