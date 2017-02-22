using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace IbagensProcessor.FiltrosBorda
{
    public class Roberts : IFiltroBorda
    {
        private static int Threshold = 20;

        public Image Executar(Image image, int[,] grayScale)
        {
            Bitmap b = new Bitmap(image);
            Bitmap result = new Bitmap(b.Width, b.Height);
            for (int x = 0; x < b.Width - 2; x++)
            {
                for (int y = 0; y < b.Height - 2; y++)
                {
                    int gx = 0;
                    int gy = 0;

                    for (int convX = 0; convX < 3; convX++)
                    {
                        for (int convY = 0; convY < 3; convY++)
                        {
                            var gray = grayScale[x + (convX), y + (convY)];
                            gx += gray * xKernel[convX, convY];
                            gy += gray * yKernel[convX, convY];
                        }
                    }
                    int grayResult = 0;
                    int g = Convert.ToInt32(Math.Sqrt(Math.Pow(gx, 2) + Math.Pow(gy, 2)));
                    if (g > Threshold)
                    {
                        grayResult = 255;
                    }
                    result.SetPixel(x + 1, y + 1, Color.FromArgb(grayResult, grayResult, grayResult));
                }
            }
            return result;
        }

        private static int[,] xKernel = new int[,]
		{
			{  0,0,0 },
			{  0,-1,0 },
			{  0,0,1 }
		};

        private static int[,] yKernel = new int[,]
		{
			{  0,0,0 },
			{  0,0,-1 },
			{  0,1,0 }
		};

    }
}
