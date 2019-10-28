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
            this.algorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dijkstraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wallNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.visualsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGCOSTgreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.Toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
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
            this.sTARTToolStripMenuItem,
            this.sTOPToolStripMenuItem});
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(584, 24);
            this.Toolbar.TabIndex = 1;
            this.Toolbar.Text = "ToolbarStrip";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algorithmToolStripMenuItem,
            this.speedToolStripMenuItem,
            this.visualsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // algorithmToolStripMenuItem
            // 
            this.algorithmToolStripMenuItem.AccessibleName = "";
            this.algorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.dijkstraToolStripMenuItem});
            this.algorithmToolStripMenuItem.Name = "algorithmToolStripMenuItem";
            this.algorithmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.algorithmToolStripMenuItem.Text = "Algorithm";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Checked = true;
            this.aToolStripMenuItem.CheckOnClick = true;
            this.aToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.aToolStripMenuItem.Text = "A*";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // dijkstraToolStripMenuItem
            // 
            this.dijkstraToolStripMenuItem.CheckOnClick = true;
            this.dijkstraToolStripMenuItem.Name = "dijkstraToolStripMenuItem";
            this.dijkstraToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.dijkstraToolStripMenuItem.Text = "Dijkstra";
            this.dijkstraToolStripMenuItem.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noLimitToolStripMenuItem,
            this.sToolStripMenuItem,
            this.sToolStripMenuItem1,
            this.sToolStripMenuItem2,
            this.sToolStripMenuItem3,
            this.mToolStripMenuItem});
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speedToolStripMenuItem.Text = "Speed";
            // 
            // noLimitToolStripMenuItem
            // 
            this.noLimitToolStripMenuItem.Checked = true;
            this.noLimitToolStripMenuItem.CheckOnClick = true;
            this.noLimitToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noLimitToolStripMenuItem.Name = "noLimitToolStripMenuItem";
            this.noLimitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.noLimitToolStripMenuItem.Text = "No limit";
            this.noLimitToolStripMenuItem.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.CheckOnClick = true;
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.sToolStripMenuItem.Text = "1s";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // sToolStripMenuItem1
            // 
            this.sToolStripMenuItem1.CheckOnClick = true;
            this.sToolStripMenuItem1.Name = "sToolStripMenuItem1";
            this.sToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.sToolStripMenuItem1.Text = "5s";
            this.sToolStripMenuItem1.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // sToolStripMenuItem2
            // 
            this.sToolStripMenuItem2.CheckOnClick = true;
            this.sToolStripMenuItem2.Name = "sToolStripMenuItem2";
            this.sToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.sToolStripMenuItem2.Text = "10s";
            this.sToolStripMenuItem2.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // sToolStripMenuItem3
            // 
            this.sToolStripMenuItem3.CheckOnClick = true;
            this.sToolStripMenuItem3.Name = "sToolStripMenuItem3";
            this.sToolStripMenuItem3.Size = new System.Drawing.Size(117, 22);
            this.sToolStripMenuItem3.Text = "30s";
            this.sToolStripMenuItem3.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.CheckOnClick = true;
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.mToolStripMenuItem.Text = "1m";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.CheckedChanged);
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
            this.sTARTToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sTARTToolStripMenuItem.Text = "START";
            this.sTARTToolStripMenuItem.Click += new System.EventHandler(this.START_Click);
            // 
            // sTOPToolStripMenuItem
            // 
            this.sTOPToolStripMenuItem.Name = "sTOPToolStripMenuItem";
            this.sTOPToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.sTOPToolStripMenuItem.Text = "STOP";
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
            // visualsToolStripMenuItem
            // 
            this.visualsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGCOSTgreenToolStripMenuItem});
            this.visualsToolStripMenuItem.Name = "visualsToolStripMenuItem";
            this.visualsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualsToolStripMenuItem.Text = "Visuals";
            // 
            // showGCOSTgreenToolStripMenuItem
            // 
            this.showGCOSTgreenToolStripMenuItem.Name = "showGCOSTgreenToolStripMenuItem";
            this.showGCOSTgreenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showGCOSTgreenToolStripMenuItem.Text = "Show node costs";
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
        private System.Windows.Forms.ToolStripMenuItem algorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dijkstraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTOPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wallNodeToolStripMenuItem;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.ToolStripMenuItem visualsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGCOSTgreenToolStripMenuItem;
    }
}

