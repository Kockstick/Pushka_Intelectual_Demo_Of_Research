using System;
using System.Linq;
using System.Threading;

namespace Pushka_Intelectual_Demo_Of_Research
{
    internal class Program
    {
        public static int time = 10;
        public static string text = "";

        private static RightAngled rightAngled = new RightAngled();

        static void Main(string[] args)
        {
            DisplayNow("Enter to system");
            Display("Введите оба катета");

            rightAngled.setFirst(Read());
            rightAngled.setSecond(Read());

            Display($"Вы ввели катеты {rightAngled.first} и {rightAngled.second}\nEnter to contunie");
            Read();
            Display($"Гипотенуза = {rightAngled.getGipotenuse()}\nEnter to contunie");
            Read();
            Display($"Площадь = {rightAngled.getSqare()}\nEnter to contunie");
            Read();

            Console.ReadKey();
        }

        private static float Read()
        {
            string s = Console.ReadLine();
            if (s == "")
                return 0;
            return Convert.ToSingle(s);
        }

        private static void DisplayNow(string str)
        {
            Console.WriteLine(str);
        }
        private static void Display(string str)
        {
            text = str;
            Thread thread = new Thread(new ThreadStart(ThreadProc));
            thread.Start();
        }

        public static void ThreadProc()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);

                if(i % 3 == 0 & i != 0)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write(Enumerable.Repeat<char>(' ', Console.BufferWidth).ToArray());
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }
            }
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(Enumerable.Repeat<char>(' ', Console.BufferWidth).ToArray());
            Console.SetCursorPosition(0, Console.CursorTop - 1);

            Console.WriteLine(text);
        }
    }
}
