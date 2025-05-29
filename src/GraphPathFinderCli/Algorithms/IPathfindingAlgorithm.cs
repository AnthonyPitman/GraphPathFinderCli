using System.Collections.Generic;
using GraphPathFinderCli.Graph;

namespace GraphPathFinderCli.Algorithms;

public interface IPathfindingAlgorithm
{
    /// <summary>
    /// Attempts to find a path from start to end.
    /// </summary>
    /// <param name="map">The map to search.</param>
    /// <param name="visited">Optional set to record visited nodes (for visualization).</param>
    /// <returns>The path from start to end, or null if no path is found.</returns>
    List<Node>? FindPath(GridMap map, out HashSet<Node> visited);
}