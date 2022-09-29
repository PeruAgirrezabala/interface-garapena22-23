using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulagailua
{
    internal class Kalkulagailua
    {
        //propietrateak
        public float Zenb1 { get; set; }
        public float Zenb2 { get; set; }

        public Kalkulagailua()
        {

        }
        public Kalkulagailua(float zenb1, float zenb2){
            this.Zenb1 = zenb1;
            this.Zenb2 = zenb2;
        }
        public float Gehiketa()
        {
            return Zenb1 + Zenb2;
        }
        public float Kenketa()
        {
            return Zenb1 - Zenb2;
        }
        public float Biderketa()
        {
            return Zenb1 * Zenb2;
        }
        public float Zatiketa()
        {
            return Zenb1 / Zenb2;
        }



    }
}
