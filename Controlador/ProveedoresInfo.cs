using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaInventarioColchones.Controlador
{
    class ProveedoresInfo
    {
        public string id { get; set; }
        public string Nombre { get; set; }
        public string Nit { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public List<ProveedoresInfo> Proveedores()
        {
            List<ProveedoresInfo> listData = new List<ProveedoresInfo>();
            string connString = "Server=bed32989.mysql.database.azure.com;Database=sistema_comercial;Uid=parradosamuel35;Pwd=RTX2080TIxz$;SslMode=Required;";

            using (var con = new MySqlConnection(connString))
            {
                con.Open();
                string selectData = "SELECT * FROM Proveedor";

                using (var cmd = new MySqlCommand(selectData, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProveedoresInfo info = new ProveedoresInfo();
                            info.id = reader["Proveedor_Id"].ToString();
                            info.Nombre = reader["Nombre"].ToString();
                            info.Nit = reader["NIT"].ToString();
                            info.Telefono = reader["Telefono"].ToString();
                            info.Direccion = reader["Direccion"].ToString();

                            listData.Add(info);
                        }
                    }
                }
            }
            return listData;
        }
    }
}