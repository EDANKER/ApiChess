using ApiChess.Models;

namespace ApiChess.ServicePusher;

public interface IServicePusher
{
    public void PushPlayer(Player player);
}

public class ServicePusher : IServicePusher
{
    public void PushPlayer(Player player)
    {
        throw new NotImplementedException();
    }
}