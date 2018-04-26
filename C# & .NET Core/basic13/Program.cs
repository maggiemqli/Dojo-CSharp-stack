using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            basic13.Print1To255();
            basic13.PrintOdd();
            basic13.PrintSum();
            basic13.IterateThruArray(1,3,5,7,9,13);
            basic13.FindMax(1,3,5,7,9,13);
            basic13.GetAverage(2,10,3);
            basic13.GetOddNum();
            basic13.GreaterThanY(3, 1,3,5,7);
            basic13.SquareValue(1,5,10,-2);
            basic13.NoNegative(1,5,10,-2);
            basic13.MinMaxAverage(1,5,10,-2);
            basic13.ShiftValue1(1,5,10,7,-2);
            basic13.ShiftValue2(1,5,10,7,-2);
            List<int> y = new List<int>{1,5,10,7,-2};
            basic13.ShiftValue3(y);
            basic13.NumToString(1,5,10,7,-2);
        }
    }
}
