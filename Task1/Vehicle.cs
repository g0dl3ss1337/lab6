namespace Task1;

public abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }

    public Vehicle(int speed, int capacity)
    {
        Speed = speed;
        Capacity = capacity;
    }

    public abstract void Move();
}
