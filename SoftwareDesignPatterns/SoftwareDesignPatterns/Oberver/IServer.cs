using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Oberver
{
    public interface IServer
    {
        void AddClients(IClient client);

        void RemoveClient(IClient client);

        void NotifyClient(string message);

    }
}
