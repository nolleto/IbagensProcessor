namespace IbagensProcessor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPickImage = new System.Windows.Forms.Button();
            this.btnHistograma = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblVariancia = new System.Windows.Forms.Label();
            this.lblMediana = new System.Windows.Forms.Label();
            this.lblModa = new System.Windows.Forms.Label();
            this.tbModa = new System.Windows.Forms.TextBox();
            this.tbVariancia = new System.Windows.Forms.TextBox();
            this.tbMediana = new System.Windows.Forms.TextBox();
            this.tbMedia = new System.Windows.Forms.TextBox();
            this.pbImageTransf = new System.Windows.Forms.PictureBox();
            this.btnTransf1 = new System.Windows.Forms.Button();
            this.btnTransf2 = new System.Windows.Forms.Button();
            this.btnTransf3 = new System.Windows.Forms.Button();
            this.btnTransf4 = new System.Windows.Forms.Button();
            this.btnTransf5 = new System.Windows.Forms.Button();
            this.tb125baixo = new System.Windows.Forms.TextBox();
            this.tb125cima = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProcessarSegmentacao = new System.Windows.Forms.Button();
            this.cbFiltroBorda = new System.Windows.Forms.ComboBox();
            this.btnFiltroBorda = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDilatacao = new System.Windows.Forms.Button();
            this.btnAbertura = new System.Windows.Forms.Button();
            this.btnErosao = new System.Windows.Forms.Button();
            this.btnFechamento = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCirculos = new System.Windows.Forms.Button();
            this.btnQuadrados = new System.Windows.Forms.Button();
            this.txtAreaQuadrado = new System.Windows.Forms.TextBox();
            this.lblAreaQuadrado = new System.Windows.Forms.Label();
            this.txtPerimetroQuadrado = new System.Windows.Forms.TextBox();
            this.lblPerimetroQuadrado = new System.Windows.Forms.Label();
            this.txtPerimetroCirculo = new System.Windows.Forms.TextBox();
            this.lblPerimetroCirculo = new System.Windows.Forms.Label();
            this.txtAreaCirculo = new System.Windows.Forms.TextBox();
            this.lblAreaCirculo = new System.Windows.Forms.Label();
            this.lblCircularidade = new System.Windows.Forms.Label();
            this.txtCircularidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageTransf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(194, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPickImage
            // 
            this.btnPickImage.Location = new System.Drawing.Point(12, 12);
            this.btnPickImage.Name = "btnPickImage";
            this.btnPickImage.Size = new System.Drawing.Size(140, 23);
            this.btnPickImage.TabIndex = 1;
            this.btnPickImage.Text = "Escolher Imagem";
            this.btnPickImage.UseVisualStyleBackColor = true;
            this.btnPickImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHistograma
            // 
            this.btnHistograma.Location = new System.Drawing.Point(12, 41);
            this.btnHistograma.Name = "btnHistograma";
            this.btnHistograma.Size = new System.Drawing.Size(140, 23);
            this.btnHistograma.TabIndex = 2;
            this.btnHistograma.Text = "Exibir Histograma";
            this.btnHistograma.UseVisualStyleBackColor = true;
            this.btnHistograma.Click += new System.EventHandler(this.btnHistograma_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.Location = new System.Drawing.Point(12, 80);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(60, 20);
            this.lblMedia.TabIndex = 4;
            this.lblMedia.Text = "Média";
            this.lblMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVariancia
            // 
            this.lblVariancia.Location = new System.Drawing.Point(12, 170);
            this.lblVariancia.Name = "lblVariancia";
            this.lblVariancia.Size = new System.Drawing.Size(60, 20);
            this.lblVariancia.TabIndex = 5;
            this.lblVariancia.Text = "Variância";
            this.lblVariancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMediana
            // 
            this.lblMediana.Location = new System.Drawing.Point(12, 110);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(60, 20);
            this.lblMediana.TabIndex = 6;
            this.lblMediana.Text = "Mediana:";
            this.lblMediana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModa
            // 
            this.lblModa.Location = new System.Drawing.Point(12, 140);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(60, 20);
            this.lblModa.TabIndex = 7;
            this.lblModa.Text = "Moda:";
            this.lblModa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbModa
            // 
            this.tbModa.Enabled = false;
            this.tbModa.Location = new System.Drawing.Point(75, 141);
            this.tbModa.Name = "tbModa";
            this.tbModa.Size = new System.Drawing.Size(100, 20);
            this.tbModa.TabIndex = 8;
            // 
            // tbVariancia
            // 
            this.tbVariancia.Enabled = false;
            this.tbVariancia.Location = new System.Drawing.Point(75, 170);
            this.tbVariancia.Name = "tbVariancia";
            this.tbVariancia.Size = new System.Drawing.Size(100, 20);
            this.tbVariancia.TabIndex = 9;
            // 
            // tbMediana
            // 
            this.tbMediana.Enabled = false;
            this.tbMediana.Location = new System.Drawing.Point(75, 110);
            this.tbMediana.Name = "tbMediana";
            this.tbMediana.Size = new System.Drawing.Size(100, 20);
            this.tbMediana.TabIndex = 10;
            // 
            // tbMedia
            // 
            this.tbMedia.Enabled = false;
            this.tbMedia.Location = new System.Drawing.Point(75, 80);
            this.tbMedia.Name = "tbMedia";
            this.tbMedia.Size = new System.Drawing.Size(100, 20);
            this.tbMedia.TabIndex = 11;
            // 
            // pbImageTransf
            // 
            this.pbImageTransf.Location = new System.Drawing.Point(194, 279);
            this.pbImageTransf.Name = "pbImageTransf";
            this.pbImageTransf.Size = new System.Drawing.Size(319, 277);
            this.pbImageTransf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageTransf.TabIndex = 12;
            this.pbImageTransf.TabStop = false;
            // 
            // btnTransf1
            // 
            this.btnTransf1.Location = new System.Drawing.Point(12, 274);
            this.btnTransf1.Name = "btnTransf1";
            this.btnTransf1.Size = new System.Drawing.Size(140, 23);
            this.btnTransf1.TabIndex = 13;
            this.btnTransf1.Text = ">= Media = Preto";
            this.btnTransf1.UseVisualStyleBackColor = true;
            this.btnTransf1.Click += new System.EventHandler(this.btnTransf1_Click);
            // 
            // btnTransf2
            // 
            this.btnTransf2.Location = new System.Drawing.Point(12, 303);
            this.btnTransf2.Name = "btnTransf2";
            this.btnTransf2.Size = new System.Drawing.Size(140, 23);
            this.btnTransf2.TabIndex = 14;
            this.btnTransf2.Text = ">= Moda = 100";
            this.btnTransf2.UseVisualStyleBackColor = true;
            this.btnTransf2.Click += new System.EventHandler(this.btnTransf2_Click);
            // 
            // btnTransf3
            // 
            this.btnTransf3.Location = new System.Drawing.Point(12, 332);
            this.btnTransf3.Name = "btnTransf3";
            this.btnTransf3.Size = new System.Drawing.Size(140, 23);
            this.btnTransf3.TabIndex = 15;
            this.btnTransf3.Text = ">= Mediana = Branco";
            this.btnTransf3.UseVisualStyleBackColor = true;
            this.btnTransf3.Click += new System.EventHandler(this.btnTransf3_Click);
            // 
            // btnTransf4
            // 
            this.btnTransf4.Location = new System.Drawing.Point(12, 361);
            this.btnTransf4.Name = "btnTransf4";
            this.btnTransf4.Size = new System.Drawing.Size(140, 23);
            this.btnTransf4.TabIndex = 16;
            this.btnTransf4.Text = "< Media = 50";
            this.btnTransf4.UseVisualStyleBackColor = true;
            this.btnTransf4.Click += new System.EventHandler(this.btnTransf4_Click);
            // 
            // btnTransf5
            // 
            this.btnTransf5.Location = new System.Drawing.Point(12, 390);
            this.btnTransf5.Name = "btnTransf5";
            this.btnTransf5.Size = new System.Drawing.Size(140, 42);
            this.btnTransf5.TabIndex = 17;
            this.btnTransf5.Text = "> Mediana = 255 E < Media = 0";
            this.btnTransf5.UseVisualStyleBackColor = true;
            this.btnTransf5.Click += new System.EventHandler(this.btnTransf5_Click);
            // 
            // tb125baixo
            // 
            this.tb125baixo.Enabled = false;
            this.tb125baixo.Location = new System.Drawing.Point(75, 229);
            this.tb125baixo.Name = "tb125baixo";
            this.tb125baixo.Size = new System.Drawing.Size(100, 20);
            this.tb125baixo.TabIndex = 21;
            // 
            // tb125cima
            // 
            this.tb125cima.Enabled = false;
            this.tb125cima.Location = new System.Drawing.Point(75, 200);
            this.tb125cima.Name = "tb125cima";
            this.tb125cima.Size = new System.Drawing.Size(100, 20);
            this.tb125cima.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cima 125";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Baixo 125";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(6, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 190);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(224, 234);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(120, 23);
            this.btnProcessar.TabIndex = 23;
            this.btnProcessar.Text = "Processar Imagem";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Convolução";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Segmentação";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView2.Location = new System.Drawing.Point(9, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(335, 153);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellValueChanged);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // btnProcessarSegmentacao
            // 
            this.btnProcessarSegmentacao.Location = new System.Drawing.Point(224, 216);
            this.btnProcessarSegmentacao.Name = "btnProcessarSegmentacao";
            this.btnProcessarSegmentacao.Size = new System.Drawing.Size(120, 23);
            this.btnProcessarSegmentacao.TabIndex = 27;
            this.btnProcessarSegmentacao.Text = "Processar Imagem";
            this.btnProcessarSegmentacao.UseVisualStyleBackColor = true;
            this.btnProcessarSegmentacao.Click += new System.EventHandler(this.btnProcessarSegmentacao_Click);
            // 
            // cbFiltroBorda
            // 
            this.cbFiltroBorda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroBorda.Location = new System.Drawing.Point(9, 216);
            this.cbFiltroBorda.Name = "cbFiltroBorda";
            this.cbFiltroBorda.Size = new System.Drawing.Size(121, 21);
            this.cbFiltroBorda.TabIndex = 28;
            // 
            // btnFiltroBorda
            // 
            this.btnFiltroBorda.Location = new System.Drawing.Point(9, 244);
            this.btnFiltroBorda.Name = "btnFiltroBorda";
            this.btnFiltroBorda.Size = new System.Drawing.Size(121, 23);
            this.btnFiltroBorda.TabIndex = 29;
            this.btnFiltroBorda.Text = "Aplicar Filtro Borda";
            this.btnFiltroBorda.UseVisualStyleBackColor = true;
            this.btnFiltroBorda.Click += new System.EventHandler(this.btnFiltroBorda_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Controls.Add(this.tabPage4);
            this.tabs.Location = new System.Drawing.Point(519, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(371, 544);
            this.tabs.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnProcessar);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(363, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Convolução";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnFiltroBorda);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.cbFiltroBorda);
            this.tabPage2.Controls.Add(this.btnProcessarSegmentacao);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(363, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Segmentação";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDilatacao);
            this.tabPage3.Controls.Add(this.btnAbertura);
            this.tabPage3.Controls.Add(this.btnErosao);
            this.tabPage3.Controls.Add(this.btnFechamento);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(363, 518);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Erosao/Dilatacao";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDilatacao
            // 
            this.btnDilatacao.Location = new System.Drawing.Point(6, 35);
            this.btnDilatacao.Name = "btnDilatacao";
            this.btnDilatacao.Size = new System.Drawing.Size(120, 23);
            this.btnDilatacao.TabIndex = 31;
            this.btnDilatacao.Text = "Dilatação";
            this.btnDilatacao.UseVisualStyleBackColor = true;
            this.btnDilatacao.Click += new System.EventHandler(this.btnDilatacao_Click);
            // 
            // btnAbertura
            // 
            this.btnAbertura.Location = new System.Drawing.Point(6, 64);
            this.btnAbertura.Name = "btnAbertura";
            this.btnAbertura.Size = new System.Drawing.Size(120, 23);
            this.btnAbertura.TabIndex = 30;
            this.btnAbertura.Text = "Abertura";
            this.btnAbertura.UseVisualStyleBackColor = true;
            this.btnAbertura.Click += new System.EventHandler(this.btnAbertura_Click);
            // 
            // btnErosao
            // 
            this.btnErosao.Location = new System.Drawing.Point(6, 6);
            this.btnErosao.Name = "btnErosao";
            this.btnErosao.Size = new System.Drawing.Size(120, 23);
            this.btnErosao.TabIndex = 29;
            this.btnErosao.Text = "Erosão";
            this.btnErosao.UseVisualStyleBackColor = true;
            this.btnErosao.Click += new System.EventHandler(this.btnErosao_Click);
            // 
            // btnFechamento
            // 
            this.btnFechamento.Location = new System.Drawing.Point(6, 93);
            this.btnFechamento.Name = "btnFechamento";
            this.btnFechamento.Size = new System.Drawing.Size(120, 23);
            this.btnFechamento.TabIndex = 28;
            this.btnFechamento.Text = "Fechamento";
            this.btnFechamento.UseVisualStyleBackColor = true;
            this.btnFechamento.Click += new System.EventHandler(this.btnFechamento_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtCircularidade);
            this.tabPage4.Controls.Add(this.lblCircularidade);
            this.tabPage4.Controls.Add(this.txtPerimetroCirculo);
            this.tabPage4.Controls.Add(this.lblPerimetroCirculo);
            this.tabPage4.Controls.Add(this.txtAreaCirculo);
            this.tabPage4.Controls.Add(this.lblAreaCirculo);
            this.tabPage4.Controls.Add(this.txtPerimetroQuadrado);
            this.tabPage4.Controls.Add(this.lblPerimetroQuadrado);
            this.tabPage4.Controls.Add(this.txtAreaQuadrado);
            this.tabPage4.Controls.Add(this.lblAreaQuadrado);
            this.tabPage4.Controls.Add(this.btnCirculos);
            this.tabPage4.Controls.Add(this.btnQuadrados);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(363, 518);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Detecção";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCirculos
            // 
            this.btnCirculos.Location = new System.Drawing.Point(192, 46);
            this.btnCirculos.Name = "btnCirculos";
            this.btnCirculos.Size = new System.Drawing.Size(102, 43);
            this.btnCirculos.TabIndex = 1;
            this.btnCirculos.Text = "Processar Circulo";
            this.btnCirculos.UseVisualStyleBackColor = true;
            this.btnCirculos.Click += new System.EventHandler(this.btnCirculos_Click);
            // 
            // btnQuadrados
            // 
            this.btnQuadrados.Location = new System.Drawing.Point(6, 46);
            this.btnQuadrados.Name = "btnQuadrados";
            this.btnQuadrados.Size = new System.Drawing.Size(102, 43);
            this.btnQuadrados.TabIndex = 0;
            this.btnQuadrados.Text = "Processar Quadrados";
            this.btnQuadrados.UseVisualStyleBackColor = true;
            this.btnQuadrados.Click += new System.EventHandler(this.btnQuadrados_Click);
            // 
            // txtAreaQuadrado
            // 
            this.txtAreaQuadrado.Enabled = false;
            this.txtAreaQuadrado.Location = new System.Drawing.Point(69, 118);
            this.txtAreaQuadrado.Name = "txtAreaQuadrado";
            this.txtAreaQuadrado.Size = new System.Drawing.Size(100, 20);
            this.txtAreaQuadrado.TabIndex = 13;
            // 
            // lblAreaQuadrado
            // 
            this.lblAreaQuadrado.Location = new System.Drawing.Point(6, 118);
            this.lblAreaQuadrado.Name = "lblAreaQuadrado";
            this.lblAreaQuadrado.Size = new System.Drawing.Size(60, 20);
            this.lblAreaQuadrado.TabIndex = 12;
            this.lblAreaQuadrado.Text = "Area:";
            this.lblAreaQuadrado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPerimetroQuadrado
            // 
            this.txtPerimetroQuadrado.Enabled = false;
            this.txtPerimetroQuadrado.Location = new System.Drawing.Point(69, 141);
            this.txtPerimetroQuadrado.Name = "txtPerimetroQuadrado";
            this.txtPerimetroQuadrado.Size = new System.Drawing.Size(100, 20);
            this.txtPerimetroQuadrado.TabIndex = 15;
            // 
            // lblPerimetroQuadrado
            // 
            this.lblPerimetroQuadrado.Location = new System.Drawing.Point(6, 141);
            this.lblPerimetroQuadrado.Name = "lblPerimetroQuadrado";
            this.lblPerimetroQuadrado.Size = new System.Drawing.Size(60, 20);
            this.lblPerimetroQuadrado.TabIndex = 14;
            this.lblPerimetroQuadrado.Text = "Perimetro:";
            this.lblPerimetroQuadrado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPerimetroCirculo
            // 
            this.txtPerimetroCirculo.Enabled = false;
            this.txtPerimetroCirculo.Location = new System.Drawing.Point(252, 140);
            this.txtPerimetroCirculo.Name = "txtPerimetroCirculo";
            this.txtPerimetroCirculo.Size = new System.Drawing.Size(100, 20);
            this.txtPerimetroCirculo.TabIndex = 19;
            // 
            // lblPerimetroCirculo
            // 
            this.lblPerimetroCirculo.Location = new System.Drawing.Point(189, 140);
            this.lblPerimetroCirculo.Name = "lblPerimetroCirculo";
            this.lblPerimetroCirculo.Size = new System.Drawing.Size(60, 20);
            this.lblPerimetroCirculo.TabIndex = 18;
            this.lblPerimetroCirculo.Text = "Perimetro:";
            this.lblPerimetroCirculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAreaCirculo
            // 
            this.txtAreaCirculo.Enabled = false;
            this.txtAreaCirculo.Location = new System.Drawing.Point(252, 117);
            this.txtAreaCirculo.Name = "txtAreaCirculo";
            this.txtAreaCirculo.Size = new System.Drawing.Size(100, 20);
            this.txtAreaCirculo.TabIndex = 17;
            // 
            // lblAreaCirculo
            // 
            this.lblAreaCirculo.Location = new System.Drawing.Point(189, 117);
            this.lblAreaCirculo.Name = "lblAreaCirculo";
            this.lblAreaCirculo.Size = new System.Drawing.Size(60, 20);
            this.lblAreaCirculo.TabIndex = 16;
            this.lblAreaCirculo.Text = "Area:";
            this.lblAreaCirculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCircularidade
            // 
            this.lblCircularidade.Location = new System.Drawing.Point(189, 163);
            this.lblCircularidade.Name = "lblCircularidade";
            this.lblCircularidade.Size = new System.Drawing.Size(60, 20);
            this.lblCircularidade.TabIndex = 20;
            this.lblCircularidade.Text = "Circularidade:";
            this.lblCircularidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCircularidade
            // 
            this.txtCircularidade.Enabled = false;
            this.txtCircularidade.Location = new System.Drawing.Point(252, 165);
            this.txtCircularidade.Name = "txtCircularidade";
            this.txtCircularidade.Size = new System.Drawing.Size(100, 20);
            this.txtCircularidade.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 597);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.tb125baixo);
            this.Controls.Add(this.tb125cima);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTransf5);
            this.Controls.Add(this.btnTransf4);
            this.Controls.Add(this.btnTransf3);
            this.Controls.Add(this.btnTransf2);
            this.Controls.Add(this.btnTransf1);
            this.Controls.Add(this.pbImageTransf);
            this.Controls.Add(this.tbMedia);
            this.Controls.Add(this.tbMediana);
            this.Controls.Add(this.tbVariancia);
            this.Controls.Add(this.tbModa);
            this.Controls.Add(this.lblModa);
            this.Controls.Add(this.lblMediana);
            this.Controls.Add(this.lblVariancia);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.btnHistograma);
            this.Controls.Add(this.btnPickImage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageTransf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPickImage;
        private System.Windows.Forms.Button btnHistograma;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblVariancia;
        private System.Windows.Forms.Label lblMediana;
        private System.Windows.Forms.Label lblModa;
        private System.Windows.Forms.TextBox tbModa;
        private System.Windows.Forms.TextBox tbVariancia;
        private System.Windows.Forms.TextBox tbMediana;
        private System.Windows.Forms.TextBox tbMedia;
        private System.Windows.Forms.PictureBox pbImageTransf;
        private System.Windows.Forms.Button btnTransf1;
        private System.Windows.Forms.Button btnTransf2;
        private System.Windows.Forms.Button btnTransf3;
        private System.Windows.Forms.Button btnTransf4;
        private System.Windows.Forms.Button btnTransf5;
        private System.Windows.Forms.TextBox tb125baixo;
        private System.Windows.Forms.TextBox tb125cima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnProcessarSegmentacao;
        private System.Windows.Forms.ComboBox cbFiltroBorda;
        private System.Windows.Forms.Button btnFiltroBorda;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnFechamento;
        private System.Windows.Forms.Button btnDilatacao;
        private System.Windows.Forms.Button btnAbertura;
        private System.Windows.Forms.Button btnErosao;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnCirculos;
        private System.Windows.Forms.Button btnQuadrados;
        private System.Windows.Forms.TextBox txtPerimetroQuadrado;
        private System.Windows.Forms.Label lblPerimetroQuadrado;
        private System.Windows.Forms.TextBox txtAreaQuadrado;
        private System.Windows.Forms.Label lblAreaQuadrado;
        private System.Windows.Forms.TextBox txtCircularidade;
        private System.Windows.Forms.Label lblCircularidade;
        private System.Windows.Forms.TextBox txtPerimetroCirculo;
        private System.Windows.Forms.Label lblPerimetroCirculo;
        private System.Windows.Forms.TextBox txtAreaCirculo;
        private System.Windows.Forms.Label lblAreaCirculo;
    }
}

