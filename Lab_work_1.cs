using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Console_Lab._1;
using System.Diagnostics;

namespace Lab1_1
{
    class Program
    {
        // TASK 11-14 масив
        // Пошук перебором
        static void Task11(int[] arr, int n)
        {
            Console.Clear();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            Console.WriteLine("Структура даних: масив");
            Console.WriteLine("Пошук перебором");
            Console.WriteLine("\nВведіть шукане число:");
            int x = Convert.ToInt32(Console.ReadLine());
            int r = 0;
            bool Found = true;
            stopWatch.Start();
            while ((r < n) && ( Found != false ))
            {
                if (arr[r] == x)
                {
                    stopWatch.Stop();
                    Console.WriteLine("Число " + x + " знайдено");
                    Found = false;
                }
                else r++;
            }
            stopWatch.Stop();
            if (r == n)
                Console.WriteLine("Такого числа не має у масиві");
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("\nЗатрачено часу в мілісекундах: " + ts.TotalMilliseconds);
            Console.WriteLine("\nНатиснiть будь-яку клавiшу для повернення у меню:");
            Console.ReadKey();
            Console.Clear();
        }
        //Пошук з бар'єром
        static void Task12(int[] arr, int n)
        {
            Console.Clear();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            Console.WriteLine("Структура даних: масив");
            Console.WriteLine("Пошук з бар'єром");
            Console.WriteLine("\nВведіть шукане число:");
            int x = Convert.ToInt32(Console.ReadLine());
            int r = 0;
            int[] arr2 = new int[n+1];
            for (int i=0; i<n; i++)
                arr2[i] = arr[i];
            arr2[n] = x;
            stopWatch.Start();
            while (arr2[r]!=x)
            {
                stopWatch.Stop();
                r++;
            }
            stopWatch.Stop();
            if (r < n)
                Console.WriteLine("Число " + x + " знайдено");
            else
                Console.WriteLine("Такого числа не має у масиві");
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("\nЗатрачено часу в мілісекундах: " + ts.TotalMilliseconds);
            Console.WriteLine("\nНатиснiть будь-яку клавiшу для повернення у меню:");
            Console.ReadKey();
            Console.Clear();
        }
        //Бінарний пошук(стандарт)
        static int[] Task13(int[] arr3, int n)
        {
            Console.Clear();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            Console.WriteLine("Структура даних: масив");
            Console.WriteLine("Бінарний пошук(стандарт)");
            Console.WriteLine("\nВведіть шукане число:");
            int x = Convert.ToInt32(Console.ReadLine());
            int l = 0;
            int r = n - 1;
            int m=0;
            stopWatch.Start();
            while ((l <= r))
            {
                m = l + (r-l) / 2;
                if (arr3[m] == x)
                {
                    stopWatch.Stop();
                    Console.WriteLine("Число " + x + " знайдено");
                    break;
                }
                if (arr3[m] < x)
                    l = m + 1;

                else r = m-1;
            }
            stopWatch.Stop();
            if (arr3[m] != x)
                Console.WriteLine("Такого числа не має у масиві");
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("\nЗатрачено часу в мілісекундах: " + ts.TotalMilliseconds);
            Console.WriteLine("\nНатиснiть будь-яку клавiшу для повернення у меню:");
            Console.ReadKey();
            Console.Clear();
            return arr3;
        }
        // бінарний пошук за правилом золотого перерізу.
        static void Task14(int[] arr3, int n)
        {
            Console.Clear();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            Console.WriteLine("Структура даних: масив");
            Console.WriteLine("Бінарний пошук(стандарт)");
            Console.WriteLine("\nВведіть шукане число:");
            int x = Convert.ToInt32(Console.ReadLine());
            int l = 0;
            int r = n - 1;
            int m = 0;
            stopWatch.Start();
            while ((l <= r))
            {
                m = l + (r - l) / 6;
                if (arr3[m] == x)
                {
                    stopWatch.Stop();
                    Console.WriteLine("Число " + x + " знайдено");
                    break;
                }
                if (arr3[m] < x)
                    l = m + 1;

                else r = m - 1;
            }
            stopWatch.Stop();
            if (arr3[m] != x)
                Console.WriteLine("Такого числа не має у масиві");
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("\nЗатрачено часу в мілісекундах: " + ts.TotalMilliseconds);
            Console.WriteLine("\nНатиснiть будь-яку клавiшу для повернення у меню:");
            Console.ReadKey();
            Console.Clear();
        }
        //TASK 21-24 лінійний зв`язний список
        static void Task21(Node head, int n)
        {
            Console.Clear();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            Console.WriteLine("Структура даних: лінійний зв’язний список");
            Console.WriteLine("\nВведіть шукане число:");
            int x = Convert.ToInt32(Console.ReadLine());
            bool isFound = false;
            stopWatch.Start();
            for (int i = 0; i < n; i++)
            {
                if (head.data == x)
                {
                    stopWatch.Stop();
                    Console.WriteLine("\nЧисло " + x + " знайдено");
                    isFound = true;
                    break;
                }
                else
                    head = head.next;
            }
            stopWatch.Stop();
            if (!isFound)
                Console.WriteLine("\nЧисло " + x + " не знайдено");
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("\nЗатрачено часу в мілісекундах: " + ts.TotalMilliseconds);
            Console.WriteLine("Натиснiть будь-яку клавiшу для повернення у меню:");
            Console.ReadKey();
        }
        static void Task22(Node head, int n)
        {
            Console.Clear();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            Console.WriteLine("Структура даних: лінійний зв’язний список");
            Console.WriteLine("\nВведіть шукане число:");
            int x = Convert.ToInt32(Console.ReadLine());
            head = BinarySearch.push(head, x);
            int k = 0;
            stopWatch.Start();
            for (int i = 0; i < n; i++)
            {
                k++;
                if (head.data == x)
                {
                    stopWatch.Stop();
                    break;
                }
                else head = head.next;
            }
            stopWatch.Stop();
            if (k < n)
                Console.WriteLine("Число " + x + " знайдено");
            else
                Console.WriteLine("Число " + x + " не знайдено");
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("\nЗатрачено часу в мілісекундах: " + ts.TotalMilliseconds);
            Console.WriteLine("Натиснiть будь-яку клавiшу для повернення у меню:");
            Console.ReadKey();
        }
        static void Task23(Node head, int n)
        {
            Console.Clear();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            Console.WriteLine("Структура даних: лінійний зв’язний список");
            Console.WriteLine("\nВведіть шукане число:");
            int x = Convert.ToInt32(Console.ReadLine());
            stopWatch.Start();
            if (BinarySearch.binarySearch(head, x) == null)
            {
                stopWatch.Stop();
                Console.WriteLine("Число " + x + " не знайдено");
            }
            else
            {
                stopWatch.Stop();
                Console.WriteLine("Число " + x + " знайдено");
            }
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("\nЗатрачено часу в мілісекундах: " + ts.TotalMilliseconds);
            Console.WriteLine("Натиснiть будь-яку клавiшу для повернення у меню:");
            Console.ReadKey();
        }
        static void Task24(Node head, int n)
        {
            Console.Clear();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            Console.WriteLine("Структура даних: лінійний зв’язний список");
            Console.WriteLine("\nВведіть шукане число:");
            int x = Convert.ToInt32(Console.ReadLine());
            stopWatch.Start();
            if (BinarySearch.binarySearch2(head, x) == null)
            {
                stopWatch.Stop();
                Console.WriteLine("Число " + x + " не знайдено");
            }
            else
            {
                stopWatch.Stop();
                Console.WriteLine("Число " + x + " знайдено");
            }
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("\nЗатрачено часу в мілісекундах: " + ts.TotalMilliseconds);
            Console.WriteLine("Натиснiть будь-яку клавiшу для повернення у меню:");
            Console.ReadKey();
        }
        static void Menu2(Node Head, Node head2, int n)
        {
            Console.Clear();
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
                case 1: Task21(Head, n); Menu2(Head, head2, n); break;
                case 2: Task22(Head, n); Menu2(Head, head2, n); break;
                case 3: Task23(head2, n); Menu2(Head, head2, n); break;
                case 4: Task24(head2, n); Menu2(Head, head2, n); break;
                default: break;
            }
        }
        static void Menu1(int[] arr, int[] arr3, int n)
        {
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
                case 1: Task11(arr, n); Menu1(arr, arr3, n); break;
                case 2: Task12(arr, n); Menu1(arr, arr3, n); break;
                case 3: Task13(arr3, n); Menu1(arr, arr3, n); break;
                case 4: Task14(arr3, n); Menu1(arr, arr3, n); break;
                default: break;
            }
        }
        static void Main()
        {
            Console.Clear(); 
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Лабораторна робота 1");
            Console.ResetColor();
            Node head = null;
            Node head2 = null;
            Console.WriteLine("Введіть кількість елементів масиву:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n1];
            Random aRand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = aRand.Next(0,10);
            for (int i = 0; i < arr.Length; i++)
                head = BinarySearch.push(head, arr[i]);
            int[] arr3 = new int[n1];
            for (int i = 0; i < arr.Length; i++)
                arr3[i] = arr[i];
            var len = arr3.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (arr3[j] > arr3[j + 1])
                    {
                        (arr3[j + 1], arr3[j]) = (arr3[j], arr3[j + 1]);
                    }
                }
            }
            for (int i = 0; i < arr3.Length; i++)
                head2 = BinarySearch.push(head2, arr3[i]);
            Console.WriteLine("\nВиберіть структуру данних:");
            Console.WriteLine("1. Масив/Лінійний зв’язаний список");
            Console.WriteLine("Для завершення роботи натисність будь-яку iншу клавiшу");
            Console.WriteLine("Виберiть завдання:");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    Console.Clear();
                    Menu1(arr, arr3, n1);
                    Menu2(head, head2, n1);
                    Main();
                    break;
                default: break;
            }
        }
    }
}
