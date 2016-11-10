using System;
using SoftwareDesignPatterns.Decorator;
using SoftwareDesignPatterns.Oberver;
using SoftwareDesignPatterns.Command;

namespace Output
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandPattern();

            //DecoratorPattern();

            //ObserverPattern();
        }

        static void CommandPattern()
        {
            Waiter waiter = new Waiter();

            Pizza pizza1 = new Pizza(new string[1] { "cheese" });
            PizzaCommand pizzaCommand1 = new PizzaCommand(pizza1);
            waiter.AddOrder(pizzaCommand1);

            Steak steak = new Steak(Steak.SteakType.TBone, Steak.SteakPreperation.WellDone);
            SteakCommand steakCommand = new SteakCommand(steak);
            waiter.AddOrder(steakCommand);

            Wings wing1 = new Wings(Wings.WingFlavor.BBQ, 10);
            WingsCommand wingsCommand1 = new WingsCommand(wing1);
            waiter.AddOrder(wingsCommand1);

            Pizza pizza2 = new Pizza(new string[4] { "chicken", "bacon","ham","pepperoni" });
            PizzaCommand pizzaCommand2 = new PizzaCommand(pizza2);
            waiter.AddOrder(pizzaCommand2);

            Wings wing2 = new Wings(Wings.WingFlavor.HotGarlic,20);
            WingsCommand wingsCommand2 = new WingsCommand(wing2);
            waiter.AddOrder(wingsCommand2);

            Wings wing3 = new Wings(Wings.WingFlavor.SweetChili, 10);
            WingsCommand wingsCommand3 = new WingsCommand(wing3);
            waiter.AddOrder(wingsCommand3);

            waiter.ExecuteOrder();

            Console.WriteLine("**********************");
            Console.ReadLine();


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

            LightsDecorator d1 = new LightsDecorator();
            TopperDecorator d2 = new TopperDecorator();

            d1.AddTreeDecoration(treeA);
            d2.AddTreeDecoration(d1);
            Console.WriteLine(d2.Display());

            Console.WriteLine("**********");

            IChristmasTree treeB = new WhiteChristmasTree();
           
            TopperDecorator d3 = new TopperDecorator();
            GiftDecorator d4 = new GiftDecorator();

            d3.AddTreeDecoration(treeB);
            d4.AddTreeDecoration(treeB);
            Console.WriteLine(d4.Display());

            Console.WriteLine("**********");

            Console.ReadLine();
        }
    }
}
