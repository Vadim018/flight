using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MCCL7
{
    class MainMenu : IMenu
    {
        IMenu dispatcherMenu;
        public MainMenu(IMenu dispatcherMenu)
        {
            this.dispatcherMenu = dispatcherMenu;
        }
        public void Run()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                              ******************************************");
                Console.WriteLine("                              **WELCOME TO THE AIRLINE COMPANY 'POLIT'**");
                Console.WriteLine("                              ******************************************");
                Console.WriteLine("                              |----------------------------------------|");
                Console.WriteLine("                              |               'MAIN MENU'              |");
                Console.WriteLine("                              |----------------------------------------|");
                Console.WriteLine("                              | ~ DISPATCHER MENU                      |");
                Console.WriteLine("                              | ~ EXIT                                 |");
                Console.WriteLine("                              |----------------------------------------|");

                int menuNumber = Convert.ToInt32(Console.ReadLine());

                switch (menuNumber)
                {
                    case 1:
                        dispatcherMenu.Run();
                        break;  
                    case 2:
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