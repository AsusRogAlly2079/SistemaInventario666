using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioColchones.Controlador
{
    class UsuariosInfo
    {

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public string Fecha { get; set; }

        public List<UsuariosInfo> Usuarios()
        {

            List<UsuariosInfo> listData = new List<UsuariosInfo>();

            using (SqlConnection con = new SqlConnection(@"Server=DESKTOP-TR972KR;Database=Bedware_;User Id=sa;Password=daniel1234;TrustServerCertificate=True"))
            {

                con.Open();
                string selectData = "select * from Usuario";

                using (SqlCommand cmd = new SqlCommand(selectData, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) 
                    { 
                    UsuariosInfo info = new UsuariosInfo();
                       info.Id = reader["Usuario_id"].ToString();
                       info.Nombre= reader["Nombre"].ToString();
                       info.Contraseña= reader["Contrasena"].ToString();
                        info.Rol = reader["Rol"].ToString();
                        info.Fecha = reader["Fecha_Creacion"].ToString();

                        listData.Add(info);

                    }
                }   
            }
            return listData;
        }
    }
}