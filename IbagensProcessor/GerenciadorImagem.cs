using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

namespace IbagensProcessor
{
    public static class GerenciadorImagem
    {
        private static System.Threading.SemaphoreSlim semaphore = new System.Threading.SemaphoreSlim(1);
        private static Image image;

        public static void SetImage(Image image)
        {
            GerenciadorImagem.image = image;
        }

        public static void Process()
        {
            new Thread(ProcessImage);
        }

        private static void ProcessImage() {
        }
    }

    public class ImagemAttribute
    {
        public int Media { get; set; }
    }
}
