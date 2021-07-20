using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;

namespace The_Wanderer
{
    class Program
    {
        //Base Stats
        static int BaseStats(int npcHealth, int userHP, int userXP, int hitPoints)
        {
            npcHealth = 100;
            userHP = 100;
            userXP = 0;
            hitPoints = 0;

            return npcHealth + userHP + userXP + hitPoints;
        }
        //The introduction scenario
        static bool Intro(bool introComplete) 
        {
            
            Console.WriteLine("Welcome to The Wanderer!\nA text-based adventure game where you take control of a character of your choosing!");
            Thread.Sleep(2000);
            Console.WriteLine("You have three classes to choose from:");
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
        public static void Combat()
        {
            //Working on a combat system for the Wanderer
            int npcHealth = 100;
            int userHP = 100;
            int userXP = 0;
            int hitPoints = 0;
            int npcHitPoints = 0;
            int heal = 0;
            int npcHitChance = 0;
            
            // int item  = 0;

            

            //new random instance for the User random value generator
            Random rnGenerator = new Random();

            while (npcHealth != 0 || userHP != 0)
            {

                if (userHP == 0)
                {
                    Console.WriteLine("You have died.");
                    break;
                }
                else
                {
                    Console.WriteLine("The NPC's health is currently " + npcHealth + " points");
                Thread.Sleep(1000);
                Console.WriteLine("Your Health Point level is " + userHP + ".");
                Thread.Sleep(1000);
                Console.WriteLine("What kind of attack would you like to do?");
                Thread.Sleep(2000);
                Console.WriteLine("1. Melee\n2. Magic\n3. Heal");
                
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    hitPoints = rnGenerator.Next(0, 51);
                    // npcHitPoints = rnGenerator.Next(0,51);
                    Console.WriteLine("You dealt " + hitPoints + " points of damage to the NPC.");
                    // if (npcHitPoints == 0)
                    // {
                    //     Console.WriteLine("The NPC's attack missed.");
                    // }
                    // else
                    // {
                    //     Console.WriteLine("The NPC dealt " + npcHitPoints + " points of melee damage to you.");
                    // }
                    npcHitChance = rnGenerator.Next(0, 21);
                    if (npcHitChance >= 15)
                    {
                        npcHitPoints = rnGenerator.Next(0,51);
                        Console.WriteLine("The NPC dealt " + npcHitPoints + " points of melee damage to you.");
                        
                        userHP -= npcHitPoints;
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("The NPC's attack missed.");
                    }
                    npcHealth -= hitPoints;
                    // userHP -= npcHitPoints;
                    Thread.Sleep(1000);

                }
                else if (input == 2)
                {
                    hitPoints = rnGenerator.Next(0, 76);
                    // npcHitPoints = rnGenerator.Next(0,51);
                    Console.WriteLine("You dealt " + hitPoints + " points of magic damage to the NPC.");
                    // if (npcHitPoints == 0)
                    // {
                    //     Console.WriteLine("The NPC's attack missed.");
                    // }
                    // else
                    // {
                    //     Console.WriteLine("The NPC dealt " + npcHitPoints + " points of melee damage to you.");
                    // }
                    npcHitChance = rnGenerator.Next(0, 21);
                    if (npcHitChance >= 15)
                    {
                        npcHitPoints = rnGenerator.Next(0,51);
                        Console.WriteLine("The NPC dealt " + npcHitPoints + " points of melee damage to you.");
                        
                        userHP -= npcHitPoints;
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("The NPC's attack missed.");
                    }
                    npcHealth -= hitPoints;
                    // userHP -= npcHitPoints;
                    Thread.Sleep(1000);
                }
                else if ( input == 3)
                {
                    heal = rnGenerator.Next(0, 51);

                    userHP += heal;
                     if (userHP > 100)
                    {
                        userHP = 100;
                        Console.WriteLine($"You healed yourself by {heal} points.\nYour health is now {userHP} points.");
                    }
                    else if (userHP <= 100)
                    {
                        userHP+= heal;
                        Console.WriteLine($"You healed yourself by {heal} points.\nYour health is now {userHP} points.");
                    }
                    npcHitChance = rnGenerator.Next(0, 21);
                    if (npcHitChance >= 15)
                    {
                        npcHitPoints = rnGenerator.Next(0,51);
                        Console.WriteLine("The NPC dealt " + npcHitPoints + " points of melee damage to you.");
                        
                        userHP -= npcHitPoints;
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
                if (npcHealth <= 0)
                {
                    int experience = 5 * rnGenerator.Next(10, 21);
                    Console.WriteLine($"You have killed the NPC. You gained {experience} XP.");
                    Thread.Sleep(1000);
                    userXP += experience;
                    Console.WriteLine($"You currently have {userXP} experience points. Congratulations.");
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

        static void Exit() {
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
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadKey();
            ScenarioOne();
            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(1000);
            Combat();
            Thread.Sleep(3000);
            Exit();

            Console.ReadKey();
        }
    }
}
