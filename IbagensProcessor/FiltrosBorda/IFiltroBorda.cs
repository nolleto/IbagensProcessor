using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace IbagensProcessor.FiltrosBorda
{
    interface IFiltroBorda
    {
        Image Executar(Image image, int[,] grayScale);
    }
}
