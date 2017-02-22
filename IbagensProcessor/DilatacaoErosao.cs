using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace IbagensProcessor
{
    public enum FiltroProcesso
    {
        DILATACAO,
        EROSAO
    }

    public class DilatacaoErosao
    {
        public ImageComplex ImageComplex { get; set; }
        public FiltroDilatacao Filtro { get; set; }
        public FiltroProcesso FiltroFundo { get; set; }

        public DilatacaoErosao(ImageComplex image, FiltroDilatacao filtro, FiltroProcesso filtroFundo)
        {
            this.ImageComplex = image;
            this.Filtro = filtro;
            this.FiltroFundo = filtroFundo;
        }

        public Image Processar()
        {
            Bitmap b = new Bitmap(ImageComplex.Image);
            Bitmap result = new Bitmap(ImageComplex.Image);
            var scale = FiltroFundo == FiltroProcesso.DILATACAO ? ImageComplex.InvertedGrayScale : ImageComplex.GrayScale;
            for (int y = 1; y < b.Height - 1; y++)
            {
                for (int x = 1; x < b.Width - 1; x++)
                {
                    int big = Filtro.BigOne(
                        scale[x, y - 1],
                        scale[x, y + 1],
                        scale[x, y],
                        scale[x - 1, y],
                        scale[x + 1, y]
                    );

                    if (FiltroFundo == FiltroProcesso.DILATACAO)
                        big = 255 - big;

                    Color color = Color.FromArgb(big, big, big);

                    result.SetPixel(x, y - 1, color);
                    result.SetPixel(x, y + 1, color);
                    result.SetPixel(x, y, color);
                    result.SetPixel(x + 1, y, color);
                    result.SetPixel(x - 1, y, color);
                }
            }

            return result;
        }
    }

    public class FiltroDilatacao
    {
        public int Up { get; set; }
        public int Down { get; set; }
        public int Center { get; set; }
        public int Left { get; set; }
        public int Right { get; set; }

        public FiltroDilatacao(int number)
        {
            this.Up = number;
            this.Down = number;
            this.Center = number;
            this.Left = number;
            this.Right = number;
        }

        public int BigOne(int up, int down, int center, int left, int right)
        {
            List<int> numeros = new List<int>();
            numeros.Add(up + this.Up);
            numeros.Add(down + this.Down);
            numeros.Add(center + this.Center);
            numeros.Add(right + this.Right);
            numeros.Add(left + this.Left);

            int max = numeros.Max();
            if (max > 255)
                max = 255;
            else if (max == this.Up)
                max = 0;

            return max;
        }
    }
}
