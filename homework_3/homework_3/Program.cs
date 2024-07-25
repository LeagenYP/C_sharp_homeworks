using System.ComponentModel;

class Program
{
    static void Main() //Приложение по определению четного или нечетного числа
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());   

        if (number % 2 == 0)
        {
            Console.WriteLine($"Число {number} четное");
        } else
        {
            Console.WriteLine($"Число {number} нечетное");
        }
        Console.ReadKey();
    }
}