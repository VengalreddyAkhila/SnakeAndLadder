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
            int newposition = 0;
            Console.WriteLine("Start the game");
            Console.WriteLine("position :" + position);
            Random random = new Random();
            int dice = random.Next(1, 6);
            Console.WriteLine("Dice number is:" + dice);


            Console.WriteLine("Enter the choice:");
            String answer = Convert.ToString(Console.ReadLine());
            //if (answer == "y")
            //Choice to check its snake or ladder
            int Choice = random.Next(1, 2);
            switch (Choice)
            {
                case 1:
                    //ladder
                    position = dice;
                    Console.WriteLine("current position is : " + position);
                    break;

                case 2:
                    //snake
                    //if (position > dice)

                    //{
                    position = dice;
                    Console.WriteLine("current position is : " + position);
                    //}
                    break;

                case 3:
                    //no play
                    position = 0;
                    Console.WriteLine("current position is : " + position);
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
            position = position + newposition;

            if (position < 0)
            {
                position = 0;
            }
            Console.WriteLine("You are on Position " + position);
        }

            //Console.WriteLine("dice" + dice);
            //}


        
    }
} 
