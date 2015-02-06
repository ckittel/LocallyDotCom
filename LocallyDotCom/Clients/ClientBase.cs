using LocallyDotCom.Http;

namespace LocallyDotCom.Clients
{
    public abstract class ClientBase
    {
        protected ClientBase(IApiConnection connection)
        {
            ApiConnection = connection;
        }

        protected IApiConnection ApiConnection { get; private set; }
    }
}