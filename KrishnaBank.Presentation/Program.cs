


class Program
{
    static void Main()
    {
        // displayin title
        System.Console.WriteLine("*******Krishna Bank****************");
        System.Console.WriteLine(":: Login Page::");
        // declaring variable
        string userName = null, password = null;

        // read userName from keyboard


        System.Console.Write("Username:");
        userName = System.Console.ReadLine();

        if (userName != "")
        {
            System.Console.Write("Enter the password:");
            password = System.Console.ReadLine();


        }
        if (userName == "krishna" && password == "khanal")
        {
            int mainMenuChoice = -1;
            do
            {

                System.Console.WriteLine("\n ::Main Menu::");
                System.Console.WriteLine("1.Customers");
                System.Console.WriteLine("2.Accounts");
                System.Console.WriteLine("3.Transfer funds");
                System.Console.WriteLine("4.Funds transfer Statement");
                System.Console.WriteLine("5.Account Statement");
                System.Console.WriteLine("0. Exit");

                System.Console.Write("Enter choice");
                mainMenuChoice = int.Parse(System.Console.ReadLine());
                switch (mainMenuChoice)
                {
                    case 1:customersMenu();
                        break;
                    case 2: // todo display accounts menu
                        break;
                    case 3: // todo display funds transfer menu
                        break;
                    case 4: // todo display funds transfer statement menu
                        break;
                    case 5: // todo display account statement menu
                        break;
                }

            } while (mainMenuChoice != 0);



        }
        else
        {
            System.Console.WriteLine("Invalid Username or password");
        }
        System.Console.WriteLine("Thank you! Visit again");
        System.Console.ReadKey();


    }

    static void customersMenu()
    {
        int customerMenuOption = -1;
        do
        {
            System.Console.WriteLine("\n ::Customers Menu::");
            System.Console.WriteLine("1.Add Customer");
            System.Console.WriteLine("2.Delete Customer");
            System.Console.WriteLine("3.Update Customer");
            System.Console.WriteLine("4.View Customer");
            System.Console.WriteLine("5.Account Statement");

            System.Console.Write("Enter Choice:");
            customerMenuOption = System.Convert.ToInt32(System.Console.ReadLine());

        }
        while (customerMenuOption != 0);

    }
}
