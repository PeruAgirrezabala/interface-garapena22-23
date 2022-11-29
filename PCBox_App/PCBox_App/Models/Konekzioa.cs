using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBox_App
{
    internal class Konekzioa
    {
        private string server;
        private int port;
        private string userId;
        private string pass;
        private string database;
        public Konekzioa(string server, int port,string userId, string pass, string database){
            this.server = server;
            this.port = port;
            this.userId = userId;
            this.pass = pass;
            this.database = database;
        }
        public NpgsqlConnection KonektatuDatuBasera()
        {
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection("Server=" + server + ";Port = "+ port +"; User Id=" + userId + ";" + "Password=" + pass + ";Database=" + database + ";");
            npgsqlConnection.Open();
            return npgsqlConnection;
        }
    }
}