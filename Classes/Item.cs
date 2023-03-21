namespace Dungeoneer;
public class Item
{
    public enum rarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary,
        Mythic
    }
    public string Name;
    public rarity Rarity;
    public Dictionary<string, double> Stats = new Dictionary<string, double>();
    public void PrintName()
    {
        switch(Rarity)
        {
            case rarity.Common:
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(Name);
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            case rarity.Uncommon:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Name);
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            case rarity.Rare:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(Name);
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            case rarity.Epic:
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(Name);
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            case rarity.Legendary:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(Name);
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            case rarity.Mythic:
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(Name);
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
        }
    }

    public void printDetailed(){
        PrintName();
        Console.Write("(");
        foreach(string key in Stats.Keys)
        {
            Stats.TryGetValue(key, out double value);
            Statistics.StatColorCoding.TryGetValue(key, out ConsoleColor color);
            Console.ForegroundColor = color;
            Console.Write(value);
            Console.ForegroundColor = ConsoleColor.Gray;
            if(key != Stats.Keys.Last<string>()) Console.Write(", ");
            else Console.Write(")");
        }
    }

}
