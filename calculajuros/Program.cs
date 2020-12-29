using System;
using System.Collections.Generic;
using System.Text;

namespace frete
{
    class Program
    {
        static void Main(string[] args)
        {
          Preco sedex =  new Sedex();
            Preco normal = new Normal();

            Console.WriteLine("Selecione a distância desejada (EM KM):");
            string Sdistancia = Console.ReadLine();
            int distanciaKM = int.Parse(Sdistancia);

            Distancia distancia = new Distancia(distanciaKM);
            CalculaDistancia calcula = new CalculaDistancia();
            calcula.Calculo(distancia, normal);


        }
    }
}
