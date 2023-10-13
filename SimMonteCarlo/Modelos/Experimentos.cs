using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimMonteCarlo.Modelos
{
    public class Experimentos
    {
        public int Id { get; set; }
        public int Posicion { get; set; }

        public int SegundoMayor { get; set; }
        public List<int> ListaAleatorios { get; set; }

        public Experimentos() { }
        public Experimentos(int id, int posicion, int segundoMayor, List<int> listaAleatorios )
        {
            ListaAleatorios = listaAleatorios;
            Id = id;
            Posicion = posicion;
            SegundoMayor = segundoMayor;
        }
    }
}
