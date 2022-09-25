using System;
using System.Reflection.PortableExecutable;
using Inheritance_Exercise_01;

namespace Inheritance_Exercise_01_Answers
{
    class Program
    {
        #region DO THESE FIRST!!!


       

     

        #endregion

        static void Main(string[] args)
        {
            #region DO THESE SECOND!!!

            // TODO: Create an instance of the Character class
            // TODO: Create an instance of your MainCharacter class
            // TODO: Create an instance of your EnemyCharacter class

            var character = new Character();
            var mainCharacter = new MainCharacter();
            var enemy = new EnemyCharacter();
            // TODO: Call all the methods for the main character and enemy character
            // TODO: Seperate them with the AddSpaces(int numberOfSpaces) function
            mainCharacter.Attack();
            mainCharacter.Defense();
            AddSpaces(1);
            enemy.Attack();
            enemy.Defense();


           


            // TODO: Try calling the methods for the character class
            character.Attack1();
            character.Defense1();

            // Thought Experiment: Why can't you call the methods for the charcter class?
            // Answer here: Character class has protected fields which cant be called outside the base class

            #endregion
        }
        public static void AddSpaces(int numberOfSpaces)
        {
            while (numberOfSpaces != 0)
            {
                Console.WriteLine();
                numberOfSpaces--;
            }
        }
    }
}
