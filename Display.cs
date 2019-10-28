using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows;


namespace Pathfinding_Visualizer {
    public partial class Display : Form {

        public static HashSet<Node> nodes = new HashSet<Node>();
        public static Node startNode = new Node(1, 1, "start");
        public static Node endNode = new Node(9, 9, "end");
        public static int gridSize = 20;
        public static int canvasWidth = Screen.PrimaryScreen.WorkingArea.Width - 20;
        public static int canvasHeight = Screen.PrimaryScreen.WorkingArea.Height - 60;
        public static int mouseCol, mouseRow;
        static bool rmbHeld, lmbHeld;
        static string nodeType = "start";
        
        public Display() {
            InitializeComponent();
            canvas.MouseMove += new MouseEventHandler(Canvas_MouseMove);
            canvas.MouseUp += new MouseEventHandler(Canvas_MouseUp);
            canvas.MouseDown += new MouseEventHandler(Canvas_MouseDown);
        }

        private void Form1_Load(object sender, EventArgs e) {
            for (int i = 0; i < (canvasWidth / gridSize); i++) {
                for (int j = 0; j < (canvasHeight / gridSize); j++) {
                    nodes.Add(new Node(i, j, "empty"));
                }
            }
            nodes.Add(startNode);
            nodes.Add(endNode);
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {

        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e) {
            switch(e.Button) {
                case MouseButtons.Left: lmbHeld = false; break;
                case MouseButtons.Right: rmbHeld = false; break;
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e) {
            mouseCol = (e.Location.X / gridSize);
            mouseRow = (e.Location.Y / gridSize);

            var nodeObj = nodes.Where(i => i.GetCol() == mouseCol && i.GetRow() == mouseRow);
            List<Node> nodesList = nodeObj.ToList();
            
            if (lmbHeld && nodesList.Count > 0) {
                Node node = nodesList[0];
                if (nodeType == "start" ) {
                    startNode.SetCell(node.GetCol(), node.GetRow());
                }
                else if (nodeType == "end") {
                    endNode.SetCell(node.GetCol(), node.GetRow());
                }
                else {
                    Node n = nodesList[0];
                    n.SetNodeType("wall");
                    Console.WriteLine(n.GetCol() + ", " + n.GetRow() + " set to wall");
                }
            }

            if (rmbHeld) {
                if (nodesList.Count > 0) {
                    Node n = nodesList[0];
                    if (n.GetNodeType() != "empty") n.SetNodeType("empty");
                    Console.WriteLine(n.GetCol() + ", " + n.GetRow() + " set to empty");
                }
            }

            canvas.Invalidate();
            canvas.Update();
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e) {
            var node = nodes.Where(i => i.GetCol() == mouseCol && i.GetRow() == mouseRow);
            List<Node> nodesList = node.ToList();

            if (nodesList.Count > 0) {
                Node n = nodesList[0];

                if (e.Button == MouseButtons.Left) {
                    lmbHeld = true;
                    switch (nodeType) {
                        case "start": startNode.SetCell(n.GetCol(), n.GetRow()); break;
                        case "end": endNode.SetCell(n.GetCol(), n.GetRow()); break;
                        default: n.SetNodeType("wall"); break;
                    }
                    Console.WriteLine(n.GetCol() + ", " + n.GetRow() + " set to " + nodeType);
                }

                else if (e.Button == MouseButtons.Right) {
                    rmbHeld = true;
                    string type = n.GetNodeType();
                    if (type == "wall" && type != "empty") {
                        n.SetNodeType("empty");
                        Console.WriteLine(n.GetCol() + ", " + n.GetRow() + " set to empty");
                    }
                }
            }
            canvas.Invalidate();
            canvas.Update();
        }

        private void START_Click(object sender, EventArgs e) {
            AStar.Start();
        }

        private void CheckedChanged(object sender, EventArgs e) {
            ToolStripMenuItem changedItem = sender as ToolStripMenuItem;
            ToolStripItemCollection items = changedItem.GetCurrentParent().Items;
            for (int i = 0; i < items.Count; i++) {
                ToolStripMenuItem item = items[i] as ToolStripMenuItem;
                if (item == changedItem) item.Checked = true;
                else item.Checked = false;
            }
            nodeType = changedItem.AccessibleName;
        }

        private void Canvas_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Brushes.Black);
           
            for (int i = -1; i < canvasWidth; i += gridSize) {
                g.FillRectangle(pen.Brush, i, 0, 1, canvasHeight);
            }
            for (int i = -1; i < canvasHeight; i += gridSize) {
                g.FillRectangle(pen.Brush, 0, i, canvasWidth, 1);
            }

            foreach (Node n in nodes) {
                string type = n.GetNodeType();
                switch (type) {
                    case "wall": pen.Brush = Brushes.Black; break;
                    case "empty": pen.Brush = Brushes.LightGray; break;
                    case "start": pen.Brush = Brushes.ForestGreen; break;
                    case "end": pen.Brush = Brushes.IndianRed; break;
                }
                g.FillRectangle(pen.Brush, n.GetX(), n.GetY(), gridSize - 1, gridSize - 1);
            }
            
            
            

        }
    }
}
