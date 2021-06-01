using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLAdder
{
    public class Singleplayer
    {
        public void player()
        {
            //single player position is 0
            int position = 0;
            Console.WriteLine("position :" + position);
            //player rolls the die
            Random random = new Random();
            int dice = random.Next(1, 6);
            Console.WriteLine("Dice number is:" + dice);
            int Choice = random.Next(1, 2);
            //player checks options noplay,ladder,snake
            switch (Choice)
            {
                case 1:
                    position = position + dice;
                    Console.WriteLine("Its a ladder" + position);
                    break;
                case 2:
                    if (position < 0)
                    Console.WriteLine("you lose");
                    else
                    position = position - dice;
                    Console.WriteLine("Its a Snake" + position);
                    break;

                case 3:
                    position = 0;
                    Console.WriteLine("current position is : " + position);
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
            Console.WriteLine("your position is : " + position);
        }
    }
}
                
               