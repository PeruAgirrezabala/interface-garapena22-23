using System.ComponentModel.DataAnnotations;
using System;
using Npgsql;
using System.Collections.Generic;
using System.Data;

namespace PCBox_App
{
    public class Produktuak
    {
        [Key]
        public int Id { get; set; }
        public string Produktua { get; set; }
        public double Prezioa { get; set; }
        public int Kantitatea { get; set; }

        public List<Produktuak> produktuakLortu()
        {
            Konekzioa konexioaDB = new Konekzioa("localhost", 5432, "postgres", "admin", "Odoo_Ethazi");
            //Konekzioa ireki
            NpgsqlConnection konekzioa = konexioaDB.KonektatuDatuBasera();

            //Kontsulta definitu
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * from public.\"Produktuak\"", konekzioa);
            //Kontsulta exekutatu
            List<Produktuak> produktuenZerrenda = new List<Produktuak>();
            Produktuak produktuak = new Produktuak();
            using (var reader = cmd.ExecuteReader())
            {
                //Kontsultako datuak jaso
                int i = 0;
                while (reader.Read())
                {
                    produktuak.Id = reader.GetInt32(0);
                    produktuak.Produktua = reader.GetString(1).Trim();
                    produktuak.Prezioa = reader.GetDouble(2);
                    produktuak.Kantitatea = reader.GetInt32(3);
                    produktuenZerrenda.Add(produktuak);
                    i++;
                }
            }
            // Konekzioa itxi
            konekzioa.Close();
            return produktuenZerrenda;
        }
        public DataSet produktuakLortuDS()
        {
            Konekzioa konexioaDB = new Konekzioa("localhost", 5432, "postgres", "admin", "Odoo_Ethazi");
            //Konekzioa ireki
            NpgsqlConnection konekzioa = konexioaDB.KonektatuDatuBasera();

            //Kontsulta definitu
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * from public.\"Produktuak\"", konekzioa);

            DataSet dsProduktuak = new DataSet();
            DataTable t = new DataTable();
            t.Columns.Add("Id");
            t.Columns.Add("Produktua");
            t.Columns.Add("Prezioa");
            t.Columns.Add("Kantitatea");
            //Kontsulta exekutatu
            using (var reader = cmd.ExecuteReader())
            {
                //Kontsultako datuak jaso
                while (reader.Read())
                {
                    DataRow row = t.NewRow();
                    row["Id"] = reader.GetInt32(0);
                    row["Produktua"] = reader.GetString(1).Trim();
                    row["Prezioa"] = reader.GetDouble(2);
                    row["Kantitatea"] = reader.GetInt32(3);
                    t.Rows.Add(row);
                }
            }
            dsProduktuak.Tables.Add(t);
            //dsProduktuak.Tables[0].Columns[0].ColumnName = "Id";
            //dsProduktuak.Tables[0].Columns[0].ColumnName = "Produktua";
            //dsProduktuak.Tables[0].Columns[0].ColumnName = "Prezioa";
            //dsProduktuak.Tables[0].Columns[0].ColumnName = "Kantitatea";
            // Konekzioa itxi
            konekzioa.Close();
            dsProduktuak.AcceptChanges();
            return dsProduktuak;
        }
    }
}
