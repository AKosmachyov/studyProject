using System;

namespace Matrix
{
    class Program
    {
        static int temp;
        static int temp1;
        static int stolb;
        static void Main()
        {
            var matri = new int[,]
            {
            {10,11,12,13,14,15,16},
            {29,00,00,00,00,00,17},
            {28,00,00,00,00,00,18},
            {27,00,00,00,00,00,19},
            {26,25,24,23,22,21,20},

            };
            stolb = matri.Length / matri.GetLength(1);
            ConsoleKeyInfo info;
            do
            {
                info = Console.ReadKey();
                switch(info.Key)
                {
                    case ConsoleKey.LeftArrow: Console.WriteLine();
                    change1(matri);
                     write(matri);
                    break;
                default: Console.WriteLine("Again");
                    break;
                }
            }
            while(info.Key!=ConsoleKey.Escape);
            
        }
      
        static void change1(int [,] array)
        {
            temp = array[0, array.GetLength(1) - 1];
            for (var i = array.GetLength(1)-1; i >0 ;i-- )
            {
                array[0, i] = array[0, i - 1];
            }
            temp1 = array[stolb - 1, array.GetLength(1) - 1];
            for (var j = stolb - 1; j > 1; j--)
            {
                array[j, array.GetLength(1)-1] = array[j - 1,array.GetLength(1)-1];
            }
            array[1, array.GetLength(1) - 1] = temp;
            temp = array[stolb - 1, 0];
            for (var g = 0; g < array.GetLength(1)-2;g++ )
            {
                array[stolb - 1, g] = array[stolb - 1, g + 1];
            }
            array[stolb - 1, array.GetLength(1)-2] = temp1;
            for(var f=0;f<stolb-1;f++)
            {
                array[f, 0] = array[f + 1, 0];
            }
            array[stolb - 2, 0] = temp;

        }
        static void write(int [,] array)
        {
            for (var i = 0; i < stolb; i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
