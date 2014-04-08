using System;

namespace SnakesOnAGame
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Game1 game = new Game1())
            {
                game.Run();
            }
        }
    }
#endif
}
            class Game 1 :
            {
                List<Vector2>Snake = new List<Vector2>();
                public void Load Content(      )
                }
               

