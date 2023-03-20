namespace Dungeoneer;
public class Dungeon
{
    public int PositionX, PositionY, SizeX, SizeY;
    public Room[] Rooms;
    public void GenerateRoom()
    {

    }
    public void Print()
    {

    }
}
public class Room
{
    public type Type;
    public int SizeX, SizeY;
    public enum type{
        Start,
        End,
        Loot,
        Enemy,
        Foyer
    }
}