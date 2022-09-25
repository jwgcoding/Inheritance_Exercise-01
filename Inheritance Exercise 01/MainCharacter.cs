using System;
using System.Collections.Generic;
using System.Text;
// TODO: Create a child class called MainCharacter that inherits from the base class
// TODO: Give the MainCharacter class methods and properties (be creative)
// TODO: Make all members public
namespace Inheritance_Exercise_01
{
    public class MainCharacter : Character  
    {
       public int Holy { get; set; }
      
        public new void Attack()
        {
            Console.WriteLine("Dragon Blade Activate!!!! Slash of the Dragon God");
        }

        public new void Defense()
        {
            Console.WriteLine("Armor the Turtle! Activate!!!!");
        }
    }
}
