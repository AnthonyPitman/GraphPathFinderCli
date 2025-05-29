using System;
using System.Collections.Generic;
using GraphPathFinderCli.Graph;

namespace GraphPathFinderCli.Utils;

public class ConsoleRenderer
{
    public static void Render(GridMap map, HashSet<Node>? visited = null, List<Node>? path = null)
    {
        Console.Clear();

        for (var y = 0; y < map.Height; y++)
        {
            for (var x = 0; x < map.Width; x++)
            {
                var node = map.Nodes[y, x];

                Console.ForegroundColor = node.Symbol switch
                {
                    '#' => ConsoleColor.DarkGray,
                    'S' => ConsoleColor.Green,
                    'E' => ConsoleColor.Red,
                    '.' => ConsoleColor.White,
                    _ => ConsoleColor.Gray
                };

                if (path?.Contains(node) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write('*');
                }
                else if (visited?.Contains(node) == true && node.Symbol != 'S' && node.Symbol != 'E')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write('+');
                }
                else
                {
                    Console.Write(node.Symbol);
                }
            }

            Console.WriteLine();
        }

        Console.ResetColor();
    }
}