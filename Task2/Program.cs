using System;
using System.Text;

namespace Task2;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        int resultInt = MathOperations.Add(5, 3);
        Console.WriteLine("Додавання цілих чисел: " + resultInt);

        double resultDouble = MathOperations.Add(2.5, 3.7);
        Console.WriteLine("Додавання дійсних чисел: " + resultDouble);

        int[] array1 = new int[] { 1, 2, 3 };
        int[] array2 = new int[] { 4, 5, 6 };
        int[] resultIntArray = MathOperations.Add(array1, array2);
        Console.WriteLine("Додавання масивів цілих чисел: " + string.Join(", ", resultIntArray));

        double[] doubleArray1 = new double[] { 1.1, 2.2, 3.3 };
        double[] doubleArray2 = new double[] { 4.4, 5.5, 6.6 };
        double[] resultDoubleArray = MathOperations.Add(doubleArray1, doubleArray2);
        Console.WriteLine("Додавання масивів дійсних чисел: " + string.Join(", ", resultDoubleArray));

        int subtractResult = MathOperations.Subtract(10, 5);
        Console.WriteLine("Віднімання цілих чисел: " + subtractResult);

        double subtractDoubleResult = MathOperations.Subtract(7.5, 3.2);
        Console.WriteLine("Віднімання дійсних чисел: " + subtractDoubleResult);

        int multiplyResult = MathOperations.Multiply(5, 4);
        Console.WriteLine("Множення цілих чисел: " + multiplyResult);

        double multiplyDoubleResult = MathOperations.Multiply(2.5, 3.0);
        Console.WriteLine("Множення дійсних чисел: " + multiplyDoubleResult);

        Console.ReadLine();
    }
}

