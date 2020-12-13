using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  1. Написать программу «Анкета». Последовательно задаются вопросы
(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
а) используя склеивание;
б) используя форматированный вывод;
в) *используя вывод со знаком $.*/

namespace task_1_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("АНКЕТА\n");

            Console.Write("Введите имя: "); //ввод исходных данных
            string namePer = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surnamePer = Console.ReadLine();
            Console.Write("Введите возраст (лет): ");
            string agePer = Console.ReadLine();
            Console.Write("Введите рост (см): ");
            string growthPer = Console.ReadLine();
            Console.Write("Введите вес (кг): ");
            string weightPer = Console.ReadLine();
            Console.WriteLine();

            // Вывод информации в консоль тремя методами
            #region а) склеивание
            Console.WriteLine("клиент " + namePer + " " + surnamePer + 
                    ", возраст " + agePer + " лет," + " рост " + 
                    growthPer + " см, вес " + weightPer + " кг ");
            Console.WriteLine();
            #endregion

            #region б) форматированный вывод 
            Console.WriteLine("клиент {0} {1}, возраст {2} лет, рост {3} см, вес {4} кг ",
                             namePer,surnamePer,agePer, growthPer, weightPer);
            Console.WriteLine();
            #endregion

            #region в) метод интерполяции
            Console.WriteLine($"клиент {namePer} {surnamePer}, возраст {agePer} лет, " +
                $"рост {growthPer} см, вес {weightPer} кг ");
            Console.ReadLine();
            #endregion
        }
    }
}