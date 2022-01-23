using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;


namespace Pathfinding_Visualizer
{
    public partial class Display : Form
    {
        public static int gridSize = 20;
        public static int canvasWidth = Screen.PrimaryScreen.WorkingArea.Width - 20;
        public static int canvasHeight = Screen.PrimaryScreen.WorkingArea.Height - 60;
        public static int columns = canvasWidth / gridSize;
        public static int rows = canvasHeight / gridSize;

        public static Node[,] nodes = new Node[columns, rows];
        public static Node startNode = new Node(1, 1, Node.types.start); // initial position of the start node
        public static Node endNode = new Node(10, 18, Node.types.end);   // initial position of the end node
        
        public static int mouseCol, mouseRow, clickX, clickY, mouseX, mouseY;
        static bool rmbHeld, lmbHeld;
        static Node.types nodeType = Node.types.start;

        static bool canDraw;
        static String algorithm = "A*";
        
        public Display()
        {
            InitializeComponent();
            canvas.MouseMove += new MouseEventHandler(Canvas_MouseMove);
            canvas.MouseUp += new MouseEventHandler(Canvas_MouseUp);
            canvas.MouseDown += new MouseEventHandler(Canvas_MouseDown);

            endNode.gCost = endNode.GetDistance(startNode);
            endNode.hCost = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    nodes[i, j] = new Node(i, j, Node.types.empty);
                }
            }
        }

        public void Redraw()
        {
            canvas.Invalidate();
            canvas.Update();
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left: lmbHeld = false; break;
                case MouseButtons.Right: rmbHeld = false; break;
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.Location.X;
            mouseY = e.Location.Y;
            mouseCol = mouseX / gridSize;
            mouseRow = mouseY / gridSize;

            Node node;

            canDraw = Math.Abs(mouseX - clickX) >= gridSize || Math.Abs(mouseY - clickY) >= gridSize;
            
            if (mouseCol >= 0 && mouseCol < columns && mouseRow >= 0 && mouseRow < rows)
            {
                node = nodes[mouseCol, mouseRow];

                if (lmbHeld)
                {
                    if (nodeType == Node.types.start)
                    {
                        startNode.SetCell(node.GetCol(), node.GetRow());

                    }

                    else if (nodeType == Node.types.end)
                    {
                        endNode.SetCell(node.GetCol(), node.GetRow());
                    }

                    else 
                    {
                        if (node.GetNodeType() != Node.types.wall && canDraw)
                        {
                            node.SetNodeType(Node.types.wall);
                            
                            Console.WriteLine(node.GetCol() + ", " + node.GetRow() + " set to wall");
                        }
                        
                    }
                    
                    Redraw();
                }

                if (rmbHeld)
                {
                    if (node.GetNodeType() != Node.types.empty) node.SetNodeType(Node.types.empty);
                    Redraw();
                }
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            clickX = e.X;
            clickY = e.Y;

            Node node;
            node = nodes[mouseCol, mouseRow];

            if (e.Button == MouseButtons.Left )
            {
                lmbHeld = true;
                switch (nodeType)
                {
                    case Node.types.start: startNode.SetCell(node.GetCol(), node.GetRow()); break;
                    case Node.types.end: endNode.SetCell(node.GetCol(), node.GetRow()); break;
                    default: node.SetNodeType(Node.types.wall); break;
                }
            }

            else if (e.Button == MouseButtons.Right)
            {
                rmbHeld = true;
                Node.types type = node.GetNodeType();
                if (type == Node.types.wall && type != Node.types.empty)
                {
                    node.SetNodeType(Node.types.empty);
                }
            }

            Redraw();
        }
        
        

        private void START_Click(object sender, EventArgs e)
        {
            Node.Clear();

            switch (algorithm)
            {
                case "A*": AStar.Start(); break;
                case "Dijkstra": Dijkstra.Start(); break;
            }

            Redraw();
        }

        private void STOP_Click(object sender, EventArgs e)
        {
            Node.Clear();
            Redraw();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem changedItem = sender as ToolStripMenuItem;
            ToolStripItemCollection items = changedItem.GetCurrentParent().Items;
            for (int i = 0; i < items.Count; i++)
            {
                ToolStripMenuItem item = items[i] as ToolStripMenuItem;
                if (item == changedItem) item.Checked = true;
                else item.Checked = false;
            }
            
            switch(changedItem.AccessibleName)
            {
                case "start": nodeType = Node.types.start; break;
                case "end": nodeType = Node.types.end; break;
                case "wall": nodeType = Node.types.wall; break;
                case "a*": algorithm = "A*"; break;
                case "dijkstra": algorithm = "Dijkstra"; break;
            }

            Node.Clear();
            Redraw();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Brushes.Black);

            for (int i = -1; i < canvasWidth; i += gridSize)
            {
                g.FillRectangle(pen.Brush, i, 0, 1, canvasHeight);
            }
            for (int i = -1; i < canvasHeight; i += gridSize)
            {
                g.FillRectangle(pen.Brush, 0, i, canvasWidth, 1);
            }

            foreach (Node n in nodes)
            {
                Node.types type = n.GetNodeType();
                switch (type)
                {
                    case Node.types.wall: pen.Brush = Brushes.Black; break;
                    case Node.types.empty: pen.Brush = Brushes.LightGray; break;
                    case Node.types.debug1: pen.Brush = Brushes.Orange; break;
                    case Node.types.debug2: pen.Brush = Brushes.Blue; break;
                    case Node.types.debug3: pen.Brush = Brushes.LightSteelBlue; break;
                    case Node.types.path: pen.Brush = Brushes.Yellow; break;
                }
                g.FillRectangle(pen.Brush, n.GetX(), n.GetY(), gridSize - 1, gridSize - 1);
            }

            g.FillRectangle(Brushes.ForestGreen, startNode.GetX(), startNode.GetY(), gridSize - 1, gridSize - 1);
            g.FillRectangle(Brushes.IndianRed, endNode.GetX(), endNode.GetY(), gridSize - 1, gridSize - 1);
            
        }
    }
}
