using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeFactors primeFactor=new PrimeFactors();
            primeFactor.GeneratePrimeFactors(6);
        }
    }
    
    public class PrimeFactors
    {
        public List<int> GeneratePrimeFactors(int number)
        {
            List<int> primeFactorList = new List<int>();
            List<int> AllFactors = new List<int>();

            if (isPrime(number))
            {
                primeFactorList.Add(number);
                return primeFactorList;
            }

            foreach(var factor in GetAllFactors(number))
            {
                if (isPrime(factor))
                    primeFactorList.Add(factor);
            }
            return primeFactorList;
        }
        public bool isPrime(int number)
        {
            int divisorCounter = 0;
            for(int divisor=number/2; divisor>1; divisor--)
            {
                if (number % divisor == 0)
                    divisorCounter++;
            }
            return divisorCounter==0;
        }
        public List<int> GetAllFactors (int number)
        {
            List<int> AllFactorList = new List<int>();

            for(int divisor = number/2; divisor>1; divisor--)
            {
                if (number % divisor == 0)
                    AllFactorList.Add(divisor);
            }
            return AllFactorList; ;

        }


    }
}
