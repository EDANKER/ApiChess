using ApiChess.Models;

namespace ApiChess.SessionUser;

public interface ISessionUser
{
    public void ConnectPlayer(int id, string name, int money, int win);
    public void ReConnect(int id);
}

public class SessionUser : ISessionUser
{
    public void ConnectPlayer(int id, string name, int money, int win)
    {
        throw new NotImplementedException();
    }

    public void ReConnect(int id)
    {
        throw new NotImplementedException();
    }
}