using SimMonteCarlo.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimMonteCarlo.Algoritmos
{
    public class AlgoritmoGenerador

    {
        public List<Experimentos> lista = new List<Experimentos>();
        public List<Experimentos> AlgoritmoMonteCarlo(int paneles, int experimentos, int limInf, int limSup)
        {
            List<Experimentos> listaSalida = new List<Experimentos>();

            Random random = new Random();

            for (int experiment = 0; experiment < experimentos; experiment++)
            {
                List<int> panelLifetimes = new List<int>();

                for (int i = 0; i < paneles; i++)
                {
                    panelLifetimes.Add(random.Next(limInf, limSup + 1));
                }

                listaSalida.Add(new Experimentos());
                listaSalida[experiment].Id = experiment;
                listaSalida[experiment].Posicion = experiment;

                // Encontrar el segundo mayor valor
                int segundoMayor = EncontrarSegundoMayor(panelLifetimes);

                // Agregar el segundo mayor valor a la lista
                // panelLifetimes.Add(segundoMayor);
                listaSalida[experiment].SegundoMayor = segundoMayor;
                listaSalida[experiment].ListaAleatorios = panelLifetimes;

            }

            return listaSalida;

        }

        static int EncontrarSegundoMayor(List<int> lista)
        {

            // Utilizar LINQ para ordenar la lista en orden descendente
            List<int> listaOrdenada = lista.OrderByDescending(x => x).ToList();

            // El segundo mayor valor estará en el índice 1 después de ordenar
            return listaOrdenada[1];
        }

        public double CalcularPromedioTiempoDeVida(List<Experimentos> lista)
        {
            if (lista.Count == 0)
            {
                return 0; // O manejar el caso de una lista vacía según tus necesidades
            }

            double sumaTiempoDeVida = 0;

            foreach (var experimento in lista)
            {
                sumaTiempoDeVida += experimento.SegundoMayor;
            }

            // Calcular el promedio dividiendo la suma total entre el número de elementos
            double promedio = sumaTiempoDeVida / lista.Count;

            return promedio;
        }
    }
}
