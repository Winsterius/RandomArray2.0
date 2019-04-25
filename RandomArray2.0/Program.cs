using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomArray
{
    class Program
    {

        static Random random;
        static int maxValue;
        static int minValue;
        static int numOfElements;
        int[] numbers;

        static void Main(string[] args)
        {

            Program p = new Program();

            numOfElements = p.ReadArrayDates("Geben Sie die Länge des Arrays ein");
            minValue = p.ReadArrayDates("Geben Sie minimale Zahl ein");
            maxValue = p.ReadArrayDates("Geben Sie maximale Zahl ein");

            p.FillArrayWithDifferentNumbers(p.numbers, numOfElements, minValue, maxValue);
            p.PrintArray(p.numbers);
            Console.WriteLine("\n");            
            p.PrintFrequencyArray(p.GetFrequencyArray(p.numbers));
            Console.ReadKey();
        }


        int ReadArrayDates(string str)
        {
            int output;
            Console.WriteLine(str);
            while (!int.TryParse(Console.ReadLine(), out  output)) Console.WriteLine("Falsche Eingabe");
            return output;
        }
        void FillArrayWithDifferentNumbers(int[] numbers, int numOfElements, int minValue, int maxValue)
        {
            random = new Random();
            numbers = new int[numOfElements];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue +1);
            }
            this.numbers = numbers;
        }
        int Summe(int[] numbers)
        {
            int summe = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                summe += numbers[i];
            }
            return summe;
        }
        double Average(int[] numbers)
        {
            int summe = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                summe += numbers[i];
            }
            return (double)summe / numbers.Length;
        }
        int[] GetFrequencyArray(int[] numbers)
        {
            int[] frequency = new int[maxValue + 1];

            for (int i = 0; i <= maxValue; i++)
            {
                int count = 0;
                foreach (int num in numbers)  if (num == i) count++;                
                if(count != 0) frequency[i] = count;
            }
            return frequency;
        }
        void PrintFrequencyArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (!arr[i].Equals(0)) Console.WriteLine("Zahl {0,2}  ---  {1,2}", i, arr[i]);                
            }            
        }
        void PrintArray(int[] arr)
        {
            foreach (int i in arr) Console.Write(i + " ");
        }
    }
}
