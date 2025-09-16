namespace LINQ_Mangum_Stephen
{
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
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

            var shortGames = from game in games
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";

            foreach(var game in shortGames)
            {
                               Console.WriteLine(game);
            }

            var mineCraft = games.Where(game => game.Title == "Minecraft")
                                               .Select(game => $"Game Title: {game.Title}, ESRB Rating: {game.Esrb}, Genre: {game.Genre}");


            Console.WriteLine(mineCraft.FirstOrDefault());
        }
    }
}