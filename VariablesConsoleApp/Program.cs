using System;

namespace VariablesConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 21;
            
            string fullName = "Ivanov Vasiliy Petrovich";
            string eMail = "vpivanov@university.com";

            double programmingScores = 87.7;
            double mathScores = 81.2;
            double phisicsScores = 79.9;

            double sumOfScores = programmingScores + mathScores + phisicsScores;
            double meanScores = sumOfScores / 3;

            Console.WriteLine($"{"ФИО:", 30}{fullName, 30}");
            Console.WriteLine($"{"Возраст:", 30}{age, 30}");
            Console.WriteLine($"{"Эл. почта:",30}{eMail,30}");
            Console.WriteLine($"{"Баллы по программированию:",30}{programmingScores,30}");
            Console.WriteLine($"{"Баллы по математике:",30}{mathScores,30}");
            Console.WriteLine($"{"Баллы по физике:",30}{phisicsScores,30}");

            Console.ReadKey();

            Console.WriteLine($"{"Сумма баллов:",30}{sumOfScores,30}");
            Console.WriteLine($"{"Средний балл:",30}{meanScores,30:#.##}");

            Console.ReadKey();
        }
    }
}
