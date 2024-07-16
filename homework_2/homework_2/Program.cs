
class Program
{
    static void Main()
    {
        string fullName = "Ponomarev Yuriy Andreevich";
        int age = 27;
        string email = "ponomarev-25@mail.ru";
        double codingScore = 4.76;
        double mathScore = 4.15;
        double physicScore = 4.48;
        string pattern = "Full name: {0} \nAge: {1} \nEmail: {2} \nCoding score: {3} \nMath score: {4} \nPhysic score: {5}";

        double scoreSum = codingScore + mathScore + physicScore;
        double scoreAverage = scoreSum / 3;

        Console.WriteLine(
            pattern,
            fullName,
            age,
            email,
            codingScore,
            mathScore,
            physicScore
        );

        Console.ReadKey();

        Console.WriteLine($"\nScore sum = {scoreSum} \nAverage score = {scoreAverage.ToString("#.###")}");

        Console.ReadKey();
    }
}