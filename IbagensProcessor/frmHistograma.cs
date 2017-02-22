using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IbagensProcessor
{
    public partial class frmHistograma : Form
    {
        private int[] grays;

        public frmHistograma(int[] grays)
        {
            this.grays = grays;
            InitializeComponent();

            chartHistogram.Series["Series"].Points.Clear();
            for (int i = 0; i < this.grays.Length; i++)
            {
                chartHistogram.Series["Series"].Points.AddXY(i, this.grays[i]);
            }
            chartHistogram.Series["Series"].ToolTip = "#VALX teve #VAL ocorrências.";
        }

    }
}
