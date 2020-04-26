using System;

namespace KEAOpgave5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            bool prime; // a bool is a variable that is either true or false
            int n = 0; // We use the n to count the amount of run throughs of the loops
            int x = 100000; //  b: 25000 & d: 100000
            Console.WriteLine($"Amount of numbers we wanna go through and check if they are prime, is {x}!");
            Console.ReadLine();
            Console.Clear();

            for (int i = 2; i < x; i++) //  b: 250000 & d: 100000
            {
                prime = true; // we assume the number is a prime until its not

                for (int j = 2; j < i; j++)
                {
                    n++; // n = n + n
                    if (i % j == 0) // if the division between i and j leaves nothing, then we know i is not a primenumber
                    {
                        prime = false; // setting prime to false if above if is true

                        // c: without this break, we would run through all of the numbers in the second loop,
                        //    even though we might already know that i is not a primenumber, 
                        //    since were checking with modulus, thus making the program run much lighter.
                        break; 
                    }
                }
                if (prime) // if prime == true
                {
                    Console.WriteLine(i + " This is a prime number!");
                }
            }
            Console.WriteLine($"\n\nNumber of times we ran through the loops: {n} with {x} as max");
            Console.ReadLine();
        }
    }
}
