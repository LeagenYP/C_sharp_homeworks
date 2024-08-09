using System.ComponentModel;

class Program
{
    static void Main() //Игра «Угадай число»
    {
        Console.Write("Введите максимальное значение для загаданного числа: ");
        int maxSecretNumber = int.Parse(Console.ReadLine());
        int number = 0;

        Random random = new Random();
        int secretNumber = random.Next(0, maxSecretNumber);

        Console.WriteLine($"Попробуй угадать загаданное число от 0 до {maxSecretNumber}");
        while (true)
        {
            Console.Write("Введите число: ");
            string userText = Console.ReadLine() ?? "";

            if (userText == "")
            {
                Console.WriteLine($"Игра прервана. Было загадно число {secretNumber}");
                break;
            }
            else
            {
                number = int.Parse(userText);

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
        }
        Console.ReadKey();
    }
}