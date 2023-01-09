using ConsoleApp10.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Models
{
    internal class Group
    {
        static int _id = 1;
        public int Id { get;set; }
        public string No { get; set; }

        public LessonCategory Category { get; set; }

        public bool IsOnline { get; set; }
        public int Limit { get; set; }


        public List<Student> Students = new List<Student>();
        

        public Group( LessonCategory category)
        {
            No = $"{category.ToString().Substring(0,1).ToUpper()}-{_id}";
            Category = category;
            
            
            Id = _id;
            _id++;
        }
        public override string ToString()
        {
            return $"No: {No}\nCategory: {Category}\nOnline: {IsOnline}\nNumber of students: {Students.Count}\n";
        }
    }
}
