using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Title = "Начальные индексы всех непрерывных последовательностей чисел";
            int[] Arr = new int[100]; // массив размером 100 элементов
            Random rand = new Random(); 
              for ( i=0;i<100;++i)
                Arr[i] = rand.Next(-50, 50);
            Console.Write("Исходный массив:\n");
            for (i = 0; i < 100; ++i)
                
                Console.Write("{0} ", Arr[i]);
            Console.Write("\nНачальные индексы всех непрерывных последовательностей чисел\n");
            for (i=0;i<100-1;i++) 
                if (i==0)
                {
                    if (Arr[i + 1] >= Arr[i])
                        Console.Write("{0} ", i);
                }
            else
                    if (Arr[i]<Arr[i-1]&&Arr[i]<=Arr[i+1])
                    Console.Write("{0} ", i);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
