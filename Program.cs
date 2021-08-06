using System;
using System.Threading;
using System.Collections.Generic;


namespace The_Wanderer
{
    class Program
    
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
        }
        public class NPC
        {
            public string name;
            public int npcHealth = 100;
            public  int npcHitPoints = 0;
            public  int npcHitChance = 0;

        }

        //The item class
        public class Item
        {
            //this is how much damage it will deal to the NPC
            public int damagePoints;
            //How much the user will be healed by
            public int healPoints;
            //How much a player's attack will be boosted by until the end of the fight.
            public int damageBoost;
            public bool used;
        }


        //creating a new player
        static Player CreatePlayer()
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
        static Player CreatePlayer(Player _user, int userClass)
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
        static void PrintPlayerStats(Player user)
        {
            Console.WriteLine("Your name is: " + user.name + ".");
            Console.WriteLine("You are a " + user.playerClass + ".");
            Thread.Sleep(1000);
            Console.WriteLine("Your current stats are:\n");
            Console.WriteLine("Your Melee attack damage range is between 1 and " + user.hitPoints + " points.");
            Console.WriteLine("Your Magic attack damage range is between 1 and " + user.userMagic + " points.");
            Console.WriteLine("Your Heal range is between 1 and " + user.heal + "points.");
        }
        static NPC CreateEnemy(string _name)
        {
            NPC newEnemy = new NPC();
            Random stats = new Random();
            newEnemy.npcHealth = stats.Next(90, 151);
            newEnemy.npcHitPoints = stats.Next(15, 51);
            newEnemy.name = _name;
            return newEnemy;
        }

        static Item CreateItem(string _playerClass)
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
        

        //The introduction scenario
        static bool Intro(bool introComplete) 
        {
            
            Console.WriteLine("Welcome to The Wanderer!\nA text-based adventure game where you take control of a character of your choosing!");
            Thread.Sleep(2000);
            Console.WriteLine("In the full version you will be able to choose your character's class which each come with their own special stats and abilities.");
            Thread.Sleep(2000);
            Console.WriteLine("You will have three classes to choose from:");
            Thread.Sleep(2000);
            Console.WriteLine("1. Knight");
            Thread.Sleep(800);
            Console.WriteLine("2. Druid");
            Thread.Sleep(800);
            Console.WriteLine("3. Priest");
            Thread.Sleep(2000);
            Console.WriteLine("You will venture through the land of Terah, slaying void monsters, in order to save your familiy from capture.");
            Thread.Sleep(2000);
            Console.WriteLine("Failure to do so will result in you being banaished from your village, and forced to walk the earth as an outcast.");
            Thread.Sleep(1000);
            Console.WriteLine("Would you like to continue?");

            string input = Console.ReadLine();

            if ((input == "yes") | (input == "Yes"))
            {
                
                Console.WriteLine("Then your adventure awaits you...");
                Thread.Sleep(2000);
                Console.WriteLine("The game is simple to follow, and easy to use.");
                Thread.Sleep(2000);
                Console.WriteLine("All you have to do input the option that you'd like to choose, and the game will do the rest.");
                Thread.Sleep(2000);
                Console.WriteLine("Let's do an example.");
                Thread.Sleep(2000);
                Console.WriteLine("A bad guy comes at you. What do you do?");
                Thread.Sleep(2000);
                Console.WriteLine("1. Attack");
                Thread.Sleep(800);
                Console.WriteLine("2. Talk");
                Thread.Sleep(800);
                Console.WriteLine("3. Heal");
                Thread.Sleep(800);
                Console.WriteLine("4. Item");
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
                    break;
                }
            }
        }
    }
        //scenario 1 - the tutorial
        static void ScenarioOne()
        {
            Console.WriteLine("The wind blows against your bare face, the ice cold rain batters your soaked robes, threatening to drown you before you reach the next village.");
            Thread.Sleep(1000);
            Console.WriteLine("'Why didn't I bring spare robes?' you ask yourself.");
            Thread.Sleep(1000);
            Console.WriteLine("You hear branches snap to the side of you, and your attention immediately focuses on a figure that appeared out of nowhere.");
            Thread.Sleep(1000);
            Console.WriteLine("'Fancy seeing you here, boy.' came a familiar voice. You recognise the emphasise on the word 'boy'.");
            Thread.Sleep(1000);
            Console.WriteLine("'Why are you here, master?' you respond, drawing on your energy slowly. He will surely sense it, otherwise.");
            Thread.Sleep(1000);
            Console.WriteLine("'You know exactly why I am here. It's time for you to perish...for good.'");
            Thread.Sleep(1000);
            Console.WriteLine("");
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

            bool complete = true;
            complete = Intro(complete);
            Continue();
            

            Player user = CreatePlayer();

            Item potion = CreateItem(user.playerClass);

            NPC enemy = CreateEnemy("Heath");

            PrintPlayerStats(user);

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
