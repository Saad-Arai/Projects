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
  class OpenImage : Form1
    {
        public Image Open()
        {
            
            DialogResult DR = openFileDialog1.ShowDialog();
            try
            {
                if (DR == DialogResult.OK)
                {
                    Image Picture = Image.FromFile(openFileDialog1.FileName);
                    return Picture;
                }

                else
                {
                    return null;
                }
            }
            catch
            {
                MessageBox.Show("Invalid Extension");
                return null;
            }
        }
    }
}
