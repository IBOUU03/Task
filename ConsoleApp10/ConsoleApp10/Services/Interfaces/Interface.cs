using ConsoleApp10.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Services.Interfaces
{
    internal interface Interface
    {
        public string CreateGroup(LessonCategory category);
        public void GetAllGroup();
        public string EditGroup(string no, LessonCategory category);
        public void GetAllGroupStudent();
        public void GetAllStudent();
        public string CreateStudent(string name,string Surname);
    }
}
