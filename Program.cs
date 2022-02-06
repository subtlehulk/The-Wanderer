using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace The_Wanderer
{
    class Program
    {
        
        private static void SaveGame(Player _player)
        {

            /*
            Must make sure that all of the player's stats are saved to a list or an array so I can
            then save and load. Will have to look this up before I do this, however.        
            */       

            string filepath = @"C:\Users\corey\OneDrive\Programming\The Wanderer\PlayerInfo.txt";
            string[] playerStats = new string[6];
            playerStats[0] = _player.name;
            playerStats[1] = _player.playerClass;
            playerStats[2] = _player.userHP.ToString();
            playerStats[3] = _player.hitPoints.ToString();
            playerStats[4] = _player.userMagic.ToString();
            playerStats[5] = _player.heal.ToString();

            File.WriteAllLines(filepath, playerStats);

        }
        private static Player LoadGame(Player _player)
        {
            string filepath = @"C:\Users\corey\OneDrive\Programming\The Wanderer\PlayerInfo.txt";
            string[] playerStats = File.ReadAllLines(filepath);

                    _player.name = playerStats[0];
                    _player.playerClass = playerStats[1];
                    _player.userHP = int.Parse(playerStats[2]);
                    _player.hitPoints = int.Parse(playerStats[3]);
                    _player.userMagic = int.Parse(playerStats[4]);
                    _player.heal = int.Parse(playerStats[5]);
                    _player.progress = int.Parse(playerStats[6]);
            return _player ;
        }
        //The introduction scenario
        static bool Intro(bool introComplete) 
        {
            string filepath = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\intro.txt";
            string[] intro = File.ReadAllLines(filepath);
            
            

            foreach (string line in intro)
            {
                Console.WriteLine(line);
                Thread.Sleep(1000);
            }

            string input = Console.ReadLine();
            if ((input == "yes") | (input == "Yes"))
            {
                string textFiles = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\introYes.txt";
                string[] _yes = File.ReadAllLines(textFiles);
            
            foreach (string line in _yes)
            {
                Console.WriteLine(line);
                Thread.Sleep(1000);
            }
                input = Console.ReadLine();
                if (input == "1")
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("You attacked them, and they died..");
                }
                else if (input == "2")
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("You talked to them, and you both had a nice conversation about tables..");
                }
                else if (input == "3")
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("You healed yourself BEFORE they attacked so it was kind of pointless..");
                }
                else if (input == "4")
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("You used a mana poition, but like, you don't use mana so...yeah, it was kind of a waste..");
                }
                else{
                    Console.WriteLine("That wasn't even a choice? But oh well, moving on..");
                }
                Thread.Sleep(1000);
                Console.WriteLine("but you get the idea. So let's move on!");
                return introComplete = true; 
            }
            else
            {
                Console.WriteLine("Very well, your story will be told another time..");
                Thread.Sleep(2000);
                Console.WriteLine("Exiting application..");
                Thread.Sleep(3000);
                Environment.Exit(0);
                return introComplete = false;
            }
            
            
        }
        //combat
        public static void Combat(Player _player, NPC _npc, Item _potion)
        {

            if (_player.playerClass == "Priest")
            {
                _npc.npcHealth = 50;
            }


            //new random instance for the User random value generator
            Random rnGenerator = new Random();

            while (_npc.npcHealth != 0 || _player.userHP <= 0)
            {

                if (_player.userHP <= 0)
                {
                    Console.WriteLine("You have died.");
                    break;
                }
                else
                {
                Console.WriteLine("The NPC's health is currently " + _npc.npcHealth + " points");
                Thread.Sleep(1000);
                Console.WriteLine("Your Health Point level is " + _player.userHP + ".");
                Thread.Sleep(1000);
                Console.WriteLine("What kind of attack would you like to do?");
                Thread.Sleep(2000);
                
                
                
                if (_potion.used == false)
                {

                Console.WriteLine("1. Melee\n2. Magic\n3. Heal\n4. Item");
                int input = Convert.ToInt32(Console.ReadLine());
                {
                    if (input == 1)
                    {
                        

                        _player.hitPoints = rnGenerator.Next(1, _player.hitPoints + 1);

                        
                        Console.WriteLine("You dealt " + _player.hitPoints + " points of damage to the NPC.");
                    
                        _npc.npcHitChance = rnGenerator.Next(0, 21);
                        if (_npc.npcHitChance >= 15)
                        {
                            _npc.npcHitPoints = rnGenerator.Next(15,51);
                            Console.WriteLine("The NPC dealt " + _npc.npcHitPoints + " points of melee damage to you.");
                            
                            _player.userHP -= _npc.npcHitPoints;
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.WriteLine("The NPC's attack missed.");
                        }
                        _npc.npcHealth -= _player.hitPoints;
                        
                        Thread.Sleep(1000);

                    }
                    else if (input == 2)
                    {
                        _player.hitPoints = rnGenerator.Next(0, _player.userMagic + 1);
                        
                        Console.WriteLine("You dealt " + _player.hitPoints + " points of magic damage to the NPC.");
                    
                        _npc.npcHitChance = rnGenerator.Next(0, 21);
                        if (_npc.npcHitChance >= 15)
                        {
                            _npc.npcHitPoints = rnGenerator.Next(15,51);
                            Console.WriteLine("The NPC dealt " + _npc.npcHitPoints + " points of melee damage to you.");
                            
                            _player.userHP -= _npc.npcHitPoints;
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.WriteLine("The NPC's attack missed.");
                        }
                    _npc.npcHealth -= _player.hitPoints;
                        
                        Thread.Sleep(1000);
                    }
                    else if ( input == 3)
                    {
                        _player.heal = rnGenerator.Next(1, _player.heal + 1);

                        _player.userHP += _player.heal;

                        Console.WriteLine($"You healed yourself by {_player.heal} points.\nYour health is now {_player.userHP} points.");
                      
                        _npc.npcHitChance = rnGenerator.Next(0, 21);
                        if (_npc.npcHitChance >= 15)
                        {
                            _npc.npcHitPoints = rnGenerator.Next(15,51);
                            Console.WriteLine("The NPC dealt " + _npc.npcHitPoints + " points of melee damage to you.");
                            
                            _player.userHP -= _npc.npcHitPoints;
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.WriteLine("The NPC's attack missed.");
                        }
                    
                        // Console.WriteLine($"You healed yourself by {heal} points. Your total health points is now: {userHP} points.");
                        Thread.Sleep(1000);
                    }
                    else if (input == 4)
                    {
                        _potion.used = true;

                        if (_player.playerClass == "Knight")
                        {
                            _player.hitPoints = _player.hitPoints + _potion.damageBoost;
                            Console.WriteLine("Your attack power has been increased by " + _potion.damageBoost + " points.");
                        }
                        else if (_player.playerClass == "Druid")
                        {
                            _player.userHP += _potion.healPoints;
                            Console.WriteLine("You healed yourself by " + _potion.healPoints + " points. Your health is now " + _player.userHP + " points");
                        }
                        else
                        {
                            _npc.npcHealth =- _potion.damagePoints;
                            Console.WriteLine("You dealt " + _potion.damagePoints + " points to the NPC.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid option.");
                        break;
                    }
                }
            } 
            else 
            {
                Console.WriteLine("1. Melee\n2. Magic\n3. Heal");
                int input = Convert.ToInt32(Console.ReadLine());
                
                if (input == 1)
                    {
                        if (_player.playerClass == "Knight" || _player.playerClass == "Druid")
                        {
                            
                            Thread.Sleep(2000);

                            _player.hitPoints = rnGenerator.Next(_player.hitPoints, _potion.damageBoost + _player.hitPoints);
                            
                            Console.WriteLine("You dealt " + _player.hitPoints + " points of damage to the NPC.");
                        }
                        else 
                        {
                            Console.WriteLine("You dealt " + _player.hitPoints + " points of damage to the NPC.");
                        }
                        

                        _npc.npcHitChance = rnGenerator.Next(0, 21);
                        if (_npc.npcHitChance >= 15)
                        {
                            _npc.npcHitPoints = rnGenerator.Next(15,51);
                            Console.WriteLine("The NPC dealt " + _npc.npcHitPoints + " points of melee damage to you.");
                            
                            _player.userHP -= _npc.npcHitPoints;
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.WriteLine("The NPC's attack missed.");
                        }
                        _npc.npcHealth -= _player.hitPoints;
                        
                        Thread.Sleep(1000);

                    }
                    else if (input == 2)
                    {
                        _player.hitPoints = rnGenerator.Next(0, _player.userMagic + 1);
                        
                        Console.WriteLine("You dealt " + _player.hitPoints + " points of magic damage to the NPC.");
                    
                        _npc.npcHitChance = rnGenerator.Next(0, 21);
                        if (_npc.npcHitChance >= 15)
                        {
                            _npc.npcHitPoints = rnGenerator.Next(15,51);
                            Console.WriteLine("The NPC dealt " + _npc.npcHitPoints + " points of melee damage to you.");
                            
                            _player.userHP -= _npc.npcHitPoints;
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.WriteLine("The NPC's attack missed.");
                        }
                    _npc.npcHealth -= _player.hitPoints;
                        
                        Thread.Sleep(1000);
                    }
                    else if ( input == 3)
                    {
                        _player.heal = rnGenerator.Next(1, _player.heal + 1);

                        _player.userHP += _player.heal;
                        
                        Console.WriteLine($"You healed yourself by {_player.heal} points.\nYour health is now {_player.userHP} points.");
                        
                        _npc.npcHitChance = rnGenerator.Next(0, 21);
                        if (_npc.npcHitChance >= 15)
                        {
                            _npc.npcHitPoints = rnGenerator.Next(15,51);
                            Console.WriteLine("The NPC dealt " + _npc.npcHitPoints + " points of melee damage to you.");
                            
                            _player.userHP -= _npc.npcHitPoints;
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.WriteLine("The NPC's attack missed.");
                        }
                    
                        // Console.WriteLine($"You healed yourself by {heal} points. Your total health points is now: {userHP} points.");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid option.");
                        break;
                    }
            }

                Thread.Sleep(1000);
                if (_npc.npcHealth <= 0)
                {
                    int experience = 5 * rnGenerator.Next(10, 21);
                    Console.WriteLine($"You have killed the NPC.");
                    Thread.Sleep(1000);
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                }
            }
        }
    }
        //scenario 1 - the tutorial
        static void ScenarioOne()
        {
            string filepath = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\scenarioOne.txt";
            string[] scenarioOne = File.ReadAllLines(filepath);
            
            foreach (string line in scenarioOne)
            {
                Console.WriteLine(line);
                Thread.Sleep(1500);
            }
        }
        static void Continue()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Now that the introduction has been made, let us move on to the tutorial!"); 
            Thread.Sleep(1000);
            Console.WriteLine("You can press 'CTRL + C' at any time to exit the applications.");
            Thread.Sleep(1000);
            Console.WriteLine("However, in future versions, this will not save your progress and you will have to start again.");  
            Thread.Sleep(1500);
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadKey();
            Thread.Sleep(2000);
        }
        static void Exit() 
        {
            Console.WriteLine("And that, ladies and gentlemen, is 'The Wanderer' - preview edition!");
            Thread.Sleep(1000);
            Console.WriteLine("I hope you have enjoyed this little preview, and hope it has enticed you to wait for the full version to be released.");
            Thread.Sleep(1000);
            Console.WriteLine("If you have any feedback on the application, please send me an email at:");
            Thread.Sleep(1000);
            Console.WriteLine("coreygraham@live.co.uk");
            Thread.Sleep(2000);
            Console.WriteLine("Press any key to exit the program..");
            Console.ReadKey();
            Environment.Exit(0);
        }

        static void Main(string[] args)
        {   
            
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            // bool complete = true;
            // complete = Intro(complete);
            // Continue();
            Player user = Player.CreatePlayer();
            Item potion = Item.CreateItem(user.playerClass);
            NPC enemy = NPC.CreateEnemy("Heath");
            Player.PrintPlayerStats(user);
            // Thread.Sleep(1000);
            // Console.WriteLine("Saved game data");
            Console.WriteLine();
            Console.WriteLine("Would you like to save your game so far?");
            if (Console.ReadLine() == "Yes" || Console.ReadLine() == "yes" || Console.ReadLine() == "y")
            {
                SaveGame(user);
            }
            
            // Thread.Sleep(2000);
            // Console.WriteLine("Loaded game data");
            // LoadGame(user);
            Console.WriteLine("Press 'Enter' or any key to continue.");
            Console.ReadKey();
            ScenarioOne();
            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(1000);
            Combat(user, enemy, potion);
            Thread.Sleep(3000);
            Exit();
        }
    }
}