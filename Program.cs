using Dungeoneer;
void Initialize()
{
    Console.ForegroundColor = ConsoleColor.Gray;
    Statistics.setup();
}

Initialize();

Console.ReadLine();


GameController Game = new GameController();
Game.Start(); 
