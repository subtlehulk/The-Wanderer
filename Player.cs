using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace The_Wanderer
{
        //Base Stats
        public class Player
        {
            public string name;
            public string playerClass;
            public int userMagic;
            public int userHP;
            public int hitPoints;
            public int heal;
            public double progress;

             //creating a new player
        public static Player CreatePlayer()
        {
            Console.WriteLine("Which Clan-sister would you like to be?");
            Thread.Sleep(1000);
            Console.WriteLine("1. Ryuko - the strong warrior Sister.");
            Thread.Sleep(1000);
            Console.WriteLine("2. Yoko - the druid Sister.");
            Thread.Sleep(1000);
            Console.WriteLine("3. Atsuke - the High Priest Sister.");
            
            Player user = new Player();

            string userInputClass = Console.ReadLine();
            if (userInputClass == "1")
            {
                user = CreatePlayer(user, 1);
            }           
            else if (userInputClass == "2")
            {
                user = CreatePlayer(user, 2);
            }
            else
            {
                user = CreatePlayer(user, 3);
            }


            return user;
        }
        public static Player CreatePlayer(Player _user, int userClass)
        {
            if (userClass == 1)
            {
                
                _user.playerClass = "Knight";
                _user.name = "Ryuko";
                _user.userHP = 150;
                _user.hitPoints = 25;
                _user.userMagic = 5;
                _user.heal = 20;
                return _user;
            }
            else if (userClass == 2)
            {
                _user.name = "Yoko";
                _user.playerClass = "Druid";
                _user.userHP = 140;
                _user.hitPoints = 20;
                _user.userMagic = 15;
                _user.heal = 30;
                return _user;
            }
            else if (userClass == 3)
            {
                _user.name = "Atsuke";
                _user.playerClass = "Priest";
                _user.userHP = 70;
                _user.hitPoints = 10;
                _user.userMagic = 35;
                _user.heal = 50;
                return _user;
            }
            else {
                return null;
            }
        }
        public static void PrintPlayerStats(Player user)
        {
            Console.WriteLine("Your name is: " + user.name + ".");
            Thread.Sleep(100);
            Console.WriteLine("You are a " + user.playerClass + ".");
            Thread.Sleep(1000);
            Console.WriteLine("Your current stats are:\n");
            Thread.Sleep(100);
            Console.WriteLine("Your Melee attack damage range is between 1 and " + user.hitPoints + " points.");
            Thread.Sleep(100);
            Console.WriteLine("Your Magic attack damage range is between 1 and " + user.userMagic + " points.");
            Thread.Sleep(100);
            Console.WriteLine("Your Heal range is between 1 and " + user.heal + "points.");
        }
    }
}