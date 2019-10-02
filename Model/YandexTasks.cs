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
    }
}
