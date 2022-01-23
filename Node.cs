using System;
using System.Collections.Generic;
using System.Linq;

namespace Pathfinding_Visualizer
{
    public class Node
    {

        public Node parent;
        public enum types
        {
            start,
            end,
            wall,
            empty,
            path,
            debug1,
            debug2,
            debug3
        }
          
        private types type;

        private int col;
        private int row;

        public double gCost; //dist to start node
        public double hCost; //dist to end node
        public double fCost //gCost + hCost
        {
            get { return gCost + hCost; }
        } 

        public Node(int column, int row, types nodeType)
        {
            col = column;
            this.row = row;
            type = nodeType;
            parent = null;
        }
        public static void Clear()
        {
            foreach (Node node in Display.nodes)
            {
                if (node.GetNodeType() != Node.types.wall)
                {
                    node.SetNodeType(Node.types.empty);
                }
            }
        }
        public int GetX()
        {
            return col * Display.gridSize;
        }

        public int GetY()
        {
            return row * Display.gridSize;
        }

        public int GetCol()
        {
            return col;
        }

        public int GetRow()
        {
            return row;
        }

        public int[] GetCell()
        {
            int[] pos = new int[2] { GetCol(), GetRow() };
            return pos;
        }

        public types GetNodeType()
        {
            return type;
        }

        public List<Node> GetNeighbors()
        {
            List<Node> neighbors = new List<Node>();
            
            //uncomment these if you want diagonals in the pathfinding (it will go through corners)

            //if (col - 1 >= 0 && row - 1 >= 0)                           neighbors.Add(Display.nodes[col - 1, row - 1]);
            if (col - 1 >= 0)                                           neighbors.Add(Display.nodes[col - 1, row]);
            //if (col - 1 >= 0 && row + 1 < Display.rows)                 neighbors.Add(Display.nodes[col - 1, row + 1]);
            if (row - 1 >= 0)                                           neighbors.Add(Display.nodes[col, row - 1]);
            if (row + 1 < Display.rows)                                 neighbors.Add(Display.nodes[col, row + 1]);
            //if (col + 1 < Display.columns && row - 1 >= 0)              neighbors.Add(Display.nodes[col + 1, row - 1]);
            if (col + 1 < Display.columns)                              neighbors.Add(Display.nodes[col + 1, row]);
            //if (col + 1 < Display.columns && row + 1 < Display.rows)    neighbors.Add(Display.nodes[col + 1, row + 1]);
            
            return neighbors;
        }

        public double GetDistance(Node otherNode)
        {
            double x = otherNode.col - col;
            double y = otherNode.row - row;
            x *= x;
            y *= y;
            double dist = Math.Sqrt(x + y);
            return dist;
        }

        public void SetCell(int col, int row)
        {
            if (col < 0 || col > Display.canvasWidth || row < 0 || row > Display.canvasHeight) throw new ArgumentOutOfRangeException();
            this.col = col;
            this.row = row;
        }

        public void SetNodeType(types nodeType) 
        {
            type = nodeType;
        }

        public override string ToString()
        {
            return "Node type: " + GetNodeType() + ", x: " + GetX() + ", y: " + GetY() + ", g: " + gCost + ", h: " + hCost + ", f: " + fCost;
        }

        public bool Equals(Node other)
        {
            return other.GetCol() == col && other.GetRow() == row;
        }
    }
}
