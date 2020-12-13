using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3. а) Написать программу, которая подсчитывает расстояние между точками
 с координатами x1, y1 и x2,y2 по формуле 
r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;*/

namespace task_3_HW1 // реализация программы с помощью метода
{
    class Program
    {
        static double Calc(double X1, double Y1, double X2, double Y2) //метод для расчета росстояния м\д (.) 
        {
            return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Расчет расстония между точками\n");

            Console.WriteLine("Введите координату Х1, нажмите enter и введите координату Y1: ");
            string x1 = Console.ReadLine(); //строчные икс и игрик для приемка с консоли
            string y1 = Console.ReadLine();
            double X1 = Convert.ToDouble(x1); //ЗАГЛАВНЫЕ икс и игрик для перевода в дробные числа
            double Y1 = Convert.ToDouble(y1);

            Console.WriteLine("Введите координату Х2, нажмите enter и введите координату Y2: ");
            string x2 = Console.ReadLine();
            string y2 = Console.ReadLine();
            double X2 = Convert.ToDouble(x2);
            double Y2 = Convert.ToDouble(y2);

            Console.WriteLine("Расстояние между точками = ");   //передача координат в метод
            Console.WriteLine("{0:0.00}", Calc(X1, Y1, X2, Y2));//спецификатор формата .2f (
                                                                //с двумя знаками после запятой)??Это он? "{0:0.00}"?
            Console.ReadLine();
        }
    }
}