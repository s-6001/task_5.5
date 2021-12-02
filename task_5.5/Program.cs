using System;

namespace task_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите целое N>=0:");
                Console.Write("N=");
                uint n = 0; //размер квадратного массива
                try
                {
                    n = Convert.ToUInt32(Console.ReadLine());    //пытаемся считать размер квадратного массива
                }
                catch
                {
                    Console.WriteLine("Не удалось прочитать число или число дробное/отрицательное.");   //В случае если не удалось считать размер массива
                }
                byte[,] array = new byte[n,n];  //создаем массив со стороной n
                for (int j = 0; j < n; j++)  //присваиваем 0 или 1
                {
                    for (int i = 0; i < n; i++)
                    {
                        if ((i+j) % 2 == 0)
                        {
                            array[i,j]= 1;
                        }
                        Console.Write("{0} ", array[i, j]); //выводим значения в строку
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
        }
    }
}