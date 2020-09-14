using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionTree.UI
{
    public partial class ModelDecomposition : Form
    {
        public ModelDecomposition()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
            dlg.Title = "Save Model Decomposition";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filepath = dlg.FileName;

                if (filepath.Length > 0)
                {
                    File.WriteAllText(filepath, decompositionTextBox.Text);
                }
            }
        }

        private void ModelDecomposition_Load(object sender, EventArgs e)
        {
            decompositionTextBox.Text = Core.CoreAPI.SharedInstance.GetDecompositionModel();
            ModelDecomposition_Resize(sender, e);
        }

        private void ModelDecomposition_Resize(object sender, EventArgs e)
        {
            CancelButton.Top = this.Height - (CancelButton.Height + 50);
            CancelButton.Left = this.Width - (CancelButton.Width + 30);
            SaveButton.Top = this.Height - (SaveButton.Height + 50);
            SaveButton.Left = this.Width - (SaveButton.Width + CancelButton.Width + 40);

            decompositionTextBox.Width = this.Width - 40;
            decompositionTextBox.Height = this.Height - 100;
        }
    }
}
