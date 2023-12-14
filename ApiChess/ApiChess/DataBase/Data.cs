using ApiChess.Models;

namespace ApiChess.DataBase;

public interface IData
{
    public List<Player> GetPlayer();
    public void AddPlayer(Player player);
    public void RedactorPlayer(Player player);
    public void UpdatePlayer(Player player);
}

public class Data : IData
{
    public List<Player> GetPlayer()
    {
        throw new NotImplementedException();
    }

    public void AddPlayer(Player player)
    {
        throw new NotImplementedException();
    }

    public void RedactorPlayer(Player player)
    {
        throw new NotImplementedException();
    }

    public void UpdatePlayer(Player player)
    {
        throw new NotImplementedException();
    }
}