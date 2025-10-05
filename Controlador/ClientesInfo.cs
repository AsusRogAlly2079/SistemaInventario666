using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaInventarioColchones.Controlador
{
    class ClientesInfo
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public List<ClientesInfo> Clientes()
        {
            List<ClientesInfo> listData = new List<ClientesInfo>();
            string connString = "Server=bed32989.mysql.database.azure.com;Database=sistema_comercial;Uid=parradosamuel35;Pwd=RTX2080TIxz$;SslMode=Required;";

            using (var con = new MySqlConnection(connString))
            {
                con.Open();
                string selectData = "SELECT * FROM Cliente";
                using (var cmd = new MySqlCommand(selectData, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClientesInfo info = new ClientesInfo();
                            info.Nombre = reader["Nombre"].ToString();
                            info.Apellidos = reader["Apellidos"].ToString();
                            info.Documento = reader["Documento"].ToString();
                            info.Direccion = reader["Direccion"].ToString();
                            info.Telefono = reader["Telefono"].ToString();
                            info.Email = reader["Email"].ToString();
                            listData.Add(info);
                        }
                    }
                }
            }
            return listData;
        }
    }
}