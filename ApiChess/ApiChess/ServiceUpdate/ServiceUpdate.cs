using ApiChess.Models;

namespace ApiChess.ServiceUpdate;

public interface IServiceUpdate
{
    public void UpdatePlayer(Player player);
}

public class ServiceUpdate : IServiceUpdate
{
    public void UpdatePlayer(Player player)
    {
        throw new NotImplementedException();
    }
}