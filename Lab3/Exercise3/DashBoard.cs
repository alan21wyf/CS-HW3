using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class DashBoard
    {
        public static void Run()
        {
            Menu m = new Menu();
            int choice = (int)MenuOption.Exit;
            HouseholdAccounts acc = new HouseholdAccounts();
            do
            {
                Console.Clear();
                choice = m.Print(typeof(MenuOption));
                acc.Execute(choice);
            } while (choice != (int)MenuOption.Exit);
        }
    }
}
