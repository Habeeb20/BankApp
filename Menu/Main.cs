using OOP_Project.Menu;
using OOP_Project.Menu.customerMenu;
namespace OOP_Project.Menu
{
    public class Main
    {
        CustomerRegistration customerRegistration;

        CustomerLogin customerLogin;

        public Main()
        {
            customerRegistration = new CustomerRegistration();
            customerLogin = new CustomerLogin();
        }
        public void LandingMenu()
        {
            System.Console.WriteLine("enter 1 to go to Customer menu \n2 to main menu");
            int option;
            while(!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("invalid option");
            }
            switch (option)
            {
                case 1:
                    CustomerMenu();
                    break;
                case 2:
                    AdminMenu();
                    break;
                default:
                    break;

            }

        }
        public void CustomerMenu()
        {
            System.Console.WriteLine("1. signin\n2. Sign-up");
            int option;
            while(!int.TryParse(Console.ReadLine(), out option))
            {
                // Console.ForegroundColor = Console.DarkRed;
                System.Console.WriteLine("invalid input");
                Console.ResetColor();
            }
            switch (option)
            {
                case 1:
                    customerLogin.Login();
                    break;
                case 2:
                    customerRegistration.RegisterMenu();
                    customerLogin.Login();
                    break;
                
                default:
                    break;
            }

        }

        public void AdminMenu()
        {

        }
    }
}