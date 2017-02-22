using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace IbagensProcessor.FiltrosBorda
{
    public class Robinson : IFiltroBorda
    {
        private static int Threshold = 20;

        public Image Executar(System.Drawing.Image image, int[,] grayScale)
        {
            Bitmap b = new Bitmap(image);
            Bitmap result = new Bitmap(b.Width, b.Height);
            for (int x = 0; x < b.Width - 2; x++)
            {
                for (int y = 0; y < b.Height - 2; y++)
                {
                    int grayResult = 0;
                    int[] g = new int[8].Select(temp => 0).ToArray();

                    for (int convX = 0; convX < 3; convX++)
                    {
                        for (int convY = 0; convY < 3; convY++)
                        {
                            var gray = grayScale[x + (convX), y + (convY)];
                            g[0] += gray * mask1[convX, convY];
                            g[1] += gray * mask2[convX, convY];
                            g[2] += gray * mask3[convX, convY];
                            g[3] += gray * mask4[convX, convY];
                            g[4] += gray * mask5[convX, convY];
                            g[5] += gray * mask6[convX, convY];
                            g[6] += gray * mask7[convX, convY];
                            g[7] += gray * mask8[convX, convY];
                        }
                    }
                    if (g.Max() > 255)
                    {
                        grayResult = 255;
                    }

                    result.SetPixel(x + 1, y + 1, Color.FromArgb(grayResult, grayResult, grayResult));
                }
            }
            return result;
        }

        private static int[,] mask1 = new int[,]
		{
			{  -1, 0, 1 },
			{  -2,  0, 2 },
			{  -1, 0, 1 }
		};
        private static int[,] mask2 = new int[,]
		{
			{  0, 1, 2 },
			{  -1,  0, 1 },
			{  -2, -1, 0 }
		};
        private static int[,] mask3 = new int[,]
		{
			{  1, 2, 1 },
			{  0,  0, 0 },
			{  -1, -1, -1 }
		};
        private static int[,] mask4 = new int[,]
		{
			{  2, 1, 0 },
			{  1,  0, -1 },
			{  0, -1, -2 }
		};

        private static int[,] mask5 = new int[,]
		{
			{  1, 0, -1 },
			{  2,  0, -2 },
			{  1, 0, -1 }
		};
        private static int[,] mask6 = new int[,]
		{
			{  0, -1, -2 },
			{  1,  0, -1 },
			{  2, 1, 0 }
		};
        private static int[,] mask7 = new int[,]
		{
			{  -1, -2, -1 },
			{  0,  0, 0 },
			{  1, 2, 1 }
		};
        private static int[,] mask8 = new int[,]
		{
			{  -2, -1, 0 },
			{  -1,  0, 1 },
			{  0, 1, 2 }
		};
    }
}
