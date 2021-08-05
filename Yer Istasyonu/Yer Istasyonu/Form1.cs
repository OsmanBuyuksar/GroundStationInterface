using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;  
using System.Drawing.Imaging;

namespace Yer_Istasyonu
{

    public partial class Form1 : Form
    {
        const float hudCameraViewAngle = 180;
        Image img = Image.FromFile(@"C:\Users\osman\Desktop\Drone\2021\yer istasyonu\Resimler\arkaplan.png");
        int roll = 0;
        int pitch = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void txtBoxRoll_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(txtBoxRoll.Text,out roll))
            {
                 roll = int.Parse(txtBoxRoll.Text);
                 RotatingImg.BackgroundImage = DrawHUD(RotatingImg, pitch);
                 RotatingImg.BackgroundImage = Rotate_Image(img,roll,RotatingImg);
            }
        }
        private void txtBoxPitch_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(txtBoxPitch.Text, out pitch)) 
            {
                pitch = Convert.ToInt32(txtBoxPitch.Text);
                 img = DrawHUD(RotatingImg, pitch);
                 RotatingImg.BackgroundImage = Rotate_Image(img, roll, RotatingImg);
            }
 
        }
        private Image Rotate_Image(Image image, float angle, PictureBox rotatingPicBox)
        {

            Bitmap img = new Bitmap(image.Width, image.Height);

            Graphics gfx = Graphics.FromImage(img);

            gfx.TranslateTransform(img.Width / 2, img.Height / 2);

            gfx.RotateTransform(angle);

            gfx.DrawImage(image, -img.Width / 2, -img.Height / 2,image.Width,image.Height);

            gfx.Dispose();

            return img;

        }
        private Image DrawHUD(PictureBox picBox,float angle)
        {
            float y = picBox.Size.Height;
            float g = picBox.Size.Width;
            Bitmap img = new Bitmap((int)g, (int)y);
            Graphics gfx = Graphics.FromImage(img);


            if(angle < hudCameraViewAngle / 2 && angle > -hudCameraViewAngle/2)
            {
                float ratio = (hudCameraViewAngle/2 - angle) / (hudCameraViewAngle/2 + angle);//MathF.Tan(hudCameraViewAngle - angle) / MathF.Tan(hudCameraViewAngle + angle);
                float sky_h = y / (1 / ratio + 1);
                float grnd_h = y / (ratio + 1);



                RectangleF sky = new RectangleF(0,0,g,sky_h);
                RectangleF grnd = new RectangleF(0, sky_h, g, grnd_h);

                gfx.FillRectangle(Brushes.Aqua, sky);
                gfx.FillRectangle(Brushes.Brown, grnd);
            }
            else if(angle <= hudCameraViewAngle / 2)
            {
                RectangleF sky = new RectangleF(0, 0, g, y);
                gfx.FillRectangle(Brushes.Aqua, sky);
            }
            else if(angle >= hudCameraViewAngle / 2)
            {
                RectangleF grnd = new RectangleF(0, 0, g, y);
                gfx.FillRectangle(Brushes.Brown, grnd);
            }
            gfx.DrawImage(img, 0, 0, (int)g, (int)y);
            gfx.Dispose();

            return img;
        }
    }
}
