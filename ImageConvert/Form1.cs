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
            openFileDialog.Filter = "Images (*.JPG)|*.jpg";
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

        private char SetSymbol(UInt32 pixel)
        {
            char symbol = ' ';

            if (pixel < 4280054215)
            {
                symbol = '#';
            }
            else if (pixel >= 4280054215 && pixel < 4281918350)
            {
                symbol = '@';
            }
            else if (pixel >= 4281918350 && pixel < 4283782485)
            {
                symbol = '%';
            }
            else if (pixel >= 4283782485 && pixel < 4285646620)
            {
                symbol = '=';
            }
            else if (pixel >= 4285646620 && pixel < 4287510755)
            {
                symbol = '+';
            }
            else if (pixel >= 4287510755 && pixel < 4289374890)
            {
                symbol = '*';
            }
            else if (pixel >= 4289374890 && pixel < 4291239025)
            {
                symbol = '-';
            }
            else if (pixel >= 4291239025 && pixel < 4293103160)
            {
                symbol = '.';
            }
            return symbol;
        }

        private async void convertButton_Click(object sender, EventArgs e)
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
                        UInt32 pixel = (UInt32)(image.GetPixel(i, j).ToArgb());

                        char symbol = SetSymbol(pixel);

                        await writer.WriteAsync(symbol);
                    }
                    await writer.WriteLineAsync();
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
