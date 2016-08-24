using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio
{
    public class Rueda
    {
        public string Marca;
        public float tamanio;

        public Rueda() {
            this.Marca = "sin marca";
        }

        public void mostrarTamanio()
        {
            Console.WriteLine("El tamaño es: {0}", this.tamanio);
        }

    }
}
