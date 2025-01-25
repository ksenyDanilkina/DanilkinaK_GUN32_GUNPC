int[] fibonacciNumbers = { 0, 1, 1, 2, 3, 5, 8, 13 };
string[] monthsName = {"January", "February", "March", "April", "May", "June", "July", "August", "September",
    "October","November", "December"};

int[,] numbers = new int[3, 3]{
    {2,3,4},
    {4,9,16},
    {8,27,64}
};

double[][] doubleArray = [
    [1,2,3,4,5],
    [Math.E, Math.PI],
    [Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000)]
];

int[] array = { 1, 2, 3, 4, 5 };
int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
Array.Copy(array, 0, array2, 0, 3);
Array.ForEach(array2, Console.WriteLine);

Array.Resize(ref array, array.Length * 2);
Array.ForEach(array, Console.WriteLine);
