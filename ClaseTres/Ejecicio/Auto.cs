﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio
{
    public class Auto
    {
        private Efabricante fabricante;
        public Rueda DI;
        public Rueda DD;
        public Rueda TI;
        public Rueda TD;
        public static int contadorDeObjetos;
        //atributo estatico es de clase no de objeto. 
        private int kmRecorridos;
        private int tiempoDemorado;
        private static Random rdm;



        public Auto() {
            
            int num = rdm.Next(0, 2);
            this.fabricante = (Efabricante) num;

            this.kmRecorridos = 0;
            this.tiempoDemorado = 0;


            this.DI= new Rueda();
            this.DD= new Rueda();
            this.TI= new Rueda();
            this.TD= new Rueda();
            Auto.contadorDeObjetos++;
            
        }

        static Auto()
        {
            Auto.contadorDeObjetos = 0;
            rdm = new Random();
            /*
             *  metodo static se ejecuta una sola vez cuando se crea el primer objeto auto.
             *  no se puede sobrecargar.
             */
        }






        public void mostrarAuto() {
            Console.WriteLine("El fab es: {0}", this.fabricante);
            Console.WriteLine("Y este auto recorrio: {0}", this.kmRecorridos);

        }

        public int getKm()
        {
            return this.kmRecorridos;
        }

        public void volverACero() {
            this.kmRecorridos = 0;
            this.tiempoDemorado = 0;
        }

        public void agregarKm(int km)
        {
            this.kmRecorridos = km;
        }

        public void agregarTiempo(int tiempo)
        {
            this.tiempoDemorado = tiempo;
        }
       
        public static bool compararAuto(Auto uno, Auto dos){
            if (uno.fabricante == dos.fabricante)
                return true;
                return false;
        }

       


    }
}
