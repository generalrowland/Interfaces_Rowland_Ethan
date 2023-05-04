using System;

namespace Interfaces_Rowland_Ethan
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("M", "FPS", "FarCry 5");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            Movie myMovie = new Movie("R", "Action/Comedy", "The Hitman's Bodyguard");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}
