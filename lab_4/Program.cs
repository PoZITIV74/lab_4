using System;
using static System.Math;
using System.Collections.Generic;

namespace lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Main main = new Main();
                if (main.vvod_puncta == 1 || main.vvod_puncta == 2 || main.vvod_puncta == 3 || main.vvod_puncta == 4)
                {
                    if (main.vvod_puncta == 1)
                    {
                        Program1_5 program1_5 = new();
                       
                        Console.ReadLine();
                        Console.Clear();

                    }
                    else if (main.vvod_puncta == 2)
                    {
                        Program_2 program_2 = new();                      
                        Sort1 sort1 = new Sort1();
                        Sort2 sort2 = new Sort2();
                        Sort3 sort3 = new Sort3();
                        Sort4 sort4 = new Sort4();
                        Sort5 sort5 = new Sort5();

                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (main.vvod_puncta == 3)
                    {
                       Program_2_2_1 program_2_2_1 = new(); 
                       
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (main.vvod_puncta == 4)
                    {
                        Program_lab_2_3 program_Lab_2_3 = new();

                        

                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Не верно выбран номер задания!");
                    }
                }
            }
        }   
    }
}
