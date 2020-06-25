using DecisionTree.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DecisionTree.UI
{
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            reportTextBox.Text = CoreAPI.SharedInstance.GetReport();
            reportTextBox.Select(0, 0);
        }

        private void ReportViewer_Resize(object sender, EventArgs e)
        {
            reportTextBox.Height = this.Height - 85;
            reportTextBox.Width = this.Width - 35;
        }

        private void saveReportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
            dlg.Title = "Save Report";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filepath = dlg.FileName;

                if (filepath.Length > 0)
                {
                    File.WriteAllText(filepath, reportTextBox.Text);
                }
            }
        }
    }
}
