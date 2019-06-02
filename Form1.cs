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
    public partial class Form1 : MetroForm
    {
        Pen cropPen;
        public Image Picture;
        Image NoCropImage;
        Image PictureReload;
        Image PictureBCG;
        int cropX;
        int cropY;
        int cropWidth;
        int cropHeight;
        public bool MakeSelection = false;
        public Form1()
        {
           InitializeComponent();
           pictureBox1.AllowDrop = true;
        }
        // Open Image
        public void OpenImageButton_Click(object sender, EventArgs e)
        {
            OpenImageButtonM();
        }
        // Reset Image
        private void ResetImageButton_Click(object sender, EventArgs e)
        {
            ResetImageButtonM();
        }
        // Reload Image
        private void OriginalImageButton_Click(object sender, EventArgs e)
        {
            reload();
        }
        // Save Image
        private void SaveImageButton_Click(object sender, EventArgs e)
        {
            SaveImage();
        }
        // Gray Scale Image
        private void GrayScaleImageButton_Click(object sender, EventArgs e)
        {
            reload();
            GrayScaleM();
        }
        // Negative Image
        private void NegativeImageButton_Click(object sender, EventArgs e)
        {
            reload();
            NegativeM();
        }
        // Sepia Image
        private void SepiaImageButton_Click(object sender, EventArgs e)
        {
            reload();
            SepiaM();
        }
        // Swap Image Color
        private void SwapImageButton_Click(object sender, EventArgs e)
        {
            reload();
            SwapM();
        }
        // Black and white Image
        private void BlackWhiteImageButton_Click(object sender, EventArgs e)
        {
            reload();
            BlackWhiteM();
        }
        // Polaroid Image
        private void PolaroidImageButton_Click(object sender, EventArgs e)
        {
            reload();
            PolaroidM();
        }
        // Achromatopsia Image
        private void AchromatopsiaImageButton_Click(object sender, EventArgs e)
        {
            reload();
            AchromatopsiaM();
        }
        private void TritanopiaImageButton_Click(object sender, EventArgs e)
        {
            reload();
            TritanopiaM();
        }
        public void TritanopiaM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: 0.95f, G1: 0.05f, G2: 0.433f, B2: 0.567f, G3: 0.475f, B3: 0.525f, A4: 1, T5: 1);
            PictureBCG = pictureBox1.Image;
        }
        private void DeuteranopiaImageButton_Click(object sender, EventArgs e)
        {
            reload();
            DeuteranopiaM();
        }
        public void DeuteranopiaM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: 0.625f, G1: 0.375f, R2: 0.7f, G2: 0.3f, G3: 0.3f, B3: 0.7f, A4: 1, T5: 1);
            PictureBCG = pictureBox1.Image;
        }
        private void ProtanopiaImageButton_Click(object sender, EventArgs e)
        {
            reload();
            ProtanopiaM();
        }
        public void ProtanopiaM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: 0.567f, G1: 0.433f, R2: 0.558f, G2: 0.422f, G3: 0.242f, B3: 0.758f, A4: 1, T5: 1);
            PictureBCG = pictureBox1.Image;
        }
        private void TritanomalyImageButton_Click(object sender, EventArgs e)
        {
            reload();
            TritanomalyM();
        }
        public void TritanomalyM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: 0.967f, G1: 0.033f, G2: 0.733f, B2: 0.267f, G3: 0.183f, B3: 0.817f, A4: 1, T5: 1);
            PictureBCG = pictureBox1.Image;
        }
        private void DeuteranomalyImageButton_Click(object sender, EventArgs e)
        {
            reload();
            DeuteranomalyM();
        }
        public void DeuteranomalyM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: 0.8f, G1: 0.2f, R2: 0.258f, G2: 0.742f, G3: 0.143f, B3: 0.858f, A4: 1, T5: 1);
            PictureBCG = pictureBox1.Image;
        }
        private void ProtanomalyImageButton_Click(object sender, EventArgs e)
        {
            reload();
            ProtanomalyM();
        }
        public void ProtanomalyM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: 0.817f, G1: 0.183f, R2: 0.333f, G2: 0.667f, G3: 0.125f, B3: 0.875f, A4: 1, T5: 1);
            PictureBCG = pictureBox1.Image;
        }

        private void Cool_Click(object sender, EventArgs e)
        {
            reload();
            CoolM();
        }
        public void CoolM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: 0.99f, G2: 0.93f, B3: 1.08f, A4: 1, T5: 1);
            PictureBCG = pictureBox1.Image;
        }

        private void NightVisionImageButton_Click(object sender, EventArgs e)
        {
            reload();
            NightVisionM();
        }
        public void NightVisionM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: 0.1f, G1: 0.4f, R2: 0.3f, G2: 1f, B2: 0.3f, G3: 0.4f, B3: 0.1f, A4: 1, T5: 1);
            PictureBCG = pictureBox1.Image;
        }
        private void WarmImageButton_Click(object sender, EventArgs e)
        {
            reload();
            WarmM();
        }
        public void WarmM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: 1.06f, G2: 1.01f, B3: .93f, A4: 1, T5: 1);
            PictureBCG = pictureBox1.Image;
        }

        private void luminanceImageButton_Click(object sender, EventArgs e)
        {
            reload();
            lumianceM();

        }
        public void lumianceM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: 2f, G1: -0.4f, B1: 0.5f, R2: -0.5f, G2: 2f, B2: -0.4f, R3: -0.4f, G3: -0.5f, B3: 3f, A4: 1f);
            PictureBCG = pictureBox1.Image;
        }

        private void BrowniImageButton_Click(object sender, EventArgs e)
        {
            reload();
            BrowniM();

        }
        public void BrowniM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: 0.599f, G1: 0.345f, B1: -0.270f, T1: 47.431f, R2: -0.037f, G2: 0.860f, B2: 0.150f, T2: -36.962f, R3: 0.241f, G3: -0.074f, B3: 0.449f, T3: -7.562f, A4: 1);
            PictureBCG = pictureBox1.Image;

        }
        // Negative filter Method
        public void NegativeM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: -1, G2: -1, B3: -1, A4: 1, R5: 1, G5: 1, B5: 1, T5: 1);
            PictureBCG = pictureBox1.Image;
        }
        // Gray Scale Image Method
        public void GrayScaleM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: .3f, G1: .3f, B1: .3f, R2: .59f, G2: .59f, B2: .59f, R3: .11f, G3: .11f, B3: .11f, A4: 1, T5: 1);
            PictureBCG = pictureBox1.Image;
        }
        // Sepia Image Method
        public void SepiaM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: .393f, G1: .349f, B1: .272f, R2: .769f, G2: .686f, B2: .543f, R3: .189f, G3: .168f, B3: .131f, A4: 1, T5: 1);
            PictureBCG = pictureBox1.Image;
        }
        // Swap Color Method 
        public void SwapM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, B1: 1f, G2: 1f, R3: 1f, A4: 1, T5: 1);
            PictureBCG = pictureBox1.Image;
        }
        // Black and White Image Method 
        public void BlackWhiteM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: 1.5f, G1: 1.5f, B1: 1.5f, R2: 1.5f, G2: 1.5f, B2: 1.5f, R3: 1.5f, G3: 1.5f, B3: 1.5f, A4: 1, R5: -1, G5: -1, B5: -1, T5: 1);
            PictureBCG = pictureBox1.Image;
        }
        // Polariod Image Method
        public void PolaroidM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: 1.438f, G1: -0.062f, B1: -0.062f, R2: -0.122f, G2: 1.378f, B2: -0.122f, R3: -0.016f, G3: -0.016f, B3: 1.483f, A4: 1, R5: -0.03f, G5: 0.05f, B5: -0.02f, T5: 1);
            PictureBCG = pictureBox1.Image;
        }
        // Achromatopsia Image Method
        public void AchromatopsiaM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: 0.299f, G1: 0.587f, B1: 0.114f, R2: 0.299f, G2: 0.587f, B2: 0.114f, R3: 0.299f, G3: 0.587f, B3: 0.114f, A4: 1, T5: 1);
            PictureBCG = pictureBox1.Image;
        }

        // Save Image Method
        public void SaveImage()
        {
            ImageSave Save = new ImageSave(pictureBox1.Image);
        }
        // Filter Image Button To Open filter Image Panel
        private void FilterImageButton_Click(object sender, EventArgs e)
        {
            CropPanel.Hide();
            EnhancePanel.Hide();
            BCGPanel.Hide();
            RotatePanel.Hide();
            FlipPanel.Hide();
            FilterPanel.Show();
        }
        // Flip Image Button To Open Flip Image Panel
        private void FlipImageButton_Click(object sender, EventArgs e)
        {
            CropPanel.Hide();
            EnhancePanel.Hide();
            FlipPanel.Show();
            FilterPanel.Show();
            RotatePanel.Show();
            BCGPanel.Hide();
        }
        // To Flip Up to Down 
        private void FlipUpToDownButton_Click(object sender, EventArgs e)
        {
            try
            {
                Picture = pictureBox1.Image;
                Picture.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBox1.Image = Picture;
            }
            catch
            {
                MessageBox.Show("No Image");
            }
        }
        // To Flip Right to Left
        private void FlipRightToLeftButton_Click(object sender, EventArgs e)
        {
            try
            {
                Picture = pictureBox1.Image;
                Picture.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox1.Image = Picture;
            }
            catch
            {
                MessageBox.Show("No Image");
            }
        }
        // Rotate Image Button to Open Rotate Image Panel
        private void RotateImageButton_Click(object sender, EventArgs e)
        {
            CropPanel.Hide();
            EnhancePanel.Hide();
            FilterPanel.Show();
            FlipPanel.Hide();
            RotatePanel.Show();
            BCGPanel.Hide();
        }
        // To  Rotate Left
        private void RotateLeftButton_Click(object sender, EventArgs e)
        {
            try
            {
                Picture = pictureBox1.Image;
                Picture.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Image = Picture;
            }
            catch
            {
                MessageBox.Show("No Image");
            }
        }
        // To Rotate Right
        private void RotateRightButton_Click(object sender, EventArgs e)
        {
            try
            {
                Picture = pictureBox1.Image;
                Picture.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = Picture;
            }
            catch
            {
                MessageBox.Show("No Image");
            }
        }
        // BCG Image Button To Open BCG Image Panel
        private void BCGImageButton_Click(object sender, EventArgs e)
        {
            CropPanel.Hide();
            EnhancePanel.Hide();
            FilterPanel.Show();
            FlipPanel.Show();
            RotatePanel.Show();
            BCGPanel.Show();
        }
        // Image Brightness Track Bar 
        private void BrightnessTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            reload();
            BrightnessM();
        }
        // Image Brightness Method
        public void BrightnessM()
        {
            float B = BrightnessTrackBar.Value * 0.01f;
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(PictureBCG, R1: 1, G2: 1, B3: 1, A4: 1, R5: B, G5: B, B5: B, A5: 1, T5: 1);
        }
        // Image Contrast Track Bar
        private void ContrastTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            reload();
            ContrastM();
        }
        // Image Contrast Method 
        public void ContrastM()
        {
            float C = 0.01f * ContrastTrackBar.Value;
            float t = 0.5f * (1f - C);
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(PictureBCG, R1: C, G2: C, B3: C, A4: 1, T1: t, T2: t, T3: t, T4: 1, T5: 1);
        }
        // Image Transparency Track Bar 
        private void GammaTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            reload();
            GammaM();
        }
        //Image Transparency Method  
        public void GammaM()
        {
            float G = TransparencyTrackBar.Value * 0.1f;
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(PictureBCG, R1: 1, G2: 1, B3: 1, A4: G, T5: 1);
        }
        // Open Image Method
        public void OpenImageButtonM()
        {
            OpenImage obj = new OpenImage();
            Picture = obj.Open();
            if (Picture != null)
            {
                SaveImageButton.Enabled = true;
                NoCropImage = Picture;
                PictureReload = Picture;
                PictureBCG = Picture;
                pictureBox1.Image = Picture;
                OpenImageButton.Visible = false;
            }
        }
        // Reset Image Method
        public void ResetImageButtonM()
        {
            if (pictureBox1.Image != null)
            {
                SaveImage();
                ResetImageButtonM2();
            }
            else
            {
                ResetImageButtonM2();
                OpenImageButtonM();
            }
        }
        public void ResetImageButtonM2()
        {
            pictureBox1.Image = null;
            OpenImageButton.Visible = true;
            Picture = null;
            PictureReload = null;
            PictureBCG = null;
            SaveImageButton.Enabled = false;
            metroPanel2.Show();
            EnhancePanel.Hide();
            BCGPanel.Hide();
            RotatePanel.Hide();
            FlipPanel.Hide();
            FilterPanel.Hide();
            CropPanel.Hide();

        }
        // Reload Image Method
        public void reload()
        {
            Picture = PictureReload;
            pictureBox1.Image = Picture;
        }
        // Enhance Image Button to Open Enhance Panel 
        private void EnhanceImageButton_Click(object sender, EventArgs e)
        {
            EnhancePanel.Show();
            FilterPanel.Show();
            FlipPanel.Show();
            RotatePanel.Show();
            BCGPanel.Show();
            CropPanel.Hide();
        }
        private void RedTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            reload();
            Hue();
        }
        private void BlueTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            reload();
            Hue();

        }
        private void GreenTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            reload();
            Hue();
        }
        public void Hue()
        {
            float Red = RedTrackBar.Value * 0.01f;
            float Green = GreenTrackBar.Value * 0.01f;
            float Blue = BlueTrackBar.Value * 0.01f;
            Filters Obj = new Filters();
            pictureBox1.Image = Obj.PIC(Picture, R1: Red, G2: Green, B3: Blue, A4: 1, T5: 1);
        }
        private void CropImageButton_Click(object sender, EventArgs e)
        {
            MakeSelection = true;
            EnhancePanel.Show();
            FilterPanel.Show();
            FlipPanel.Show();
            RotatePanel.Show();
            BCGPanel.Show();
            CropPanel.Show();
            
        }


        private void ReddishImageButton_Click(object sender, EventArgs e)
        {
            ReddishImageButtonM();
        }
        public void ReddishImageButtonM()
        {
            Filters obj = new Filters();
            pictureBox1.Image = obj.PIC(Picture, R1: 0.627f, G1: 0.320f, B1: -0.039f, T1: 9.651f, R2: 0.025f, G2: 0.644f, B2: 0.032f, T2: 7.462f, R3: 0.0466f, G3: -0.085f, B3: 0.524f, T3: 5.159f, A4: 1, T5: 1);
            PictureBCG = pictureBox1.Image;
        }
        // Form Closing to check if you want to save or not!
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                DialogResult Dr = MessageBox.Show("Do You Want To Save And Exit", "Exit", MessageBoxButtons.YesNo);

                if (Dr == DialogResult.No)
                {
                    Application.ExitThread();
                }
                else if (Dr == DialogResult.Yes)
                {
                    SaveImage();
                    Application.ExitThread();
                }
            }
            else
            {
                Application.Exit();
            }
        }
    
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
            if (MakeSelection)
            {

                try
                {
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        Cursor = Cursors.Cross;
                        cropX = e.X;
                        cropY = e.Y;

                        cropPen = new Pen(Color.Black, 1);
                        cropPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                    }
                    pictureBox1.Refresh();
                }
                catch
                {
                    MessageBox.Show("Error");
                }

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (MakeSelection)
            { 
                Cursor = Cursors.Default;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
             Cursor = Cursors.Default;
                if (MakeSelection)
                {
                    try
                    {
                        if (pictureBox1.Image == null)
                            return;
                        if (e.Button == System.Windows.Forms.MouseButtons.Left)
                        {
                            pictureBox1.Refresh();
                            cropWidth = e.X - cropX;
                            cropHeight = e.Y - cropY;
                            pictureBox1.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error!");
                    }
                }
            }
        private void CropItImageButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            try
            {
                if (cropWidth < 1)
                {
                    return;
                }
                Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
                Bitmap OriginalImage = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
                Bitmap _img = new Bitmap(cropWidth, cropHeight);
                Graphics g = Graphics.FromImage(_img);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);
                pictureBox1.Image = _img;
                PictureReload = pictureBox1.Image;
            }
            catch
            {
                MessageBox.Show("NO Image");
            }
        }

        private void CropCancelButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = NoCropImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
