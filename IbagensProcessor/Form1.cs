using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using IbagensProcessor.DeteccaoFormas;

namespace IbagensProcessor
{
    public partial class Form1 : Form
    {
        private Image image = null;
        private int[] grayHistogram = new int[256];
        private int[,] grayScale = new int[0,0];


        private int mediana;
        private int moda;
        private int media;
        private decimal variancia;
        private int cima125;
        private int baixo125;

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                DataGridViewRow row2 = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                row.Cells[0].Value = 0;
                row.Cells[1].Value = 0;
                row.Cells[2].Value = 0;
                row2.Cells[0].Value = 1;
                row2.Cells[1].Value = 1;
                row2.Cells[2].Value = 1;

                dataGridView1.Rows.Add(row);
                dataGridView2.Rows.Add(row2);

            }
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;

            cbFiltroBorda.DataSource = Enum.GetValues(typeof(FiltroBorda));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var file = GerenciadorArquivo.OpenFile();
            if (file != null)
            {
                image = Image.FromStream(file);
                pictureBox1.Image = image;
                pbImageTransf.Image = null;

                Analisar();
            }
        }

        private void btnHistograma_Click(object sender, EventArgs e)
        {
            if (image == null)
                MessageBox.Show("Nenhuma imagem carregada!");

            var form = new frmHistograma(grayHistogram);
            form.ShowDialog(this);
        }

        private void Analisar()
        {
            Reset();
            Bitmap b = new Bitmap(image);
            int diagonal = b.Width;

            grayScale = new int[b.Width, b.Height];

            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    Color c = b.GetPixel(x, y);
                    int grayValue = (int)((c.R * .3) + (c.G * .59) + (c.B * .11));
                    grayScale[x, y] = grayValue;
                    grayHistogram[grayValue] += 1;

                    if (grayValue <= 125)
                    {
                        if (y < diagonal)
                        {
                            baixo125++;
                        }
                        else
                        {
                            cima125++;
                        }
                    }
                }
                diagonal--;
            }

            GetMedia();
            GetMediana();
            GetModa();
            GetVariancia();
            tb125baixo.Text = baixo125.ToString();
            tb125cima.Text = cima125.ToString();
        }

        private void GetMedia()
        {
            int sumGrayscale = 0;
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    sumGrayscale += grayScale[x, y];
                }
            }

            int media = sumGrayscale / (image.Width * image.Height);
            this.media = media;
            tbMedia.Text = media.ToString();
        }

        private void GetVariancia()
        {
            int variancia = 0;

            for (int y = 0; y < image.Width; y++)
            {
                for (int x = 0; x < image.Height; x++)
                {
                    variancia += (grayScale[y, x] - this.media) ^ 2;
                }
            }

            this.variancia = variancia;

            tbVariancia.Text = variancia.ToString();
        }

        private void GetModa()
        {
            var itens = grayHistogram.Select((value, index) => new { Index = index, Valor = value });
            int maxValue = itens.Max(x => x.Valor);
            int maxIndex = itens.FirstOrDefault(x => x.Valor == maxValue).Index;

            this.moda = maxIndex;

            tbModa.Text = maxIndex.ToString();
        }

        private void GetMediana()
        {
            var grayList = new List<int>();

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    grayList.Add(grayScale[x, y]);
                }
            }

            grayList = grayList.OrderBy(x => x).ToList();

            int mediana;
            if ((grayList.Count % 2) == 0)
            {
                int index = grayList.Count / 2;
                mediana = ((grayList[index] + grayList[index + 1]) / 2);
            }
            else
            {
                int index = (grayList.Count / 2);
                mediana = grayList[index];
            }

            this.mediana = mediana;

            tbMediana.Text = mediana.ToString();
        }

        private void Reset()
        {
            mediana = 0;
            moda = 0;
            media = 0;
            variancia = 0;

            for (int i = 0; i < grayHistogram.Length; i++)
            {
                grayHistogram[i] = 0;
            }
        }

        private void btnTransf1_Click(object sender, EventArgs e)
        {
            TransformarImagem(new Action<Bitmap, int, int, int>((b, grayValue, x , y) => {
                if (grayValue >= media)
                {
                    b.SetPixel(x, y, Color.Black);
                }
            }));
        }

        private void btnTransf2_Click(object sender, EventArgs e)
        {
            TransformarImagem(new Action<Bitmap, int, int, int>((b, grayValue, x, y) =>
            {
                if (grayValue >= moda)
                {
                    b.SetPixel(x, y, Color.FromArgb(100, 100, 100));
                }
            }));
        }

        private void btnTransf3_Click(object sender, EventArgs e)
        {
            TransformarImagem(new Action<Bitmap, int, int, int>((b, grayValue, x, y) =>
            {
                if (grayValue >= mediana)
                {
                    b.SetPixel(x, y, Color.White);
                }
            }));
        }

        private void TransformarImagem(Action<Bitmap, int, int, int> action)
        {
            if (image == null)
            {
                MessageBox.Show("Você deve carregar uma imagem primeiro!");
                return;
            }

            var b = new Bitmap(image);

            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    Color c = b.GetPixel(x, y);
                    int grayValue = (int)((c.R * .3) + (c.G * .59) + (c.B * .11));

                    action.Invoke(b, grayValue, x, y);
                }
            }

            pbImageTransf.Image = b;
        }

        private void btnTransf4_Click(object sender, EventArgs e)
        {
            TransformarImagem(new Action<Bitmap, int, int, int>((b, grayValue, x, y) =>
            {
                if (grayValue < media)
                {
                    b.SetPixel(x, y, Color.FromArgb(50, 50, 50));
                }
            }));
        }

        private void btnTransf5_Click(object sender, EventArgs e)
        {
            TransformarImagem(new Action<Bitmap, int, int, int>((b, grayValue, x, y) =>
            {
                if (grayValue > mediana)
                {
                    b.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }

                if (grayValue < media)
                {
                    b.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                }
            }));
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (image == null) return;
            var btn = (Button)sender;
            btn.Enabled = false;
            var vetor = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                vetor[i, 0] = Int16.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                vetor[i, 1] = Int16.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                vetor[i, 2] = Int16.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            Bitmap b = new Bitmap(image);
            Bitmap result = new Bitmap(b.Width, b.Height);
            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    var p = b.GetPixel(x, y);
                    var x1 = x * vetor[0, 0] + y * vetor[1, 0] + 1 * vetor[2, 0];
                    var y1 = x * vetor[0, 1] + y * vetor[1, 1] + 1 * vetor[2, 1];
                    //var z1 = x * vetor[0, 2] + y * vetor[1, 2] + 1 * vetor[2, 2];
                    if (x1 < 0)
                    {
                        x1 = b.Width + x1;
                    }
                    if (y1 < 0)
                    {
                        y1 = b.Height + y1;
                    }

                    if (x1 >= 0 && x1 < b.Width && y1 >= 0 && y1 < b.Height)
                    {
                        result.SetPixel(x1, y1, p);
                    }
                }
            }
            pbImageTransf.Image = result;
            btn.Enabled = true;
        }

        private void OnCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var dataGrid = (DataGridView)sender;
                var field = dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var rgx = new Regex("^(-?)[0-9]+$");
                if (!rgx.IsMatch(field.Value.ToString()))
                {
                    field.Value = "0";
                }
            }
        }

        private void btnProcessarSegmentacao_Click(object sender, EventArgs e)
        {
            if (image == null) return;
            var btn = (Button)sender;
            btn.Enabled = false;
            var vetor = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                vetor[i, 0] = Int16.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString());
                vetor[i, 1] = Int16.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString());
                vetor[i, 2] = Int16.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString());
            }
            Bitmap b = new Bitmap(image);
            Bitmap result = new Bitmap(b.Width, b.Height);
            for (int x = 0; x < b.Width-2; x++)
            {
                for (int y = 0; y < b.Height-2; y++)
                {
                    int grayResult = 0;
                    for (int convX = 0; convX < 3; convX++)
                    {
                        for (int convY = 0; convY < 3; convY++)
                        {
                            grayResult += grayScale[x+convX, y+convY] * vetor[convX, convY];
                        }   
                    }
                    grayResult = grayResult / 9;
                    if (grayResult > 255) grayResult = 255;
                    else if (grayResult < 0) grayResult = 0;
                    result.SetPixel(x + 1, y + 1, Color.FromArgb(grayResult, grayResult, grayResult));
                }
            }
            pbImageTransf.Image = result;
            btn.Enabled = true;
        }

        private void btnFiltroBorda_Click(object sender, EventArgs e)
        {
            FiltroBorda filtro;
            Enum.TryParse<FiltroBorda>(cbFiltroBorda.SelectedValue.ToString(), out filtro);

            Image imagemProcessada = null;
            FiltrosBorda.IFiltroBorda filtroBorda = null;
            switch (filtro)
            {
                case FiltroBorda.ROBERTS:
                    filtroBorda = new FiltrosBorda.Roberts();
                    break;
                case FiltroBorda.PREWITT:
                    filtroBorda = new FiltrosBorda.Prewitt();
                    break;
                case FiltroBorda.SOBEL:
                    filtroBorda = new FiltrosBorda.Sobel();
                    break;
                case FiltroBorda.ROBINSON:
                    filtroBorda = new FiltrosBorda.Robinson();
                    break;
                case FiltroBorda.KIRSCH:
                    filtroBorda = new FiltrosBorda.Kirsch();
                    break;
                case FiltroBorda.MAR_HIDRELT:
                    filtroBorda = new FiltrosBorda.MarrHildret();
                    break;
                /*case FiltroBorda.LAPLACIANO:
                    filtroBorda = new FiltrosBorda.Laplaciano();
                    break;*/
                default:
                    break;
            }

            imagemProcessada = filtroBorda.Executar(image, grayScale);
            pbImageTransf.Image = imagemProcessada;
        }

        private void btnErosao_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                MessageBox.Show("Você deve carregar uma imagem primeiro!");
                return;
            }

            ImageComplex imageComplex = new ImageComplex(image);

            if (pbImageTransf.Image != null)
            {
                imageComplex.Image = pbImageTransf.Image;
            }

            FiltroDilatacao filtro = new FiltroDilatacao(10);
            DilatacaoErosao erosao = new DilatacaoErosao(imageComplex, filtro, FiltroProcesso.EROSAO);

            pbImageTransf.Image = erosao.Processar();
        }

        private void btnDilatacao_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                MessageBox.Show("Você deve carregar uma imagem primeiro!");
                return;
            }

            ImageComplex imageComplex = new ImageComplex(image);

            if (pbImageTransf.Image != null)
            {
                imageComplex.Image = pbImageTransf.Image;
            }

            FiltroDilatacao filtro = new FiltroDilatacao(10);
            DilatacaoErosao dilatacao = new DilatacaoErosao(imageComplex, filtro, FiltroProcesso.DILATACAO);

            pbImageTransf.Image = dilatacao.Processar();
        }

        private void btnAbertura_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                MessageBox.Show("Você deve carregar uma imagem primeiro!");
                return;
            }

            ImageComplex imageComplex = new ImageComplex(image);

            if (pbImageTransf.Image != null)
            {
                imageComplex.Image = pbImageTransf.Image;
            }

            FiltroDilatacao filtro = new FiltroDilatacao(10);
            DilatacaoErosao erosao = new DilatacaoErosao(imageComplex, filtro, FiltroProcesso.EROSAO);
            imageComplex.Image = erosao.Processar();
            DilatacaoErosao dilatacao = new DilatacaoErosao(imageComplex, filtro, FiltroProcesso.DILATACAO);
            pbImageTransf.Image = dilatacao.Processar();
        }

        private void btnFechamento_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                MessageBox.Show("Você deve carregar uma imagem primeiro!");
                return;
            }

            ImageComplex imageComplex = new ImageComplex(image);

            if (pbImageTransf.Image != null)
            {
                imageComplex.Image = pbImageTransf.Image;
            }

            FiltroDilatacao filtro = new FiltroDilatacao(10);
            DilatacaoErosao dilatacao = new DilatacaoErosao(imageComplex, filtro, FiltroProcesso.DILATACAO);
            imageComplex.Image = dilatacao.Processar();
            DilatacaoErosao erosao = new DilatacaoErosao(imageComplex, filtro, FiltroProcesso.EROSAO);
            pbImageTransf.Image = erosao.Processar();
        }

        private void btnQuadrados_Click(object sender, EventArgs e)
        {
            var newImage = new ImageComplex(image);
            List<Quadrado> quadrados = new List<Quadrado>();
            int tamanho = 0;

            newImage.Transform((x, y, g) =>
            {
                if (!Blacklist(quadrados, x, y))
                {
                    if (g == 0)
                    {
                        tamanho = 0;
                        int aux = 0;
                        while (newImage.GrayScale[(x + (++aux)), y] == 0)
                        {
                            tamanho++;
                        }

                        var pontos = new Ponto[] { 
                        new Ponto(x, y),
                        new Ponto(x + tamanho, y),
                        new Ponto(x + tamanho, y + tamanho),
                        new Ponto(x, y + tamanho)
                    };

                        if (Quadrado.E_Quadrado(pontos, newImage.GrayScale))
                        {
                            quadrados.Add(new Quadrado(pontos[0], pontos[1], pontos[2], pontos[3], tamanho + 1));
                        }
                    }
                }
            });

            if (quadrados.Count() > 0)
            {
                var quadradoMaiorTamanho = quadrados.Max(x => x.Tamanho);
                var quadradoMenorTamanho = quadrados.Min(x => x.Tamanho);

                txtAreaQuadrado.Text = (quadradoMaiorTamanho * quadradoMaiorTamanho).ToString();
                txtPerimetroQuadrado.Text = (quadradoMenorTamanho * quadradoMenorTamanho).ToString();
            }
            else
            {
                MessageBox.Show("Nenhum quadrado encontrado!");
            }
        }

        public bool Blacklist(List<Quadrado> quadrados, int x, int y)
        {
            foreach (var quadrado in quadrados)
            {
                if (quadrado.TaNaBlack(x, y)) return true;
            }
            return false;
        }

        private void btnCirculos_Click(object sender, EventArgs e)
        {
            var newImage = new ImageComplex(image);

            double raio = 0;
            bool found = false;

            newImage.Transform((x, y, g) =>
            {
                if (!found)
                {
                    if (g == 0)
                    {
                        if (!(y > 0 && newImage.GrayScale[x, y - 1] == 0))
                        {
                            int aux = 0;
                            double tamanho = 0;
                            while (newImage.GrayScale[x, (y + (aux++))] == 0)
                            {
                                tamanho++;
                            }

                            int xAux = 0;
                            while (newImage.GrayScale[x + 1 + (xAux++), y] == 0) { }

                            int a = Convert.ToInt32(tamanho / 2);
                            var ok = Circulo.E_Circulo(new Ponto(x + (xAux / 2), y + a), a, newImage.GrayScale);
                            if (a > 0 && ok)
                            {
                                found = true;
                                raio = tamanho / 2;

                                double perimetro = 2 * Math.PI * raio;
                                double area = Math.PI * (raio * raio);
                                double circularidade = (perimetro * perimetro) / (4 * Math.PI * area);

                                txtAreaCirculo.Text = Math.Round(area, 4).ToString();
                                txtPerimetroCirculo.Text = Math.Round(perimetro, 4).ToString();
                                txtCircularidade.Text = Math.Round(circularidade).ToString();
                            }
                        }
                    }
                }
            });

            if (!found)
            {
                MessageBox.Show("Nenhum circulo encontrado!");
            }
        }

        
    }
}
