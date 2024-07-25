using System.ComponentModel;

class Program
{
    static void Main() //Наименьший элемент в последовательности
    {
        string userText;
        int number;
        int minNumber = int.MaxValue;

        Console.WriteLine("Чтобы закончить ввод, и узнать минимальное число, нажмите \"Enter\", вместо ввода числа");

        while (true)
        {
            Console.Write("Введите число: ");
            userText = Console.ReadLine();

            if (userText != "")
            {

                number = int.Parse(userText);

                if (number < minNumber)
                {
                    minNumber = number;
                }
            }
            else break;

        }
        Console.WriteLine($"Минимальное число: {minNumber}");
        Console.ReadKey();
    }
}