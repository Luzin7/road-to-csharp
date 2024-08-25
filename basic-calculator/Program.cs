int n1, n2, result = 0;
string operation;

Console.Write("Enter first number: ");
n1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
n2 = int.Parse(Console.ReadLine());

Console.Write("Enter an operator (+, -, *, /): ");
operation = Console.ReadLine();

switch (operation)
{ 
    case "+":
        result = n1 + n2;
        break;
    case "-":
        result = n1 - n2;
        break;
    case "*":
        result = n1 * n2;
        break;
    case "/":
        if (n2 == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return;
        }
        result = n1 / n2;
        break;
    default:
        Console.WriteLine("Error: Invalid operator. Please use one of the following: +, -, *, /");
        return;
}

Console.WriteLine(result);