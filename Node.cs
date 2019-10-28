using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinding_Visualizer {
    public class Node {

        public Node parent;

        private readonly string[] types = { "start", "end", "wall", "empty", "path" };
        private string type;

        private int col;
        private int row;
        private int x;
        private int y;

        public double gCost; //dist to start node
        public double hCost; //dist to end node
        public double fCost; //gCost + hCost
        
        public Node(int column, int row, string nodeType) {
            if (nodeType == null) throw new ArgumentNullException();
            else if (!types.Contains(nodeType)) throw new ArgumentException("invalid node type");
            this.col = column;
            this.x = column * Display.gridSize;
            this.y = row * Display.gridSize;
            this.row = row;
            this.type = nodeType;
            if (this.type != "start" && this.type != "end") {
                this.gCost = GetDistance(this, Display.startNode);
                this.hCost = GetDistance(this, Display.endNode);
                this.fCost = gCost + hCost;
            }
            this.parent = this;
        }

        public int GetX() {
            return this.col * Display.gridSize;
        }

        public int GetY() {
            return this.row * Display.gridSize;
        }

        public int GetCol() {
            return this.col;
        }

        public int GetRow() {
            return this.row;
        }

        public int[] GetCell() {
            int[] pos = new int[2] { this.GetCol(), this.GetRow() };
            return pos;
        }

        public string GetNodeType() {
            return this.type;
        }

        public List<Node> GetNeighbors() {
            var nodeObj = Display.nodes.Where(i => i.GetCol() - this.col < 2 && i.GetCol() - this.col > -2 && i.GetRow() - this.row < 2 && i.GetRow() - this.row > -2);
            List<Node> neighbors = nodeObj.ToList();
            neighbors.Remove(this);
            return neighbors;
        }

        public double GetDistance(Node node, Node otherNode) {
            double x = otherNode.GetX() - node.GetX();
            double y = otherNode.GetY() - node.GetY();
            x *= x;
            y *= y;
            double dist = Math.Sqrt(x + y);
            return dist;
        }

        public void SetCell(int col, int row) {
            if (col < 0 || col > Display.canvasWidth || row < 0 || row > Display.canvasHeight) throw new ArgumentOutOfRangeException();
            this.col = col;
            this.row = row;
        }

        public void SetNodeType(string nodeType) {
            if (nodeType == null) throw new ArgumentNullException();
            else if (!types.Contains(nodeType)) throw new ArgumentException("invalid node type");
            this.type = nodeType;
        }

        

    }
}
