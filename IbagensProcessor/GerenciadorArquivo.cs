using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace IbagensProcessor
{
    public class GerenciadorArquivo
    {
        public static Stream OpenFile()
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //openFileDialog1.InitialDirectory = "C:\\Users\\0132631\\Downloads\\Trabalhos_CG_2014\\Imagens";
            //openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        return myStream;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    return null;
                }
            }

            return null;
        }
    }
}
