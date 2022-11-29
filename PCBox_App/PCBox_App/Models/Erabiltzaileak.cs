using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBox_App
{
    internal class Erabiltzaileak
    {
        public int id { get; set; }
        public string erabiltzailea { get; set; }
        public string pasahitza { get; set; }
        public string baimenak { get; set; }

        public Erabiltzaileak()
        {

        }
        public List<Erabiltzaileak> getErabiltzaileak()
        {
            Konekzioa konexioaDB = new Konekzioa("localhost", 5432, "postgres", "admin", "Odoo_Ethazi");
            //Konekzioa ireki
            NpgsqlConnection konekzioa = konexioaDB.KonektatuDatuBasera();

            //Kontsulta definitu
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * from public.\"Erabiltzaileak\"", konekzioa);
            //Kontsulta exekutatu
            List<Erabiltzaileak> erabiltzaileZerrenda = new List<Erabiltzaileak>();
            Erabiltzaileak erabiltzailea = new Erabiltzaileak();
            using (var reader = cmd.ExecuteReader())
            {
                //Kontsultako datuak jaso
                int i = 0;
                while (reader.Read())
                {
                    erabiltzailea.id = reader.GetInt32(0);
                    erabiltzailea.erabiltzailea = reader.GetString(1).Trim();
                    erabiltzailea.pasahitza = reader.GetString(2).Trim();
                    erabiltzailea.baimenak = reader.GetString(3).Trim();
                    erabiltzaileZerrenda.Add(erabiltzailea);
                    i++;
                }
            }
            // Konekzioa itxi
            konekzioa.Close();
            return erabiltzaileZerrenda;
        }
    }
}
