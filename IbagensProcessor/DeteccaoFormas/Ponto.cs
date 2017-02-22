using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IbagensProcessor.DeteccaoFormas
{
    public class Ponto
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Ponto(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static bool MesmoPonto(Ponto p1, int x, int y)
        {
            return p1.X == x && p1.Y == y;
        }

        public static bool MesmoPonto(Ponto p1, Ponto p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }
    }
}
