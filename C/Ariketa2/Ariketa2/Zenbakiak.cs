using System;

namespace Ariketa2
{
	public class Ariketa2
	{
		List<Ariketa2> zenbakiak = new List<Ariketa2>();

		public String label;
		public double zenbakia { get; set; }

		public Ariketa2(double zenbakia)
		{
			this.zenbakia = zenbakia;
		}

		public static double Eragiketa (List<Ariketa2> zenbakiak)
		{
            double emaitza = (zenbakiak[0].zenbakia + (2 * zenbakiak[1].zenbakia) + (3 * zenbakiak[2].zenbakia) + (4 * zenbakiak[3].zenbakia)) / 4;
            return emaitza;
        }

	}
}
