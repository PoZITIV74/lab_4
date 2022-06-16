using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Main
    {
        public double vvod_puncta;

        public Main()
        {
            Console.WriteLine("1. Диапозон массива от -100 до 100");
            Console.WriteLine("2. Виды сортировок и время их выполнения");
            Console.WriteLine("3. Работа с текстом");
            Console.WriteLine("4. Связи");
            vvod_puncta = double.Parse(Console.ReadLine());
        }
    }
}
