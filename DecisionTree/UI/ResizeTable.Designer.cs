namespace DecisionTree.UI
{
    partial class ResizeTable
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.columnsTrackbar = new System.Windows.Forms.TrackBar();
            this.rowsTrackbar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnsNumberLabel = new System.Windows.Forms.Label();
            this.rowsNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.columnsTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(12, 123);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(136, 29);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(154, 123);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(136, 29);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // columnsTrackbar
            // 
            this.columnsTrackbar.AutoSize = false;
            this.columnsTrackbar.Location = new System.Drawing.Point(13, 26);
            this.columnsTrackbar.Maximum = 100;
            this.columnsTrackbar.Name = "columnsTrackbar";
            this.columnsTrackbar.Size = new System.Drawing.Size(277, 29);
            this.columnsTrackbar.TabIndex = 7;
            this.columnsTrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.columnsTrackbar.Scroll += new System.EventHandler(this.columnsTrackbar_Scroll);
            // 
            // rowsTrackbar
            // 
            this.rowsTrackbar.AutoSize = false;
            this.rowsTrackbar.Location = new System.Drawing.Point(13, 88);
            this.rowsTrackbar.Maximum = 100;
            this.rowsTrackbar.Name = "rowsTrackbar";
            this.rowsTrackbar.Size = new System.Drawing.Size(277, 29);
            this.rowsTrackbar.TabIndex = 8;
            this.rowsTrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.rowsTrackbar.Scroll += new System.EventHandler(this.rowsTrackbar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Columns number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rows number";
            // 
            // columnsNumberLabel
            // 
            this.columnsNumberLabel.AutoSize = true;
            this.columnsNumberLabel.Location = new System.Drawing.Point(266, 10);
            this.columnsNumberLabel.Name = "columnsNumberLabel";
            this.columnsNumberLabel.Size = new System.Drawing.Size(13, 13);
            this.columnsNumberLabel.TabIndex = 11;
            this.columnsNumberLabel.Text = "0";
            this.columnsNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rowsNumberLabel
            // 
            this.rowsNumberLabel.AutoSize = true;
            this.rowsNumberLabel.Location = new System.Drawing.Point(266, 72);
            this.rowsNumberLabel.Name = "rowsNumberLabel";
            this.rowsNumberLabel.Size = new System.Drawing.Size(13, 13);
            this.rowsNumberLabel.TabIndex = 12;
            this.rowsNumberLabel.Text = "0";
            this.rowsNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ResizeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 160);
            this.Controls.Add(this.rowsNumberLabel);
            this.Controls.Add(this.columnsNumberLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rowsTrackbar);
            this.Controls.Add(this.columnsTrackbar);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResizeTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resize Table";
            this.Load += new System.EventHandler(this.ResizeTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.columnsTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TrackBar columnsTrackbar;
        private System.Windows.Forms.TrackBar rowsTrackbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label columnsNumberLabel;
        private System.Windows.Forms.Label rowsNumberLabel;
    }
}