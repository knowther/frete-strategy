using System;
using System.Collections.Generic;
using System.Text;

namespace frete
{
    public class Normal : Preco
    {
        public double Calcula(Distancia distancia)
        {
           return distancia.Vdistancia * 1.25 + 10;
        }
    }
}
