using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class HouseholdAccounts
    {
        public List<Transaction> transactions;
        public int count = 0;

        public HouseholdAccounts()
        {
            this.transactions = new List<Transaction>();
        }

        public void Execute(int choice)
        {
            switch (choice)
            {
                case (int)MenuOption.AddNewExpense:
                    this.AddTransaction();
                    break;
                case (int)MenuOption.ShowAllExpenses:
                    this.ShowExpense();
                    break;
                case (int)MenuOption.Search:
                    this.Search();
                    break;
                case (int)MenuOption.ModifyTab:
                    break;
                case (int)MenuOption.DeleteData:
                    this.Delete();
                    break;
                case (int)MenuOption.SortData:
                    Menu m = new Menu();
                    int c = (int)SortOption.Exit;
                    do
                    {
                        Console.Clear();
                        c = m.Print(typeof(SortOption));
                        this.SortData(choice);
                    } while (c != (int)SortOption.Exit);
                    break;
                case (int)MenuOption.NormalizeDescription:
                    this.NormalizeDisc();
                    break;
                default:
                    break;
            }
        }

        public void AddTransaction()
        {
            string date;
            string desc;
            string cat;
            double amount;
            bool validDate = false;
            bool validDesc = false;
            do
            {
                Console.Write("Enter the date(YYYYMMDD): ");
                date = Console.ReadLine();
                if (DateValidation(date))
                {
                    validDate = true;
                }
            } while (!validDate);
            do
            {
                Console.Write("Enter the description of Expenditure or Revenue: ");
                desc = Console.ReadLine();
                if (DescValidation(desc))
                {
                    validDesc = true;
                }
            } while (!validDesc);
            Console.Write("Enter the category of the transaction: ");
            cat = Console.ReadLine();
            Console.Write("Enter the amount of the transaction: ");
            amount = Convert.ToDouble(Console.ReadLine());
            Transaction t = new Transaction(date, desc, cat, amount);
            transactions.Add(t);
            t.number = transactions.IndexOf(t)+1;
            count += 1;
            Console.WriteLine($"New transaction (#{count}) has been added successfully.");
            Console.ReadLine();


        }

        public bool DateValidation(string date)
        {
            if (date.Length != 8)
            {
                Console.WriteLine("Wrong input format for date, please try again.");
                return false;
            }
            else
            {
                int year = Convert.ToInt32(date.Substring(0, 4));
                int month = Convert.ToInt32(date.Substring(4, 2));
                int day = Convert.ToInt32(date.Substring(6, 2));
                if ((year < 1000 || year > 3000) && (month < 1 || month > 12) && (day < 1 || day > 31))
                {
                    Console.WriteLine("Invalid input of date, please try again.");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public bool DescValidation(string desc)
        {
            if ((desc.Trim().Length == 0))
            {
                Console.WriteLine("Description cannot be empty. Please try again.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ShowExpense()
        {
            string cat;
            string start;
            string end;
            Console.Write("Enter the category you wish to show: ");
            cat = Console.ReadLine();
            Console.Write("Enter the start date you wish to search: ");
            start = Console.ReadLine();
            if (!DateValidation(start))
            {
                Console.WriteLine("You have entered invalid start date. Please try again.");
                return;
            }
            Console.Write("Enter the end date you wish to search: ");
            end = Console.ReadLine();
            if (!DateValidation(end))
            {
                Console.WriteLine("You have entered invalid end date. Please try again.");
                return;
            }
            else if (String.Compare(start, end) > 0)
            {
                Console.WriteLine("You have entered a end date that is earlier than the start date. Please try again.");
                return;
            }
            int ct = 0;
            foreach (Transaction trans in transactions)
            {
                if (trans.category == cat)
                {
                    if ((String.Compare(start, trans.date) <= 0) && (String.Compare(end, trans.date) >= 0))
                    {
                        trans.ShowData();
                        ct += 1;
                    }
                }
                else if (cat == "")
                {
                    if ((String.Compare(start, trans.date) <= 0) && (String.Compare(end, trans.date) >= 0))
                    {
                        trans.ShowData();
                        ct += 1;
                    }
                }
            }
            if (ct == 0)
            {
                Console.WriteLine("There is no transaction that meets the criteria.");
            }
            Console.ReadLine();
            Console.WriteLine($"Total amount of data displayed: {ct}.");
            Console.ReadLine();
        }



        public void Search()
        {
            bool hasData = false;
            Console.Write("Enter the keyword you wish to search: ");
            string keyword = Console.ReadLine();
            foreach (Transaction t in transactions)
            {
                if (t.category.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 || t.desc_Exp.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    t.ShowData();
                    hasData = true;
                }
            }
            if (!hasData)
            {
                Console.WriteLine($"No transaction contains the keyword {keyword}");
            }
            Console.ReadLine();
        }




        public void Delete()
        {
            Console.Write("Enter the number of the transaction you wish to delete: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool success = false;
            Transaction t = transactions.Find(x => x.number == num);
            if (t != null)
            {
                t.ShowData();
                Console.WriteLine("\nDo you wish to delete this transaction? Y/N");
                string c = Console.ReadLine();
                if (c.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    transactions.Remove(t);
                    Console.WriteLine("The transaction has been successfully deleted.");
                    success = true;
                }
                else
                {
                    Console.WriteLine("Deletion is cancelled.");
                    success = true;
                }
            }


            if (!success)
            {
                Console.WriteLine("There is no transaction having the number you entered. Please try another one.");
            }
            Console.ReadLine();
        }

        public void SortData(int choice)
        {
            switch (choice)
            {
                case (int)SortOption.ByDate:
                    transactions.Sort((x, y) => String.Compare(x.date, y.date));
                    Console.WriteLine("Data has been sorted alphabetically by date.");
                    break;
                case (int)SortOption.ByCategory:
                    transactions.Sort((x, y) => String.Compare(x.category, y.category));
                    Console.WriteLine("Data has been sorted alphabetically by category.");
                    break;
                default:
                    break;
            }
        }

        public void NormalizeDisc()
        {
            Console.Write("Enter the number of the transaction you wish to normalize: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool success = false;
            foreach (Transaction t in transactions)
            {
                if (t.number == num)
                {
                    t.desc_Exp.Trim().ToLower();
                    char.ToUpper(t.desc_Exp[0]);
                    success = true;
                }
            }

            if (!success)
            {
                Console.WriteLine("There is no transaction having the number you entered. Please try another one.");
            }

        }

    }

    class Transaction
    {
        public int number;
        public string date;
        public string desc_Exp;
        public string category;
        public double amount;
        public string year;
        public string month;
        public string day;

        public Transaction(string date, string desc, string cat, double amt)
        {
            this.date = date;
            this.year = date.Substring(0, 4);
            this.month = date.Substring(4, 2);
            this.day = date.Substring(6, 2);
            this.desc_Exp = desc;
            this.category = cat;
            this.amount = amt;
        }

        public void ShowData()
        {
            Console.WriteLine($"#{number}-{day}/{month}/{year}-{this.desc_Exp}-{this.category}-{Math.Round(this.amount, 2)}");
        }


    }
}
