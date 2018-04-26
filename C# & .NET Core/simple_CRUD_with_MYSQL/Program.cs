using System;
using DbConnection;
using System.Collections;
using System.Collections.Generic;

namespace simple_CRUD_with_MYSQL
{
    class Program
    {

        public static void readCommand()
        {
            string command = "y";
            while(command == "y" || command == "c" || command == "r" || command == "u" || command == "d")
            {
                Console.WriteLine("y to Continue, c to Create, r to Read, u to Update, d to Delete, any key to Stop:");
                command = Console.ReadLine();
                if(command == "c")
                    Create();
                if(command == "r")
                    Read();
                if(command == "u")
                    Update();
                if(command == "d")
                    Delete();
            }
        }

        public static void Read(){
            List<Dictionary<string,object>> userInfo = DbConnector.Query("SELECT * FROM users");
            Console.WriteLine("Current users : ");
            foreach(var user in userInfo){
                Console.WriteLine($"{user["id"]} {user["FirstName"]} {user["LastName"]} {user["FavoriteNumber"]}");
            }
            Console.WriteLine(new string('=', 20));
        }

        public static void Create(){
            Console.WriteLine("Create a new user : ");
            Console.WriteLine("First name : ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Last name : ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Favorite Number : ");
            int favnum = Int32.Parse(Console.ReadLine());
            string createQuery = $"INSERT INTO users (FirstName, LastName, FavoriteNumber) VALUES ('{firstname}', '{lastname}', '{favnum}')";
            DbConnector.Execute(createQuery);
            Console.WriteLine("The new user's info is : {0} {1} {2}", firstname, lastname, favnum);
            Console.WriteLine(new string('=', 20));

        }

        public static void Update(){
            Console.WriteLine("Update a user's info : ");
            Console.WriteLine("Please enter the user id :");
            int id = Int32.Parse(Console.ReadLine());
            List<Dictionary<string,object>> updateQuery = DbConnector.Query($"SELECT * FROM users WHERE id = {id}");
            if(updateQuery == null){
                Console.WriteLine($"Error: id {id} does not exist.");
            }else{
                foreach(var updateuser in updateQuery){
                    Console.WriteLine($"Current user Info: {updateuser["id"]} {updateuser["FirstName"]} {updateuser["LastName"]} {updateuser["FavoriteNumber"]}");
                    Console.WriteLine("Update: ");
                    Console.WriteLine("First name : ");
                    string firstname2 = Console.ReadLine();
                    Console.WriteLine("Last name : ");
                    string lastname2 = Console.ReadLine();
                    Console.WriteLine("Favorite Number : ");
                    int favnum2 = Int32.Parse(Console.ReadLine());
                    string updateInfo = $"UPDATE users SET FirstName = '{firstname2}', LastName = '{lastname2}', FavoriteNumber = '{favnum2}' WHERE id = {id}";
                    DbConnector.Execute(updateInfo);
                    Console.WriteLine($"Updated user Info: {updateuser["id"]} {firstname2} {lastname2} {favnum2}");
                }

            }
        }

        public static void Delete(){
            Console.WriteLine("Delete a user's info : ");
            Console.WriteLine("Please enter the user id :");
            int id = Int32.Parse(Console.ReadLine());
            List<Dictionary<string,object>> deleteQuery = DbConnector.Query($"SELECT * FROM users WHERE id = {id}");
            if(deleteQuery == null){
                Console.WriteLine($"Error: id {id} does not exist.");
            }else{
                foreach(var deleteuser in deleteQuery){
                    Console.WriteLine($"The following user Info will be deleted: {deleteuser["id"]} {deleteuser["FirstName"]} {deleteuser["LastName"]} {deleteuser["FavoriteNumber"]}");
                    string deleteInfo = $"DELETE FROM users WHERE id = {id}";
                    DbConnector.Execute(deleteInfo);
                    Console.WriteLine("Succeed. User Info has been deleted.");            
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            readCommand();
            // Read();
            // Create();
            // Update();
            // Delete();

        }
    }
}
