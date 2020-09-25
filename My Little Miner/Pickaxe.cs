using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Little_Miner
{


        //types of pickaxes
        public enum PickaxeType
        {
            Wood,
            Stone,
            Iron,
            Gold,
            Diamond,
            Obsidian
        }

    class Pickaxe
    {
        private PickaxeType playerPickaxe;

        public PickaxeType PlayerPickaxe
        {
            get { return playerPickaxe; }
            set { playerPickaxe = value; }
        }

        private float pickaxeDamamge;
        public float PixaceDamage
        {
            get { return pickaxeDamamge; }
            set { pickaxeDamamge = value; }
        }

        private float lifeTime;
        public float LifeTime
        {
            get { return lifeTime; }
            set { lifeTime = value; }
        }
        private PickaxeType types;
        public PickaxeType Types
        {
            get { return types; }
            set { types = value; }
        }

        public void PickaxeDamage()
        {
           
        }

        public Pickaxe()
        {
            types = PickaxeType.Wood;
            types = PickaxeType.Stone;
        }
    }
}
