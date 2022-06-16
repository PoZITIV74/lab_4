using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public abstract class Lab_1_5
    {
        public abstract void Zapolnenie();
        //public abstract void SredZapolnenie();
        //public abstract void SredSredZapolnenie();
        public abstract double Min(double[,] numbers);
        public abstract double Max(double[,] numbers);  
        public abstract double Min(double[] numbers);
        public abstract double Max(double[] numbers);
        public abstract void Srednee();         
        public abstract double Diapozon(double di);
        public abstract double DiapozonVivod(double divo);
        //public double Min_s = double.MaxValue;       //новые перемные мксимума и минимума
        //public double Max_s = double.MinValue;
        public double ss;
    }

    public class Program1_5 : Lab_1_5
    {
        public double[,] numbers = new double[5, 10];  // задаются строки и столбцы
        public Random ran = new Random(); // задаем переменую для рандомных чисел 
        public HashSet<int> check = new HashSet<int>(); // будет смотреть дубль числа
        public double[] per = new double[5];       // строки
        public override void Zapolnenie()
        {
            for (int i = 0; i < numbers.GetLength(0); i++) // numbers.GetLength(0) сьроки 5
            {
                for (int j = 0; j < numbers.GetLength(1); j++) // numbers.GetLength(1) столбцы 10
                {
                    int Numbers;
                    Numbers = ran.Next(-100, 100); // генерирует рандомные числа
                    while (check.Contains(Numbers))  // если находит такоеже число то его пересоздает 
                    {
                        Numbers = ran.Next(-100, 100); // если есть дубль то по новой
                    }
                    check.Add(Numbers);     // если нету дубля то дальше
                    numbers[i, j] = Numbers;
                    // Console.Write($"{numbers[i, j]} ");
                }
            }
        }

        public override double Min(double[,] numbers)
        {
            double min = int.MaxValue; 
            for (int i = 0; i < numbers.GetLength(0); i++) // numbers.GetLength(0) сьроки 5
            {
               
                for (var j = 0; j < numbers.GetLength(1); j++) //  столбцы 10
                {
                    if (numbers[i, j] < min)        // смотрит минимальное по каждой строке
                    {
                        min = numbers[i, j];        // Минимальное
                    }
                }       
            }
            Console.WriteLine("");      //выводим все минимальные
            return min;
        }

        public override double Max(double[,] numbers)
        {
            double max = int.MinValue;
            for (int i = 0; i < numbers.GetLength(0); i++)    // numbers.GetLength(0) сьроки 5        
            {

                for (var j = 0; j < numbers.GetLength(1); j++)   //  столбцы 10   
                {
                    if (numbers[i, j] > max)        // смотрит максимальное 
                    {
                        max = numbers[i, j];        // Максимальное
                    }
                }
            }
            Console.WriteLine("");
            return max;  //выводим все максимальные
        } 
        public override double Min(double[] numbers)
        {
            double min = int.MaxValue; 
            for (int i = 0; i < numbers.GetLength(0); i++) // numbers.GetLength(0) сьроки 5
            {
             
                if (numbers[i] < min)        // смотрит минимальное по каждой строке
                {
                    min = numbers[i];        // Минимальное
                }                    
            }
            Console.WriteLine("");      //выводим все минимальные
            return min;
        }

        public override double Max(double[] numbers)
        {
            double max = int.MinValue;
            for (int i = 0; i < numbers.GetLength(0); i++)    // numbers.GetLength(0) сьроки 5        
            {
             
                if (numbers[i] > max)        // смотрит максимальное 
                {
                    max = numbers[i];        // Максимальное
                }
               
            }
            Console.WriteLine("");
            return max;  //выводим все максимальные
        }

        public override double Diapozon(double di)
        {
            for (int i = -10; i < 11; i++)
            {
                Console.Write($"sin: {Math.Round(Math.Sin(i * di), 2)} | ");              // Находим синус и округляем до двух знаков после запятой.
                Console.Write($"cos: {Math.Round(Math.Cos(i * di), 2)} | ");                        // Находим косинус и округляем до двух знаков после запятой.
                Console.Write($"tan: {Math.Round(Math.Tan(i * di), 2)}\n");                         // Находим тангенс и округляем до двух знаков после запятой.
            }
            return di;
        }        
        public override double DiapozonVivod(double divo)
        {
            for (int i = -10; i < 11; i++)
            {
                Console.Write($"{Math.Round(Math.Sin(i * divo), 2)} | ");              // Находим синус и округляем до двух знаков после запятой.
                Console.Write($"{Math.Round(Math.Cos(i * divo), 2)} | ");                        // Находим косинус и округляем до двух знаков после запятой.
                Console.Write($"{Math.Round(Math.Tan(i * divo), 2)}\n");                         // Находим тангенс и округляем до двух знаков после запятой.
            }
            return divo;
        }


        public override void Srednee()
        {          
            for (int i = 0; i < numbers.GetLength(0); i++)         // смотрит 5 строк
            {         
                for (int j = 0; j < numbers.GetLength(1); j++) // столбы
                {
                    ss += Math.Abs(numbers[i, j]); // обсолютное значение по горизантале и вертикале 
                    ss /= 10; // с 10 столбцов среднее арифмитическое 
                }
                per[i] = ss; // строка равна столбам
                Console.WriteLine(per[i]);
            }
        }  

        //public override void SredZapolnenie()
        //{
        //    for (int i = 0; i < numbers.GetLength(0); i++)   // строки
        //    {
        //        if (per[i] < Min_s) // минимальное значение берет из строки
        //        {
        //            Min_s = per[i];
        //        }
        //    }
        //    for (int i = 0; i < numbers.GetLength(0); i++)   // строки
        //    {
        //        if (per[i] > Max_s)   // максимальное значение берет из строки
        //        {
        //            Max_s = per[i];
        //        }
        //    }
        //}

        //public override void SredSredZapolnenie()
        //{
        //    for (int i = -10; i < 11; i++)
        //    {
        //        Console.Write($"sin: {Math.Round(Math.Sin(i * Min_s), 2)} | ");              // Находим синус и округляем до двух знаков после запятой.
        //        Console.Write($"cos: {Math.Round(Math.Cos(i * Min_s), 2)} | ");                        // Находим косинус и округляем до двух знаков после запятой.
        //        Console.Write($"tan: {Math.Round(Math.Tan(i * Min_s), 2)}\n");                         // Находим тангенс и округляем до двух знаков после запятой.
        //    }
           
        //}

        public Program1_5()
        {
            Zapolnenie();
            Console.WriteLine();
            Console.WriteLine("_________________________");
            Console.Write($"Наибольшее число: {Max(numbers)}");
            Console.Write($"Наименьшее число: {Min(numbers)}\n");
            Console.WriteLine("_________________________");
            Console.WriteLine("\nСреднее значение по строке: ");          
            Srednee();
            Console.WriteLine("_________________________");
            Console.Write($"Максимальное значение: {Max(per)}");        
            Console.Write($"Минимальное значение: {Min(per)}\n");
            Console.WriteLine("_________________________");
            Console.Write($"Максимальное значение: {DiapozonVivod(Max(per))}\n");          
            Console.Write($"Минимальное значение: {DiapozonVivod(Min(per))}\n");
        }
    }
}
