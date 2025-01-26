var fibonacciNumber = 0;
var nextFibonacciNumber = 1;

for (var i = 0; i < 10; i++)
{
    var fibonacciSeriesIncrement = fibonacciNumber;
    Console.WriteLine(fibonacciNumber);

    fibonacciNumber = nextFibonacciNumber;
    nextFibonacciNumber += fibonacciSeriesIncrement;
}

for (var i = 2; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

var tableSize = 5;

for (int i = 1; i <= tableSize; ++i)
{
    for (int j = 1; j <= tableSize; ++j)
    {
        var multiplicationResult = (j * i).ToString().PadLeft(3);
        Console.Write(multiplicationResult);
    }

    Console.WriteLine();
}

var password = "qwerty";
var inputPassword = string.Empty;

do
{
    Console.WriteLine("Введите пароль: ");
    inputPassword = Console.ReadLine();
}
while (inputPassword != password);

