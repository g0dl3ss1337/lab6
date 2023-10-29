using System;
using System.Numerics;
using System.Text;

namespace Task3;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Quaternion q1 = new Quaternion(1, 2, 3, 4);
        Quaternion q2 = new Quaternion(5, 6, 7, 8);

        Console.WriteLine("Кватерніон 1: " + q1.W + " + " + q1.X + "i + " + q1.Y + "j + " + q1.Z + "k");
        Console.WriteLine("Кватерніон 2: " + q2.W + " + " + q2.X + "i + " + q2.Y + "j + " + q2.Z + "k \n");


        // Додавання
        Quaternion sum = q1 + q2;
        Console.WriteLine("Сума кватерніонів: " + sum.W + " + " + sum.X + "i + " + sum.Y + "j + " + sum.Z + "k\n");

        // Віднімання
        Quaternion difference = q1 - q2;
        Console.WriteLine("Різниця кватерніонів: " + difference.W + " + " + difference.X + "i + " + difference.Y + "j + " + difference.Z + "k\n");

        // Множення
        Quaternion product = q1 * q2;
        Console.WriteLine("Добуток кватерніонів: " + product.W + " + " + product.X + "i + " + product.Y + "j + " + product.Z + "k\n");

        // Норма
        float norm = q1.Norm();
        Console.WriteLine("Норма кватерніону 1: " + norm +"\n");

        // Спряжений кватерніон
        Quaternion conjugate = q1.Сoupled();
        Console.WriteLine("Спряжений кватерніон 1: " + conjugate.W + " + " + conjugate.X + "i + " + conjugate.Y + "j + " + conjugate.Z + "k\n");

        // Інверсний кватерніон
        Quaternion inverse = q1.Inverted();
        Console.WriteLine("Інверсний кватерніон 1: " + inverse.W + " + " + inverse.X + "i + " + inverse.Y + "j + " + inverse.Z + "k\n");

        // Перевірка на рівність
        bool areEqual = q1 == q2;
        Console.WriteLine("Кватерніон 1 і кватерніон 2 рівні: " + areEqual);


        //  Конвертація кватерніону в матрицю обертання

        //  Конвертація з матриці обертання
    }
}

