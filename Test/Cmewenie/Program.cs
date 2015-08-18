using System;

namespace Cmewenie
{
    class Program
    {
        static void Main()
        {
            ConsoleKeyInfo info;
            var arrayInt = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11,12,13,14,15 };           
            do{
                info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.LeftArrow: leftArray(arrayInt);
                        write(arrayInt);
                        break;
                    case ConsoleKey.UpArrow: UpArray(arrayInt);
                        write(arrayInt);
                        break;
                    case ConsoleKey.RightArrow: rigthArray(arrayInt);
                        write(arrayInt);
                        break;
                    case ConsoleKey.DownArrow: downArray(arrayInt);
                        write(arrayInt);
                        break;
                    case ConsoleKey.Escape: break;
                    default: Console.WriteLine("Error");
                        break;
                }
            }while (info.Key != ConsoleKey.Escape);
            Console.ReadLine();
        }
        static void UpArray(int [] arrat)
        {
           for (var i=0;i<arrat.Length;i++)
           {
               arrat[i]++;
           }
        }
        static void downArray(int[] arrat)
        {
            for (var i = 0; i < arrat.Length; i++)
            {
                arrat[i]--;
            }
        }
        static void leftArray(int[] arrat)
        {
            var temp = arrat[0];
            for (var i = 0; i < arrat.Length - 1; i++)
                arrat[i] = arrat[i + 1];
            arrat[arrat.Length - 1] = temp;
        }
       static void rigthArray(int [] arrat)
        {
            var temp = arrat[arrat.Length - 1];
            for (var i = arrat.Length-1; i >0; i--)
                arrat[i] = arrat[i-1];
           arrat[0] = temp;
        }
        static void write(int [] arrat)
       {
           for (var i = 0; i < arrat.Length; i++)
               Console.Write(arrat[i] + " ");
           Console.WriteLine();
       }

    }
}
