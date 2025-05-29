using System.IO;
using GraphPathFinderCli.Graph;

namespace GraphPathFinderCli.Utils;

public class MapLoader
{
    public static GridMap Load(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException($"Map file not found: {filePath}");

        var lines = File.ReadAllLines(filePath);
        var height = lines.Length;
        var width = lines[0].Length;

        var nodes = new Node[height, width];
        Node? start = null;
        Node? end = null;

        for (var y = 0; y < height; y++)
        {
            var line = lines[y];
            if (line.Length != width)
                throw new InvalidDataException("All lines must be the same length.");

            for (var x = 0; x < width; x++)
            {
                char symbol = line[x];
                bool walkable = symbol != '#';
                int cost = symbol switch
                {
                    '.' => 1,
                    'S' => 1,
                    'E' => 1,
                    _ => 1
                };

                var node = new Node(x, y, walkable, cost, symbol);
                nodes[y, x] = node;

                if (symbol == 'S') start = node;
                if (symbol == 'E') end = node;
            }
        }

        if (start is null || end is null)
            throw new InvalidDataException("Map must contain one 'S' (start) and one 'E' (end).");

        return new GridMap(nodes, start, end);
    }
}