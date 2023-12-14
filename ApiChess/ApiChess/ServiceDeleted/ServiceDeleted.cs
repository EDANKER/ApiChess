using ApiChess.Models;

namespace ApiChess.ServiceDeleted;

public interface IServiceDeleted
{
    public void DeletedPlayer(Player player);
}

public class ServiceDeleted : IServiceDeleted
{
    public void DeletedPlayer(Player player)
    {
        throw new NotImplementedException();
    }
}