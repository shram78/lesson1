using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ)
 по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах*/

namespace task_2_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор индекса массы тела\n");
            Console.Write("Введите Ваш вес (кг): "); //ввод исходных данных
            string wp = Console.ReadLine();
            double weightPer = Convert.ToDouble(wp); //переменная для массы тела

            Console.Write("Введите Ваш рост (например, 1,8 м): ");
            string gp = Console.ReadLine();
            double growthPer = Convert.ToDouble(gp); // переменная для роста в метрах

            double indMass=0.0; // переменная для расчета идекса
            indMass = weightPer / (growthPer * growthPer);
            Console.WriteLine();
            Console.Write("Индекс массы Вашего тела = "); //для отображения 2 знаков после зпт 
            Console.WriteLine("{0:0.00}", indMass);
            Console.ReadLine();
        }
    }
}
