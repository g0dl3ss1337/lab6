namespace Task1;

public class Human
{
    public int Speed { get; set; }

    public Human(int speed)
    {
        Speed = speed;
    }

    public void Move()
    {
        Console.WriteLine("Людина рухается пішки.");
    }
}
