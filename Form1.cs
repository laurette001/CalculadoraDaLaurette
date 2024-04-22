using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDesgraçada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        enum Operacao
        {
            Soma,
            Subtracao,
            Divisao,
            Multiplicacao,
            Nenhuma
        }

        static Operacao ultimaOperacao = Operacao.Nenhuma;

        
        private void button0_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "4";
        }
    
        private void copiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDisplay.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "5";
        }
    

        private void multiplicacao_Click(object sender, EventArgs e)
        {

        }

        private void Dividir_Click(object sender, EventArgs e)
        {

        }

        private void subitrair_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "6";
        }
    



      

   

    private void apagar_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length > 0)        
            {
                textBoxDisplay.Text=
                textBoxDisplay.Text.Remove  (textBoxDisplay.Text.Length - 1,1);
            }
        }




        private void soma_Click(object sender, EventArgs e)
        {
           
            {

            }
        }



        private void igual_Click(object sender, EventArgs e)
        {

        }

        private void virgula_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void limpar_Click(object sender, EventArgs e)
        {
           textBoxDisplay.Clear();  
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += (sender as Button);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "8";
        }

        private void soma_Click_1(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.Nenhuma) 
            {
                ultimaOperacao = Operacao.S oma;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
        }

        private void FazerCalculo(Operacao ultimaOperacao)
        {
            List<double> listaDeNumeros = new List<double>();

            switch (ultimaOperacao)
            {
                case Operacao.Soma:
                    listaDeNumeros = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] + listaDeNumeros[1]).ToString();
                    break;
                case Operacao.Subtracao:
                    listaDeNumeros = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] - listaDeNumeros[1]).ToString();
                    break;
                case Operacao.Divisao:
                    listaDeNumeros = textBoxDisplay.Text.Split('/').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] / listaDeNumeros[1]).ToString();
                    break;
                case Operacao.Multiplicacao:
                    listaDeNumeros = textBoxDisplay.Text.Split('*').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] * listaDeNumeros[1]).ToString();
                    break;
            }
        }

        private void igual_Click_1(object sender, EventArgs e)
        {
            if(ultimaOperacao!= Operacao.Nenhuma)
                FazerCalculo(ultimaOperacao);   
        }
    }
}
