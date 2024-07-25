using System.ComponentModel;

class Program
{
    static void Main() //Проверка простого числа
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        bool simpleCheck = false;

        for (int i = 2; i < number - 1; i++)
        {

            if (number % i == 0)
            {
                simpleCheck = true;
                break;
            }

        }

        if (simpleCheck)
        {
            Console.WriteLine($"Число {number} не является простым");
        }
        else
        {
            Console.WriteLine($"Число {number} является простым");
        }
        Console.ReadKey();
    }
}