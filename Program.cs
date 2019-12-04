using System;

namespace Excersice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aux = new int[5];
            aux = getNumbers();
            sort(aux);
        }

        public static int[] getNumbers()
        {
            int[] numbers = new int[5];
            string aux;
            int number;
            int i = 0;
            int v;
            Console.WriteLine("Please, enter five different numbers.");
            do 
            {
                v = i +1;
                Console.Write("Enter the value of number " + v + ": ");
                aux = Console.ReadLine();
                number = int.Parse(aux);
                if(i == 0)
                {
                    numbers[i] = number;
                }
                for(int j = 0; j < i; j++)
                {
                    if(number != numbers[j])
                    {
                        numbers[i] = number;
                    }
                    else
                    if( number == numbers[j])
                    {
                        Console.WriteLine("Error. Try with a different number.");
                        i--;
                    }
                }
                i++;
            }while(i < 5);
            return numbers;
        }

        public static void sort(int[] array)
        {
            int aux;
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length - 1 ;j++)
                {
                    if(array[j] > array[j+1])
                    {
                        aux = array[j+1];
                        array[j+1] = array[j];
                        array[j] = aux;
                    }
                }
            }
            Console.WriteLine("Sort: ");
            for(int a = 0; a < 5; a++)
            {
                Console.WriteLine(array[a]);
            } 
        }
    }
}
