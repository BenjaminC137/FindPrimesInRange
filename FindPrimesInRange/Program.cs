using System;
using System.Collections.Generic;
using System.Linq;


namespace FindPrimesInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            //IEnumerable<int> answer = FindPrimesInRange(2, 100);
            foreach(var number in FindPrimesInRange(2, 100)){
                Console.WriteLine(number);
            }
        }

        public static IEnumerable<int> FindPrimesInRange(int a, int b){

            List<int> data = new List<int>();

        for (int i = a; i <= b; i++)
            {
                if(IsPrime(i)){
                    
                    data.Add(i);
                }
            }      
            return data;
        }

        public static bool IsPrime(int y){
            int i;
            for (i = 2; i <= (int)Math.Sqrt(y); i++)
            {
                if (y % i == 0)
                {
                    return false;
                }
            }
            return true;
            }
    }
}
