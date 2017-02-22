using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace IbagensProcessor
{
    public class ImageComplex
    {
        private int black { get; set; }
        private int white { get; set; }

        private Image image;
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                CalculateGrayscale();
            }
        }

        private int[,] grayScale;
        public int[,] GrayScale
        {
            get
            {
                return grayScale;
            }
        }

        private int[,] invertedGrayScale;
        public int[,] InvertedGrayScale
        {
            get
            {
                return invertedGrayScale;
            }
        }

        public ImageComplex(Image image)
        {
            this.Image = image;
        }

        private void CalculateGrayscale()
        {
            Bitmap b = new Bitmap(image);

            grayScale = new int[b.Width, b.Height];
            invertedGrayScale = new int[b.Width, b.Height];

            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    Color c = b.GetPixel(x, y);
                    int grayValue = (int)((c.R * .3) + (c.G * .59) + (c.B * .11));
                    grayScale[x, y] = grayValue;
                    invertedGrayScale[x, y] = 255 - grayValue;
                    
                }
            }

        }

        public void Transform(Action<int, int, int> action)
        {
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    action(x, y, grayScale[x, y]);
                }
            }
        }
    }
}
