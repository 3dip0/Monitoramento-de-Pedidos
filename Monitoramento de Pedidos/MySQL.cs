﻿using MySql.Data.MySqlClient;

namespace Monitoramento_de_Pedidos
{
    public class MySQL
    {
        IniFile arquivo = new IniFile("c:/Config.ini");

        public MySqlConnection GetConnection()
        {
            var server = arquivo.Read("Server", "DATABASE");
            var database = arquivo.Read("Database", "DATABASE");
            var uid = arquivo.Read("Uid", "DATABASE");
            var pwd = arquivo.Read("Pwd", "DATABASE");
            var port = arquivo.Read("Port", "DATABASE");

            string conn = $"Server={server};Database={database};Uid={uid};Pwd={pwd};Port={port};SSL Mode=None";
            return new MySqlConnection(conn);
        }
    }
}
