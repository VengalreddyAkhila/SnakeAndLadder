using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLAdder
{
     public class Singleplayer
    {
        public void player()
        {
            int position = 0;
            Console.WriteLine("position :" + position);
            while (position  >= 0 && position  <= 100)
            {
               Random random = new Random();
                int dice = random.Next(1, 6);
                Console.WriteLine("Dice number is:" + dice);
                Console.WriteLine("Enter the choice:");
                int Choice = random.Next(1, 2);
                switch (Choice)
                {
                    case 1:
                        position = position  + dice;
                        if (position >= 100)
                        {
                            Console.WriteLine("You won ");
                            break;

                        }
                        if (position  == 0)
                        {
                            Console.WriteLine("You Lose ");
                        }
                        else
                        {
                            Console.WriteLine("Its a Ladder:" + position);
                        }
                        break;

                    case 2:
                        if (position  < 0)
                        {
                            Console.WriteLine("Lose");
                        }
                        else
                        {
                            position  = position  - dice;
                        }
                        Console.WriteLine("Its a Snake" + position);
                        break;

                    case 3:
                        position = dice;
                        Console.WriteLine("current position is : " + position);
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
                
                Console.WriteLine("You are on Position " + position);
            }
        }  
    }
} 
