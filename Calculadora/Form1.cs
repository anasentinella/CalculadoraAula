using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double numero1;
        private double numero2;
        private string operacao;
        private double resultado;
        private Boolean PressionouIgual;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }
       
        private void LimparCampos()
        {
            numero1 = 0;
            numero2 = 0;
            operacao = String.Empty;
            resultado = 0;
            PressionouIgual = false;
            txtDisplay.Clear();
        }
        private void calcular()
        {
            switch(operacao)
           {
                case "/":
                    if(numero2==0)
                    {
                        MessageBox.Show("impossível divisão por zero! ","aviso do sistema",MessageBoxButtons.OK);
                        break;
                    }
                    resultado = numero1 / numero2;
                    break;
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":

                    resultado = numero1 * numero2;
                    break;
            }
            txtDisplay.Text = resultado.ToString();
        }

        private void adicionarOperacacao(String caractere)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
                txtDisplay.Clear();
         
                operacao = caractere;
            }
        }
        void adicionarDigito(String digito)
        {
            if (txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = digito;
            }
            else
            {
                txtDisplay.Text += digito;
            }
        }


        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = txtDisplay.Text + ("0");
            }

            else
            {
                txtDisplay.Text += "0";
            }

        }       


        private void btnUm_Click(object sender, EventArgs e)
        {
            adicionarDigito("1");
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            adicionarDigito("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            adicionarDigito("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            adicionarDigito("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            adicionarDigito("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            adicionarDigito("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            adicionarDigito("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            adicionarDigito("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            adicionarDigito("9");
        }

        private void btnPower_Click(object sender, EventArgs e)
        {

        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            adicionarOperacacao("/");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
           if(!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                numero2 = Convert.ToDouble(txtDisplay.Text.Trim());
                calcular();
                PressionouIgual = true;
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            adicionarOperacacao("+");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            adicionarOperacacao("-");
        }

        private void btnmultiplicacao_Click(object sender, EventArgs e)
        {
            adicionarOperacacao("*");
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if(PressionouIgual)
            {
                LimparCampos();
            }
            if (txtDisplay.Text.Trim().Equals(String.Empty))
            {
                txtDisplay.Text += "0";
            }
            if (txtDisplay.Text.Trim().Contains(",")) return;
            txtDisplay.Text += ",";
        }
    }
}
