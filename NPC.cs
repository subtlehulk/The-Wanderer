using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace The_Wanderer
{
    public class NPC
        {
            public string name;
            public int npcHealth = 100;
            public  int npcHitPoints = 0;
            public  int npcHitChance = 0;

             public static NPC CreateEnemy(string _name)
        {
            NPC newEnemy = new NPC();
            Random stats = new Random();
            newEnemy.npcHealth = stats.Next(90, 151);
            newEnemy.npcHitPoints = stats.Next(15, 51);
            newEnemy.name = _name;
            return newEnemy;
        }

        }
}