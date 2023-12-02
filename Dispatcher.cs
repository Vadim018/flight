using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MCCL7
{
    class Dispatcher : IDispatcher
    {
        IDBItem<Flight> dbFlight;
        public Dispatcher(IDBItem<Flight> dbFlight)
        {
            this.dbFlight = dbFlight;
        }
        public void CreateFlight()
        {
            Console.WriteLine("                              |----------------------------------------*");
            Console.Write("                              |NUMBER - ");
            string number = Console.ReadLine();

            Console.Write("                              |TO - ");
            string to = Console.ReadLine();

            Console.Write("                              |FROM - ");
            string from = Console.ReadLine();

            Console.Write("                              |DATE - ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("                              |----------------------------------------*");
            Console.WriteLine();
            
            Flight flight = new Flight(number, to, from, date);
            dbFlight.AddItem(flight);
        }
        public void GetFlights()
        {
            foreach (Flight f in dbFlight.Items)
            {
                Console.WriteLine(f);
                Console.WriteLine("                              ----------------------------------------------------------------------------");
            }
        }
            public void DeleteFlight()
        {
            Console.WriteLine("                              |----------------------------------------|");
            Console.WriteLine("                              |           ENTER ID TO DELETE           |");
            int d = Convert.ToInt32(Console.ReadLine());

            Flight flight = dbFlight.FindById(d);
            bool deletedflight = dbFlight.Delete(flight);

            Console.WriteLine("                              ******************************************");
            Console.WriteLine("                              *****        FLIGHT IS DELETED       *****");
            Console.WriteLine("                              ******************************************");
            Console.WriteLine("");
        }
            public void GetFlightById()
        {
            Console.WriteLine("                              |----------------------------------------|");
            Console.WriteLine("                              | ВВЕДІТЬ 'ID' РЕЙСА, ЯКИЙ ТРЕБА ЗНАЙТИ! |");

            int c = Convert.ToInt32(Console.ReadLine());

            Flight foundFlight = dbFlight.FindById(c);

            Console.WriteLine("                              ----------------------------------------------------------------------------");
            Console.WriteLine(foundFlight);
        }
    }
}