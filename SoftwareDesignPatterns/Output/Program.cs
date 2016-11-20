using System;
using SoftwareDesignPatterns.Decorator;
using SoftwareDesignPatterns.Oberver;
using SoftwareDesignPatterns.Command;
using SoftwareDesignPatterns.Adapter;
using SoftwareDesignPatterns.Builder;
using SoftwareDesignPatterns.Factory;
using SoftwareDesignPatterns.Template;
using SoftwareDesignPatterns.Proxy;

namespace Output
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProxyPattern();

            TemplatePattern();

            //FactoryPattern();

            //BuilderPattern();

            //AdapterPattern();

            //CommandPattern();

            //DecoratorPattern();

           // ObserverPattern();
        }

        static void ProxyPattern()
        {
            Console.WriteLine("Proxy Pattern");
            Console.WriteLine("---------------");

            IReal real = new Proxy();
            real.ProcessRequest("Hello World!");


            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("**********************");
            Console.ReadLine();

        }

        static void TemplatePattern()
        {
            Console.WriteLine("Template Pattern");
            Console.WriteLine("---------------");

            Console.WriteLine("*****ATM - Deposit Transaction*****");
            ATM deposit = new DepositTransaction();
            deposit.PerformTransaction();

            Console.WriteLine("*****ATM - Withdrawal Transaction*****");
            ATM withdraw = new WithdrawalTranaction();
            withdraw.PerformTransaction();
    

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("**********************");
            Console.ReadLine();

        }

        static void FactoryPattern()
        {
            Console.WriteLine("Factory Pattern");
            Console.WriteLine("---------------");

            IFood food;

            FoodFactory factory = new FoodFactory();

            food = factory.OrderFood("RochesterFriedChicken");
            food.GetFood();

            Console.WriteLine(Environment.NewLine);

            food = factory.OrderFood("SpicyFriedChicken");
            food.GetFood();

            Console.WriteLine(Environment.NewLine);

            food = factory.OrderFood("FriedChicken");
            food.GetFood();

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("**********************");
            Console.ReadLine();

        }

        static void BuilderPattern()
        {
            Console.WriteLine("Builder Pattern");
            Console.WriteLine("---------------");

            IBurgerBuilder chicken = new ChickenBurger();
            IBurgerBuilder beef = new BeefBurger();

            Console.WriteLine("Cooking - Chicken Burger");
            Cook cook = new Cook(chicken);
            cook.GetMeal();

            Console.WriteLine("Cooking - Beef Burger");
            cook = new Cook(beef);
            cook.GetMeal();



            Console.WriteLine("**********************");
            Console.ReadLine();

        }

        static void AdapterPattern()
        {
            Console.WriteLine("Adapter Pattern");
            Console.WriteLine("---------------");

            Analog analogValue = new Analog(new decimal(3.142));

           // Digital digitalValue = new Digital(20);            

            IAdapter adapter = new AnalogToDigitalAdapter();
            adapter.ConvertToDigital(analogValue);

            Console.WriteLine("**********************");
            Console.ReadLine();
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
