using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IbagensProcessor.DeteccaoFormas
{
    public class Circulo
    {
        public static int taxaErro
        {
            get
            {
                return 15;
            }
        }

        public static bool E_Circulo(Ponto pontoCentral, int raio, int[,] grayScale)
        {
            //Muito pequeno para identificar com precisão
            if (raio < 5) return true;
            int ld = 0,
                le = 0,
                eb = 0,
                ea = 0,
                db = 0,
                da = 0,
                c = 0,
                b = 0,
                i = 1;

            bool Bld = true,
                Ble = true,
                Beb = true,
                Bea = true,
                Bdb = true,
                Bda = true,
                Bc = true,
                Bb = true;
            //for (int i = 1; i < raio; i++)
            while (true)
            {
                var raioFaltante = raio - i;
                //indo para o cima
                if (Bc && Validar(pontoCentral.X, pontoCentral.Y + i, grayScale, raioFaltante, 5)) { c++; } else { Bc = false; }
                //indo para o baixo
                if (Bb && Validar(pontoCentral.X, pontoCentral.Y - i, grayScale, raioFaltante, 5)) { b++; } else { Bb = false; }
                //indo para o lado direito
                if (Bld && Validar(pontoCentral.X + i, pontoCentral.Y, grayScale, raioFaltante, 5)) { ld++; } else { Bld = false; }
                //indo para o lado esquerdo
                if (Ble && Validar(pontoCentral.X - i, pontoCentral.Y, grayScale, raioFaltante, 5)) { le++; } else { Ble = false; }
                //indo para diagonal esquerda baixa
                if (Beb && Validar(pontoCentral.X - i, pontoCentral.Y - i, grayScale, raioFaltante)) { eb++; } else { Beb = false; }
                //indo para diagonal esquerda alta
                if (Bea && Validar(pontoCentral.X - i, pontoCentral.Y + i, grayScale, raioFaltante)) { ea++; } else { Bea = false; }
                //indo para diagonal direita baixa
                if (Bdb && Validar(pontoCentral.X + i, pontoCentral.Y - i, grayScale, raioFaltante)) { db++; } else { Bdb = false; }
                //indo para diagonal direita alta
                if (Bda && Validar(pontoCentral.X + i, pontoCentral.Y + i, grayScale, raioFaltante)) { da++; } else { Bda = false; }
                if (!Bld && !Ble && !Beb && !Bea && !Bdb && !Bda && !Bc && !Bb)
                {
                    break;
                }
                i++;
            }

            if (new int[] { ld, le, c, b, eb, ea, db, da }.Any(a => a == 0)) return false;
            var coe1 = CoeficienteVariacao(new int[] { ld, le, c, b });
            var coe2 = CoeficienteVariacao(new int[] { eb, ea, db, da });
            var coe3 = CoeficienteVariacao(new int[] { Convert.ToInt32(coe1), Convert.ToInt32(coe2) });

            if (coe3 <= 50)
            {
                System.Diagnostics.Debug.WriteLine("coeficienteVariacao: " + coe3);
            }
            return coe1 < 5 && coe2 < 5 &&coe3 <= 15;
        }

        public static bool NaoPreto(int x, int y, int[,] grayScale)
        {
            if (x < 0 || y < 0) return true;
            return grayScale[x, y] != 0;
        }

        public static double CoeficienteVariacao(int[] values)
        {
            var count = values.Count();
            var media = values.Sum() / count;
            var desvioPadrao = Math.Sqrt(values.Sum(x => Math.Pow((x - media), 2)) / (count - 1));
            return 100 * (desvioPadrao / media);
        }

        public static bool Validar(int x, int y, int[,] grayScale, int raioFaltante, int? erro = null)
        {
            if (x < 0 || y < 0) return false;
            var g = grayScale[x, y];
            return g == 0;
            /*var ok = g == 0;
            if (ok) return true;
            if (raioFaltante <= (erro.HasValue ? erro.Value : taxaErro))
            {
                return true;
            }
            return false;*/
        }

        public Circulo()
        {

        }
    }
}
