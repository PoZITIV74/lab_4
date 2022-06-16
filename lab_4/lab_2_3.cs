using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public abstract class Program_2_3
    {
        protected abstract void Vvod();
        public abstract void Itog();
        protected abstract void Print();
        public abstract void Sviazi_mnoj();
        public abstract void Sviazi_1_1();     
    }

    public class Program_lab_2_3 : Program_2_3
    {
        public List<int> list;
        public int dlina, menu, sv, sv1;

        protected override void Vvod()
        {
            Console.WriteLine("Выбрать длину массива: ");
            dlina = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            object[,] obj = new object[3, dlina];  // массив из объектов создается
            list = new List<int>();

            for (int i = 0; i < dlina; i++)
            {
                list.Add(i);  // добавляет в лист
            }

            Console.WriteLine("Оригинал:");
            foreach (int i in list)
            {
                Console.Write(i);   // просто вывод оригинатьльной записи 
            }

            Console.WriteLine();
            Console.WriteLine("Впереди стоящие: ");
            foreach (int i in list)
            {
                if (i < list.Count - 1)   // смотрит количество знаком и убирает один знак
                {
                    obj[1, i] = i + 1;  // прибавляет единицу
                }
                Console.Write(obj[1, i]);  // выводит записанные в массив значения 
            }

            Console.WriteLine();
            Console.WriteLine("Позади стоящие: ");

            foreach (int i in list)
            {
                if (i > 0 && i != list.Count)  // смотрит, чтобы было больше 0 и не ровнялась количеству знаков
                {
                    obj[2, i] = i - 1;  // убирает на единицу
                }
                Console.Write(obj[2, i]); // выводит записанные в массив значения 
            }

            Console.WriteLine();
            Console.WriteLine("Связи: ");
            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count)  // пока не равняется количеству символов
                {
                    sv = i + 1; // прибавляет на 1
                }
                if (sv == dlina) // делает до тех пор пока не лостигнит максимального символа
                {
                    break;
                }
                Console.WriteLine($"Объект: {i} стоит перед, {sv}");  // вывод 
            }
            Console.WriteLine();

            Console.WriteLine();

        }

        protected override void Print()
        {
            Console.WriteLine("1. Объекты с множественными связями");
            Console.WriteLine("2. Связь один к одному");
            Console.WriteLine("3. Результат");
            menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1)
            {
                Sviazi_mnoj();
            }
            else if (menu == 2)
            {
                Sviazi_1_1();
            }
            else if (menu == 3)
            {
                Itog();
            }
            else
            {
                Console.WriteLine("Не правильно выбран пункт ");
            }
        }

        public override void Sviazi_mnoj()
        {
            Console.WriteLine("Объекты с множественными связями: ");
            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count)
                {
                    sv = i + 1;            //прибавляет имеющийся символ на единицу
                }
                if (sv1 != list.Count)
                {
                    sv1 = sv + 1;              //прибавляет имеющийся символ на единицу из прошлого ещё на единицу
                }
                if (sv == dlina)  // длина объекта
                {
                    break;
                }
                if (sv1 == dlina)
                {
                    break;
                }
                Console.WriteLine($"Объект: {i} стоит перед: {sv}, после стоит {sv1}");            //выводит                               
            }
        }

        public override void Sviazi_1_1()
        {
            Console.WriteLine("Связь один к одному");
            foreach (int i in list)
            {
                Console.Write(i);
            }
        }

        public override void Itog()
        {
            LinkedList<int> list1 = new LinkedList<int>(list);
            Stack<int> stack = new Stack<int>(list);

            Console.WriteLine("Связанные объекты: ");
            foreach (int i in stack)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            Console.WriteLine("Объекты с множествами: ");
            foreach (int i in list1)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            Console.WriteLine("Объекты без связи: ");
            foreach (int i in list)
            {
                Console.Write(i);
            }
        }

        public Program_lab_2_3()
        {
            Vvod();
            Print();
        }

    }
}
