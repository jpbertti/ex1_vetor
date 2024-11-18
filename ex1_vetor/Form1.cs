using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1_vetor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lsbAleatorios.Items.Clear();
            lsbOrdem.Items.Clear();

            int[] numeros = new int[10];
            Random random = new Random();

            for (int i = 0; i <10 ; i++)
            {
                numeros[i] = random.Next(1, 100);
                lsbAleatorios.Items.Add(numeros[i]);
            }

            Array.Sort(numeros);

            foreach (var numero in numeros)
            {
                lsbOrdem.Items.Add(numero);
            }
        }



    }
}
