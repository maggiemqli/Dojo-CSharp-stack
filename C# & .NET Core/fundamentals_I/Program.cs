using System;

namespace fundamentals_I
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        // Create a Loop that prints all values from 1-255
            for(int i = 1; i <= 255; i++){
                Console.WriteLine(i);
            }
            //Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            for(int y = 1; y <= 100; y++){
                if(y%15 != 0){
                    if(y%3 == 0 || y%5 == 0){
                        Console.WriteLine(y);
                    }
                }
            }
        //Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            for(int x = 1; x <= 100; x++){
                if (x%3 == 0 && x%5 == 0){
                    Console.WriteLine("FizzBuzz");
                }
                else if (x%3 == 0){
                    Console.WriteLine("Fizz");
                }
                else if (x%5 == 0){
                    Console.WriteLine("Buzz");
                }
            }

    // Referred to the Answer sheet :
        //Optional FizzBuzz without Mod
            int three = 3;
            int five = 5;
            for (int num = 1; num < 101; num++)
            {
                three--;
                five--;
                if (three == 0 && five == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    three = 3;
                    five = 5;
                }
                else if (three == 0)
                {
                    Console.WriteLine("Fizz");
                    three = 3;
                }
                else if (five == 0) {
                    Console.WriteLine("Buzz");
                    five = 5;
                }
            }
        //Optional Generate 10 random values 1-100 and output Fizz or Buzz
            Random rand = new Random();
            for (int num = 0; num <= 10; num++){
                int val = rand.Next(1, 100);

                string output = "For attempt " + num + " the value is " + val + " and the word is ";

                if(val % 3 == 0 && val % 5 == 0)
                {
                    output += "FizzBuzz";
                }
                else if (val % 3 == 0)
                {
                    output += "Fizz";
                }
                else if (val % 5 == 0)
                {
                output += "Buzz";
                } else {
                    output += "Neither";
                }

                Console.WriteLine(output);
            }
        }
    }
}



