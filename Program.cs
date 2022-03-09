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
        //Prologue
        static void Prologue(Player p)
        {
            if (p.playerClass == "Knight")
            {
                //load knight prologue text
                string filepath = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\knight\intro.txt";
                List<string> intro = File.ReadAllLines(filepath).ToList();
                foreach (var item in intro)
                {
                    Console.WriteLine(item);
                    Thread.Sleep(1000);
                }
            }
            else if (p.playerClass == "Druid")
            {
                //load druid prologue text
                string filepath = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\druid\intro.txt";
                List<string> intro = File.ReadAllLines(filepath).ToList();
                foreach (var item in intro)
                {
                    Console.WriteLine(item);
                    Thread.Sleep(1000);
                }
            }
            else {
                //load priest prologue text
                string filepath = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\priest\intro.txt";
                List<string> intro = File.ReadAllLines(filepath).ToList();
                foreach (var item in intro)
                {
                    Console.WriteLine(item);
                    Thread.Sleep(1000);
                }
            }
        }
        //Tutorial
        public static void Tutorial(Player p) 
        {
            Console.WriteLine($"Okay, {p.name}, give me your best shot!");
                string textFiles = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\introYes.txt";
                string[] _yes = File.ReadAllLines(textFiles);
                foreach (string line in _yes)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(1000);
                }

                string input = Console.ReadLine();
                if (input == "1")
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("You went on the offensive, and took your sister by surprise and knocked her over.");
                    Thread.Sleep(1000);
                    Console.WriteLine("She winces as her back takes the brunt of her fall.");
                }
                else if (input == "2")
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("You tell your Sister that you're worried about what may happen on this mission\nbut she assures you nothing bad is going to happen.");
                }
                else if (input == "3")
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("You healed yourself BEFORE they attacked so it was kind of pointless, but your Sister just laughs and pulls her swing wide.");
                }
                else if (input == "4")
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("You take your item out of your bag and inspect it. Hopefully you don't have to use it, but it is always better to take it with you.");
                }
                else{
                    Console.WriteLine("I advise you to pay attention to your options.");
                }
                Thread.Sleep(1000);
                Console.WriteLine("Simple, right? Let's move on, and begin your adventure.");
        }
        public static void ScenarioOne(string n) 
        {
            if (n == "Ryuko")
            {
                string textFiles = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\knight\scenario_1.txt";
                string[] _yes = File.ReadAllLines(textFiles);
                foreach (string line in _yes)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(1500);
                }  
            }
            else if (n == "Yoko")
            {
                string textFiles = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\druid\scenario_1.txt";
                string[] _yes = File.ReadAllLines(textFiles);
                foreach (string line in _yes)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(1500);
                } 
            }
            else {
                string textFiles = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\priest\scenario_1.txt";
                string[] _yes = File.ReadAllLines(textFiles);
                foreach (string line in _yes)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(1500);
                } 
            }
            Console.WriteLine("Press 'Enter' to continue..");
            Console.ReadKey();
            
        }
        public static void ScenarioTwo(string n) 
        {
            if (n == "Ryuko")
            {
                string textFiles = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\knight\scenario_2.txt";
                string[] _yes = File.ReadAllLines(textFiles);
                foreach (string line in _yes)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(1500);
                }  
            }
            else if (n == "Yoko")
            {
                string textFiles = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\druid\scenario_2.txt";
                string[] _yes = File.ReadAllLines(textFiles);
                foreach (string line in _yes)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(1500);
                } 
            }
            else {
                string textFiles = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\priest\scenario_2.txt";
                string[] _yes = File.ReadAllLines(textFiles);
                foreach (string line in _yes)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(1500);
                } 
            }
            Console.WriteLine("Press 'Enter' to continue..");
            Console.ReadKey();
            
        }
        public static void ScenarioThree(string n) 
        {
            if (n == "Ryuko")
            {
                string textFiles = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\knight\scenario_3.txt";
                string[] _yes = File.ReadAllLines(textFiles);
                foreach (string line in _yes)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(1500);
                }  
            }
            else if (n == "Yoko")
            {
                string textFiles = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\druid\scenario_3.txt";
                string[] _yes = File.ReadAllLines(textFiles);
                foreach (string line in _yes)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(1500);
                } 
            }
            else {
                string textFiles = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\priest\scenario_3.txt";
                string[] _yes = File.ReadAllLines(textFiles);
                foreach (string line in _yes)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(1500);
                } 
            }
            Console.WriteLine("Press 'Enter' to continue..");
            Console.ReadKey();
            
        }

        public static void ScenarioFour() {
            string textFiles = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\scenarioFour\scenario_4.txt";
                string[] _yes = File.ReadAllLines(textFiles);
                foreach (string line in _yes)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(2000);
                }
        }

        public static void ScenarioFivePartOne() {
            string textFiles = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\scenarioFive\scenario_5_pt_one.txt";
                string[] _yes = File.ReadAllLines(textFiles);
                foreach (string line in _yes)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(2000);
                }
        }
        public static void ScenarioFivePartTwo() {
            string textFiles = @"C:\Users\corey\OneDrive\Programming\The Wanderer\text\scenarioFive\scenario_5_pt_two.txt";
                string[] _yes = File.ReadAllLines(textFiles);
                foreach (string line in _yes)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(2000);
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
                Console.WriteLine($"{_npc.name}'s health is currently " + _npc.npcHealth + " points");
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

                        
                        Console.WriteLine($"You dealt " + _player.hitPoints + " points of damage to {_npc.name}.");
                    
                        _npc.npcHitChance = rnGenerator.Next(0, 21);
                        if (_npc.npcHitChance >= 15)
                        {
                            _npc.npcHitPoints = rnGenerator.Next(15,51);
                            Console.WriteLine($"{_npc.name} dealt " + _npc.npcHitPoints + " points of melee damage to you.");
                            
                            _player.userHP -= _npc.npcHitPoints;
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.WriteLine($"{_npc.name}'s attack missed.");
                        }
                        _npc.npcHealth -= _player.hitPoints;
                        
                        Thread.Sleep(1000);

                    }
                    else if (input == 2)
                    {
                        _player.hitPoints = rnGenerator.Next(0, _player.userMagic + 1);
                        
                        Console.WriteLine($"You dealt " + _player.hitPoints + " points of magic damage to {_npc.name}.");
                    
                        _npc.npcHitChance = rnGenerator.Next(0, 21);
                        if (_npc.npcHitChance >= 15)
                        {
                            _npc.npcHitPoints = rnGenerator.Next(15,51);
                            Console.WriteLine($"{_npc.name} dealt " + _npc.npcHitPoints + " points of melee damage to you.");
                            
                            _player.userHP -= _npc.npcHitPoints;
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.WriteLine($"{_npc.name}'s attack missed.");
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
                            Console.WriteLine($"{_npc.name} dealt " + _npc.npcHitPoints + " points of melee damage to you.");
                            
                            _player.userHP -= _npc.npcHitPoints;
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.WriteLine($"{_npc.name}'s attack missed.");
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
                            Console.WriteLine($"You dealt " + _potion.damagePoints + " points to {_npc.name}.");
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
                            
                            Console.WriteLine($"You dealt " + _player.hitPoints + " points of damage to {_npc.name}.");
                        }
                        else 
                        {
                            Console.WriteLine($"You dealt " + _player.hitPoints + " points of damage to {_npc.name}.");
                        }
                        

                        _npc.npcHitChance = rnGenerator.Next(0, 21);
                        if (_npc.npcHitChance >= 15)
                        {
                            _npc.npcHitPoints = rnGenerator.Next(15,51);
                            Console.WriteLine($"{_npc.name} dealt " + _npc.npcHitPoints + " points of melee damage to you.");
                            
                            _player.userHP -= _npc.npcHitPoints;
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.WriteLine($"{_npc.name}'s attack missed.");
                        }
                        _npc.npcHealth -= _player.hitPoints;
                        
                        Thread.Sleep(1000);

                    }
                    else if (input == 2)
                    {
                        _player.hitPoints = rnGenerator.Next(0, _player.userMagic + 1);
                        
                        Console.WriteLine($"You dealt " + _player.hitPoints + " points of magic damage to {_npc.name}.");
                    
                        _npc.npcHitChance = rnGenerator.Next(0, 21);
                        if (_npc.npcHitChance >= 15)
                        {
                            _npc.npcHitPoints = rnGenerator.Next(15,51);
                            Console.WriteLine($"{_npc.name} dealt " + _npc.npcHitPoints + " points of melee damage to you.");
                            
                            _player.userHP -= _npc.npcHitPoints;
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.WriteLine($"{_npc.name}'s attack missed.");
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
                            Console.WriteLine($"{_npc.name} dealt " + _npc.npcHitPoints + " points of melee damage to you.");
                            
                            _player.userHP -= _npc.npcHitPoints;
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.WriteLine($"{_npc.name}'s attack missed.");
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
        

        static void Main(string[] args)
        {   
            
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            Player user = Player.CreatePlayer();
            Item potion = Item.CreateItem(user.playerClass);
            NPC enemy = NPC.CreateEnemy("Heath");
            Player.PrintPlayerStats(user);
            //V add this to the SaveGame() function V
            Console.WriteLine();
            Console.WriteLine("Would you like to save your game so far?\nPlease enter 'yes' or 'no'.");
            string input = Console.ReadLine();
            if (input == "Yes" || input == "yes" || input == "y")
            {
                
                SaveGame(user);
                Console.WriteLine("Game has been saved.");
                
            }
            else {
                Console.WriteLine("Game has not been saved.");
            }
            Prologue(user);
            
            Console.WriteLine("Press 'Enter' or any key to continue.");
            Console.ReadKey();
            Console.WriteLine($"'Hey, {user.name}, before we head out we should warm up first.'\n(Would you like to play through the tutorial?)");
            input = Console.ReadLine();
            if (input == "Yes" || input == "yes" || input == "y" || input == "y")
            {
                Console.Clear();
                Tutorial(user);
                
            }
            ScenarioOne(user.name);
            Combat(user, enemy = NPC.CreateEnemy("The Shadowy Figure"), potion);
            ScenarioTwo(user.name);
            Combat(user, enemy = NPC.CreateEnemy("Void Monster"), potion);
            ScenarioThree(user.name);
            Combat(user, enemy = NPC.CreateEnemy("The Man"), potion);
            ScenarioFour();
            Combat(user, enemy = NPC.CreateEnemy("The Void"), potion);
            ScenarioFivePartOne();
            Combat(user, enemy = NPC.CreateEnemy("Atsuke"), potion);
            Combat(user, enemy = NPC.CreateEnemy("Yoko"), potion);
            ScenarioFivePartTwo();
            Combat(user, enemy=NPC.CreateEnemy("Void Entity Incarnation"), potion);
            Console.WriteLine("You've completed The Wanderer! Congratulations!");
            Thread.Sleep(1000);
            Console.WriteLine("If you would like to get in touch my email address is:");
            Thread.Sleep(1000);
            Console.WriteLine("coreygraham@live.co.uk");
            Console.WriteLine("Press any button to exit.");
            Console.ReadKey();
            
            Console.ReadKey();
        }
    }
}