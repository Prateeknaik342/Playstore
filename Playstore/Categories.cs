﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Playstore
{
    internal class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Constructor
        //Class name and method name schould be same
        //it will trigger automatically when object created

        public Categories() {
            Console.WriteLine("This is default");
            Console.WriteLine(this.Id);
        }

        public Categories(int id, string name, string description) 
        {
            Id = id;
            Name = name;
            Description = description;

        }

        public void AddCategory(int id, string name) 
        {
            Console.WriteLine(this.Id);

            Console.WriteLine("Category details:" + id + "," + name);
        }
        public void AddCategory(int id, string name, string description)
        {
            Console.WriteLine("Category details:" + id + "," + name + "," + description);
        }
    }
}
