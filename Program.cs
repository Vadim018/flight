/*
-------------------------------------------------------------------------------------------------------------------------------------
Завдання MCCL7
-------------------------------------------------------------------------------------------------------------------------------------
Створити в окремому класі колекцію об'єктів класу Flight та вивести інформацію щодо колекції на консоль. Клас повинен мати такі поля: 
'Id' 'Number' 'From' 'To' 'Date'
Окремий клас повинен мати інтерфейс та такі методи:
 * додавання елемента до колекції;
 * отримання всіх елементів з колекції;
 * пошук елемента по 'Id';
 * видалення елемента з колекції.
Створити окремий клас Dispatcher з інтерфейсом, методи якого використовують методи класу з колекцією.
Створити дворівневе меню: MainMenu та DispatcherMenu. 
Кожне меню в окремому класі.
-------------------------------------------------------------------------------------------------------------------------------------
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MCCL7
{
    class Program
    {
       public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            IDBItem<Flight> dbFlight = new DBItem<Flight>();
       
            Flight flight1 = new Flight("103355", "KYIV", "PARIS", new DateTime(2023, 2, 1, 10, 00, 00));
            dbFlight.AddItem(flight1);

            Flight flight2 = new Flight("104536", "LVIV", "KRAKIV", new DateTime(2023, 3, 1, 11, 30, 00));
            dbFlight.AddItem(flight2);

            Flight flight3 = new Flight("105211", "KYIV", "BERLIN", new DateTime(2023, 4, 1, 15, 00, 00));
            dbFlight.AddItem(flight3);

            IDispatcher dispatcher = new Dispatcher(dbFlight);

            IMenu dispatcherMenu = new DispatcherMenu(dispatcher);

            IMenu mainMenu = new MainMenu(dispatcherMenu);

            mainMenu.Run();

            Console.ReadKey(); // завершує роботу програми
        }
    }
}