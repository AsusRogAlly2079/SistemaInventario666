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
using System.Data.SqlClient;

namespace SistemaInventarioColchones.Persistencia
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            infoClientes();
        }

        SqlConnection
       con = new SqlConnection(@"Server=DESKTOP-TR972KR;Database=Bedware_;User Id=sa;Password=daniel1234;TrustServerCertificate=True");

        public bool ConfirmarCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
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
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        int total = (int)cmd.ExecuteScalar();
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
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        int total = (int)cmd.ExecuteScalar();
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
