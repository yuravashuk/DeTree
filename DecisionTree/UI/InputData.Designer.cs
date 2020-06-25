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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 64);
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
            this.menuBox.Location = new System.Drawing.Point(0, 0);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(798, 58);
            this.menuBox.TabIndex = 1;
            this.menuBox.TabStop = false;
            this.menuBox.Text = "Menu";
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
            // InputData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeTree - Input Data";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InputData_FormClosed);
            this.Load += new System.EventHandler(this.InputData_Load);
            this.Resize += new System.EventHandler(this.InputData_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuBox.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

