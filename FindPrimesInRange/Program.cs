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
            
            Console.WriteLine(FindPrimesInRange(2, 100));
        }
        public static IEnumerable<int> FindPrimesInRange(int a, int b){

            List<int> data = new List<int>();

        for (int i = 2; i < b; i++)
            {
                if(IsPrime(i)){
                    
                    data.Add(i);
                }
            }      
            return data;
        }
        public static bool IsPrime(int a){
            
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
            }
    }
}
