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
    public partial class UserManual : Form
    {
        public UserManual()
        {
            InitializeComponent();
        }

        private void UserManual_Load(object sender, EventArgs e)
        {
            var path = System.IO.Directory.GetCurrentDirectory() + "/user_manual.html";
            Uri uri = new Uri(path);
            webBrowser1.Navigate(uri);
        }
    }
}
