
using ConsoleApp10.Services.Implementation;

string selection;

while (true)
{


    Console.WriteLine("1.Create Group");
    Console.WriteLine("2.Show groups information");
    Console.WriteLine("3.Edit Group");
    Console.WriteLine("4.Create Student");
    Console.WriteLine("5.Show students information");
    Console.WriteLine("6.Show group students information");
    Console.WriteLine("0.Stop the program");


    selection=Console.ReadLine();

    switch (selection)
    {
        case "1":
            MenuSerivce.CreatGroupMenu();
            break;
        case "2":
            MenuSerivce.GetAllGroupMenu();
            break;
        case "3":
            MenuSerivce.EditGroupMenu();
            break;
        case "4":
            MenuSerivce.CreatStudentMenu();
            break;
        case "5":
            MenuSerivce.GetAllStudentMenu();
            break;
        case "6":
            MenuSerivce.GetAllGroupStudentMenu();
            break;
        case "0":
            return;
        default:
        
            
                Console.WriteLine("Please choose valid number");
            
            break;
            
    }
}