using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexador
{
    class AutoExeption: MiExeption
    {
        Auto miAuto;

        public AutoExeption(string text, DateTime time, Auto auto)
            : base(text, time)
        {
            this.miAuto = auto;
        }



    }
}
