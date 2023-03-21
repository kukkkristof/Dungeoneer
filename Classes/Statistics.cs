using System.Drawing;
namespace Dungeoneer;
public class Statistics
{
    public static Dictionary<string, ConsoleColor> StatColorCoding = new Dictionary<string, ConsoleColor>();
    public static void setup()
    {
        StatColorCoding.Add("Strength", ConsoleColor.Red);
        StatColorCoding.Add("Health", ConsoleColor.Green);
        StatColorCoding.Add("Armor", ConsoleColor.DarkGray);
        StatColorCoding.Add("Critical Rate", ConsoleColor.DarkYellow);
        StatColorCoding.Add("Critical Damage", ConsoleColor.Yellow);
    }
}
