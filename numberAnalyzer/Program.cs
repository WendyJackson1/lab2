
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello! What is your name?");
        string userName = Console.ReadLine();
        bool continueLoop = true;  
        int userNumber = 0;
        while (continueLoop)
        {
            while (true)
            {
                Console.WriteLine($" {userName} please enter a integer between 1 and 100.");
                int userInput = int.Parse(Console.ReadLine());
                userNumber = userInput;

                if (userNumber >= 1 && userNumber <= 100)
                {
                    Console.WriteLine($"{userName}, your number is {userNumber}");
                    break;
                }
                else
                {
                    Console.WriteLine($"{userName}, please try again.");
                }

            }
                Console.WriteLine($"{userName} you entered the number " + userNumber);
                if (userNumber % 2 != 0)
                {
                    if (userNumber > 60)
                    {
                        Console.WriteLine("Odd and greater than 60.");
                    }
                    else if (userNumber < 60)
                    {
                        Console.WriteLine($"{userName}Odd and less than 60.");
                    }

                }
                else
                {
                    if (userNumber < 25)
                    {
                        Console.WriteLine($"{userNumber} is even and less than 25 {userName}");
                    }
                    else if (userNumber >= 60)
                    {
                        Console.WriteLine($"Wow {userName}, {userNumber} is even and greater or equal to 60");
                    }
                    else
                    {
                        Console.WriteLine($"{userNumber} is even and between 26 and 60 inclusive. Good job {userName}!");
                    }
                }
            
            Console.WriteLine($"{userName} would you like to play again? press y to play again");
            string userRepsonse = Console.ReadLine().ToLower();

            if (userRepsonse == "y")
            {
                Console.WriteLine("Great!");
            }
            else
            {
                Console.WriteLine("Have a great day! Good bye!");
                continueLoop = false;
            }
        }

    }
}
