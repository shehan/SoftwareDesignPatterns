namespace SoftwareDesignPatterns.Oberver
{
    public interface IServer
    {
        void AddClients(IClient client);

        void RemoveClient(IClient client);

        void NotifyClient(string message);

    }
}
