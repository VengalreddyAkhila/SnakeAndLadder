﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLAdder
{
     public class Singleplayer
    {
        public void player()
        {
            int position = 0;
            Console.WriteLine("Start the game");
            Console.WriteLine("position :" + position);
            Random random = new Random();
            int dice = random.Next(1, 6);
            Console.WriteLine("Your Dice number is:" + dice);
        }
    }
}
