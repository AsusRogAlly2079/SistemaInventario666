using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaInventarioColchones.Controlador;
using MySql.Data.MySqlClient;

namespace SistemaInventarioColchones.Persistencia
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            infoClientes();
        }

        MySqlConnection con = new MySqlConnection("Server=bed32989.mysql.database.azure.com;Database=sistema_comercial;Uid=parradosamuel35;Pwd=RTX2080TIxz$;SslMode=Required;");

        public bool ConfirmarCon()
        {
            return con.State == ConnectionState.Closed;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (ConfirmarCon())
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Usuario";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        int total = Convert.ToInt32(cmd.ExecuteScalar());
                        MessageBox.Show("Total de Usuarios: " + total, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al contar usuarios\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public void infoClientes()
        {
            ClientesInfo infoo = new ClientesInfo();
            List<ClientesInfo> listData = infoo.Clientes();

            dataGridView1.DataSource = listData;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (ConfirmarCon())
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Cliente";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        int total = Convert.ToInt32(cmd.ExecuteScalar());
                        MessageBox.Show("Total de clientes: " + total, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al contar clientes\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
