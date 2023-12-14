using ApiChess.CreateServerService;

namespace ApiChess;

public class Program
{
    private static void Main()
    {
        var server = new Server();
        server.StartServer();
    }
}

