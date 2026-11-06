class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Напишіть ваше ім'я: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"Вітаю, {userName}!");
    }
}