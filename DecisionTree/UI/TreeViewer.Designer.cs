namespace DecisionTree.UI
{
    partial class TreeViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeViewer));
            this.treePictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.treePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treePictureBox
            // 
            this.treePictureBox.Location = new System.Drawing.Point(12, 12);
            this.treePictureBox.Name = "treePictureBox";
            this.treePictureBox.Size = new System.Drawing.Size(776, 426);
            this.treePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.treePictureBox.TabIndex = 0;
            this.treePictureBox.TabStop = false;
            this.treePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treePictureBox_MouseDown);
            this.treePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treePictureBox_MouseMove);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.treePictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel1_Scroll);
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            // 
            // saveImageButton
            // 
            this.saveImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveImageButton.Image = ((System.Drawing.Image)(resources.GetObject("saveImageButton.Image")));
            this.saveImageButton.Location = new System.Drawing.Point(10, 10);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(100, 29);
            this.saveImageButton.TabIndex = 6;
            this.saveImageButton.Text = "Save";
            this.saveImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // TreeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TreeViewer";
            this.Text = "Decision Tree - Tree Viewer";
            this.Load += new System.EventHandler(this.TreeViewer_Load);
            this.Resize += new System.EventHandler(this.TreeViewer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.treePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox treePictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveImageButton;
    }
}