using System;
using System.Collections.Generic;

namespace OptimusPrime {
    class Program {
        static void Main(string[] args) {
            foreach (int val in Primality()) {
                Console.WriteLine(val);
            };
        }

        static List<int> Primality() {
            //Ten minute solution to primality (less than 1000)
            List<int> primes = new List<int>();
            List<int> noprimes = new List<int>();

            for (int i = 1; i < 1000; i++) {
                bool divisible = false;
                foreach (int ele in primes) {
                    if (i % ele == 0 && ele != 1) {
                        divisible = true;
                    }
                }
                if (divisible == false) {
                    primes.Add(i);
                }
            }

            return primes;
        }
    }
}
