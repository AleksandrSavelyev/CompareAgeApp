using System;

namespace ProgNaSravVozrasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте!!! Вас приветствует программа сравнения возраста");
            Console.WriteLine("Нажмите любую кнопку чтобы продолжить\n");
            Console.ReadKey();

            Console.WriteLine("введите данные первого человека\n");
            string userName1 = AskName();
            int userAge1 = AskAge();

            Console.WriteLine("введите данные второгочеловека:\t");
            string userName2 = AskName();
            int userAge2 = AskAge();

            Console.WriteLine($"кто старше {userName1} или {userName2}?");
            int a = 0;
            while (a < 1)
            {
                string answer = Console.ReadLine();
                if (answer == userName1)
                {
                    AnswerUserName(userName1, userAge1, userAge2);
                    break;
                }
                else if (answer == userName2)
                {
                    AnswerUserName(userName2, userAge2, userAge1);
                    break;
                }
                else
                {
                    Console.WriteLine("не верный ответ повторите ввод");
                }
            }
            Console.ReadKey();
        }
        static string AskName()
        {
            Console.Write("введите имя:\t");
            string userName = Console.ReadLine();
            return userName;
        }
        static int AskAge()
        {
            Console.Write("введите возраст:\t");
            int age = 0;
            int i = 0;
            while (i < 1)
            {
                string a = Console.ReadLine();
                if (int.TryParse(a, out int b))
                {
                    age = b;
                    break;
                }
                else
                {
                    Console.Write("не верные данные повторите ввод:\t");
                }
            }
            return age;
        }
        static void AnswerUserName(string userName1, int age1, int age2)
        {
            if (age1 > age2)
            {
                int diferens = age1 - age2;
                Console.WriteLine($"правильно {userName1} старше на {diferens} лет");
            }
            else if (age1 < age2)
            {
                int diferens = age2 - age1;
                Console.WriteLine($"неправильно {userName1} младше на {diferens} лет");
            }
            else
            {
                Console.WriteLine("они ровесники");
            }
        }
    }
}
