using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCalculadora
{
    class Calculadora
    {
        public string visor { get; set; }
        public double Aux1 { get; set; }
        public double Aux2 { get; set; }

        private string op;
        public string Op
        {
            get { return op; }
            set
            {
                Aux1 = Double.Parse(visor);
                visor = "0";
                op = value;
            }
        }

        public Calculadora()
        {
            visor = "0";
            Aux1 = 0f;
            Aux2 = 0f;
            Op = "";
        }

        public void SetVisor(string digito)
        {
            if (visor.Length > 15) return;
            if (visor.Equals("0"))
                visor = digito;

            else visor += digito;
        }

        public void Calcular()
        {
            if (Aux2 == 0) Aux2 = Double.Parse(visor);
            if (Op.Equals("+")) Aux1 += Aux2;
            if (Op.Equals("-")) Aux1 -= Aux2;
            if (Op.Equals("*")) Aux1 *= Aux2;
            if (Op.Equals("/")) Aux1 /= Aux2;

            visor = Aux1.ToString();
        }

        public void InverterSinal()
        {
            double num = Double.Parse(visor) * -1;
            visor = num.ToString();
        }

        public void RaizQuadrada()
        {
            double num = Double.Parse(visor);
            visor = Math.Sqrt(num).ToString();
        }

        public void Fracao()
        {
            double num = 1 / Double.Parse(visor);
            visor = num.ToString();
        }

        public void Quadrado()
        {
            double num = Double.Parse(visor);
            visor = Math.Pow(num, 2).ToString();
        }

        public void Decimal()
        {
            if (visor.Contains(","))
            {
                visor += ",";
            }
        }

        public void BackSpace()
        {
            visor = visor.Substring(0, visor.Length - 1);
            
            if (visor.Length == 0)
                visor = "0";
          
            
        }

        public void Porcentagem()
        {
            double porcentagem = Double.Parse(visor);
            double resultado = Aux1 * porcentagem / 100;
            visor = resultado.ToString();
        }

        public void Seno()
        {
            double num = Double.Parse(visor);
            visor = Math.Sin(num / 180 * Math.PI).ToString();
        }

        public void Cosseno()
        {
            double num = Double.Parse(visor);
            visor = Math.Cos(num / 180 * Math.PI).ToString();
        }

        public void Tangente()
        {
            double num = Double.Parse(visor);
            visor = Math.Tan(num / 180 * Math.PI).ToString();
        }

        public void Euller()
        {
            visor = Math.E.ToString();
        }

        public void PI()
        {
            visor = Math.PI.ToString();
        }

        public void Log()
        {
            double num = Double.Parse(visor);
            visor = Math.Log10(num).ToString();

        }
    }
}
