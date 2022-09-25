using System;
using System.Collections.Generic;
using System.Text;
// TODO: Create another child class called EnemyCharacter that inherits from the base class
// TODO: Give the EnemyCharacter class methods and properties (be creative)
// TODO: Make all members public
namespace Inheritance_Exercise_01
{
    public class EnemyCharacter : Character
    {

        public int Shield { get; set; }
        public int Darkness { get; set; }
        public new void Attack()
        {
            Console.WriteLine("Take this. Destruction BLAST");

        }
        public new void Defense()
        {
            Console.WriteLine("You think this will hurt me, Shield of Darkness!");
        }
    }
}
