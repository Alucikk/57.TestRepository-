using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Напишіть ваше ім'я: ");
        string userName = Console.ReadLine();

        Console.Write("Напишіть ваш вік: ");
        string ageInput = Console.ReadLine();

        Console.WriteLine($"Користувач: {userName}, вік: {ageInput} років. Вітаю, {userName}!");

        Console.ReadLine();
    }
}