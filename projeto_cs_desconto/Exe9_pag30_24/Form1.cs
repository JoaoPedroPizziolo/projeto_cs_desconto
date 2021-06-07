using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe9_pag30_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcule_Click(object sender, EventArgs e)
        {
            double numero_produtos, calculo, calculo2, desconto, nome;

            nome = double.Parse(txtnome.Text);
            numero_produtos = double.Parse(txtnprodutos.Text);
            calculo = numero_produtos * 1.99;

            if (numero_produtos <= 10)
            {
                MessageBox.Show(nome.ToString() + Environment.NewLine + "voce gastou: " + calculo.ToString("C") + Environment.NewLine + "Seu desconto sera de 0%");
            }
            else if (numero_produtos <= 25 && numero_produtos > 10)
            {
                calculo2 = calculo * 0.05;
                desconto = calculo - calculo2;

                MessageBox.Show(nome.ToString() + Environment.NewLine + "Voce gastou: " + calculo.ToString("C") + Environment.NewLine + "seu desconto sera de 5% e o valor passara ser de: " + desconto.ToString("C"));
            }
            else
            {
                calculo2 = calculo * 0.12;
                desconto = calculo - calculo2;

                MessageBox.Show(nome.ToString() + Environment.NewLine + "Voce gastou: " + calculo.ToString("C") + Environment.NewLine + "seu desconto sera de 12% e o valor passara ser de: " + desconto.ToString("C"));
            }
        }
    }
}
