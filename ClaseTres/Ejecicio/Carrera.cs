using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio
{
    public class Carrera
    {
        public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;
        
        public static Random rdm;

         public Carrera(){
             auto1 = new Auto();
             auto2 = new Auto();
             auto3 = new Auto();
             auto4 = new Auto();
             auto5 = new Auto();
             auto6 = new Auto();
        }

         static Carrera() {
             rdm = new Random();
        }


         public void porTiempo(int minutos) {
             for (int i = 0; i < minutos; i++)
             {
                 this.auto1.agregarKm( (int)rdm.Next(10, 100) );
                 this.auto2.agregarKm((int)rdm.Next(10, 100));
                 this.auto3.agregarKm((int)rdm.Next(10, 100));
                 this.auto4.agregarKm((int)rdm.Next(10, 100));
                 this.auto5.agregarKm((int)rdm.Next(10, 100));
                 this.auto6.agregarKm((int)rdm.Next(10, 100));

             
             }
         }

         public void mostrarCarrera()
         {
             Console.WriteLine("La carrera tiene: ");
             this.auto1.mostrarAuto();
             this.auto2.mostrarAuto();
             this.auto3.mostrarAuto();
             this.auto4.mostrarAuto(); 
             this.auto5.mostrarAuto();
             this.auto6.mostrarAuto();
         }

    }
}
