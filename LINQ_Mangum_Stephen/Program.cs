namespace LINQ_Mangum_Stephen
{
    using System.Linq;
    using System.Net.WebSockets;

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates an array of Game objects with various titles, ESRB ratings, and genres
            Game[] games = new Game[]
            {
                new Game("Minecraft", 'E', "Action-Adventure"),
                new Game("CS:GO", 'M', "FPS"),
                new Game("Elden Ring", 'M', "Action-Adventure"),
                new Game("Valorant", 'T', "FPS"),
                new Game("Halo 3", 'M', "Action FPS"),
                new Game("ZombCube", 'E', "FPS Survival"),
                new Game("Magnet Destroyer", 'E', "Hyper-Casual"),
                new Game("Paddle Balls", 'E', "Arcade Casual"),
                new Game("Rocket League", 'E', "Action Racing"),
                new Game("Fifa 22", 'E', "Sport")
            };

            // Query for games with titles shorter than 9 characters and convert their titles to uppercase
            var shortGames = from game in games
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";

            // Prints each short game title to the console
            foreach(var game in shortGames)
            {
                Console.WriteLine(game);
            }

            // Query for the game with the title "Minecraft" and select its details
            var mineCraft = games.Where(game => game.Title == "Minecraft")
                                 .Select(game => $"Game Title: {game.Title}, ESRB Rating: {game.Esrb}, Genre: {game.Genre}");

            // Prints the details of "Minecraft" (or null if not found)
            Console.WriteLine(mineCraft.FirstOrDefault());

            // Query for games with an ESRB rating of 'T' (Teen)
            var tRated = from game in games
                         where game.Esrb == 'T'
                         select game.Title;

            // Prints all T rated game titles
            Console.WriteLine("T Rated Games:");
            foreach(var game in tRated)
            {
                Console.WriteLine(game);
            }

            // Query for games with an ESRB rating of 'E' (Everyone) and a genre containing "Action"
            var eRatedAction = from game in games
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;

            // Prints all E rated action game titles
            Console.WriteLine("E Rated Action Games:");
            foreach (var game in eRatedAction)
            {
                Console.WriteLine(game);
            }
        }
    }
}