using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Result.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Result.Focus();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Result.Text += "6";
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            Result.Text = "";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {

            Numero("1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {

            Numero("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {

            Numero("3");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {

            Numero("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {

            Numero("5");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {

            Numero("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {

            Numero("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {

            Numero("9");
        }

        private void Btn0_Click(object sender, EventArgs e)
        {

            Numero("0");

        }

        private void Numero(string numero)
        {
            Result.Text += numero;
            this.Result.Focus();
            this.Result.Select(Result.Text.Length , 0);
        }
        double valorprevio = 0;
        TipoAccion accion;

        private void BtnSum_Click(object sender, EventArgs e)
        {
            primerValor();
            accion = TipoAccion.Suma;
        }
        private void primerValor()
        {
            String v = Result.Text;
            if (v.Length==0)
            {
                valorprevio = 0;
            }
            else
            {
                valorprevio = Convert.ToDouble(v);
            }
            this.Result.Focus();
            this.Result.Select(Result.Text.Length, 0);
            Result.Text = "";
        }
        private void segundoValor()
        {
            String v = Result.Text;
            if (v.Length == 0)
            {
                ultimovalor = 0;
            }
            else
            {
                ultimovalor = Convert.ToDouble(v);
            }
            this.Result.Focus();
            this.Result.Select(Result.Text.Length, 0);
        }

        enum TipoAccion
        {
            Suma,
            Resta,
            Div,
            Multi,
            Potencia
        }

        double ultimovalor;
        private void BtnIg_Click(object sender, EventArgs e)
        {

            segundoValor();
            double total = 0;
            switch (this.accion)
            {
                case TipoAccion.Suma:

                    total = ultimovalor + this.valorprevio;
                    this.Result.Text = total.ToString();
                    break;
                case TipoAccion.Resta:
                    total = this.valorprevio - ultimovalor;
                    this.Result.Text = total.ToString();
                    break;
                case TipoAccion.Div:
                    total = valorprevio / ultimovalor;
                    Result.Text = total.ToString();
                    break;
                case TipoAccion.Multi:
                    total = this.valorprevio * ultimovalor;
                    this.Result.Text = total.ToString();
                    break;
                case TipoAccion.Potencia:
                    total = Math.Pow(this.valorprevio, ultimovalor);
                    this.Result.Text = total.ToString();
                    break;

            }
            this.Result.Focus();
            this.Result.Select(Result.Text.Length, 0);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double total = 0;
            valorprevio = Convert.ToDouble(Result.Text);
            total = Math.Sqrt(valorprevio);
            this.Result.Text = total.ToString();


        }
        private void BtnRes_Click(object sender, EventArgs e)
        {
            primerValor();
            accion = TipoAccion.Resta;
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            primerValor();
            accion = TipoAccion.Div;
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            primerValor();
            accion = TipoAccion.Multi;
        }

        private void BtnPun_Click(object sender, EventArgs e)
        {
            Result.Text += ".";
        }

        private void BtnPot_Click(object sender, EventArgs e)
        {
            primerValor();
            accion = TipoAccion.Potencia;
        }




        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;


            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 46|| e.KeyChar==08)
                e.Handled = false;

            if (e.KeyChar == 46 && this.Result.Text.IndexOf(".") != -1)
                e.Handled = true;
            if (e.KeyChar == 47)
                BtnDiv_Click(sender,e);
            if (e.KeyChar == 43)
                BtnSum_Click(sender, e);
            if (e.KeyChar == 45)
                BtnRes_Click(sender, e);
            if (e.KeyChar == 42)
                BtnMul_Click(sender, e);
            if (e.KeyChar == 13)
                BtnIg_Click(sender, e);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Result.Focus();
        }
    }

}