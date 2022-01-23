using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinding_Visualizer
{
    public static class Dijkstra
    {
        //gCost here is represented as the shortest length to the start node

        static List<Node> visited;
        static List<Node> unvisited;
        public static void Start()
        {
            visited = new List<Node>();
            unvisited = new List<Node>();

            foreach (Node n in Display.nodes)
            {
                unvisited.Add(n);
                n.gCost = double.MaxValue;
                n.parent = null;
            }

            Display.startNode.gCost = 0;
            Display.startNode.parent = null;
            unvisited.Add(Display.startNode);

            while (unvisited.Count > 0)
            {
                Node current = MinDist();

                if (current.Equals(Display.endNode))
                {
                    CreatePath(current);
                    return;
                }

                foreach (Node neighbor in current.GetNeighbors())
                {
                    if (!visited.Contains(neighbor) && neighbor.GetNodeType() != Node.types.wall)
                    {
                        double newCost = current.gCost + current.GetDistance(neighbor);

                        if (newCost < neighbor.gCost)
                        {
                            neighbor.gCost = newCost;
                            neighbor.parent = current;
                            neighbor.SetNodeType(Node.types.debug1);
                        }
                    }
                }

                visited.Add(current);
                unvisited.Remove(current);

                foreach(Node n in visited)
                {
                    n.SetNodeType(Node.types.debug3);
                }
            }
            
        }
        static Node MinDist()
        {
            Node n = unvisited[0];

            for (int i = 1; i < unvisited.Count; i++)
            {
                if (unvisited[i].gCost < n.gCost) n = unvisited[i];
            }

            return n;
        }

        static void CreatePath(Node n)
        {
            while (n.parent != null)
            {
                n.SetNodeType(Node.types.path);
                n = n.parent;
            }
        }
    }
}
