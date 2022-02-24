using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two-digit number:");
            string numberTD = Console.ReadLine();
            int number = Convert.ToInt32(numberTD);
            int tenth = number / 10;
            int unit = number % 10;
            string tenthNum;
            string unitNum;

            if (number > 19)
            {
                if (tenth == 2)
                {
                    tenthNum = "Двадцать";
                }
                else if (tenth == 3)
                {
                    tenthNum = "Тридцать";
                }
                else if (tenth == 4)
                {
                    tenthNum = "Сорок";
                }
                else if (tenth == 5)
                {
                    tenthNum = "Пятьдесят";
                }
                else if (tenth == 6)
                {
                    tenthNum = "Шестьдесят";
                }
                else if (tenth == 7)
                {
                    tenthNum = "Семьдесят";
                }
                else if (tenth == 8)
                {
                    tenthNum = "Восемьдесят";
                }
                else
                {
                    tenthNum = "Девяносто";
                }
                if (unit == 1)
                {
                    unitNum = "Один";
                }
                else if (unit == 2)
                {
                    unitNum = "Два";
                }
                else if (unit == 3)
                {
                    unitNum = "Три";
                }
                else if (unit == 4)
                {
                    unitNum = "Четыре";
                }
                else if (unit == 5)
                {
                    unitNum = "Пять";
                }
                else if (unit == 6)
                {
                    unitNum = "Шесть";
                }
                else if (unit == 7)
                {
                    unitNum = "Семь";
                }
                else if (unit == 8)
                {
                    unitNum = "Восемь";
                }
                else
                {
                    unitNum = "Девять";
                }
                Console.WriteLine($"{tenthNum} {unitNum}");
            }
            else
            {
                if (number == 10)
                {
                    Console.WriteLine("Десять");
                }
                else if (number == 11)
                {
                    Console.WriteLine("Одиннадцать");
                }
                else if (number == 12)
                {
                    Console.WriteLine("Двенадцать");
                }
                else if (number == 13)
                {
                    Console.WriteLine("Тринадцать");
                }
                else if (number == 14)
                {
                    Console.WriteLine("Четырнадцать");
                }
                else if (number == 15)
                {
                    Console.WriteLine("Пятнадцать");
                }
                else if (number == 16)
                {
                    Console.WriteLine("Шестнадцать");
                }
                else if (number == 17)
                {
                    Console.WriteLine("Семнадцать");
                }
                else if (number == 18)
                {
                    Console.WriteLine("Восемнадцать");
                }
                else if (number == 19)
                {
                    Console.WriteLine("Девятнадцать");
                }
            } 
        }
    }
}
