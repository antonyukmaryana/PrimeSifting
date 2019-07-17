using System;
using System.Collections.Generic;
namespace PrimeSifting {
    public class Program {
        public static void Main () {
            Console.WriteLine ("Enter your number:");
            int userInput = Int32.Parse (Console.ReadLine ());

            List<int> PrimeNumbers = new List<int> ();
            for (int i = 2; i < userInput; i++) {
                //PrimeNumbers.Add (i);
                if (IsPrime (i)) {
                    PrimeNumbers.Add (i);
                }
            }
            bool IsPrime (int num) {
                for(int i = 2; i < num; i++){
                    if (num % i == 0){
                        return false;
                    }
                }
                return true;
            }
            
            Console.WriteLine(string.Join(",", PrimeNumbers));
        }

    }
}