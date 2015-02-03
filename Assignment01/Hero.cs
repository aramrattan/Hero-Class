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

        //*****************************************Public Properties***********************************************************
        public string name;

        //*****************************************Constructor Method**********************************************************
        public Hero(string name)
        {
            this.name = name;
            generateAbilities();
        }
    }
}
