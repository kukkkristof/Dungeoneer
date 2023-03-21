namespace Dungeoneer;
public class GameController
{
    public int playerPosX = 10, playerPosY = 10;
    public void Start()
    {
        Console.Clear();
        Task.Run(CheckInput);
        Console.SetCursorPosition(playerPosX, playerPosY);
        Console.Write("X");
        while(true)
        {
            Update();
            if(Console.GetCursorPosition().Left != playerPosX ||Console.GetCursorPosition().Top != playerPosY)
            {
                Console.SetCursorPosition(playerPosX, playerPosY);
                Console.Write($"X");
                Console.SetCursorPosition(playerPosX, playerPosY);
            }
            movePlayer = 0;
            Thread.Sleep(10);
        }
    }
    byte movePlayer = 0;
    public void Update()
    {       
        if(movePlayer != 0)
        {
            switch(movePlayer)
            {
                case 1:
                    if(playerPosY != 0)
                    {
                        playerPosY--;
                    }
                    break;
                case 2:
                    if(playerPosX != 0)
                    {
                        playerPosX--;
                    }
                    break;
                case 3:
                    if(playerPosY != 0)
                    {
                        playerPosY--;
                    }
                    if(playerPosX != 0)
                    {
                        playerPosX--;
                    }
                    break;
                case 4:
                    playerPosY++;
                    break;
            }
        }
    }
    // w -> 1
    // a -> 2
    // aw -> 3
    // s -> 4
    // ws -> 5 --> 0
    // as -> 6
    // was -> 7 --> a -> 2
    // d -> 8
    // wd -> 9
    // ad -> 10 --> 0
    // awd -> 11 --> w -> 1
    // sd -> 12
    // wsd -> 13 --> d -> 8
    // asd -> 14 --> s -> 4
    // wasd -> 15 --> 0
    public async Task CheckInput(){
        while(true)
        {
            try
            {
                char c = Console.ReadKey().KeyChar;
                Console.SetCursorPosition(playerPosX, playerPosY);
                Console.Write(" ");
                Console.SetCursorPosition(playerPosX, playerPosY);
                if(c == 'w') movePlayer += 1;
                if(c == 'a') movePlayer += 2;
                if(c == 's') movePlayer += 4;
                if(c == 'd') movePlayer += 8;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        await Task.Delay(1);
    } 
}
