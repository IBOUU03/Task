using ConsoleApp10.Enums;
using ConsoleApp10.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Services.Implementation
{
    internal static class MenuSerivce
    {
        private static Service Service = new();
        public static void CreatGroupMenu()
        {
            test:
            Console.WriteLine("Category sec\n");
            foreach (var item in Enum.GetValues(typeof(LessonCategory)))
            {
                Console.WriteLine($"{(int)item}.{item}");
            }
            int CategoryLength = Enum.GetValues(typeof(LessonCategory)).Length;
            int.TryParse(Console.ReadLine(), out int CategoryNumber);
            if (CategoryNumber <= 0 || CategoryNumber > CategoryLength)
            {
                goto test;
            }
            string result = Service.CreateGroup((LessonCategory)CategoryNumber);
            Console.WriteLine(result);
        }

        public static void GetAllGroupMenu()
        {
            Service.GetAllGroup();
        }
        public static void EditGroupMenu()
        {
            if (Service.Groups.Count == 0)
            {
                Console.WriteLine("Qrup yoxdur");
                return;
            }
            foreach (var item in Service.Groups)
            {
                Console.WriteLine($"{item.No}");
            }
            Console.WriteLine("Grupun no-sunu yaz");
            string no = Console.ReadLine();
        test:
            Console.WriteLine("Category sec");
            foreach (var item in Enum.GetValues(typeof(LessonCategory)))
            {
                Console.WriteLine($"{(int)item}.{item}");
            }
            int CategoryLength = Enum.GetValues(typeof(LessonCategory)).Length;
            int.TryParse(Console.ReadLine(), out int CategoryNumber);
            if (CategoryNumber <= 0 || CategoryNumber > CategoryLength)
            {
                goto test;
            }
            string result = Service.EditGroup(no, (LessonCategory)CategoryNumber);

            Console.WriteLine(result);

        }

        public static void CreatStudentMenu()
        {
            Console.WriteLine("Ad daxil et:");
        name:
            string name = Console.ReadLine().Trim();
            if (name.Length < 2 || name.Length > 12 || name == string.Empty)
            {
                Console.WriteLine("Duzgun ad daxil edin");
                goto name;
            }
            Console.WriteLine("Soyad daxil et:");
        surname:
            string surname = Console.ReadLine().Trim();
            if (surname.Length < 2 || surname.Length > 12 || string.IsNullOrEmpty(surname))
            {
                Console.WriteLine("Duzgun soyad daxil edin");
                goto surname;
            }
            
            string result = Service.CreateStudent(name,surname);

            Console.WriteLine(result);
             
        }

        public static void GetAllStudentMenu()
        {
            Service.GetAllStudent();
        }

        public static void GetAllGroupStudentMenu()
        {
            Service.GetAllGroupStudent();
        }
    }

    
}
