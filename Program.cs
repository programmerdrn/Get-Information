namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter Your Username");
            string username = Console.ReadLine();
            while (true)
            {
                if (username.Length >= 3 && username.Length <= 7)
                {
                    //Console.WriteLine("Enter Pasword:");
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Try Agine User Name Between 3 to 7 Chracters:");
                    username = Console.ReadLine();
                }
            }

            string password;
            while (true)
            {
                Console.WriteLine("Enter Your Password:");
                password = Console.ReadLine();

                if (IsNumeric(password))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Just Number:");
                }
            }

            Console.WriteLine("Enter Your PhonNumber");
            string phonNumber = Console.ReadLine();
            while (true)
            {
                if (phonNumber.Length == 11)
                {
                    Console.WriteLine("Valid Count!");
                }
                else
                {
                    Console.WriteLine("Invalid Count!");
                }
                break;
            }

            Console.WriteLine("Successfully Registered");
            Console.WriteLine("You Username: " + username + "\nYour Password: " + password);
        }
        static bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c)) { return false; }
            }
            return true;
        }
    }
}
