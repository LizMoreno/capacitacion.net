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
    public partial class Calculadora : Form
    {
        string operacion;
        double primero;
        double segundo;
        double resultado;
        public Calculadora()
        {
            InitializeComponent();
            textresultado.Focus();
            textresultado.Select(textresultado.Text.Length, 0);
        }

        private void tomarPrimero()
        {
            if (textresultado.Text != "")
            { 
            primero = double.Parse(textresultado.Text);
            textresultado.Clear();
            textresultado.Focus();
            textresultado.Select(textresultado.Text.Length, 0);
            }
        }
        private void recibirNumero(String num)
        {
            textresultado.Text = textresultado.Text + num;
            textresultado.Focus();
            textresultado.Select(textresultado.Text.Length, 0);
        }
        private void Textresultado_TextChanged(object sender, EventArgs e)
        {
            textresultado.Focus();
            textresultado.Select(textresultado.Text.Length, 0);
        }
        private void Btn0_Click(object sender, EventArgs e)
        {
            recibirNumero("0");
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            recibirNumero("1");

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            recibirNumero("2");

        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            recibirNumero("3");
        }
      
        private void Btn4_Click(object sender, EventArgs e)
        {
            recibirNumero("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            recibirNumero("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            recibirNumero("6");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            recibirNumero("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            recibirNumero("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            recibirNumero("9");
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            textresultado.Text = "";
        }

        private void Btnpunto_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + ".";
        }

        

        private void Btnsuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            tomarPrimero();
        }

        private void Btnresta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            tomarPrimero();
            
        }


        private void Btndividir_Click(object sender, EventArgs e)
        {
            operacion = "/";
            tomarPrimero();
        }

        private void Btnmultiplicar_Click(object sender, EventArgs e)
        {
            operacion = "x";
            tomarPrimero();
        }
        private void BtnRaizCuadrada_Click(object sender, EventArgs e)
        {
            operacion = "√";
            primero = double.Parse(textresultado.Text);
            resultado = primero;
            textresultado.Text = Math.Sqrt(primero).ToString();


        }

        private void Btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(textresultado.Text);
            

            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    textresultado.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = primero - segundo;
                    textresultado.Text = resultado.ToString();
                    break;

                case "x":
                    resultado = primero * segundo;
                    textresultado.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = primero / segundo;
                    textresultado.Text = resultado.ToString();
                    break;
            }
        }


        private void Calculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if(e.KeyChar > 47 && e.KeyChar < 58 ||e.KeyChar==46 || e.KeyChar == 08 ) //numeros  0-9
            {
                e.Handled = false;
            }
           
            if (e.KeyChar == 46 && this.textresultado.Text.IndexOf(".") != -1)
                {
                e.Handled = true;
            }
            if (e.KeyChar == 45) //resta
            {
                Btnresta_Click(sender, e);
            }
            if(e.KeyChar == 43) //suma
            {
                Btnsuma_Click(sender, e);
            }
            if (e.KeyChar == 42 || e.KeyChar == 120) //multiplicar
            {
                Btnmultiplicar_Click(sender, e);
            }
            if (e.KeyChar == 47) //dividir
            {
                Btndividir_Click(sender, e);
            }

            if(e.KeyChar == 114) //raiz cuadrada
            {
                BtnRaizCuadrada_Click(sender, e);
            }

            if (e.KeyChar == 13) // enter
            {
                Btnigual_Click(sender, e);
            }

        }

        private void Calculadora_Activated(object sender, EventArgs e)
        {
            textresultado.Focus();
            textresultado.Select(textresultado.Text.Length, 0);
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            textresultado.Focus();
            textresultado.Select(textresultado.Text.Length, 0);
        }
    }
}

