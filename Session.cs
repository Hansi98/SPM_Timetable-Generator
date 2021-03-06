﻿using ABC_Institute___Timetable_Generator.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Institute___Timetable_Generator
{
    class Session
    {
        
        private int sessionID;
        private String GroupID;
        private String Tag;
        private String SubCode;
        private String StudentCount;
        private String Duration;
        private List<Lecturer> lecList = null;

        public Session(int sessionID, string groupID, string tag, string subCode, string studentCount, string duration, List<Lecturer> lecList)
        {
            this.sessionID = sessionID;
            GroupID = groupID;
            Tag = tag;
            SubCode = subCode;
            StudentCount = studentCount;
            Duration = duration;
            this.lecList = lecList;
        }

        public Session(int sessionID, string groupID, string tag, string subCode, string studentCount, string duration)
        {
            this.sessionID = sessionID;
            GroupID = groupID;
            Tag = tag;
            SubCode = subCode;
            StudentCount = studentCount;
            Duration = duration;
            
        }

        public int SessionID { get => sessionID; set => sessionID = value; }
        public string groupID { get => GroupID; set => GroupID = value; }
        public string tag { get => Tag; set => Tag = value; }
        public string subCode { get => SubCode; set => SubCode = value; }
        public string studentCount { get => StudentCount; set => StudentCount = value; }
        public string duration { get => Duration; set => Duration = value; }
        public List<Lecturer> LecList { get => lecList; set => lecList = value; }

        public void addToArrayList(Lecturer i)
        {
            lecList.Add(i);
        }

        public void removeFromList(string id)
        {
            int x = 0;

            for (x=0;x<lecList.Count;x++)
            {
                if (lecList[x].ID1 == id)
                {
                    lecList.RemoveAt(x);
                }
            }
        }

    }

}
