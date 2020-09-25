using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Little_Miner
{
    class Food
    {
        enum FoodTypes
        {
            Fish,
            Chicken,
            Steak,
            Apple,
            Bread,
            Cake,
            Carrot,
            Potato,
            Cookie,
            Melon
        }

        private int healthGeneration;
        public int HealthGeneration
        {
            get { return healthGeneration; }
            set { healthGeneration = value; }
        }
    }
}
