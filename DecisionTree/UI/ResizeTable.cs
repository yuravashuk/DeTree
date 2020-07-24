using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionTree.UI
{
    public partial class ResizeTable : Form
    {
        public int numColumns = 0;

        public int numRows = 0;

        public ResizeTable()
        {
            InitializeComponent();
        }

        private void columnsTrackbar_Scroll(object sender, EventArgs e)
        {
            columnsNumberLabel.Text = columnsTrackbar.Value.ToString();
        }

        private void rowsTrackbar_Scroll(object sender, EventArgs e)
        {
            rowsNumberLabel.Text = rowsTrackbar.Value.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            numRows = rowsTrackbar.Value;
            numColumns = columnsTrackbar.Value;
            this.Close();
        }

        private void ResizeTable_Load(object sender, EventArgs e)
        {
            columnsTrackbar.Value = numColumns;
            rowsTrackbar.Value = numRows;
            columnsNumberLabel.Text = columnsTrackbar.Value.ToString();
            rowsNumberLabel.Text = rowsTrackbar.Value.ToString();
        }
    }
}
