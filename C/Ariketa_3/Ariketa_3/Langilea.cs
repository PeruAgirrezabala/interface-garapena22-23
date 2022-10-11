using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa_3
{
    internal class Langilea : Kontaktua
    {
        public int Soldata { get; set; }
        public int SegurtasunSoziala { get; set; }

        public override string Emaila
        {
            get => base.Emaila;
            set
            {
                if (value.Substring(value.Length - 8) == "@uni.eus")
                {
                    base.Emaila = value;

                }
                else
                {
                    Exception ex = new Exception("Okerreko Balioa");
                }

            }
        }
    }
}
    

