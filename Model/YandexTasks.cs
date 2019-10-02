using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yandex.Interview.Model
{
    public static class YandexTasks
    {   
        
        
        /// <summary>
        /// Камни и украшения 
        /// </summary>
        public static void TaskA()
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();

            int count = 0;
            foreach (char ch in line2)
            {
                if (line1.IndexOf(ch) >= 0)
                {
                    ++count;
                }
            }
            Console.WriteLine(count);
        }

        /// <summary>
        /// Последовательно идущие единицы
        /// </summary>
        public static void TaskB()
        {
            int count;
            Int32.TryParse(Console.ReadLine(), out count);

            int max = 0;
            int current = 0;

            for (int i = 0; i < count; i++)
            {
                Int32.TryParse(Console.ReadLine(), out var number);

                if (number == 1)
                {
                    current++;
                    max = max < current ? current : max;
                }
                else
                {
                    current = 0;
                }
            }

            Console.WriteLine(max);

        }
        /// <summary>
        /// Удаление дубликатов
        /// </summary>
        public static void TaskC()
        {
            Int32.TryParse(Console.ReadLine(), out var count);
            var list = new List<int>(count);
            int val = -2;
            int number = -1;
            for (int i = 0; i < count; i++)
            {

                if (Int32.TryParse(Console.ReadLine(), out number))
                {
                    if (i == 0 || val != number)
                    {
                        list.Add(number);
                    }

                    val = number;

                }

            }
            for (int j = 0; j < list.Count; j++)
            {

                Console.WriteLine(list[j]);
            }
        }

        /// <summary>
        /// Генерация скобочных последовательностей
        /// </summary>
        public static void TaskD()
        {

        }

        /// <summary>
        /// Анаграммы
        /// </summary>
        public static void TaskE()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            if (str1 == null && str2 == null)
            {
                Console.WriteLine("1");
                return;

            }
            if (str1 == null && str2 != null)
            {
                Console.WriteLine("0");
                return;
            }
            if (str1 != null && str2 == null)
            {
                Console.WriteLine("0");
                return;
            }
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("0");
                return;
            }
            str1 = String.Concat(str1.OrderBy(s => s));
            str2 = String.Concat(str2.OrderBy(s => s));

            if (str1 == str2)
            {
                Console.WriteLine("1");
                return;
            }
            Console.WriteLine("0");

        }
    }
}
