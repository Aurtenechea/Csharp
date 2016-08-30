using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Efabricante fabricante;

/*
            fabricante = Efabricante.Honda;
            Console.WriteLine(fabricante);

            fabricante = (Efabricante) 0;
            Console.WriteLine(fabricante);
            Console.ReadLine();
*/

            Rueda otraRueda = new Rueda("pirelli");
            // uso la sobrecarga de la clase Rueda.

            Rueda ruedaTres = new Rueda(4);


            Carrera miCarrera= new Carrera();
            miCarrera.correrCarrera( (Tiempo) 15);
            miCarrera.mostrarCarrera();
            miCarrera = new Carrera();
            miCarrera.correrCarrera( (Kilometro) 12);

            miCarrera.mostrarCarrera();
            Console.ReadKey();


        
            
            /*
            Rueda nuevaRueda;
            nuevaRueda = new Rueda();

            Auto miAuto = new Auto();

            Auto miAuto1 = new Auto();

            Auto miAuto2 = new Auto();

            Auto miAuto3 = new Auto();
        */
        }


    }


}
