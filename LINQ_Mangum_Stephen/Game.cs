using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Mangum_Stephen
{
    // Represents a video game with a title, ESRB rating, and genre
    internal class Game
    {
        // The title of the game
        public string Title { get; set; }

        // The ESRB rating of the game (e.g., 'E', 'T', 'M')
        public char Esrb { get; set; }

        // The genre of the game (e.g., "Action-Adventure", "FPS")
        public string Genre { get; set; }

        // Constructor to initialize a Game object with a title, ESRB rating, and genre
        public Game(string titleParam, char esrbParam, string genreParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
            Genre = genreParam; 
        }
    }
}
