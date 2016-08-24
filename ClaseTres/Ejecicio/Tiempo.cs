using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio
{
    class Tiempo
    {

        public int cantidad;

        public Tiempo(int cantidad) {
            this.cantidad = cantidad;
        }


        public static Tiempo sumar( Tiempo tiempoAux, int valor) 
        {
            tiempoAux.cantidad = tiempoAux.cantidad + valor;


            // y para usarlo:
            //tiempoAux t1 = new Tiempo();
            //tiempoAux result = tiempoAux.sumar(t1, 10);
        }

        public static Tiempo operator + (Tiempo tiempoAux, int valor)
        {
            tiempoAux.cantidad = tiempoAux.cantidad + valor;
            // y para usarlo:
            //tiempoAux t1 = new Tiempo();
            //tiempo = tiemop + 10;
        }

    }
}
