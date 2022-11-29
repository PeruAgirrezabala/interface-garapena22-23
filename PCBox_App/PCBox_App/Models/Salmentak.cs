using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBox_App
{
    internal class Salmentak
    {
        [Key]
        public int Id { get; set; }
        public string Deskripzioa { get; set; }
        public string Produktua { get; set; }
        public double Prezioa { get; set; }
        public string Bezeroa { get; set; }

        public Salmentak()
        {

        }
        public List<Salmentak> getSalmentak()
        {
            Konekzioa konexioaDB = new Konekzioa("localhost", 5432, "postgres", "admin", "Odoo_Ethazi");
            //Konekzioa ireki
            NpgsqlConnection konekzioa = konexioaDB.KonektatuDatuBasera();

            //Kontsulta definitu
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * from public.\"Salmentak\"", konekzioa);
            //Kontsulta exekutatu
            List<Salmentak> salmentenZerrenda = new List<Salmentak>();
            Salmentak salmenta = new Salmentak();
            using (var reader = cmd.ExecuteReader())
            {
                //Kontsultako datuak jaso
                int i = 0;
                while (reader.Read())
                {
                    salmenta.Id = reader.GetInt32(0);
                    salmenta.Deskripzioa = reader.GetString(1).Trim();
                    salmenta.Produktua = reader.GetString(2).Trim();
                    salmenta.Prezioa = reader.GetDouble(3);
                    salmenta.Bezeroa = reader.GetString(4).Trim();
                    salmentenZerrenda.Add(salmenta);
                    i++;
                }
            }
            // Konekzioa itxi
            konekzioa.Close();
            return salmentenZerrenda;
        }
    }
}
