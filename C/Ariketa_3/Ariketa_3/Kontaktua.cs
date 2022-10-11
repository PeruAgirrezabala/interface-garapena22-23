using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa_3
{
    internal class Kontaktua
    {
        public string Izena { get; set; }
        public string Abizena { get; set; }
        public virtual string Emaila { get; set; }
        public string IzenOsoa { get=> Izena+" "+Abizena ;}

        public virtual string Gorde()
        {
            string mezua = "kontaktua ondo gorde da";
            return mezua;
        }
    }
}
