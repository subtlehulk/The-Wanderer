using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace The_Wanderer
{
     public class Item
        {
            //this is how much damage it will deal to the NPC
            public int damagePoints;
            //How much the user will be healed by
            public int healPoints;
            //How much a player's attack will be boosted by until the end of the fight.
            public int damageBoost;
            public bool used;

            public static Item CreateItem(string _playerClass)
            {
                Random _potionGen = new Random();
                Item potion = new Item();

                if(_playerClass == "Knight" || _playerClass == "knight")
                {
                    potion.damageBoost = _potionGen.Next(5, 15);
        
                }
                else if (_playerClass == "Druid" || _playerClass == "druid")
                {
                    potion.healPoints = _potionGen.Next(25,41);

                }
                else 
                {
                    potion.damagePoints = _potionGen.Next(60, 151);
                
                }
                return potion;
            }
            public static Item FindItem(Item p)
            {
                if (p.used == true)
                {
                    var rng = new Random();
                    int itemFound = Convert.ToInt32(rng.Next(1, 51));
                        if (itemFound >= 25)
                        {
                            Console.WriteLine("You found a potion! It has been added to your inventory.");
                            p.used = false;
                        }
                        else {
                            p.used = true;
                        }
                    
                }
                return p;
            }
        }
}
