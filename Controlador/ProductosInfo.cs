using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioColchones.Controlador
{
    class ProductosInfo
    {
        public string id {  get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Tamaño { get; set; }
        public string Material { get; set; }
        public string Stock { get; set; }
        public string Costo { get; set; }
        public string Proveedor { get; set; }

        public List<ProductosInfo> Productos()
        {
            List<ProductosInfo> listData = new List<ProductosInfo>();
            using (SqlConnection con = new SqlConnection(@"Server=DESKTOP-TR972KR;Database=Bedware_;User Id=sa;Password=daniel1234;TrustServerCertificate=True"))
            {

                con.Open();
                string selectData = "select * from Producto";

                using (SqlCommand cmd = new SqlCommand(selectData, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ProductosInfo info = new ProductosInfo();
                        info.id = reader["Producto_Id"].ToString();
                        info.Nombre = reader["Nombre"].ToString();
                        info.Descripcion = reader["Descripcion"].ToString();
                        info.Marca = reader["Marca_Id"].ToString();
                        info.Tamaño = reader["Tamaño"].ToString();
                        info.Material = reader["Material_Id"].ToString();
                        info.Stock = reader["Stock"].ToString();
                        info.Costo = reader["Costo"].ToString();
                        info.Proveedor = reader["Proveedor_Id"].ToString();


                        listData.Add(info);

                    }
                }
            }
            return listData;

        }



      
    }
}
