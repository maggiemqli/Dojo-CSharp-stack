using System;
using System.Collections.Generic;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<object> objectList = new List<object>();
            objectList.Add(7);
            objectList.Add(28);
            objectList.Add(-1);
            objectList.Add(true);
            objectList.Add("chair");

            /* A better way : 
            var objectList = new List<object>
            {
                7,
                28,
                -1,
                true,
                "chair"
            };
            */

            foreach(var o in objectList){
                Console.WriteLine(o);
            }

            int sum = 0;
            foreach(var o in objectList){
                if(o is int){
                    sum += (int)o;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
