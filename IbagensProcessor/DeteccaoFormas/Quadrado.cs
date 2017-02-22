using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IbagensProcessor.DeteccaoFormas
{
    public class Quadrado
    {
        public Ponto BaixoEsquerda, BaixoDireita, CimaDireita, CimaEsquerda;
        public int Tamanho { get; set; }

        public static bool E_Quadrado(Ponto[] pontos, int[,] grayScale)
        {
            if (pontos.Count() != 4) return false;
            for (int i = 0; i < 3; i++)
            {
                if (!LinhaReta(pontos[i], pontos[i+1], grayScale, i)) return false;
            }
            if (!LinhaReta(pontos[0], pontos[3], grayScale, 3)) return false;
            return true;
        }

        /*tipo => 
         * 0: BaixoEsquerda - BaixoDireita
         * 1: BaixoDireita - CimaDireita
         * 2: CimaDireita - CimaEsquerda
         * 3: CimaEsquerda - BaixoEsquerda
        */
        public static bool LinhaReta(Ponto a, Ponto b, int[,] grayScale, int tipo)
        {
            if (Ponto.MesmoPonto(a, b)) return false;
            //Varrer X
            if (a.X != b.X)
            {
                Ponto menor = a.X > b.X ? b : a;
                Ponto maior = a.X <= b.X ? b : a;
                for (int i = menor.X; i < maior.X; i++)
                {
                    if (grayScale[i, a.Y] != 0)
                        return false;
                    //verificar se o lado de fora é branco
                    if (tipo == 0 && a.Y > 0 && grayScale[i, a.Y - 1] == 0)
                    {
                        return false;
                    }
                    else if (tipo == 2 && grayScale[i, a.Y + 1] == 0) {
                        return false;
                    }
                }
            }
            else //Varrer Y
            {
                Ponto menor = a.Y > b.Y ? b : a;
                Ponto maior = a.Y <= b.Y ? b : a;
                for (int i = menor.Y; i < maior.Y; i++)
                {
                    if (grayScale[a.X, i] != 0)
                        return false;
                    //verificar se o lado de fora é branco
                    if (tipo == 1 && grayScale[a.X + 1, i] == 0)
                    {
                        return false;
                    }
                    else if (tipo == 3 && a.X > 0 && grayScale[a.X - 1, i] == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool TaNaBlack(int x, int y)
        {
            return (x >= BaixoEsquerda.X && x <= BaixoDireita.X) ||
                (y >= BaixoEsquerda.Y && y <= CimaEsquerda.Y);
        }

        

        public Quadrado(Ponto baixoEsquerda, Ponto baixoDireita, Ponto cimaDireita, Ponto cimaEsquerda, int tamanho)
        {
            this.BaixoEsquerda = baixoEsquerda;
            this.BaixoDireita = baixoDireita;
            this.CimaDireita = cimaDireita;
            this.CimaEsquerda = cimaEsquerda;
            this.Tamanho = tamanho;
        }
    }
}
