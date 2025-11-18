public class Program
{
    public static void Main(string[] args)
    {
        // Using default constructor
        Player player1 = new Player();

        // Using parameterized constructor
        Player player2 = new Player("Samman ", 5, 80);

        // Values of player one.
        Console.WriteLine("Player One:");
        Console.WriteLine("Name: " + player1.playerName);
        Console.WriteLine("Level: " + player1.level);
        Console.WriteLine("Health: " + player1.health);

        // Values of player two.
        Console.WriteLine("\nPlayer Two:");
        Console.WriteLine("Name: " + player2.playerName);
        Console.WriteLine("Level: " + player2.level);
        Console.WriteLine("Health: " + player2.health);
    }
}