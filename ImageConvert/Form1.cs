using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageConvert
{
    public partial class Form1 : Form
    {
        private string selectedFileName = "";
        private string selectedFolderPath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPG images (*.JPG)|*.jpg";
            openFileDialog.ShowDialog();
            selectedFileName = openFileDialog.FileNames[0];
        }

        private bool InvalidData()
        {
            string errorMessage = "";

            if (String.IsNullOrEmpty(selectedFolderPath))
            {
                errorMessage = "Result Path not selected!";
            }
            if (String.IsNullOrEmpty(selectedFileName))
            {
                errorMessage = "File not selected!";
            }
            if (!String.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                   errorMessage,
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );
                return false;
            }
            return true;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (!InvalidData())
                return;

            Bitmap image = new Bitmap(selectedFileName);

            string newFilePath = selectedFolderPath + "//" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            using (StreamWriter writer = new StreamWriter(newFilePath))
            {
                for (int j = 0; j < image.Height; j++)
                {
                    for (int i = 0; i < image.Width; i++)
                    {
                        UInt32 newPixel = (UInt32)(image.GetPixel(i, j).ToArgb());
                        
                        if (newPixel < 4280054215)
                        {
                            writer.Write('#');
                        }
                        else if (newPixel >= 4280054215 && newPixel < 4281918350)
                        {
                            writer.Write('@');
                        }
                        else if (newPixel >= 4281918350 && newPixel < 4283782485)
                        {
                            writer.Write('%');
                        }
                        else if (newPixel >= 4283782485 && newPixel < 4285646620)
                        {
                            writer.Write('=');
                        }
                        else if (newPixel >= 4285646620 && newPixel < 4287510755)
                        {
                            writer.Write('+');
                        } 
                        else if (newPixel >= 4287510755 && newPixel < 4289374890)
                        {
                            writer.Write('*');
                        }
                        else if (newPixel >= 4289374890 && newPixel < 4291239025)
                        {
                            writer.Write('-');
                        }
                        else if (newPixel >= 4291239025 && newPixel < 4293103160)
                        {
                            writer.Write('.');
                        }
                        else
                        {
                            writer.Write(' ');
                        }
                    }
                    writer.WriteLine();
                }
            }
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            outputFolder.ShowDialog();
            selectedFolderPath = outputFolder.SelectedPath;
        }
    }
}
