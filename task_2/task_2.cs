
class task_2
{
    static void Main()
    {
        string inputText = Console.ReadLine() ?? "";

        Reverse(inputText);
        Console.ReadKey();
    }

    static string[] SplitText(string text)
    {
        return text.Split(" ");
    }

    static void Reverse(string text)
    {
        string[] array = SplitText(text);
        {
            for (int i = array.GetLength(0) - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}