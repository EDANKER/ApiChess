using ApiChess.Models;

namespace ApiChess.ServiceFetcher;

public interface IServiceFetcher
{
    public List<Player> Players();
}

public class ServiceFetcher : IServiceFetcher
{
    public List<Player> Players()
    {
        throw new NotImplementedException();
    }
}