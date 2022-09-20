using System;


namespace Lesson2_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string login = "YBekova";
            string password = "19900624";
            
            Console.WriteLine("Enter correct login and password");

            for (int attempts = 1; attempts < 4; attempts++)
            {


                Console.Write("Enter the login: ");
                string enteredLogin = Console.ReadLine();
                Console.Write("Enter the password: ");
                string enteredPassword = Console.ReadLine();
                bool clearLogin = false;
                clearLogin = Equals(enteredLogin, login);
                bool clearPassword = false;
                clearPassword = Equals(enteredPassword, password);

                if (attempts < 3 && (!clearLogin || !clearPassword))
                {
                    Console.WriteLine("Wrong login or password, try again.");
                }
                else if (attempts == 3 && (!clearLogin || !clearPassword)) 
                {
                    Console.WriteLine("You've used all your attempts. Good bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Welcome!");
                    break;
                }
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}