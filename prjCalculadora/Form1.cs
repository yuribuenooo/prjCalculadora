using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculadora Logica = new Calculadora();
        bool EstadoIgual = false;

        private void btn0_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Logica.SetVisor(btn0.Text);
            lbVisor.Text = Logica.visor;
        }

        private void TestarIgual (object sender, EventArgs e)
        {
            if (EstadoIgual == true)
            {
                btnCE_Click(sender, e);
                EstadoIgual = false;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Logica.SetVisor(btn1.Text);
            lbVisor.Text = Logica.visor;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Logica.SetVisor(btn2.Text);
            lbVisor.Text = Logica.visor;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Logica.SetVisor(btn3.Text);
            lbVisor.Text = Logica.visor;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Logica.SetVisor(btn4.Text);
            lbVisor.Text = Logica.visor;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Logica.SetVisor(btn5.Text);
            lbVisor.Text = Logica.visor;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Logica.SetVisor(btn6.Text);
            lbVisor.Text = Logica.visor;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Logica.SetVisor(btn7.Text);
            lbVisor.Text = Logica.visor;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Logica.SetVisor(btn8.Text);
            lbVisor.Text = Logica.visor;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Logica.SetVisor(btn9.Text);
            lbVisor.Text = Logica.visor;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Logica.visor = "0";
            lbVisor.Text = Logica.visor;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            Logica = new Calculadora();
            lbVisor.Text = Logica.visor;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            
             Logica.Op = "+";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Logica.Calcular();
            lbVisor.Text = Logica.visor;
            EstadoIgual = true;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Logica.Op = "-";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Logica.Op = "*";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Logica.Op = "/";
        }

        private void btnInverterSinal_Click(object sender, EventArgs e)
        {
            Logica.InverterSinal();
            lbVisor.Text = Logica.visor;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            Logica.RaizQuadrada();
            lbVisor.Text = Logica.visor;
            EstadoIgual = true;
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            Logica.Porcentagem();
            lbVisor.Text = Logica.visor;
            EstadoIgual = true;
        }

        private void btnFracao_Click(object sender, EventArgs e)
        {
            Logica.Fracao();
            lbVisor.Text = Logica.visor;
            EstadoIgual = true;
        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            Logica.Quadrado();
            lbVisor.Text = Logica.visor;
            EstadoIgual = true;
        }

        private void btnPontoDecimal_Click(object sender, EventArgs e)
        {
            Logica.Decimal();
            lbVisor.Text = Logica.visor;
        }

        private void btnBK_Click(object sender, EventArgs e)
        {
            Logica.BackSpace();
            lbVisor.Text = Logica.visor;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                TestarIgual(sender, e);
                Logica.SetVisor(e.KeyChar.ToString());
                lbVisor.Text = Logica.visor;
                return;
            }

            if (e.KeyChar == '+') Logica.Op ="+";
            if (e.KeyChar == '-') Logica.Op = "-";
            if (e.KeyChar == '*') Logica.Op = "*";
            if (e.KeyChar == '/') Logica.Op = "/";
            if (e.KeyChar == '=') 
            {
                btnCalcular_Click(sender, e);
            }
       

        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            Logica.Seno();
            lbVisor.Text = Logica.visor;
        }

        private void btnCosseno_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            Logica.Cosseno();
            lbVisor.Text = Logica.visor;
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            Logica.Tangente();
            lbVisor.Text = Logica.visor;
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            Logica.PI();
            lbVisor.Text = Logica.visor;
        }

        private void btnEuller_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            Logica.Euller();
            lbVisor.Text = Logica.visor;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            Logica.Log();
            lbVisor.Text = Logica.visor;
        }
    }
}
