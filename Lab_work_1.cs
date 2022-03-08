using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1_1
{
    class Program
    {
        // TASK 11-14 масив
        // Пошук перебором
        static void Task11(int[] arr, int n)
        {
            Console.Clear();
            Console.WriteLine("Структура даних: масив");
            Console.WriteLine("Пошук перебором");
            Console.WriteLine("\nВведіть шукане число:");
            int x = Convert.ToInt32(Console.ReadLine());
            int r = 0;
            bool Found = true;
            while ((r < n) && ( Found != false ))
            {
                if (arr[r] == x)
                {
                    Console.WriteLine("Число " + x + " знайдено");
                    Found = false;
                }
                else r++;
            }
            if (r == n)
                Console.WriteLine("Такого числа не має у масиві");
            Console.WriteLine("\nНатиснiть будь-яку клавiшу для повернення у меню:");
            Console.ReadKey();
            Console.Clear();
        }
        //Пошук з бар'єром
        static void Task12(int[] arr, int n)
        {
            Console.Clear();
            Console.WriteLine("Структура даних: масив");
            Console.WriteLine("Пошук з бар'єром");
            Console.WriteLine("\nВведіть шукане число:");
            int x = Convert.ToInt32(Console.ReadLine());
            int r = 0;
            int[] arr2 = new int[n+1];
            for (int i=0; i<n; i++)
                arr2[i] = arr[i];
            arr2[n] = x;
            for (int i = 0; i < arr2.Length; i++)
                Console.Write(arr2[i] + "  ");
            while (arr2[r]!=x)
            {
                r++;
            }
            if (r < n)
                Console.WriteLine("Число " + x + " знайдено");
            else
                Console.WriteLine("Такого числа не має у масиві");
            Console.WriteLine("\nНатиснiть будь-яку клавiшу для повернення у меню:");
            Console.ReadKey();
            Console.Clear();
        }
        //Бінарний пошук(стандарт)
        static int[] Task13(int[] arr3, int n)
        {
            Console.Clear();
            Console.WriteLine("Структура даних: масив");
            Console.WriteLine("Бінарний пошук(стандарт)");
            var len = arr3.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (arr3[j] > arr3[j + 1])
                    {
                        var temp = arr3[j];
                        arr3[j] = arr3[j + 1];
                        arr3[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arr3.Length; i++)
                Console.Write(arr3[i] + "  ");
            Console.WriteLine("\nВведіть шукане число:");
            int x = Convert.ToInt32(Console.ReadLine());
            int l = 0;
            int r = n - 1;
            int m=0;
            while ((l <= r))
            {
                m = l + (r-l) / 2;
                if (arr3[m] == x)
                {
                    Console.WriteLine("Число " + x + " знайдено");
                    break;
                }
                if (arr3[m] < x)
                    l = m + 1;

                else r = m-1;
            }
            if (arr3[m] != x)
                Console.WriteLine("Такого числа не має у масиві");
            Console.WriteLine("\nНатиснiть будь-яку клавiшу для повернення у меню:");
            Console.ReadKey();
            Console.Clear();
            return arr3;
        }
        static void Task14(int[] arr3, int n)
        {
            Console.Clear();
            Console.WriteLine("Структура даних: масив");
            Console.WriteLine("Бінарний пошук(стандарт)");
            Console.WriteLine("\nВведіть шукане число:");
            int x = Convert.ToInt32(Console.ReadLine());
            int l = 0;
            int r = n - 1;
            int m = 0;
            while ((l <= r))
            {
                m = l + (r - l) / 6;
                if (arr3[m] == x)
                {
                    Console.WriteLine("Число " + x + " знайдено");
                    break;
                }
                if (arr3[m] < x)
                    l = m + 1;

                else r = m - 1;
            }
            if (arr3[m] != x)
                Console.WriteLine("Такого числа не має у масиві");
            Console.WriteLine("\nНатиснiть будь-яку клавiшу для повернення у меню:");
            Console.ReadKey();
            Console.Clear();
        }
        //TASK 21-24 лінійний зв`язний список
        static void Task21()
        {
            Console.Clear();
            Console.WriteLine("Структура даних: лінійний зв’язний список");
            Console.WriteLine("Натиснiть будь-яку клавiшу для повернення у меню:");
            Console.ReadKey();
        }
        static void Task22()
        {
            Console.Clear();
            Console.WriteLine("Структура даних: лінійний зв’язний список");
            Console.WriteLine("Натиснiть будь-яку клавiшу для повернення у меню:");
            Console.ReadKey();
        }
        static void Task23()
        {
            Console.Clear();
            Console.WriteLine("Структура даних: лінійний зв’язний список");
            Console.WriteLine("Натиснiть будь-яку клавiшу для повернення у меню:");
            Console.ReadKey();
        }
        static void Task24()
        {
            Console.Clear();
            Console.WriteLine("Структура даних: лінійний зв’язний список");
            Console.WriteLine("Натиснiть будь-яку клавiшу для повернення у меню:");
            Console.ReadKey();
        }
        static void Menu1(int[] arr, int n)
        {
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Структура даних: масив");
            Console.ResetColor();
            Console.WriteLine("Завдання:");
            Console.WriteLine("1. Пошук перебором");
            Console.WriteLine("2. Пошук з бар'єром");
            Console.WriteLine("3. Бінарний пошук(стандарт)");
            Console.WriteLine("4. Бінарний пошук(згідно з правилом золотого перерізу)");
            Console.WriteLine("Для повернення у попереднє меню натисність будь-яку iншу клавiшу");
            Console.WriteLine("Виберiть завдання:");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1: Task11(arr, n); Menu1(arr, n); break;
                case 2: Task12(arr, n); Menu1(arr, n); break;
                case 3: Task13(arr, n); Menu1(arr, n); break;
                case 4: Task14(arr, n); Menu1(arr, n); break;
                default: break;
            }
        }
        static void Menu2()
        {
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Структура даних: лінійний зв’язний список");
            Console.ResetColor();
            Console.WriteLine("Завдання:");
            Console.WriteLine("1. Пошук перебором");
            Console.WriteLine("2. Пошук з бар'єром");
            Console.WriteLine("3. Бінарний пошук(стандарт)");
            Console.WriteLine("4. Бінарний пошук(згідно з правилом золотого перерізу)");
            Console.WriteLine("Для повернення у попереднє меню натисність будь-яку iншу клавiшу");
            Console.WriteLine("Виберiть завдання:");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1: Task21(); Menu2(); break;
                case 2: Task22(); Menu2(); break;
                case 3: Task23(); Menu2(); break;
                case 4: Task24(); Menu2(); break;
                default: break;
            }
        }
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Лабораторна робота 1");
            Console.ResetColor();
            Console.WriteLine("Виберіть структуру данних:");
            Console.WriteLine("1. Масив");
            Console.WriteLine("2. Лінійний зв’язаний список");
            Console.WriteLine("Для завершення роботи натисність будь-яку iншу клавiшу");
            Console.WriteLine("Виберiть завдання:");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Введіть кількість елементів масиву:");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    int[] arr = new int[n1];
                    Random aRand = new Random();
                    for (int i = 0; i < arr.Length; i++)
                        arr[i] = aRand.Next(100);
                    Menu1(arr, n1); 
                    Main(); 
                    break;
                case 2: Menu2(); Main(); break;
                default: break;
            }
        }
    }
}
