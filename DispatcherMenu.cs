using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MCCL7
{
    class DispatcherMenu : IMenu
    {
        IDispatcher dispatcher;
        public DispatcherMenu(IDispatcher dispatcher)
        {
            this.dispatcher = dispatcher;
        }
        public void Run()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("                              |----------------------------------------|");
                Console.WriteLine("                              |      'DISPATCHER MENU IS OPENED'       |");
                Console.WriteLine("                              |----------------------------------------|");
                Console.WriteLine("                              | ~ CREATE FLIGHT                        |");
                Console.WriteLine("                              | ~ GET FLIGHTS                          |");
                Console.WriteLine("                              | ~ FIND FLIGHT BY 'ID'                  |");
                Console.WriteLine("                              | ~ DELETE FLIGHT                        |");
                Console.WriteLine("                              | ~ EXIT                                 |");
                Console.WriteLine("                              |----------------------------------------|");
                
                int menuNumber = Convert.ToInt32(Console.ReadLine());

                switch (menuNumber)
                {
                    case 1:
                        dispatcher.CreateFlight();
                        break;

                    case 2:
                        Console.WriteLine("                              ----------------------------------------------------------------------------");
                        dispatcher.GetFlights();

                        Console.WriteLine("");
                        break;
                    case 3:

                        dispatcher.GetFlightById();
                        Console.WriteLine("                              ----------------------------------------------------------------------------");
                        Console.WriteLine("");
                        break;

                    case 4:
                        dispatcher.DeleteFlight();
                        break;

                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("CHOOSE ONE OF THE POINTS BELOW");
                        break;
                }
            }
        }
    }
}