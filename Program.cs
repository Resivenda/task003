using System.Net.NetworkInformation;

public class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Введите цифру для обозначения дня недели:");
        int day=Convert.ToInt32(Console.ReadLine());
        if (day>7)
        {
            Console.WriteLine("Такого дня недели не существует");
        }
        else if (IsWeekend(day))
        {
            Console.WriteLine("Этот день является выходным");
        }
        else
        {
            Console.WriteLine("Этот день не является выходным");
        }
    }
    public static bool IsWeekend(int day)
    {
        return day ==6||day==7;

    }
    
}
