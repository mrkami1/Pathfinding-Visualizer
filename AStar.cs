using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinding_Visualizer {
    public static class AStar {

        public static List<Node> foundPath = new List<Node>();
        private static Node endNode = Display.endNode;
        private static Node startNode = Display.startNode;
        static HashSet<Node> openNodes = new HashSet<Node>();
        static HashSet<Node> closedNodes = new HashSet<Node>();

        static AStar() {
            openNodes.Add(startNode);
        }
       
        public static void Start() {

            Node currentNode = startNode;

           for (int i = 0; i < 100; i++) {
                foreach (Node n in openNodes) {
                    if (n.fCost < currentNode.fCost || n.fCost == currentNode.fCost && n.hCost < currentNode.hCost) currentNode = n;
                }
                openNodes.Remove(currentNode);
                closedNodes.Add(currentNode);

                if (currentNode == endNode) {
                    Console.WriteLine("finished");
                    break;
                }

                foreach (Node neighbor in currentNode.GetNeighbors()) {
                    if (neighbor.GetNodeType() == "wall" || closedNodes.Contains(neighbor)) continue;

                    double newCost = currentNode.gCost + currentNode.GetDistance(currentNode, neighbor);
                    if (newCost < neighbor.gCost || !openNodes.Contains(neighbor)) {
                        neighbor.gCost = newCost;
                        neighbor.hCost = neighbor.GetDistance(neighbor, endNode);
                        neighbor.fCost = neighbor.gCost + neighbor.gCost;
                        neighbor.parent = currentNode;

                        if (!openNodes.Contains(neighbor)) openNodes.Add(neighbor);
                    }
                }

            }
            Console.WriteLine("finished");
            CreatePath();
        }

        static void CreatePath() {
            List<Node> path = new List<Node>();
            Node currentNode = endNode;

            while (currentNode != startNode) {
                path.Add(currentNode);
                currentNode = currentNode.parent;
            }

            path.Reverse();
            foundPath = path;
            Console.WriteLine("helloo");
            foreach(Node n in foundPath) {
                Console.WriteLine(n.GetCell());
            }
        }
    }
}
