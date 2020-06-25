using DecisionTree.Core;
using DecisionTree.UI;
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

namespace DecisionTree
{
    public partial class InputData : Form
    {
        enum FileExtensions
        {
            Invalid = -1,
            TXT = 0,
            CSV = 1,
            HTML = 2
        };

        private int numSigns = 0;
        private DataTableUtils importer = new DataTableUtils();
        private DataTable dt = null;

        public InputData()
        {
            InitializeComponent();
        }

        private void InputData_Resize(object sender, EventArgs e)
        {
            dataGridView1.Height = this.Height - (menuBox.Height + 50);
            dataGridView1.Width = this.Width - 30;
        }

        private void InputData_Load(object sender, EventArgs e)
        {
            InputData_Resize(sender, e);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            MakeDefaultColumns();
        }

        private void addColumnButton_Click(object sender, EventArgs e)
        {
            AddColumn();
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                MessageBox.Show("Please, add column first.", "Warning", MessageBoxButtons.OK);
                return;
            }

            dataGridView1.Rows.Add();
        }

        private void saveToCsvButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt|HTML Files (*.html)|*.html| All Files (*.*)|*.*";
            dlg.Title = "Save";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filepath = dlg.FileName;

                if (filepath.Length > 0)
                {
                    FileExtensions extension = GetFileType(filepath);

                    switch (extension)
                    {
                        case FileExtensions.CSV:
                            SaveToCSV(filepath);
                            break;
                        case FileExtensions.TXT:
                            SaveToTxt(filepath);
                            break;
                        case FileExtensions.HTML:
                            SaveToHTML(filepath);
                            break;
                        default:
                            break;
                    };
                }
            }
        }

        private void loadFromCsvButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV Files (*.csv)|*.csv| Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
            dlg.Title = "Load";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filepath = dlg.FileName;

                if (filepath.Length > 0)
                {
                    FileExtensions extension = GetFileType(filepath);

                    switch (extension)
                    {
                        case FileExtensions.CSV:
                            ImportFromCSV(filepath);
                            break;
                        case FileExtensions.TXT:
                            ImportFromTxt(filepath);
                            break;
                        default:
                            break;
                    };                    
                }
            }
        }

        private void buildTreeButton_Click_1(object sender, EventArgs e)
        {
            if (dt == null)
            {
                CreateDataTable();
            }

            if (CoreAPI.SharedInstance.RunBuildTreeProcess(dt))
            {
                showReportButton.Enabled = true;
                showTreeButton.Enabled = true;

                showTreeButton_Click(sender, e);
            }
        }

        private void showReportButton_Click(object sender, EventArgs e)
        {
            ReportViewer viewer = new ReportViewer();
            viewer.ShowDialog();
        }

        private void showTreeButton_Click(object sender, EventArgs e)
        {
            TreeViewer viewer = new TreeViewer();
            viewer.ShowDialog();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int i;

            if (Convert.ToString(e.FormattedValue).Equals(""))
            {
                return;
            }

            if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    if (dataGridView1.SelectedCells[0].IsInEditMode)
                    {
                        e.Cancel = true;
                        MessageBox.Show("Please, enter numeric.", "Warning", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        // internal

        private void CreateDataTable()
        {
            dt = new DataTable();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText);
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                dt.Rows.Add();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
        }

        private void AddColumn(int value = 0)
        {
            string name = "P" + numSigns.ToString();
            dataGridView1.Columns.Add(name, name);
            numSigns = numSigns + 1;
        }

        private void MakeDefaultColumns()
        {
            dataGridView1.Columns.Add("Fx", "Fx");

            for (int i = 0; i < 3; i++)
            {
                AddColumn();
            }
 
            this.dataGridView1.Rows.Insert(0, "0", "0", "0", "1");
            this.dataGridView1.Rows.Insert(1, "1", "0", "1", "0");
            this.dataGridView1.Rows.Insert(2, "1", "1", "1", "0");
            this.dataGridView1.Rows.Insert(3, "0", "0", "1", "1");
            this.dataGridView1.Rows.Insert(4, "1", "1", "0", "0");
            this.dataGridView1.Rows.Insert(5, "1", "1", "1", "1");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InputData_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private FileExtensions GetFileType(string inFileName)
        {
            var extension = Path.GetExtension(inFileName);

            if (extension == ".txt")
                return FileExtensions.TXT;

            if (extension == ".csv")
                return FileExtensions.CSV;

            if (extension == ".html")
                return FileExtensions.HTML;

            return FileExtensions.Invalid;
        }

        private void ImportFromCSV(string filepath)
        {
            DataTable csvTable = importer.ReadCSV(filepath);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = csvTable;
            dt = csvTable;
        }

        private void ImportFromTxt(string filepath)
        {
            ImportFromCSV(filepath);
        }

        private void SaveToCSV(string filepath)
        {
            CreateDataTable();
            importer.SaveCSV(dt, filepath);
        }

        private void SaveToTxt(string filepath)
        {
            SaveToCSV(filepath);
        }

        private void SaveToHTML(string filepath)
        {
            CreateDataTable();
            importer.SaveToHtml(dt, filepath);
        }
    }
}
