using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;


namespace The_Wanderer
{
    class Program
    
    {
        //Base Stats
        public class Player
        {
            public string name;
            public string playerClass;
            public int userMagic = 0;
            public int userHP = 100;
            public float userXP = 0f;
           public int hitPoints = 0;
            public int heal = 0;
            
        }
        public class NPC
        {
           public int npcHealth = 100;
           public  int npcHitPoints = 0;
           public  int npcHitChance = 0;

        }
        //The introduction scenario
        static bool Intro(bool introComplete) 
        {
            
            Console.WriteLine("Welcome to The Wanderer!\nA text-based adventure game where you take control of a character of your choosing!");
            Thread.Sleep(2000);
            Console.WriteLine("In the full version you will be able to choose your character's class which each come with their own special stats and abilities.");
            Thread.Sleep(2000);
            Console.WriteLine("You willhave three classes to choose from:");
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
        public static void Combat(Player _player, NPC _npc)
        {
            //Working on a combat system for the Wanderer
            // int npcHealth = 100;
            // int userHP = 100;
            // int userXP = 0;
            // int hitPoints = 0;
            // int npcHitPoints = 0;
            // int heal = 0;
            // int npcHitChance = 0;
            
            // int item  = 0;

            

            //new random instance for the User random value generator
            Random rnGenerator = new Random();

            while (_npc.npcHealth != 0 || _player.userHP != 0)
            {

                if (_player.userHP == 0)
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
                Console.WriteLine("1. Melee\n2. Magic\n3. Heal");
                
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    _player.hitPoints = rnGenerator.Next(0, 51);
                    // npcHitPoints = rnGenerator.Next(0,51);
                    Console.WriteLine("You dealt " + _player.hitPoints + " points of damage to the NPC.");
                    // if (npcHitPoints == 0)
                    // {
                    //     Console.WriteLine("The NPC's attack missed.");
                    // }
                    // else
                    // {
                    //     Console.WriteLine("The NPC dealt " + npcHitPoints + " points of melee damage to you.");
                    // }
                    _npc.npcHitChance = rnGenerator.Next(0, 21);
                    if (_npc.npcHitChance >= 15)
                    {
                        _npc.npcHitPoints = rnGenerator.Next(0,51);
                        Console.WriteLine("The NPC dealt " + _npc.npcHitPoints + " points of melee damage to you.");
                        
                        _player.userHP -= _npc.npcHitPoints;
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("The NPC's attack missed.");
                    }
                    _npc.npcHealth -= _player.hitPoints;
                    // userHP -= npcHitPoints;
                    Thread.Sleep(1000);

                }
                else if (input == 2)
                {
                    _player.hitPoints = rnGenerator.Next(0, 76);
                    // npcHitPoints = rnGenerator.Next(0,51);
                    Console.WriteLine("You dealt " + _player.hitPoints + " points of magic damage to the NPC.");
                    // if (npcHitPoints == 0)
                    // {
                    //     Console.WriteLine("The NPC's attack missed.");
                    // }
                    // else
                    // {
                    //     Console.WriteLine("The NPC dealt " + npcHitPoints + " points of melee damage to you.");
                    // }
                    _npc.npcHitChance = rnGenerator.Next(0, 21);
                    if (_npc.npcHitChance >= 15)
                    {
                        _npc.npcHitPoints = rnGenerator.Next(0,51);
                        Console.WriteLine("The NPC dealt " + _npc.npcHitPoints + " points of melee damage to you.");
                        
                        _player.userHP -= _npc.npcHitPoints;
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("The NPC's attack missed.");
                    }
                   _npc.npcHealth -= _player.hitPoints;
                    // userHP -= npcHitPoints;
                    Thread.Sleep(1000);
                }
                else if ( input == 3)
                {
                    _player.heal = rnGenerator.Next(0, 51);

                    _player.userHP += _player.heal;
                     if (_player.userHP > 100)
                    {
                        _player.userHP = 100;
                        Console.WriteLine($"You healed yourself by {_player.heal} points.\nYour health is now {_player.userHP} points.");
                    }
                    else if (_player.userHP <= 100)
                    {
                        _player.userHP+= _player.heal;
                        Console.WriteLine($"You healed yourself by {_player.heal} points.\nYour health is now {_player.userHP} points.");
                    }
                    _npc.npcHitChance = rnGenerator.Next(0, 21);
                    if (_npc.npcHitChance >= 15)
                    {
                        _npc.npcHitPoints = rnGenerator.Next(0,51);
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

                Thread.Sleep(1000);
                if (_npc.npcHealth <= 0)
                {
                    int experience = 5 * rnGenerator.Next(10, 21);
                    Console.WriteLine($"You have killed the NPC. You gained {experience} XP.");
                    Thread.Sleep(1000);
                    _player.userXP += experience;
                    Console.WriteLine($"You currently have {_player.userXP} experience points. Congratulations.");
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
            Console.WriteLine("Please enter the name of your character.");
            Player user = new Player();
            user.name = Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine("What class would you like to be?");
            Thread.Sleep(1000);
            Console.WriteLine("1. Knight");
            Thread.Sleep(1000);
            Console.WriteLine("1. Druid");
            Thread.Sleep(1000);
            Console.WriteLine("1. Priest");
            string userInputClass = Console.ReadLine();
            if (userInputClass == "1")
            {
                user.playerClass = "Knight";
            }           
            else if (userInputClass == "2")
            {
                user.playerClass= "Druid";
            }
            else
            {
                user.playerClass = "Priest";
            }
            if (user.playerClass == "Knight")
            {
                user.userHP = 150;
                user.hitPoints = 25;
                user.userMagic = 5;
                
            }
            else if (user.playerClass == "Druid")
            {
                user.userHP = 140;
                user.hitPoints = 20;
                user.userMagic = 15;
            }
            else
            {
                user.userHP = 70;
                user.hitPoints = 10;
                user.userMagic = 35;
            }
            ScenarioOne();
            Thread.Sleep(1000);
            Console.Clear();
            NPC enemy = new NPC();
            Thread.Sleep(1000);
            Combat(user, enemy);
            Thread.Sleep(3000);
            Exit();
            
            Console.ReadKey();
        }
    }
}
