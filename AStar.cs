using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace Pathfinding_Visualizer
{
    public static class AStar
    {

        private static Node endNode = Display.endNode;
        private static Node startNode = Display.startNode;
        static List<Node> openNodes = new List<Node>();
        static List<Node> closedNodes = new List<Node>();

        public static void Start()
        {
            openNodes.Clear();
            closedNodes.Clear();
            openNodes.Add(startNode);

            startNode.gCost = 0;
            startNode.hCost = startNode.GetDistance(endNode);

            while (openNodes.Count > 0)
            {
                Node current = openNodes[0];
                
                for (int i = 1; i < openNodes.Count; i++)
                {
                    if (openNodes[i].fCost < current.fCost || openNodes[i].fCost == current.fCost && openNodes[i].hCost < current.hCost)
                    {
                        current = openNodes[i];
                    }
                }

                if (current.Equals(endNode))
                {
                    CreatePath(current);
                    return;
                }

                openNodes.Remove(current);
                closedNodes.Add(current);

                foreach (Node neighbor in current.GetNeighbors())
                {
                    if (closedNodes.Contains(neighbor) || neighbor.GetNodeType() == Node.types.wall)
                    {
                        continue;
                    }

                    double newGCost = current.gCost + current.GetDistance(neighbor);

                    if (!openNodes.Contains(neighbor) || newGCost < neighbor.gCost)
                    {
                        neighbor.parent = current;
                        neighbor.gCost = newGCost;
                        neighbor.hCost = neighbor.GetDistance(endNode);
                        
                        if (!openNodes.Contains(neighbor)) openNodes.Add(neighbor);
                    }
                }

                for (int i = 0; i < openNodes.Count; i++)
                {
                    openNodes[i].SetNodeType(Node.types.debug1);
                    
                }
                for (int i = 0; i < closedNodes.Count; i++)
                {
                    closedNodes[i].SetNodeType(Node.types.debug3);
                    
                }
            }
        }

        static void CreatePath(Node current)
        {
            List<Node> path = new List<Node>();

            while (current.parent != null)
            {
                path.Add(current);
                current = current.parent;
            }

            for (int i = 0; i < path.Count; i++)
            {
                path[i].SetNodeType(Node.types.path);
            }
        }
    }
}
