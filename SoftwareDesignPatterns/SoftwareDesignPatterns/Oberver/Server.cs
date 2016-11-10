using System;
using System.Collections.Generic;

namespace SoftwareDesignPatterns.Oberver
{
    public class Server : IServer
    {
        List<IClient> clientList = new List<IClient>();

        public void AddClients(IClient client)
        {
            Console.WriteLine("!!!Server Message: New Client Added - " + client.GetType().ToString());
            clientList.Add(client);
        }

        public void NotifyClient(string message)
        {
            Console.WriteLine("!!!Server Message: Sending Message To Clients - " + message);
            foreach (IClient client in clientList)
            {
                client.notify(message);
            }

        }

        public void RemoveClient(IClient client)
        {
            Console.WriteLine("!!!Server Message: Existing Client Removed - " + client.GetType().ToString());
            clientList.Remove(client);
        }
    }
}
