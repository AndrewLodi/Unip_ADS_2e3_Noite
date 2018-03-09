using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSoma.Modelo
{
    public class Controle
    {
        public String Calcular(String num1, String num2, String op)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0;
            String resposta = "";
            try
            {
                n1 = Convert.ToDouble(num1.Text);
                n2 = Convert.ToDouble(num2.Text);
                if (op.Equals("+"))
                 resultado = n1 + n2;
                if (op.Equals("-"))
                 resultado = n1 - n2;
                if (op.Equals("*"))
                 resultado = n1 * n2;
                if (op.Equals("/"))
                    else (n2 == 0);
                     resposta "Divisão por zero impossível";
                      resultado = n1 / n2;
                resposta = resultado.ToString();
            }
            catch (FormatException e)
            {

                resposta("Digite um número válido");
            }

        }
    }
}
