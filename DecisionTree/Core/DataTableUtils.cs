using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionTree.Core
{
    public class DataTableUtils
    {
        public DataTable ReadCSV(string filePath)
        {
            var dt = new DataTable();

            File.ReadLines(filePath).Take(1)
                .SelectMany(x => x.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                .ToList()
                .ForEach(x => dt.Columns.Add(x.Trim()));

            File.ReadLines(filePath).Skip(1)
                .Select(x => x.Split(','))
                .ToList()
                .ForEach(line => dt.Rows.Add(line));

            return dt;
        }

        public void SaveCSV(DataTable dtDataTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);

            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }

            sw.Write(sw.NewLine);

            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

        public void SaveToHtml(DataTable dtDataTable, string strFilePath)
        {
            string html = "<html><head><style>table, th, td { border: 1px solid black; border-collapse: collapse; } td:nth-child(1) {background: #f15b6c; color: white; } th:nth-child(1) {background: #f15b6c; color: white; } th { background: #78a2d2; color: white; } </style ></head><table>";

            //add header row
            html += "<tr>";

            for (int i = 0; i < dtDataTable.Columns.Count; i++)
                html += "<th>" + dtDataTable.Columns[i].ColumnName + "</th>";

            html += "</tr>";

            // add rows
            for (int i = 0; i < dtDataTable.Rows.Count; i++)
            {
                html += "<tr>";
                for (int j = 0; j < dtDataTable.Columns.Count; j++)
                    html += "<td>" + dtDataTable.Rows[i][j].ToString() + "</td>";
                html += "</tr>";
            }

            html += "</table>";

            StreamWriter sw = new StreamWriter(strFilePath, false);
            sw.Write(html);
            sw.Close();
        }
    }
}
