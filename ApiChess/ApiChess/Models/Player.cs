namespace ApiChess.Models;

public class Player
{
    public Player(int id, string name, double money, int win)
    {
        Id = id;
        Name = name;
        Money = money;
        Win = win;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public double Money { get; set; }
    public int Win { get; set; }
}