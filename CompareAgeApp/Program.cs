using System;

namespace ProektSVozrastom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Вы попали в программу которая сравнивает возраст\n");

            Console.Write("введите первое имя:\t");
            string name1 = Console.ReadLine();
            Console.Write("введите первый возраст:\t");

            int i = 0;
            int age1 = 0;
            while (i < 1)
            {
                int age;
                string x = Console.ReadLine();
                if (int.TryParse(x, out age))
                {
                    age1 = age;
                    i = 1;
                }
                else
                {
                    Console.Write("неверные данные повторите ввод возраста:\t");
                }

            }
            Console.Write("введите второе имя:\t");
            string name2 = Console.ReadLine();
            Console.Write("введите второй возраст:\t");
            int age2 = 0;
            int j = 0;
            while (j < 1)
            {
                int age;
                string x = Console.ReadLine();
                if (int.TryParse(x, out age))
                {
                    age2 = age;
                    j = 1;
                }
                else
                {
                    Console.Write("неверные данные повторите ввод возраста:\t");
                }
            }
            Console.WriteLine($"кто старше {name1} или {name2}?");
            int b = 0;
            while (b < 1)
            {
                string answer = Console.ReadLine();
                if (answer == name1)
                {
                    if (age1 > age2)
                    {
                        int differens = age1 - age2;
                        Console.WriteLine($"правильно {name1} старше на {differens} лет");
                    }
                    else if (age1 < age2)
                    {
                        int differens = age2 - age1;
                        Console.WriteLine($"не правильно {name2} старше на {differens} лет");
                    }
                    else
                    {
                        Console.WriteLine("они ровесники");
                    }
                    b = 1;
                }
                else if (answer == name2)
                {
                    if (age2 > age1)
                    {
                        int differens = age2 - age1;
                        Console.WriteLine($"правильно {name2} старше на {differens} лет");
                    }
                    else if (age2 < age1)
                    {
                        int differens = age1 - age2;
                        Console.WriteLine($"не правильно {name1} старше на {differens} лет");
                    }
                    else
                    {
                        Console.WriteLine("они ровесники");
                    }
                    b = 1;
                }
                else
                {
                    Console.Write("такого имени не указано повторите ввод:\t");
                }
            }
            Console.ReadKey();
        }
    }
}
