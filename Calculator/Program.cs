Console.WriteLine("Enter first number: ");

if (!int.TryParse(Console.ReadLine(), out var number1))
{
    Console.WriteLine("Error! Enter an integer");
    return;
}

Console.WriteLine("Enter second number: ");

if (!int.TryParse(Console.ReadLine(), out var number2))
{
    Console.WriteLine("Error! Enter an integer");
    return;
}

Console.WriteLine("Enter operator(& | or ^): ");
var operand = Console.ReadLine();

if (!(operand== "&" || operand == "|" || operand == "^"))
{
    Console.WriteLine("Error! Enter correct operator");
    return;
}

switch (operand)
{
    case "&":
        Console.WriteLine($"Result {number1}{operand}{number2} in binary: {Convert.ToString(number1&number2,2)}");
        Console.WriteLine($"Result {number1}{operand}{number2} in decimal: {Convert.ToString(number1 & number2, 10)}");
        Console.WriteLine($"Result {number1}{operand}{number2} in hexadecimal: {Convert.ToString(number1 & number2, 16)}");
        break;
    case "|":
        Console.WriteLine($"Result {number1}{operand}{number2} in binary: {Convert.ToString(number1 | number2, 2)}");
        Console.WriteLine($"Result {number1}{operand}{number2} in decimal: {Convert.ToString(number1 | number2, 10)}");
        Console.WriteLine($"Result {number1}{operand}{number2} in hexadecimal: {Convert.ToString(number1 | number2, 16)}");
        break;
    case "^":
        Console.WriteLine($"Result {number1}{operand}{number2} in binary: {Convert.ToString(number1 ^ number2, 2)}");
        Console.WriteLine($"Result {number1}{operand}{number2} in decimal: {Convert.ToString(number1 ^ number2, 10)}");
        Console.WriteLine($"Result {number1}{operand}{number2} in hexadecimal: {Convert.ToString(number1 ^ number2, 16)}");
        break;
}
