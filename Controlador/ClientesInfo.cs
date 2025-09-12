using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            using (SqlConnection con = new SqlConnection(@"Server=DESKTOP-TR972KR;Database=Bedware_;User Id=sa;Password=daniel1234;TrustServerCertificate=True"))
            {

                con.Open();
                string selectData = "select * from Cliente";

                using (SqlCommand cmd = new SqlCommand(selectData, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ClientesInfo info = new ClientesInfo();
                        info.Nombre = reader["Nombre"].ToString();
                        info.Apellidos = reader["Apellidos"].ToString();
                        info.Documento = reader["Documento"].ToString();
                        info.Direccion= reader["Direccion"].ToString();
                        info.Telefono = reader["Telefono"].ToString();
                        info.Email = reader["Email"].ToString();
                    


                        listData.Add(info);

                    }
                }
            }
            return listData;

        }




    }
}