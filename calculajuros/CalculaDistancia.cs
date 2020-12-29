using System;
using System.Collections.Generic;
using System.Text;

namespace frete
{
    public class CalculaDistancia
    {
        public void Calculo(Distancia distancia, Preco preco)
        {
            double calc = preco.Calcula(distancia);
            Console.WriteLine(calc);
        }
    }
}
