using ConsoleApp5;
using System.Diagnostics;

Console.WriteLine("Birinci reqemi daxil ele");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Isareni daxil ele");
string calcu = Console.ReadLine();

while (calcu != "-" && calcu != "+" && calcu != "*" && calcu != "/")
{
    Console.WriteLine("Isareni duzgun daxil edin");
    string NewCalcu;
    NewCalcu = Console.ReadLine();
    calcu = NewCalcu;
}

Console.WriteLine("Ikinci reqemi daxil ele");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Cavab: ");




if (calcu == "+")
{
    Plus plus = new(num1, num2);
}
else if (calcu == "-")
{
    Minus minus = new(num1, num2);
}else if (calcu == "*")
{
    Hit hit = new(num1, num2);
}else if (calcu == "/")
{
    Divide divide = new(num1, num2);
}



    

    
    
 

