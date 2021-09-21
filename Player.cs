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

             //creating a new player
        public static Player CreatePlayer()
        {
            Console.WriteLine("What class would you like to be?");
            Thread.Sleep(1000);
            Console.WriteLine("1. Knight");
            Thread.Sleep(1000);
            Console.WriteLine("2. Druid");
            Thread.Sleep(1000);
            Console.WriteLine("3. Priest");
            
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

            Console.WriteLine($"Please enter your {user.playerClass}'s name: ");
            user.name = Console.ReadLine();

            return user;
        }
        public static Player CreatePlayer(Player _user, int userClass)
        {
            if (userClass == 1)
            {
                
                _user.playerClass = "Knight";
                _user.userHP = 150;
                _user.hitPoints = 25;
                _user.userMagic = 5;
                _user.heal = 20;
                return _user;
            }
            else if (userClass == 2)
            {
                
                _user.playerClass = "Druid";
                _user.userHP = 140;
                _user.hitPoints = 20;
                _user.userMagic = 15;
                _user.heal = 30;
                return _user;
            }
            else if (userClass == 3)
            {
                
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
            Console.WriteLine("You are a " + user.playerClass + ".");
            Thread.Sleep(1000);
            Console.WriteLine("Your current stats are:\n");
            Console.WriteLine("Your Melee attack damage range is between 1 and " + user.hitPoints + " points.");
            Console.WriteLine("Your Magic attack damage range is between 1 and " + user.userMagic + " points.");
            Console.WriteLine("Your Heal range is between 1 and " + user.heal + "points.");
        }
    }
}