public class Player
{
    public string playerName;
    public int level;
    public  int health;

    public Player()
    {
        playerName = "Player 1";
        level = 1;
        health = 100;
    }

    public Player(string name, int level, int health)
    {
        this.playerName = name;
        this.level = level;
        this.health = health;
    }   

}