using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstore
{
    public class User:IUser
    {
        //properties
        public string Id { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Mobile { get; set; }
        private int UserKey { get; set; }

        public void AddUser()
        {
            
        }

        //Functions
        //syntax: public return/no-return-type MethodName(){}

        public void CreateUser()
        {
            //Console.WriteLine("User Registeration");
            // Read input from Keyboard
            //Console.Write("Enter Name");
            //Name = Console.ReadLine();
            
            //Console.WriteLine("Enter Mobile Number");
            //Mobile = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Welcome," + Name + " Thanks for choosing the training " + "Your Mobile Number: " + Mobile);
            Categories categories = new Categories(4, "Charana", "My name");
            


            categories.AddCategory(1, "ABC");
            categories.AddCategory(1,"PSN","Name");



        }

        public void DeleteUser()
        {
           

        }

        public void GetUser()
        {
            
        }

        public void UpdateUser()
        {
            
        }
    }
}
