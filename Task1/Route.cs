namespace Task1;

public class Route
{
    public string Start { get; set; }
    public string End { get; set; }

    public Route(string start, string end)
    {
        Start = start;
        End = end;
    }
}
