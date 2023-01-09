using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Models
{
    internal class Student
    {
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public bool Guarantee { get; set; }

        public Student(string fullName)
        {
            FullName = fullName;
        }

        public override string ToString()
        {
            return $"Fullname: {FullName}\nGroupNo: {GroupNo}\nGuarantee: {Guarantee}";
        }
    }
}
