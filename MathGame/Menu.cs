namespace MathGame;

public static class Menu
{
    public static string StartMenu()
    {
        string? input;

        do
        {
            Console.WriteLine("Play");
            Console.WriteLine("History");
            Console.WriteLine("Exit");

            Console.Write("Enter your choise => ");

            input = Console.ReadLine();
            if (input is null)
            {
                Console.WriteLine("Your input is incorrect");
            }
        } while (input is null);

        return input;
    }
    public static Operation ChooseOperation()
    {
        string? input;
        Operation operation;
        bool isValid;
        bool IsDefined;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Choose an operation: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter your choise => ");

            input = Console.ReadLine();
            isValid = Enum.TryParse(input, out operation);
            IsDefined = Enum.IsDefined(operation);

            if (input == string.Empty || !isValid || !IsDefined)
            {
                Console.WriteLine("Your input is incorrect");
            }
        } while (input == string.Empty || !isValid || !IsDefined);

        return operation;
    }

    public static DifficultyLevel ChooseOperationDifficulty()
    {
        string? input;
        DifficultyLevel difficultyLevel;
        bool isValid;
        bool IsDefined;

        do
        {
            Console.Clear();
            Console.WriteLine("Choose an operation difficulty level: ");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Intermediate");
            Console.WriteLine("3. Advanced");
            Console.Write("Enter your choise => ");

            input = Console.ReadLine();
            isValid = Enum.TryParse(input, out difficultyLevel);
            IsDefined = Enum.IsDefined(difficultyLevel);

            if (input == string.Empty || !isValid || !IsDefined)
            {
                Console.WriteLine("Your input is incorrect");
            }
        } while (input == string.Empty || !isValid || !IsDefined);

        return difficultyLevel;
    }
}