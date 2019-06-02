using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Drawing.Imaging;
using System.IO;
namespace ImageEditor
{
    class ImageSave : Form1
    {
        public ImageSave(Image A)
        { 
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "Image|*.png;*.bmp;*.jpg";
            ImageFormat Format = ImageFormat.Png;
            if (SFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = Path.GetFileName(SFD.FileName);
                switch (ext)
                {
                    case ".jpg":
                        {
                            Format = ImageFormat.Jpeg;
                            break;
                        }
                    case ".bmp":
                        {
                            Format = ImageFormat.Bmp;
                            break;
                        }
                }
                A.Save(SFD.FileName, Format);
            }
        }
    }
}