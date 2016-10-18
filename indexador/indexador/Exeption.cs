using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexador
{
    public class MiExeption : Exception
    {

        public DateTime horaDeLaExepcion;
        public string horaTextoExepcion;

        public MiExeption(string text, DateTime hora)
            :base(text)
        { 
               
        }

        public MiExeption( string text, DateTime hora, MiExeption exep )
            : this(text, hora)
        {


        }

    }
}
