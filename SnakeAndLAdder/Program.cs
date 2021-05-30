using System;

namespace SnakeAndLAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake And Ladder");
            Singleplayer singleplayer = new Singleplayer();
            singleplayer.player();
        }
    }
}
