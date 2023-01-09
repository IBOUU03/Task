using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp10.Enums;
using ConsoleApp10.Services.Interfaces;
using ConsoleApp10.Models;

namespace ConsoleApp10.Services.Implementation
{
    internal class Service : Interface
    {

       
        private List<Group> _groups { get; set; } = new List<Group>();
        public List<Group> Groups { get { return _groups;} }
        
        public string CreateGroup(LessonCategory category)
        {
            Group group = new Group(category);
            int selection;
            test:
            Console.WriteLine("1.Onlinedir");
            Console.WriteLine("2.Online deyil");
            int.TryParse(Console.ReadLine(), out selection);
            switch (selection)
            {
                case 1:
                    group.IsOnline = true;
                    group.Limit = 15;
                    break;
                case 2:
                    group.IsOnline = false;
                    group.Limit = 10;
                    break;

                default:
                    Console.WriteLine("Duzgun seceneyi secin");
                    goto test;
            }
            Groups.Add(group);

            return $"{group.No} Grup yaradildi";
        }

        public void GetAllGroup()
        {
            if (Groups.Count == 0)
            {
                Console.WriteLine("Qrup yoxdur");
            }
            foreach(Group group in Groups)
            {
                Console.WriteLine(group);
            }
        }
        


        public string EditGroup(string no, LessonCategory category)
        {
            
            foreach (Group group in Groups) 
            {
                if (group.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    group.Category = category;
                    group.No = $"{category.ToString().Substring(0, 1)}-{group.Id}";
                    return $"{no}- Yeni no-su {group.No}";
                }

            }

            return "Deyismek ucun qrup yoxdur";
        }
        
        
        
        public string CreateStudent(string name, string surname)
        {
            
            if (Groups.Count == 0)
            {
                return "Elave etmeye qrup yoxdur";
            }
            Student student = new Student($"{name} {surname}");
            int selection;
            test3:
            Console.WriteLine("1.Zemanetli");
            Console.WriteLine("2.Zemanetsiz");
            int.TryParse(Console.ReadLine(), out selection);
            switch (selection)
            {
                case 1:
                    student.Guarantee = true;
                    break;
                case 2:
                    student.Guarantee = false;
                    break;
                default:
                    Console.WriteLine("Duzgun seceneyi sec");
                goto test3;
            }

        test2:
            Console.WriteLine("Qruplar:");
            foreach (Group group in Groups)
            {
                Console.WriteLine(group.No);
            }
            
            Console.WriteLine("Daxil edeceyiniz qrupun no-sunu yaz:");
            string selec = Console.ReadLine();
            foreach (Group group in Groups)
            {
                
                if (selec == group.No)
                {
                    if (group.Students.Count == group.Limit)
                    {
                        return $"Bu qrupa {group.Limit}-dan cox telebe elave etmek olmaz";
                    }
                    group.Students.Add(student);
                    student.GroupNo = group.No;
                    return $"{group.No} bu qrupa daxil oldu";
                }                       
            }
            return "Bele qrup yoxdur";
        }




        

        public void GetAllGroupStudent()
        {
            Console.WriteLine("Groups:");
            foreach (Group group in Groups)
            {
                Console.WriteLine($"{group.No}");
            }
            Console.WriteLine("Qrupun no-sunu yaz");
            string selec = Console.ReadLine();
            foreach (Group group in Groups)
            {
                if (selec == group.No)
                {
                    foreach (Student student in group.Students)
                    {
                        Console.WriteLine($"{student}");
                    }
                }
            }
            Console.WriteLine("Bele qrup yoxdur");
        }

        public void GetAllStudent()
        {
            foreach (Group group in Groups)
            {
                foreach (Student student in group.Students)
                {
                    Console.WriteLine($"{student}");
                }
            }
        }
    }
}
