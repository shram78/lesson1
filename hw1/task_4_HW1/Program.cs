using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4. Написать программу обмена значениями двух переменных.
а) с использованием третьей переменной;
б) *без использования третьей переменной.*/

namespace task_4_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обмен значениями между двумя переменными\n");

            #region Реализация с помощью трех переменных
            Console.WriteLine("\tСпособ с тремя переменными");
            int min = 10; // стартовое минимальное значение
            int max = 100; // стартовое максимальное значение
            int temp = 0; // временная переменная для обмена
            Console.WriteLine($"ДО обмена: \tmin= {min}, max= {max} ");
            temp = max;
            max = min;
            min = temp;
            Console.WriteLine($"ПОСЛЕ обмена: \tmin= {min}, max= {max}\n");
            #endregion

            #region Реализация с помощью двух переменных
            Console.WriteLine("\tСпособ с двумя переменными");
            min = 10;
            max = 100;
            Console.WriteLine($"ДО обмена: \tmin= {min}, max= {max}");
            min = min + max;
            max = max - min;
            max = -max;
            min = min - max;
            Console.WriteLine($"ПОСЛЕ обмена: \tmin= {min}, max= {max}\n");
            Console.ReadLine();
            #endregion
        }
    }
}