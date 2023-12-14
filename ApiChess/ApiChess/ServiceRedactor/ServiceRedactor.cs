using ApiChess.Models;

namespace ApiChess.ServiceRedactor;

public interface IServiceRedactor
{
    public void RedactorPlayer(Player player);
}

public class ServiceRedactor : IServiceRedactor
{
    public void RedactorPlayer(Player player)
    {
        throw new NotImplementedException();
    }
}