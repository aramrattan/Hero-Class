﻿using System;
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
    }

}
