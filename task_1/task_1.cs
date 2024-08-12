
class task_1
{
    static void Main()
    {
        string inputText = Console.ReadLine() ?? "";

        PrintSeparateWords(SplitText(inputText));
        Console.ReadKey();
    }

    static string[] SplitText(string text)
    {
        return text.Split(" ");
    }

    static void PrintSeparateWords(string[] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine(array[i]);
        }
        
    }

}