using System.ComponentModel;

class Program()
{
    static void Main() //Программа подсчёта суммы карт в игре «21»
    {
        Console.Write("Введите количество ваших карт: ");
        int cardsAmount = int.Parse(Console.ReadLine());
        int sumPoints = 0;

        for (int i = 1; i <= cardsAmount; i++)
        {
            Console.Write($"Введите карту №{i}: ");
            var nextCard = Console.ReadLine();

            switch (nextCard)
            {
                case "J":
                    sumPoints += 10;
                    break;
                case "Q":
                    sumPoints += 10;
                    break;
                case "K":
                    sumPoints += 10;
                    break;
                case "T":
                    sumPoints += 10;
                    break;
                default:
                    sumPoints += int.Parse(nextCard);
                    break;
            }
        }
        Console.WriteLine($"Сумма очков равна: {sumPoints}");
        Console.ReadKey();
    }
}