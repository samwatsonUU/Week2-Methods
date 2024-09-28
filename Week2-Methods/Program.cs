
CreateMenu();

void CreateMenu()
{

    try
    {

        // Construct the menu
        Console.Clear();
        Console.WriteLine("Main Menu");
        Console.WriteLine("1. Say Hello");
        Console.WriteLine("2. Add Numbers");
        Console.WriteLine("3. Exit");
        Console.WriteLine("Choose an option");

        // read-in the user's choice
        string choice = Console.ReadLine();

        switch (choice)
        {

            case "1":
                SayHello();
                break;
            case "2":
                AddNumbers();
                break;
            case "3":
                Console.WriteLine("Goodbye.");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

    }
    catch (Exception ex)
    {

        Console.WriteLine($"Error. {ex.Message}");

    }

}

static void SayHello()
{

    Console.WriteLine("Hello, world!");

}

static void AddNumbers()
{

    Console.WriteLine("Enter the first number:");
    int firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the second number:");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    int result = firstNumber + secondNumber;
    Console.WriteLine($"The result is {result}");

}