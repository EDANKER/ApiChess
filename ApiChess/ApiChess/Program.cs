using ApiChess.CreateServerService;
using ApiChess.ServiceDeleted;
using ApiChess.ServiceFetcher;
using ApiChess.ServicePusher;
using ApiChess.ServiceRedactor;
using ApiChess.ServiceUpdate;
using ApiChess.SessionUser;

namespace ApiChess;

public class Program
{
    private static void Main()
    {
        IServicePusher servicePusher = new ServicePusher.ServicePusher();
        IServiceDeleted serviceDeleted = new ServiceDeleted.ServiceDeleted();
        IServiceFetcher serviceFetcher = new ServiceFetcher.ServiceFetcher();
        IServiceRedactor serviceRedactor = new ServiceRedactor.ServiceRedactor();
        IServiceUpdate serviceUpdate = new ServiceUpdate.ServiceUpdate();
        ISessionUser sessionUser = new SessionUser.SessionUser();

        var server = new Server(serviceFetcher, serviceDeleted, 
            servicePusher, serviceUpdate, serviceRedactor, sessionUser);
        server.StartServer();
    }
}