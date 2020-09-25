using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Little_Miner
{
    class Backpack
    {
        private List<Mineral> minerals;

        public List<Mineral> Minerals
        {
            get { return minerals; }
            set { minerals = value; }
        }

        private List<Pickaxe> pickaxes;
        public List<Pickaxe> Pickaxes
        {
            get { return pickaxes; }
            set { pickaxes = value; }
        }

        private List<Money> money;
        public List<Money> Money
        {
            get { return money; }
            set { money = value; }
        }

        private List<Food> food;
        public List<Food> Food
        {
            get { return food; }
            set { food = value; }
        }

            

    }
}
