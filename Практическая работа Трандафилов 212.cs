using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[6];
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.Write($"array[{i}]=");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine($"array[{i}]={array[i]}");
            //}
            //Console.Read();
            //Console.Write("n=");
            //byte n = byte.Parse(Console.ReadLine());
            //double[] array = new double[n];
            //Random rnd = new Random();
            //for (int i=0; i<array.Length; i++)
            //{
            //    array[i] = -50 + (50 - (-50)) * rnd.NextDouble();
            //    Console.WriteLine($"array[{i}]={array[i]}");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"array[0]={array[0]}\t array[{n-1}]={array[n-1]}");
            //Console.Read();
            //int[] array = { 37, 0, 50, 46, 34, 46, 0, 13 };
            //foreach(int element in array)
            //{
            //Console.Write($"{element}\n");
            //}
            //Console.Read();

            //Заполнить одномерный массив с клавиатуры шестью целыми числами. Вывести одномерный массив в обратном порядке.
            //int[] array = new int[6];
            //for(int i=0;i<6;i++) //последовательное
            //{
            //    Console.WriteLine($"array[{i}]=");
            //    array[i] = int.Parse(Console.ReadLine()); 
            //}
            //for(int i = array.Length - 1;i>=0;i--) //обратное
            //{
            //    Console.WriteLine($"array[{i}]={array[i]}"); 
            //}
            //Console.ReadLine();

            //В массиве хранятся сведения о количестве осадков, выпавших за каждый день января (использовать заполнение случайным образом целыми числами в диапазоне от 5 до 60 мм). Определить общее количество осадков за январь.
            int[]array=new int[31]
                Random.random = new Random(); 
            for(int i=0;i<array.Length;i++)
            {
                array[i] = random.Next(5, 60);
                Console.WriteLine($"array[{ i}])={array[i]}");
            }
            int summ=0
                for(int i=0;i<array.Length;i++)
            {
                summ += array[i];
            }
            Console.WriteLine($"Общее кол-во осадков={summ}");
        }
        
        int[]array=new int[20]
            Random.random=new Random();
        for(int i=0;i<array.Lenght;i++)
    }
}
