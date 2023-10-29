using System;
using System.Numerics;

namespace Task3;
public class Quaternion
{
    private float w;
    private float x;
    private float y;
    private float z;

    public Quaternion(float w, float x, float y, float z)
    {
        this.w = w;
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public float W { get { return w; } }
    public float X { get { return x; } }
    public float Y { get { return y; } }
    public float Z { get { return z; } }

    public static Quaternion operator +(Quaternion a, Quaternion b)
    {
        return new Quaternion(a.w + b.w, a.x + b.x, a.y + b.y, a.z + b.z);
    }

    public static Quaternion operator -(Quaternion a, Quaternion b)
    {
        return new Quaternion(a.w - b.w, a.x - b.x, a.y - b.y, a.z - b.z);
    }

    public static Quaternion operator *(Quaternion a, Quaternion b)
    {
        float newW = a.w * b.w - a.x * b.x - a.y * b.y - a.z * b.z;
        float newX = a.w * b.x + a.x * b.w + a.y * b.z - a.z * b.y;
        float newY = a.w * b.y - a.x * b.z + a.y * b.w + a.z * b.x;
        float newZ = a.w * b.z + a.x * b.y - a.y * b.x + a.z * b.w;

        return new Quaternion(newW, newX, newY, newZ);
    }

    public float Norm()
    {
        return (float)Math.Sqrt(w * w + x * x + y * y + z * z);
    }

    public Quaternion Сoupled()
    {
        return new Quaternion(w, -x, -y, -z);
    }

    public Quaternion Inverted()
    {
        float norm = Norm();
        float normSquared = norm * norm;
        Quaternion coupled = Сoupled();
        return new Quaternion(coupled.w / normSquared, coupled.x / normSquared, coupled.y / normSquared, coupled.z / normSquared);
    }

    public static bool operator ==(Quaternion a, Quaternion b)
    {
        return a.w == b.w && a.x == b.x && a.y == b.y && a.z == b.z;
    }

    public static bool operator !=(Quaternion a, Quaternion b)
    {
        return !(a == b);
    }

    //
    // конвертація кватерніона в матрицю обертання та навпаки
    //


}

