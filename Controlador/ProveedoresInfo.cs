using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            using (SqlConnection con = new SqlConnection(@"Server=DESKTOP-TR972KR;Database=Bedware_;User Id=sa;Password=daniel1234;TrustServerCertificate=True"))
            {

                con.Open();
                string selectData = "select * from Proveedor";

                using (SqlCommand cmd = new SqlCommand(selectData, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ProveedoresInfo info = new ProveedoresInfo();
                        info.id = reader["Proveedor_ID"].ToString();
                        info.Nombre = reader["Nombre"].ToString();
                        info.Nit= reader["NIT"].ToString();
                        info.Telefono = reader["Telefono"].ToString();
                        info.Direccion= reader["Direccion"].ToString();
                       

                        listData.Add(info);

                    }
                }
            }
            return listData;
        }

    }
}
