namespace DecisionTree
{
    partial class InputData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputData));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuBox = new System.Windows.Forms.GroupBox();
            this.showTreeButton = new System.Windows.Forms.Button();
            this.showReportButton = new System.Windows.Forms.Button();
            this.buildTreeButton = new System.Windows.Forms.Button();
            this.loadFromCsvButton = new System.Windows.Forms.Button();
            this.addRowButton = new System.Windows.Forms.Button();
            this.addColumnButton = new System.Windows.Forms.Button();
            this.saveToCsvButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.resizeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataValidationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelDecompositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 78);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.Size = new System.Drawing.Size(605, 343);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            // 
            // menuBox
            // 
            this.menuBox.Controls.Add(this.showTreeButton);
            this.menuBox.Controls.Add(this.showReportButton);
            this.menuBox.Controls.Add(this.buildTreeButton);
            this.menuBox.Controls.Add(this.loadFromCsvButton);
            this.menuBox.Controls.Add(this.addRowButton);
            this.menuBox.Controls.Add(this.addColumnButton);
            this.menuBox.Controls.Add(this.saveToCsvButton);
            this.menuBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBox.Location = new System.Drawing.Point(0, 24);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(798, 58);
            this.menuBox.TabIndex = 1;
            this.menuBox.TabStop = false;
            // 
            // showTreeButton
            // 
            this.showTreeButton.Enabled = false;
            this.showTreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showTreeButton.Image = ((System.Drawing.Image)(resources.GetObject("showTreeButton.Image")));
            this.showTreeButton.Location = new System.Drawing.Point(526, 19);
            this.showTreeButton.Name = "showTreeButton";
            this.showTreeButton.Size = new System.Drawing.Size(100, 29);
            this.showTreeButton.TabIndex = 7;
            this.showTreeButton.Text = "Show Tree";
            this.showTreeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.showTreeButton.UseVisualStyleBackColor = true;
            this.showTreeButton.Click += new System.EventHandler(this.showTreeButton_Click);
            // 
            // showReportButton
            // 
            this.showReportButton.Enabled = false;
            this.showReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showReportButton.Image = ((System.Drawing.Image)(resources.GetObject("showReportButton.Image")));
            this.showReportButton.Location = new System.Drawing.Point(420, 19);
            this.showReportButton.Name = "showReportButton";
            this.showReportButton.Size = new System.Drawing.Size(100, 29);
            this.showReportButton.TabIndex = 6;
            this.showReportButton.Text = "Show Report";
            this.showReportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.showReportButton.UseVisualStyleBackColor = true;
            this.showReportButton.Click += new System.EventHandler(this.showReportButton_Click);
            // 
            // buildTreeButton
            // 
            this.buildTreeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(162)))), ((int)(((byte)(210)))));
            this.buildTreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildTreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildTreeButton.ForeColor = System.Drawing.Color.White;
            this.buildTreeButton.Image = ((System.Drawing.Image)(resources.GetObject("buildTreeButton.Image")));
            this.buildTreeButton.Location = new System.Drawing.Point(632, 14);
            this.buildTreeButton.Name = "buildTreeButton";
            this.buildTreeButton.Size = new System.Drawing.Size(133, 39);
            this.buildTreeButton.TabIndex = 5;
            this.buildTreeButton.Text = "Build Tree";
            this.buildTreeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buildTreeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buildTreeButton.UseVisualStyleBackColor = false;
            this.buildTreeButton.Click += new System.EventHandler(this.buildTreeButton_Click_1);
            // 
            // loadFromCsvButton
            // 
            this.loadFromCsvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadFromCsvButton.Image = ((System.Drawing.Image)(resources.GetObject("loadFromCsvButton.Image")));
            this.loadFromCsvButton.Location = new System.Drawing.Point(212, 19);
            this.loadFromCsvButton.Name = "loadFromCsvButton";
            this.loadFromCsvButton.Size = new System.Drawing.Size(96, 29);
            this.loadFromCsvButton.TabIndex = 2;
            this.loadFromCsvButton.Text = "Load";
            this.loadFromCsvButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadFromCsvButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loadFromCsvButton.UseVisualStyleBackColor = true;
            this.loadFromCsvButton.Click += new System.EventHandler(this.loadFromCsvButton_Click);
            // 
            // addRowButton
            // 
            this.addRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRowButton.Image = ((System.Drawing.Image)(resources.GetObject("addRowButton.Image")));
            this.addRowButton.Location = new System.Drawing.Point(110, 19);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(96, 29);
            this.addRowButton.TabIndex = 1;
            this.addRowButton.Text = "Add Row";
            this.addRowButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // addColumnButton
            // 
            this.addColumnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addColumnButton.Image = ((System.Drawing.Image)(resources.GetObject("addColumnButton.Image")));
            this.addColumnButton.Location = new System.Drawing.Point(8, 19);
            this.addColumnButton.Name = "addColumnButton";
            this.addColumnButton.Size = new System.Drawing.Size(96, 29);
            this.addColumnButton.TabIndex = 0;
            this.addColumnButton.Text = "Add Column";
            this.addColumnButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addColumnButton.UseVisualStyleBackColor = true;
            this.addColumnButton.Click += new System.EventHandler(this.addColumnButton_Click);
            // 
            // saveToCsvButton
            // 
            this.saveToCsvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToCsvButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToCsvButton.Image")));
            this.saveToCsvButton.Location = new System.Drawing.Point(314, 19);
            this.saveToCsvButton.Name = "saveToCsvButton";
            this.saveToCsvButton.Size = new System.Drawing.Size(100, 29);
            this.saveToCsvButton.TabIndex = 3;
            this.saveToCsvButton.Text = "Save";
            this.saveToCsvButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveToCsvButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveToCsvButton.UseVisualStyleBackColor = true;
            this.saveToCsvButton.Click += new System.EventHandler(this.saveToCsvButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.analyzisToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem2,
            this.resizeTableToolStripMenuItem,
            this.dataValidationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.loadDataToolStripMenuItem.Text = "Load Data";
            this.loadDataToolStripMenuItem.Click += new System.EventHandler(this.loadDataToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveToolStripMenuItem.Text = "Save Data";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 6);
            // 
            // resizeTableToolStripMenuItem
            // 
            this.resizeTableToolStripMenuItem.Name = "resizeTableToolStripMenuItem";
            this.resizeTableToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resizeTableToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.resizeTableToolStripMenuItem.Text = "Resize Table";
            this.resizeTableToolStripMenuItem.Click += new System.EventHandler(this.resizeTableToolStripMenuItem_Click);
            // 
            // dataValidationToolStripMenuItem
            // 
            this.dataValidationToolStripMenuItem.Name = "dataValidationToolStripMenuItem";
            this.dataValidationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dataValidationToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.dataValidationToolStripMenuItem.Text = "Data Validation";
            this.dataValidationToolStripMenuItem.Click += new System.EventHandler(this.dataValidationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildTreeToolStripMenuItem,
            this.toolStripMenuItem3,
            this.saveTreeToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.dataToolStripMenuItem.Text = "&Model";
            // 
            // buildTreeToolStripMenuItem
            // 
            this.buildTreeToolStripMenuItem.Name = "buildTreeToolStripMenuItem";
            this.buildTreeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.buildTreeToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.buildTreeToolStripMenuItem.Text = "Build Tree";
            this.buildTreeToolStripMenuItem.Click += new System.EventHandler(this.buildTreeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(242, 6);
            // 
            // saveTreeToolStripMenuItem
            // 
            this.saveTreeToolStripMenuItem.Name = "saveTreeToolStripMenuItem";
            this.saveTreeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveTreeToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.saveTreeToolStripMenuItem.Text = "Save Tree Structure";
            this.saveTreeToolStripMenuItem.Click += new System.EventHandler(this.saveTreeToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "&Report";
            // 
            // saveReportToolStripMenuItem
            // 
            this.saveReportToolStripMenuItem.Name = "saveReportToolStripMenuItem";
            this.saveReportToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveReportToolStripMenuItem.Text = "Save Report";
            this.saveReportToolStripMenuItem.Click += new System.EventHandler(this.saveReportToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualToolStripMenuItem,
            this.systemInfoToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.userManualToolStripMenuItem.Text = "User Manual";
            this.userManualToolStripMenuItem.Click += new System.EventHandler(this.userManualToolStripMenuItem_Click);
            // 
            // systemInfoToolStripMenuItem
            // 
            this.systemInfoToolStripMenuItem.Name = "systemInfoToolStripMenuItem";
            this.systemInfoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.systemInfoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.systemInfoToolStripMenuItem.Text = "System Info";
            this.systemInfoToolStripMenuItem.Click += new System.EventHandler(this.systemInfoToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // analyzisToolStripMenuItem
            // 
            this.analyzisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelDecompositionToolStripMenuItem});
            this.analyzisToolStripMenuItem.Name = "analyzisToolStripMenuItem";
            this.analyzisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.analyzisToolStripMenuItem.Text = "&Analysis";
            // 
            // modelDecompositionToolStripMenuItem
            // 
            this.modelDecompositionToolStripMenuItem.Name = "modelDecompositionToolStripMenuItem";
            this.modelDecompositionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.modelDecompositionToolStripMenuItem.Text = "&Model Decomposition ";
            this.modelDecompositionToolStripMenuItem.Click += new System.EventHandler(this.modelDecompositionToolStripMenuItem_Click);
            // 
            // InputData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InputData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeTree - Input Data";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InputData_FormClosed);
            this.Load += new System.EventHandler(this.InputData_Load);
            this.Resize += new System.EventHandler(this.InputData_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox menuBox;
        private System.Windows.Forms.Button addRowButton;
        private System.Windows.Forms.Button addColumnButton;
        private System.Windows.Forms.Button loadFromCsvButton;
        private System.Windows.Forms.Button saveToCsvButton;
        private System.Windows.Forms.Button buildTreeButton;
        private System.Windows.Forms.Button showReportButton;
        private System.Windows.Forms.Button showTreeButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem resizeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataValidationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem analyzisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelDecompositionToolStripMenuItem;
    }
}

