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
using System.Drawing.Imaging;

namespace DecisionTree.UI
{
 
    public partial class TreeViewer : Form
    {
        Image treeImage;
        private Point _StartPoint;
        public TreeViewer()
        {
            InitializeComponent();

            treePictureBox.MouseWheel += TreePictureBox_MouseWheel;
        }

        private void TreePictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            int offset = 50;

            if (e.Delta > 0)
            {
                treePictureBox.Width = treePictureBox.Width + offset;
                treePictureBox.Height = treePictureBox.Height + offset;
            }
            else
            {
                treePictureBox.Width = Math.Max(treeImage.Width, treePictureBox.Width - offset);
                treePictureBox.Height = Math.Max(treeImage.Height, treePictureBox.Height - offset);
            }

            CenterPicture();
        }

        private void TreeViewer_Load(object sender, EventArgs e)
        {
            treeImage = CoreAPI.SharedInstance.GetTreeImage();
            treePictureBox.Width = treeImage.Width;
            treePictureBox.Height = treeImage.Height;
            treePictureBox.Image = treeImage;

            CenterPicture();
        }

        private void CenterPicture()
        {
            int ww = panel1.ClientSize.Width;
            int hh = panel1.ClientSize.Height;

            treePictureBox.Location = new Point(ww / 2 - treePictureBox.Size.Width / 2,
              hh / 2 - treePictureBox.Size.Height / 2);

          //  treePictureBox.Anchor = AnchorStyles.None;
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void treePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _StartPoint = e.Location;
        }

        private void treePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point changePoint = new Point(e.Location.X - _StartPoint.X,
                                              e.Location.Y - _StartPoint.Y);
                panel1.AutoScrollPosition = new Point(-panel1.AutoScrollPosition.X - changePoint.X,
                                                      -panel1.AutoScrollPosition.Y - changePoint.Y);
            }
        }

        private void TreeViewer_Resize(object sender, EventArgs e)
        {
            CenterPicture();
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Jpeg File (*.jpg)|*.jpg| All Files (*.*)|*.*";
            dlg.Title = "Save Report";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filepath = dlg.FileName;

                if (filepath.Length > 0)
                {
                    ImageCodecInfo myImageCodecInfo;
                    System.Drawing.Imaging.Encoder myEncoder;
                    EncoderParameter myEncoderParameter;
                    EncoderParameters myEncoderParameters;

                    myImageCodecInfo = GetEncoderInfo("image/jpeg");
                    myEncoder = System.Drawing.Imaging.Encoder.Quality;
                    myEncoderParameters = new EncoderParameters(1);

                    myEncoderParameter = new EncoderParameter(myEncoder, 100L);
                    myEncoderParameters.Param[0] = myEncoderParameter;
                    treeImage.Save(filepath, myImageCodecInfo, myEncoderParameters);
                }
            }
        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }
    }
}
