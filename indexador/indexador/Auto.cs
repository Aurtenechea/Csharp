using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexador
{
    public class Auto
    {

        public string marca;
        public int numero;
        public List<Rueda> lsRuedas;

        public Auto(string marca, int numero) 
        {
            this.marca = marca;
            this.numero = numero;
            this.lsRuedas = new List<Rueda>();
        }

        public void Andar()
        {
            if (this.numero < 4)
            {
                throw new MiExeption("textoExepcion", new DateTime());
            }
            else
            {
                try
                {
                    foreach (Rueda item in this.lsRuedas)
                    {
                        item.Rodar();

                    }
                }
                catch(PinchaduraExeption ex) { }
            
            }
        }


    }
}
