using System;
using System.Collections.Generic;
using System.Text;

// TODO: Create a base class called Character

// TODO: Give the Character class properties (be creative)
// TODO: Give the Character class basic attack and defend methods
// TODO: Make all the members of the base class Protected
namespace Inheritance_Exercise_01
{
    public class Character
    {
        protected int Health { get; set; }

        protected int Mana { get; set; }
        protected int Attack { get; set; }
        protected int Defense { get; set; }
        protected int Magic { get; set; }
        protected int Dexterity { get; set; }
        protected int Intelligence { get; set; }
        protected int Strength { get; set; }

        protected void Attack1()
        {
            Console.WriteLine("Generic Attack!");
        }

        protected void Defense1()
        {
            Console.WriteLine("Generic Defense.");
        }

    }
    
}
