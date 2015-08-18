using System;

namespace Test
{
    class Program
    {
        public static void Main()
        {
            var asa = new int[] { 5,2,1,3,9,0,4,6,8,7 };
            wekernsort(asa);
            for (int g = 0; g < asa.Length; g++)
            {
                Console.Write(asa[g]+" " );
            }
            Console.ReadLine();

        }
        public static void  bublesort(int [] array)
        {
            for (var i=0;i<array.Length;i++)
            {
                for (var j = 0; j < array.Length-1-i; j++)
                {
                    if(array[j]>array[j+1])
                    {
                        var temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }                     
                }
            }          
        }

        public static void wekernsort(int [] array)
        {
            for (var i = 0; i < array.Length/2; i++)
            {
                for (var j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                for (var g=array.Length-1;g>1;g--)
                {
                    if(array[g]<array[g-1])
                    {
                        var temp = array[g];
                        array[g] = array[g-1];
                        array[g-1] = temp;
                    }
                }
            }           
        }
        
    }
}
