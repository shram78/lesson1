using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организуйте в центре экрана
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)*/
namespace task_5_HW1 // решение с помощью методов
{
    class Program
    {
        static void OuterString(string Name)
        {
            int centerX = (Console.WindowWidth / 2) - (Name.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.Write(Name);
        }
        static void Main(string[] args)
        {
            // а) выводит на экран ваше имя, фамилию и город проживания.
            string outName = ("Александр Шрам, г. Санкт- Петербург");
            Console.WriteLine(outName);
            Console.WriteLine("\nНажмите Enter");
            Console.ReadLine();
            Console.Clear();

            // б) вывод организуйте в центре экрана с помощью метода
            OuterString(outName);
            Console.ReadLine();
        }
    }
}