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

         //public Carrera(Tiempo tiempo)
         //{ 
            
         //}

         //public Carrera(Kilometro km)
         //{

         //}



         static Carrera() {
             rdm = new Random();
        }


         public void porTiempo(int minutos) 
         {
             Tiempo varTiempo;

             for (int i = 0; i < minutos; i++)
             {
                 this.auto1.agregar(varTiempo = (Tiempo)((int)rdm.Next(10, 100)));
                 this.auto2.agregar(varTiempo = (Tiempo)((int)rdm.Next(10, 100)));
                 this.auto3.agregar(varTiempo = (Tiempo)((int)rdm.Next(10, 100)));
                 this.auto4.agregar(varTiempo = (Tiempo)((int)rdm.Next(10, 100)));
                 this.auto5.agregar(varTiempo = (Tiempo)((int)rdm.Next(10, 100)));
                 this.auto6.agregar(varTiempo = (Tiempo)((int)rdm.Next(10, 100)));
             }
         }

         public void porKm(int km)
         {
             Kilometro varKm;
             for (int i = 0; i < km; i++)
             {
                 this.auto1.agregar(varKm = (Kilometro)((int)rdm.Next(10, 100)));
                 this.auto2.agregar(varKm = (Kilometro)((int)rdm.Next(10, 100)));
                 this.auto3.agregar(varKm = (Kilometro)((int)rdm.Next(10, 100)));
                 this.auto4.agregar(varKm = (Kilometro)((int)rdm.Next(10, 100)));
                 this.auto5.agregar(varKm = (Kilometro)((int)rdm.Next(10, 100)));
                 this.auto6.agregar(varKm = (Kilometro)((int)rdm.Next(10, 100)));
             }
         }



         public void correrCarrera(Tiempo tiempo)
         {
             this.porTiempo((int)tiempo);
         }

         public void correrCarrera(Kilometro kilometros)
         {
             this.porKm((int)kilometros);
         }

         public void mostrarCarrera()
         {
             Console.WriteLine("=================================================");
             Console.WriteLine("La carrera tiene: ");
             Console.WriteLine();
             this.auto1.mostrarAuto();
             this.auto2.mostrarAuto();
             this.auto3.mostrarAuto();
             this.auto4.mostrarAuto(); 
             this.auto5.mostrarAuto();
             this.auto6.mostrarAuto();

             Auto ganador;
             ganador = new Auto();


             //max = this.auto1.getKm();
             //if (max < this.auto2.getKm())
             //{
             //    max = this.auto2.getKm();
             //    ganador = auto2;
             //}
             //if (max < this.auto3.getKm())
             //{
             //    max = this.auto3.getKm();
             //    ganador = auto3;
             //}
             //if (max < this.auto4.getKm())
             //{
             //    max = this.auto4.getKm();
             //    ganador = auto4;
             //}
             //if (max < this.auto5.getKm())
             //{
             //    max = this.auto5.getKm();
             //    ganador = auto5;
             //}
             //if (max < this.auto6.getKm())
             //{
             //    max = this.auto6.getKm();
             //    ganador = auto6;
             //}


           //  max = 0;

             Auto[] arrayAutos = new Auto[] { auto1, auto2, auto3, auto4, auto5, auto6 };

             if (this.auto1.getTiempo() == 0)
             {
                 for (int i = 0; i < 6; i++)
                 {
                     if (arrayAutos[i].getKm() > ganador.getKm())
                     {
                         ganador = arrayAutos[i];
                     }
                 }

                 Console.WriteLine("El ganador recorrio {0} kms.", ganador.getKm());
             }
             else
             {
                 for (int i = 0; i < 6; i++)
                 {
                     if (arrayAutos[i].getTiempo() > ganador.getTiempo())
                     {
                         ganador = arrayAutos[i];
                     }
                 }
                 Console.WriteLine("El ganador tardo {0} tiempo.", ganador.getTiempo());
             }
         }

         public void mostrarCarreraPorKm() { 
         
         }

    }
}
