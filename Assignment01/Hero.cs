using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Hero
    {
        //******************************************Private Properties*********************************************************
        private int strength;
        private int speed;
        private int health;
        private Random rnd = new Random();//made an instance so that it can just be called when needed instead of making new one each time
 

        //*****************************************Public Properties***********************************************************
        public string name;

        //*****************************************Constructor Method**********************************************************
        public Hero(string name)
        {
            this.name = name;
            generateAbilities();
        }

        //******************************************Private Methods*************************************************************************

        //Generate ability method
        private void generateAbilities()
        {
            //Calling rnd instance so we can assign values to strength, speed and health

            this.strength = this.rnd.Next(1, 101);
            this.speed = this.rnd.Next(1, 101);
            this.health = this.rnd.Next(1, 101);
        }

        //method to show if hit was successful
        private bool hitAttempt()
        {

            bool hit = false;
            int attemptRate = this.rnd.Next(1, 101);
            //hit attempt will only be successful 20% of the time

            if (attemptRate % 5 == 0)
            {
                hit = true;
            }
            // default will be false
            return hit;
        }

        //This method will calculate how much damage a hit has caused
        private int hitDamage()
        {
            //totDamage = total damage 
            int totDamage;
            int ranNum;
            ranNum = this.rnd.Next(7, 13) - 6;
            //used as a check to see if rnd is working
            //Console.WriteLine(ranNum);
            //damage = strength times a random number between 1 and 6
            totDamage = this.strength * ranNum;

            return totDamage;
        }

        //******************************************Public Methods*************************************************************************

        //This method will call hitAttempt and determine if there was a hit and if there was, how much damage was dealt, by calling hitDamage
        public void fight()
        {
            //hit calling hitAttempt method and will be assigned the returned value
            bool hit = hitAttempt();
            int damage = 0;
            if (hit == true)
            {
                damage = hitDamage(); // damage calling hitDamage method and will be assigned the returned value
                Console.WriteLine("Hit was successful. Damage Dealt: {0}", damage);
                damage = 0;
            }
            else
            {
                Console.WriteLine("Hit was not successful. No damage dealt.");
            }

        }

        //This method will display hero's abilities
        public void show()
        {
            Console.WriteLine("These are Hero {0}'s abilities: ", this.name);
            Console.WriteLine("Strength: {0}", this.strength);
            Console.WriteLine("Speed: {0}", this.speed);
            Console.WriteLine("Health: {0}", this.health);

        }
    }

}
