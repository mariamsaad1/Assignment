// See https://aka.ms/new-console-template for more information
Console.Write("Enter the First Number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the Second Number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Choose an opreation (/, +, -, ): ");
        string opreation = Console.ReadLine();

        double result = 0;

     switch (opreation)
    {
        case "+":
            result = firstNumber + secondNumber;
            break;
        case "-":
            result = firstNumber - secondNumber;
            break;
        case "":
            result = firstNumber * secondNumber;
            break;
        case "/":
            if (secondNumber != 0)
            {
                result = (double)firstNumber / secondNumber; 
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return;
            }
            break;
        default:
            Console.WriteLine("Invalid operation.");
            return;
    }
    Console.WriteLine();
    Console.WriteLine($"Result: {firstNumber} {opreation} {secondNumber} = {result}");
