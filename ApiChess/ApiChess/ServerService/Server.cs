using ApiChess.ServiceDeleted;
using ApiChess.ServiceFetcher;
using ApiChess.ServicePusher;
using ApiChess.ServiceRedactor;
using ApiChess.ServiceUpdate;
using ApiChess.SessionUser;

namespace ApiChess.CreateServerService;

public interface IServer
{
    public void StartServer();
}

public class Server : IServer
{
    private readonly IServiceFetcher _serviceFetcher;
    private readonly IServiceDeleted _serviceDeleted;
    private readonly IServicePusher _servicePusher;
    private readonly IServiceUpdate _serviceUpdate;
    private readonly IServiceRedactor _serviceRedactor;
    private readonly ISessionUser _sessionUser;

    public Server(IServiceFetcher serviceFetcher, IServiceDeleted serviceDeleted, IServicePusher servicePusher, 
        IServiceUpdate serviceUpdate, IServiceRedactor serviceRedactor, ISessionUser sessionUser)
    {
        _serviceFetcher = serviceFetcher;
        _serviceDeleted = serviceDeleted;
        _servicePusher = servicePusher;
        _serviceUpdate = serviceUpdate;
        _serviceRedactor = serviceRedactor;
        _sessionUser = sessionUser;
    }

    public void StartServer()
    {
        
    }
}