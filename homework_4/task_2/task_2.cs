
class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк матрицы: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов матрицы: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();
        int[,] matrixOne = new int[n, m];
        int[,] matrixTwo = new int[n, m];
        int[,] matrixSum = new int[n, m];
        int sum = 0;

        // Первое задание. Первая матрица.

        for (int i = 0; i < matrixOne.GetLength(0); i++)
        {
            for (int j = 0; j < matrixOne.GetLength(1); j++)
            {
                matrixOne[i, j] = random.Next(10);
                Console.Write($"{matrixOne[i, j]} ");
                sum += matrixOne[i, j];
            }
            Console.WriteLine();
        }
        Console.WriteLine($"sum = {sum}");

        // Второе задание. Создание второй матрицы и вывод.

        for (int i = 0; i < matrixTwo.GetLength(0); i++)
        {
            for (int j = 0; j < matrixTwo.GetLength(1); j++)
            {
                matrixTwo[i, j] = random.Next(10);
                Console.Write($"{matrixTwo[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("HEEE");

        // Сложение матриц и вывод третьей

        for (int i = 0; i < matrixSum.GetLength(0); i++)
        {
            for (int j = 0; j < matrixSum.GetLength(1); j++)
            {
                matrixSum[i, j] = matrixOne[i, j] + matrixTwo[i, j];
                Console.Write($"{matrixSum[i, j]} ");
            }
            Console.WriteLine();
        }


        Console.ReadKey();
    }
}