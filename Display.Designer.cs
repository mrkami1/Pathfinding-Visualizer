namespace Pathfinding_Visualizer {
    partial class Display {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.heloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolbar = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wallNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dijkstraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.Toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heloToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(98, 26);
            // 
            // heloToolStripMenuItem
            // 
            this.heloToolStripMenuItem.Name = "heloToolStripMenuItem";
            this.heloToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.heloToolStripMenuItem.Text = "helo";
            // 
            // Toolbar
            // 
            this.Toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.nodeToolStripMenuItem,
            this.sTARTToolStripMenuItem});
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(584, 24);
            this.Toolbar.TabIndex = 1;
            this.Toolbar.Text = "ToolbarStrip";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.dijkstraToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.settingsToolStripMenuItem.Text = "Algorithm";
            // 
            // nodeToolStripMenuItem
            // 
            this.nodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNodeToolStripMenuItem,
            this.endNodeToolStripMenuItem,
            this.wallNodeToolStripMenuItem});
            this.nodeToolStripMenuItem.Name = "nodeToolStripMenuItem";
            this.nodeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.nodeToolStripMenuItem.Text = "Node";
            // 
            // startNodeToolStripMenuItem
            // 
            this.startNodeToolStripMenuItem.AccessibleName = "start";
            this.startNodeToolStripMenuItem.Checked = true;
            this.startNodeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startNodeToolStripMenuItem.Name = "startNodeToolStripMenuItem";
            this.startNodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startNodeToolStripMenuItem.Text = "Start node";
            this.startNodeToolStripMenuItem.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // endNodeToolStripMenuItem
            // 
            this.endNodeToolStripMenuItem.AccessibleName = "end";
            this.endNodeToolStripMenuItem.Name = "endNodeToolStripMenuItem";
            this.endNodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.endNodeToolStripMenuItem.Text = "End node";
            this.endNodeToolStripMenuItem.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // wallNodeToolStripMenuItem
            // 
            this.wallNodeToolStripMenuItem.AccessibleName = "wall";
            this.wallNodeToolStripMenuItem.Name = "wallNodeToolStripMenuItem";
            this.wallNodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wallNodeToolStripMenuItem.Text = "Wall node";
            this.wallNodeToolStripMenuItem.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // sTARTToolStripMenuItem
            // 
            this.sTARTToolStripMenuItem.Name = "sTARTToolStripMenuItem";
            this.sTARTToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sTARTToolStripMenuItem.Text = "Run";
            this.sTARTToolStripMenuItem.Click += new System.EventHandler(this.START_Click);
            // 
            // canvas
            // 
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 24);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(584, 437);
            this.canvas.TabIndex = 2;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.AccessibleName = "a*";
            this.aToolStripMenuItem.Checked = true;
            this.aToolStripMenuItem.CheckOnClick = true;
            this.aToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aToolStripMenuItem.Text = "A*";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // dijkstraToolStripMenuItem
            // 
            this.dijkstraToolStripMenuItem.AccessibleName = "dijkstra";
            this.dijkstraToolStripMenuItem.CheckOnClick = true;
            this.dijkstraToolStripMenuItem.Name = "dijkstraToolStripMenuItem";
            this.dijkstraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dijkstraToolStripMenuItem.Text = "Dijkstra";
            this.dijkstraToolStripMenuItem.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.Toolbar);
            this.Name = "Display";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pathfinding Visualizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heloToolStripMenuItem;
        private System.Windows.Forms.MenuStrip Toolbar;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wallNodeToolStripMenuItem;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dijkstraToolStripMenuItem;
    }
}

