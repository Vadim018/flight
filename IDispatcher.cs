using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MCCL7
{
    interface IDispatcher
    {
        void CreateFlight();
        void GetFlights();
        void GetFlightById();
        void DeleteFlight();
    }
}