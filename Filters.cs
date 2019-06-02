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
    public class Filters : Form1
    {
        public Image PIC(Image A, float R1 = 0, float G1 = 0, float B1 = 0, float A1 = 0, float T1 = 0, float R2 = 0, float G2 = 0, float B2 = 0, float A2 = 0, float T2 = 0, float R3 = 0, float G3 = 0, float B3 = 0, float A3 = 0, float T3 = 0, float R4 = 0, float G4 = 0, float B4 = 0, float A4 = 0, float T4 = 0, float R5 = 0, float G5 = 0, float B5 = 0, float A5 = 0, float T5 = 0)
        {
            try
            {
                Image Picture = A;
                Bitmap bmpInverted = new Bitmap(Picture.Width, Picture.Height);
                ImageAttributes IA = new ImageAttributes();
                ColorMatrix CMPicture = new ColorMatrix(new float[][]
                    {
                    new float[] {R1,G1,B1,A1,T1},
                    new float[] {R2,G2,B2,A2,T2},
                    new float[] {R3,G3,B3,A3,T3},
                    new float[] {R4,G4,B4,A4,T4},
                    new float[] {R5,G5,B5,A5,T5}
                    });
                IA.SetColorMatrix(CMPicture);
                Graphics G = Graphics.FromImage(bmpInverted);
                G.DrawImage(Picture, new Rectangle(0, 0, Picture.Width, Picture.Height), 0, 0, Picture.Width, Picture.Height, GraphicsUnit.Pixel, IA);
                GC.Collect();
                G.Dispose();
                return bmpInverted;
            }
            catch
            {
                MessageBox.Show("No Image");
                return null;
            }

        }
    }
}
