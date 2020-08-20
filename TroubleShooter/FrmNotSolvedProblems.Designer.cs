namespace TroubleShooter
{
    partial class FrmNotSolvedProblems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmnDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Solve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addImplementorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTargetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TmrProblems = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnDetails,
            this.Solve});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(651, 387);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clmnDetails
            // 
            this.clmnDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnDetails.DataPropertyName = "Detail";
            this.clmnDetails.HeaderText = "Details";
            this.clmnDetails.Name = "clmnDetails";
            this.clmnDetails.ReadOnly = true;
            this.clmnDetails.Text = "Details";
            this.clmnDetails.UseColumnTextForButtonValue = true;
            this.clmnDetails.Width = 45;
            // 
            // Solve
            // 
            this.Solve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Solve.HeaderText = "Solve";
            this.Solve.Name = "Solve";
            this.Solve.ReadOnly = true;
            this.Solve.Text = "Solve";
            this.Solve.UseColumnTextForButtonValue = true;
            this.Solve.Width = 39;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developerToolStripMenuItem,
            this.buildsToolStripMenuItem,
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDeveloperToolStripMenuItem,
            this.addTesterToolStripMenuItem,
            this.addImplementorToolStripMenuItem});
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.developerToolStripMenuItem.Text = "Staff";
            // 
            // addDeveloperToolStripMenuItem
            // 
            this.addDeveloperToolStripMenuItem.Name = "addDeveloperToolStripMenuItem";
            this.addDeveloperToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addDeveloperToolStripMenuItem.Text = "Add developer";
            this.addDeveloperToolStripMenuItem.Click += new System.EventHandler(this.addDeveloperToolStripMenuItem_Click);
            // 
            // addTesterToolStripMenuItem
            // 
            this.addTesterToolStripMenuItem.Name = "addTesterToolStripMenuItem";
            this.addTesterToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addTesterToolStripMenuItem.Text = "Add Tester";
            this.addTesterToolStripMenuItem.Click += new System.EventHandler(this.addTesterToolStripMenuItem_Click);
            // 
            // addImplementorToolStripMenuItem
            // 
            this.addImplementorToolStripMenuItem.Name = "addImplementorToolStripMenuItem";
            this.addImplementorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addImplementorToolStripMenuItem.Text = "Add Implementor";
            this.addImplementorToolStripMenuItem.Click += new System.EventHandler(this.addImplementorToolStripMenuItem_Click);
            // 
            // buildsToolStripMenuItem
            // 
            this.buildsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBuildToolStripMenuItem,
            this.addTargetToolStripMenuItem});
            this.buildsToolStripMenuItem.Name = "buildsToolStripMenuItem";
            this.buildsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.buildsToolStripMenuItem.Text = "Builds";
            // 
            // addBuildToolStripMenuItem
            // 
            this.addBuildToolStripMenuItem.Name = "addBuildToolStripMenuItem";
            this.addBuildToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.addBuildToolStripMenuItem.Text = "Add build";
            this.addBuildToolStripMenuItem.Click += new System.EventHandler(this.addBuildToolStripMenuItem_Click);
            // 
            // addTargetToolStripMenuItem
            // 
            this.addTargetToolStripMenuItem.Name = "addTargetToolStripMenuItem";
            this.addTargetToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.addTargetToolStripMenuItem.Text = "Add Target";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAppToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // addAppToolStripMenuItem
            // 
            this.addAppToolStripMenuItem.Name = "addAppToolStripMenuItem";
            this.addAppToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.addAppToolStripMenuItem.Text = "Add App";
            this.addAppToolStripMenuItem.Click += new System.EventHandler(this.addAppToolStripMenuItem_Click);
            // 
            // TmrProblems
            // 
            this.TmrProblems.Interval = 20000;
            this.TmrProblems.Tick += new System.EventHandler(this.TmrProblems_Tick);
            // 
            // FrmNotSolvedProblems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmNotSolvedProblems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Errors";
            this.Load += new System.EventHandler(this.FrmNotSolvedProblems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeveloperToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDetails;
        private System.Windows.Forms.DataGridViewButtonColumn Solve;
        private System.Windows.Forms.Timer TmrProblems;
        private System.Windows.Forms.ToolStripMenuItem buildsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBuildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addImplementorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTargetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAppToolStripMenuItem;
    }
}