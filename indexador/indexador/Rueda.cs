﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexador
{
    public class Rueda
    {

        public string marca;
        static Random rd;

        public Rueda(string marca) 
        {
            this.marca = marca;
        }

        static Rueda()
        { 
             Rueda.rd = new Random();
        
        }

        public void Pinchar()
        {
            throw new PinchaduraExeption("texto PinchaduraExeption", new DateTime(), this.marca );
        }

        public void Rodar()
        {
            int numRan=rd.Next(1, 10);

            if (numRan == 5)
            {
                this.Pinchar();
            }
            else {

                Console.WriteLine(numRan.ToString());
            }


        }


    }
}
