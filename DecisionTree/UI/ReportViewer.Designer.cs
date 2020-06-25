namespace DecisionTree.UI
{
    partial class ReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportViewer));
            this.reportTextBox = new System.Windows.Forms.TextBox();
            this.saveReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportTextBox
            // 
            this.reportTextBox.Location = new System.Drawing.Point(8, 44);
            this.reportTextBox.Multiline = true;
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.ReadOnly = true;
            this.reportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.reportTextBox.Size = new System.Drawing.Size(418, 388);
            this.reportTextBox.TabIndex = 0;
            // 
            // saveReportButton
            // 
            this.saveReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveReportButton.Image = ((System.Drawing.Image)(resources.GetObject("saveReportButton.Image")));
            this.saveReportButton.Location = new System.Drawing.Point(8, 9);
            this.saveReportButton.Name = "saveReportButton";
            this.saveReportButton.Size = new System.Drawing.Size(100, 29);
            this.saveReportButton.TabIndex = 4;
            this.saveReportButton.Text = "Save";
            this.saveReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveReportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveReportButton.UseVisualStyleBackColor = true;
            this.saveReportButton.Click += new System.EventHandler(this.saveReportButton_Click);
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 432);
            this.Controls.Add(this.saveReportButton);
            this.Controls.Add(this.reportTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decision Tree - Calculation Report";
            this.Load += new System.EventHandler(this.ReportViewer_Load);
            this.Resize += new System.EventHandler(this.ReportViewer_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reportTextBox;
        private System.Windows.Forms.Button saveReportButton;
    }
}