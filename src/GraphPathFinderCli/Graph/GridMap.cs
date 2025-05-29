namespace GraphPathFinderCli.Graph;

public class GridMap
{
    public Node[,] Nodes { get; }
    public Node Start { get; }
    public Node End { get; }

    public int Width => Nodes.GetLength(1);
    public int Height => Nodes.GetLength(0);

    public GridMap(Node[,] nodes, Node start, Node end)
    {
        Nodes = nodes;
        Start = start;
        End = end;
    }

    public Node? GetNode(int x, int y)
    {
        if (x < 0 || x >= Width || y < 0 || y >= Height)
        {
            return null;
        }

        return Nodes[y, x];
    }
}