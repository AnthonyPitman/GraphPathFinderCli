namespace GraphPathFinderCli.Graph;

public class Node
{
    public int X { get; }
    public int Y { get; }
    public bool Walkable { get; }
    public int Cost { get; }
    public char Symbol { get; }

    public Node(int x, int y, bool walkable, int cost, char symbol)
    {
        X = x;
        Y = y;
        Walkable = walkable;
        Cost = cost;
        Symbol = symbol;
    }

    public override string ToString() => $"({X},{Y}) {Symbol}";
}