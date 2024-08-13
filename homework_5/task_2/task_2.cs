
class task_2
{
    static void Main()
    {
        string inputText = Console.ReadLine() ?? "";

        Console.WriteLine(Reverse(inputText));
        Console.ReadKey();
    }

    static string[] SplitText(string text)
    {
        return text.Split(" ");
    }

    static string Reverse(string text)
    {
        string[] array = SplitText(text);
        string resultString = "";

        {
            for (int i = array.GetLength(0) - 1; i >= 0; i--)
            {
                resultString += array[i] + " ";
            }
            return resultString;
        }
    }
}