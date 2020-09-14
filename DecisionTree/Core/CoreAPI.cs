using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionTree.Core
{
    class CoreAPI
    {
        private string coreProgramName = "DeTreeBackend.exe";
        private string temporaryCsvName = "temporary.csv";

        public static CoreAPI SharedInstance = new CoreAPI();

        public bool RunBuildTreeProcess(DataTable dataTable)
        {
            if (File.Exists(coreProgramName))
            {
                DataTableUtils manager = new DataTableUtils();
                manager.SaveCSV(dataTable, temporaryCsvName);

                Process buildProcess = new Process();
                buildProcess.StartInfo.FileName = coreProgramName;
                buildProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                buildProcess.StartInfo.Arguments = "-f " + temporaryCsvName;
                buildProcess.Start();
                buildProcess.WaitForExit();

                return true;
            }
            else
            {
                MessageBox.Show("Failed to locate " + coreProgramName + ".", "Error");
                return false;
            }
        }

        public Image GetTreeImage()
        {
            return Image.FromFile("output.png");
        }

        public string GetReport()
        {
            return File.ReadAllText("report.txt");
        }

        public string GetDecompositionModel()
        {
            return File.ReadAllText("output-decomposition.txt");
        }
    }
}
