using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareDesignPatterns.Decorator;
using SoftwareDesignPatterns.Oberver;


namespace Output
{
    class Program
    {
        static void Main(string[] args)
        {
            // DecoratorPattern();

            ObserverPattern();
        }


        static void ObserverPattern()
        {
            Console.WriteLine("-----Observer Pattern-----");

            Server server = new Server();

            ClientA clientA = new ClientA();
            ClientB clientB = new ClientB();
            ClientC clientC = new ClientC();

            server.AddClients(clientA);
            server.AddClients(clientB);

            server.NotifyClient("Good Morning!");

            server.AddClients(clientC);

            server.NotifyClient("Good Afternoon!");

            server.RemoveClient(clientA);

            server.NotifyClient("Good Night!");



            Console.ReadLine();
        }


        static void DecoratorPattern()
        {
            Console.WriteLine("-----Decorator Pattern-----");

            IChristmasTree treeA = new GreenChristmasTree();
            treeA.Display();

            LightsDecorator d1 = new LightsDecorator();
            TopperDecorator d2 = new TopperDecorator();

            d1.AddTreeDecoration(treeA);
            d2.AddTreeDecoration(d1);
            Console.WriteLine(d2.Display());

            Console.WriteLine("**********");

            IChristmasTree treeB = new WhiteChristmasTree();
            treeB.Display();
            TopperDecorator d3 = new TopperDecorator();
            GiftDecorator d4 = new GiftDecorator();

            d3.AddTreeDecoration(treeB);
            d4.AddTreeDecoration(d3);
            Console.WriteLine(d4.Display());

            Console.WriteLine("**********");

            Console.ReadLine();
        }
    }
}
