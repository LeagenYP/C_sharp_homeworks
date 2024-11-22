using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

class Program
{
    static void Main()
    {
        string filePath = @"D:\data.txt";
        CheckFileExist(filePath);

        Console.WriteLine("Выберите действие. 1 - записать в файл. 2 - считать файл.");
        string key = Console.ReadLine() ?? "0";

        while (key != "0")
        {

            if (key == "1")
            {
                WriteToFile(filePath);
            }
            else if (key == "2")
            {
                ReadFile(filePath);
            }
            else
            {
                break;
            }
            Console.WriteLine("\nВыберите действие. 1 - записать в файл. 2 - считать файл.");
            key = Console.ReadLine() ?? "0";
        }
    }
    static void CheckFileExist(string filePath)
    {
        if (!File.Exists(filePath))
        {
            using (StreamWriter sw = new StreamWriter(filePath, false)) { };
        }
    }

        static void WriteToFile(string filePath)
        {

            using (StreamWriter sw = new StreamWriter(filePath, true))

            {

                char key = '1';
                do
                {
                    string note = string.Empty;
                    Console.Write("\nВведите ID: ");
                    note += $"{Console.ReadLine()}#";

                    string now = DateTime.Now.ToString();
                    note += $"{now}#";

                    Console.Write("Введите Ф.И.О.: ");
                    note += $"{Console.ReadLine()}#";
                    //sw.Write(note);

                    Console.Write("Введите возраст: ");
                    note += $"{Console.ReadLine()}#";
                    //sw.Write(note);

                    Console.Write("Введите рост: ");
                    note += $"{Console.ReadLine()}#";
                    //sw.Write(note);

                    Console.Write("Введите дату рождения: ");
                    note += $"{Console.ReadLine()}#";
                    //sw.Write(note);

                    Console.Write("Введите место рождения: ");
                    note += $"{Console.ReadLine()}";

                    sw.WriteLine(note);

                    Console.Write("Продолжить? 1 - да. 2 - нет."); 
                    
                    key = Console.ReadKey(true).KeyChar;

                } while (key == '1');
            }
    }

        static void ReadFile(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
            string line;
                while ((line = sr.ReadLine()) != null)
                {
                string[] data = line.Split('#');
                Console.WriteLine($"\nID: {data[0]} " +
                    $"\nДата записи: {data[1]} " +
                    $"\nФ.И.О.: {data[2]} " +
                    $"\nВозраст: {data[3]} " +
                    $"\nРост: {data[4]} " +
                    $"\nДата рождения: {data[5]} " +
                    $"\nМесто рождения: {data[6]}");
                }
            Console.WriteLine();
            }
        }
    }

