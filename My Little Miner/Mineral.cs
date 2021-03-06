﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace My_Little_Miner
{
    //Varieties of minerals
    public enum MineralsVariety
    {
        Cobblestone,
        CoalOre,
        IronOre,
        GoldOre,
        DiamondOre
    }
    public enum Stage
    {
        Raw,
        Refined
    }
    class Mineral
    {
        //Property
        public MineralsVariety MineralsType { get; set; }

        public Stage StageOfMineral { get; set; }

        //Constructor
        public Mineral(MineralsVariety mineral)
        {
            MineralsType = mineral;
            StageOfMineral = Stage.Raw;
        }
    }
}