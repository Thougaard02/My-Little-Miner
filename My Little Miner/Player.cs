using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Little_Miner
{
    class Player
    {

        private string name;
        public string Name { get; set; }

        private bool isMale;
        public bool IsMale { get; set; }

        public Player(string name, bool gender)
        {
            Name = name;
            IsMale = gender;
        }

    }
}
