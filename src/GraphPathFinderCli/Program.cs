// See https://aka.ms/new-console-template for more information

using System;
using GraphPathFinderCli.Algorithms;
using GraphPathFinderCli.Utils;

namespace GraphPathFinderCli;

public class Program
{
    public int I { get; set; }

    public Program(int i)
    {
        I = i;
    }

    static void Main(string[] args)
    {
        var map = MapLoader.Load("maps/sample_maze.txt");

        IPathfindingAlgorithm solver = new BreadthFirstSearch();

        var path = solver.FindPath(map, out var visited);

        ConsoleRenderer.Render(map, visited, path);
        Console.WriteLine(path is null
            ? "No path found."
            : $"Path found! Length: {path.Count}.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

}
