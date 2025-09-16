using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Mangum_Stephen
{
    internal class Game
    {


        public string Title { get; set; }

        public char Esrb { get; set; }

        public string Genre { get; set; }

        public Game(string titleParam, char esrbParam, string genreParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
            Genre = genreParam;
        }
    }
}
