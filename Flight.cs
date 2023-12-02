using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace MCCL7
{
    class Flight : IID
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public DateTime Date { get; set; }
        public Flight(string number, string to, string from, DateTime date)
        {
            Number = number;
            To = to;
            From = from;
            Date = date;
        }
        public override string ToString()
        {
            Console.WriteLine("                              |НОМЕР РЕЙСУ| |МІСТО-ПРИЗНАЧЕННЯ| |МІСТО-ВІДПРАВЛЕННЯ| |ДАТА РЕЙСУ| |ЧАС|");
            return String.Format("                            " + "     " + Number + "            " + To + "               " + From + "          " + Date);
        }
    }
}