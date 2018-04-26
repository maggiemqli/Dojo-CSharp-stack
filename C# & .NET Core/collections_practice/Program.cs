using System;
using System.Collections.Generic;

namespace collections_practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
        //Three Basic Arrays
            //Create an array to hold integer values 0 through 9
            int[] numArray = new int[10]{0,1,2,3,4,5,6,7,8,9};
            //Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] stringArray = new string[]{"Tim", "Martin", "Nikki", "Sara"};
            //Create an array of length 10 that alternates between true and false values, starting with true
            bool[] boolArray = new bool[10]{true,false,true,false,true,false,true,false,true,false};
        //Answer Sheet :
            //for(int i = 0; i < 10; i += 2){
            //    boolArray[i] = true;
            //}

        //Multiplication Table
            //Create the table :
            int[,] array2DTable = new int[10,10];
            for(int i = 0; i < 10; i++){
                for(int y = 0; y < 10; y++){
                    array2DTable[i,y] = (i +1)*(y + 1);
                }
            }
        
            //Display the table :
            for(int i = 0; i < 10; i++){
                string display = "[";
                for(int y = 0; y < 10; y++){
                    display += array2DTable[i,y] + ",";
                    if(array2DTable[i,y] < 10 ){
                        display += "";
                    }
                }
                display += "]";
                Console.WriteLine(display);
            }

            //List of Flavors
            List<string> flavors = new List<string>();
            flavors.Add("vanilla");
            flavors.Add("chocolate");
            flavors.Add("Strawberry/Mango/Banana");
            flavors.Add("Boba Milk Tea");
            flavors.Add("coffee");
            flavors.Add("mocha");
            Console.WriteLine(flavors);
            Console.WriteLine(flavors.Count);
            Console.WriteLine("The 3rd flavor is " + flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);
    
            //User Info Dictionary
            Dictionary<string,string> usersInfo = new Dictionary<string,string>();
            Random rand = new Random();
            foreach (var name in stringArray)
            {
                usersInfo[name] = flavors[rand.Next(flavors.Count)];
            }

            Console.WriteLine("User and their choice of ice cream flavor:");
            foreach(var info in usersInfo){
                Console.WriteLine(info.Key + " - " + info.Value);
            }
        }
    }
}

