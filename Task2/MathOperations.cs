namespace Task2;

using System;

public class MathOperations
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static int[] Add(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            throw new ArgumentException("Масиви повині мати однакову довжину!");
        }

        int[] result = new int[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] + array2[i];
        }
        return result;
    }

    public static double[] Add(double[] array1, double[] array2)
    {
        if (array1.Length != array2.Length)
        {
            throw new ArgumentException("Масиви повині мати однакову довжину!");
        }

        double[] result = new double[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] + array2[i];
        }
        return result;
    }

    //
    // код для роботи з матрицями, тензорами, тощо.
    //

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }
}
