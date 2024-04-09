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
                    customerRegistration.RegisterMenu()
                    break;
                case 2:
                    customerLogin.Login();
                    break;
                default:
                    break;

            }

        }
        public void CustomerMenu()
        {
            System.Console.WriteLine("1. signin\n2. Sign-up");

        }

        public void AdminMenu()
        {

        }
    }
}