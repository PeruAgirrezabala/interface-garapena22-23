using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Console_List
{
    internal class Datuak
    {
        public string Izena { get; set; }
        public Datuak (string izena) {
            this.Izena = izena; 
        }
        public static void DatuenZerrenda(List<Datuak> datuak)
        {

        }
} 
}
