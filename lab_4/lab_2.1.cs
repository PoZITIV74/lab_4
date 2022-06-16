using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public abstract class Program_2_1
    {
        public abstract void ZapProver();
        public abstract void Itog_StopWatch(int[] numbers);
    }

    public class Program_2 : Program_2_1
    {
        public int[] numbers = new int[10000];  // задаются строки и столбцы
        public Random ran = new Random();
        public HashSet<int> check = new HashSet<int>(); // будет смотреть дубль числа
        public Stopwatch stopWatch = new Stopwatch(); // подсчёт времени сортировки.
        public int sort; // используется для разных сортировок
        public int sort_2; // используется для разных сортировок

        public override void ZapProver()
        {
            for (int i = 0; i < numbers.GetLength(0); i++) // numbers.GetLength(0) сьроки 5
            {
                int newNumbers;
                newNumbers = ran.Next(0, 10001);
                while (check.Contains(newNumbers))  // если находит такоеже число то его пересоздает 
                {
                    newNumbers = ran.Next(0, 10001);
                }
                check.Add(newNumbers);      // чистые
                numbers[i] = newNumbers;
            }

            for (int i = 0; i < numbers.Length; i++) //задает строки
            {
                Console.Write($"{numbers[i]} \t"); // выводит получившийся результат
            }
        }
    
        public override void Itog_StopWatch(int[] numbers) // Метод для вывода массива и всей его информации.
        {        
            Console.Write("Время выполнения сортировки: ");
            Console.Write(stopWatch.Elapsed); // Подсчёт затраченного времени на выполнения сортировки.
            Console.WriteLine("");
        }
    }

    public class Sort1 : Program_2
    {
        public void Puzir(int[] numbers)
        {
            stopWatch.Start();
            for (int i = 0; i < numbers.Length; i++)    // строки
            {
                for (int j = i; j < numbers.Length; j++) //столбцы
                {
                    if (numbers[i] > numbers[j])
                    {
                        sort = numbers[i];            // сравнивает массивы между собой до тех пор пока все не встанет
                        numbers[i] = numbers[j];      // большие элементы отправляет в конец наименьшие в начало
                        numbers[j] = sort;
                    }
                }
            }
            stopWatch.Stop();
        }
        public Sort1()
        {
            Puzir(numbers);
            Console.WriteLine("Пузырьковая сортировка: ");
            Itog_StopWatch(numbers);
        }
    }

    public class Sort2 : Program_2
    {
        public void Vstavki(int[] numbers)
        {        
            stopWatch.Start();
            for (int i = 1; i < numbers.Length; i++)  // строки
            {            
                while (i > 0 && numbers[i] < numbers[i - 1])      // переставляет числа
                {
                    numbers[i] = numbers[i - 1];  // помещает в уже отсортрированное 
                    i--;
                }
                numbers[i] = numbers[i];  // приравнивает
            }
            stopWatch.Stop();
        }
        public Sort2()
        {
            Vstavki(numbers);
            Console.WriteLine("Сортировка вставками: ");
            Itog_StopWatch(numbers);
        }
    }

    public class Sort3 : Program_2
    {     
        public void Vibor(int[] numbers)
        {
            stopWatch.Start();
            for (int i = 0; i < numbers.Length - 1; i++)  
            {     
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[sort])    // производит обмен с первой
                    {
                        sort = j;
                    }
                }
                sort_2 = numbers[i];        // сортирует 
                numbers[i] = numbers[sort];
                numbers[sort] = sort_2;
            }
            stopWatch.Stop();
        }
        public Sort3()
        {
            Vibor(numbers);
            Console.WriteLine("Сортировка выбором: ");
            Itog_StopWatch(numbers);
        }
    }

    public class Sort4 : Program_2
    {
        public void Shell(int[] numbers)
        {
            stopWatch.Start();
            int shell = numbers.Length / 2;
            while (shell > 0)
            {
                for (int i = 0; i < (numbers.Length - shell); i++)
                {
                    while ((sort >= 0) && (numbers[sort] > numbers[sort + shell]))
                    {
                        int t = numbers[sort];
                        numbers[sort] = numbers[sort + shell];  // сравнивает и сортируем между собой и затем она та
                        numbers[sort + shell] = t;
                        sort -= shell;
                    }
                }
                shell = shell / 2;
            }
            stopWatch.Stop();
        }
        public Sort4()
        {
            Shell(numbers);
            Console.WriteLine("Сортировка Шелла: ");
            Itog_StopWatch(numbers);
        }
    }
    public class Sort5 : Program_2
    {
        public void Rast(int[] numbers)
        {
            stopWatch.Start();
            double ras = numbers.Length;
            bool rasch = true;
            while (ras > 1 || rasch)
            {
                ras /= 1.247330950103979;
                if (ras < 1) { ras = 1; }           
                rasch = false;
                while (sort + ras < numbers.Length)
                {
                    int igap = sort + (int)ras;
                    if (numbers[sort] > numbers[igap])
                    {
                        int swap = numbers[sort];
                        numbers[sort] = numbers[igap];
                        numbers[igap] = swap;
                        rasch = true;
                    }
                    sort++;
                }
            }
            stopWatch.Stop();
        }
        public Sort5()
        {
            Rast(numbers);
            Console.WriteLine("Сортировка расчесткой: ");
            Itog_StopWatch(numbers);
        }

    }
    
}
