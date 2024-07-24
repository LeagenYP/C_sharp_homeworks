using System.ComponentModel;

class Program()
{
    static void Main() //Игра «Угадай число»
    {
        Random random = new Random();
        int secretNumber = random.Next(0, 101);

        Console.WriteLine("Попробуй угадать загаданное число от 0 до 100");
        while (true)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number > secretNumber)
            {
                Console.WriteLine($"Число {number} больше загаданного (попробуй меньше)");
            }
            else if (number < secretNumber)
            {
                Console.WriteLine($"Число {number} меньше загаданного (попробуй больше)");
            }
            else
            {
                Console.WriteLine($"Ты угадал, было загадано число {secretNumber}");
                break;
              
            }
        }
        Console.ReadKey();
    }
}