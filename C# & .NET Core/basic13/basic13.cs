using System;
using System.Collections.Generic;

namespace basic13
{
    class basic13
    {
        // Print 1-255
        public static void Print1To255(){
            for(int i = 1; i < 256; i++){
                Console.WriteLine(i);
            }
        }

        // Print odd numbers between 1-255
        public static void PrintOdd(){
            for(int i = 1; i < 256; i+=2){
                Console.WriteLine(i);
            }
        }

        // Print Sum
        public static void PrintSum(){
            int sum = 0;
            for(int i = 0; i < 256; i++){
                sum += i;
                Console.WriteLine("New number: {0} Sum: {1}", i , sum);
            }
        }

        // Iterating through an Array
        public static void IterateThruArray(params int[] x)
        {
            foreach(var num in x){
                Console.WriteLine(num);
            }
        }

        // Find Max
        public static void FindMax(params int[] x){
            int max = x[0];
            foreach(var num in x){
                if(num > x[0]){
                    max = num;
                }
            }
            Console.WriteLine("The maximum number is " + max + ".");
        }

        // Get Average
        public static void GetAverage(params int[] x){
            int sum = 0;
            int index = 0;
            foreach(var num in x){
                sum += num;
                index ++;
            }
            int average = sum / index;
            Console.WriteLine("The average is " + average + ".");
        }

        // Array with Odd Numbers
        public static void GetOddNum(){
            List<int> y = new List<int>();
            for(int i = 1; i < 256; i++){
                if(i % 2 != 0){
                    y.Add(i);
                }
            }
            foreach ( var i in y){ 
                Console.Write(i + ",");
            }
            Console.WriteLine("");
        }

        // Greater than Y
        public static void GreaterThanY(int y, params int[] x){
            int count = 0;
            foreach (var num in x){
                if (num > y){
                    count ++;
                }
            }
            if (count == 0){
                Console.WriteLine("There's no value in the array that is greater than " + y);
            }else{
                Console.WriteLine("There is/are total {0} values in the array that is/are greater than {1}.", count, y);
            }
        }

        // Square the Values
        public static void SquareValue(params int[] x){
            for(int i = 0; i < x.Length; i++){
                x[i] = x[i] * x[i];
            }
            foreach(var num in x){
                Console.Write(num + ", ");
            }
            Console.WriteLine("");
        }

        // Eliminate Negative Numbers
        public static void NoNegative(params int[] x){
            for(int i = 0; i < x.Length; i++){
                if(x[i] < 0){
                    x[i] = 0;
                }
            }
            foreach(var num in x){
                Console.Write(num + ", ");
            }
            Console.WriteLine("");
        }

        // Min, Max, and Average
        public static void MinMaxAverage(params int[] x){
            FindMax(x);
            FindMin(x);
            GetAverage(x);
        }

        public static void FindMin(params int[] x){
            int min = x[0];
            foreach(var num in x){
                if(num < x[0]){
                    min = num;
                }
            }
            Console.WriteLine("The minmum number is " + min + ".");
        }            

        //Shifting the values in an array
          // Way 1:
        public static void ShiftValue1(int[] x){
            int[] temp = new int[x.Length];
            for(int i = 0; i < x.Length; i++){
                if(i < x.Length - 1){
                    temp[i] = x[i + 1];
                }else{
                    temp[i] = 0;
                }
            }
            foreach(var num in temp){
                Console.Write(num + ", ");
            }
            Console.WriteLine("");
        }
          // Way 2:
        public static void ShiftValue2(params int[] x){
            for(int i = 0; i < x.Length - 1; i ++){
                x[i] = x[i+1];
            }
            x[x.Length -1] = 0;
            foreach(var num in x){
                Console.Write(num + ", ");
            }
            Console.WriteLine("");
        }
          // Way 3:
        public static void ShiftValue3( List<int> x)
        {
            x.RemoveAt(0);
            x.Add(0);
            foreach (var num in x)
            {
                Console.Write(num + ", ");
            }
        }

        // Number to String
        public static void NumToString(params object[] x){
            for(int i = 0; i < x.Length; i++){
                if((int)x[i] < 0){
                    x[i] = "Dojo";
                }
            }
            foreach(var num in x){
                Console.Write(num + ", ");
            }
            Console.WriteLine("");
        }
    }
}