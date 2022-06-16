using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public abstract class Program_2_2
    {
        protected abstract void Vvod();
        protected abstract void Print();
        public abstract void UP(Dictionary<int, char> dict);
        public abstract void DOWN(Dictionary<int, char> dict);
        public abstract void Kolvo();
    }

    public class Program_2_2_1 : Program_2_2
    {
        public string text, Zam, NaZam;  
        public int tmp_value, menu, tmp_key;

        public List<char> list;  // лист для исходного текста
        public Dictionary<int, char> dict;  // бтблиотека для id и сам символ
        public Dictionary<char, int> dic;

        protected override void Vvod()
        {
            Console.Write("Ведите текст: ");
            text = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            list = new List<char>();
            dict = new Dictionary<int, char>();

            foreach (char c in text)
            {
                list.Add(c); // добавляет текст в лист
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (dict.ContainsValue(list[i]) == true) // смотри похожие
                {
                    tmp_value++; // будет прибавлять значение на единицу
                }
                else
                {
                    dict.TryAdd(tmp_key, list[tmp_value]); // добавляет элемент в библиотеку
                    tmp_key++;      //увиличение ключа 
                    tmp_value++;    //увеличение значения
                }
            }
        }
 
        protected override void Print()
        {
            Console.WriteLine("Оригинал текста: " + text);
            Console.WriteLine("_____________________________________________");
            Console.WriteLine("Введите нужное действие");
            Console.WriteLine("1. Замена символов.");
            Console.WriteLine("2. Количество символов.");
            Console.WriteLine("3. Сортировка по возвростанию.");
            Console.WriteLine("4. Сортировка по убыванию.");
            menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1)
            {
                Zamena();
            }
            else if (menu == 2)
            {
                Kolvo();
            }
            else if (menu == 3)
            {
                UP(dict);
            }
            else if (menu == 4)
            {
                DOWN(dict);
            }
            else
            {
                Console.WriteLine("Не правильно выбран пункт!");
            }
        }

        public void Zamena()
        {
            Console.WriteLine("Исходный текст: " + text);

            Console.Write("Букву которую хотите заменить: ");
            Zam = Console.ReadLine();

            Console.Write("На какую хотите заменить: ");
            NaZam = Console.ReadLine();

            Console.WriteLine("_____________________________________________");
            Console.WriteLine();
            Console.WriteLine("Исходный текст: " + text);
            Console.WriteLine($"После замены \"{Zam}\" на \"{NaZam}\" : {text.Replace(Zam, NaZam)}"); // выводит замененый текст
            Console.WriteLine($"Текст с изменеными символами: {text.Replace(Zam, NaZam)}. Оригинальный текст: {text}");


            Console.WriteLine("_____________________________________________");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();

        }

        public override void Kolvo()
        {
            dic = new Dictionary<char, int>();
            foreach (char ch in text)
            {
                if (dic.ContainsKey(ch))// проверяет наличие по ключю 
                {
                    dic[ch]++; // засовывает в новую библиотеку 
                }
                else
                {
                    dic.Add(ch, 1);
                }
            }
            foreach (var i in dic)
            {
                Console.WriteLine($"{i.Key} -- {i.Value}"); // количество каждого символа
            }
        }

        public override void UP(Dictionary<int, char> dict)
        {
            foreach (var i in dict.OrderBy(x => x.Key))  // сортирует по возвростанию 
            {
                Console.WriteLine(i); // вывод
            }
            Console.ReadLine();
            Console.Clear();
        }

        public override void DOWN(Dictionary<int, char> dict)
        {
            foreach (var i in dict.OrderByDescending(x => x.Key)) // сортирует по убыванию
            {
                Console.WriteLine(i);  // вывод
            }
            Console.ReadLine();
            Console.Clear();
        }

        public Program_2_2_1()
        {
            Vvod();
            Print();
        }
    }
  
}
