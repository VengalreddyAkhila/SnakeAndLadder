using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLAdder
{
     public class Singleplayer
    {
        public void player()
        {
            //single player with position=0
            int position = 0;
            int newposition = 0;
            Console.WriteLine("Start the game");
            Console.WriteLine("position :" + position);

            //rolls the die number between 1 to 6
            Random random = new Random();
            int dice = random.Next(1, 6);
            Console.WriteLine("Dice number is:" + dice);

            //Choice foe snake and ladder
            Console.WriteLine("Enter the choice:");
            String answer = Convert.ToString(Console.ReadLine());
            int Choice = random.Next(1, 2);
            switch (Choice)
            {
                case 1:
                    //Noplay
                    position = 0;
                    Console.WriteLine("current position is : " + position);
                    break;

                case 2:
                    //ladder
                    position = dice;
                    Console.WriteLine("current position is : " + position);
                    break;

                case 3:
                    //snake
                    position = dice;
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
    }
} 
