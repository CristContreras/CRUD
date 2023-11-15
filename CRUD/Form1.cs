using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace CRUD
{
    public partial class Form1 : Form
    {

        //private SqlConnection conexion;
        //private string cadConexion = "Data Source=DESKTOP-5K0UJ5M\\SQLEXPRESS;Initial Catalog=Empresa;Integrated Security=True;";


        public Form1()
        {
            InitializeComponent();
            txtLegajo.Select();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private SqlConnection conexion=new SqlConnection("Data Source=DESKTOP-5K0UJ5M\\SQLEXPRESS;Initial Catalog=Empresa;Integrated Security=True;");
        
        private void btnConectarBD_Click(object sender, EventArgs e)
        {
            //SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-5K0UJ5M\\SQLEXPRESS;Initial Catalog=Empresa;Integrated Security=True;");
            try
            {
                conexion.Open();
                MessageBox.Show("Conexión establecida", "Listo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar a la base de datos: " + ex.Message);
                throw;
            }
            
        }
        private void btnDesconectarBD_Click(object sender, EventArgs e)
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    conexion.Close();
                    MessageBox.Show("Conexión cerrada", "Alerta");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cerrar: " + ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Conexión no esta abierta", "Alerta");
            }
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //        bool formVacio =
            //        ((string.IsNullOrEmpty(txtLegajo.Text) ||
            //        (string.IsNullOrEmpty(txtDNIEmpleado.Text) ||
            //        (string.IsNullOrEmpty(txtNombreEmpleado.Text) ||
            //        (string.IsNullOrEmpty(txtApellidoEmpleado.Text) ||
            //        (string.IsNullOrEmpty(txtSector.Text)))))));

            //        if (!formVacio)
            //        {
            //            Empleado unEmpleado = new Empleado(
            //                int.Parse(txtLegajo.Text),
            //                txtNombreEmpleado.Text,
            //                txtApellidoEmpleado.Text,
            //                int.Parse(txtDNIEmpleado.Text),
            //                txtSector.Text
            //                );

            //            //string consulta = "INSERT INTO Empleados (Legajo, DNI, Nombre, Apellido, SectorTrabajo) VALUES (@legajo, @DNI, @Nombre, @Apellido, @SectorTrabajo)";

            //            //using (SqlCommand comando = new SqlCommand(consulta, conexion))
            //            //{
            //            //    comando.Parameters.AddWithValue("@Legajo", unEmpleado.legajo);
            //            //    comando.Parameters.AddWithValue("@DNI", unEmpleado.DNI);
            //            //    comando.Parameters.AddWithValue("@Nombre", unEmpleado.Nombre);
            //            //    comando.Parameters.AddWithValue("@Apellido", unEmpleado.Apellido);
            //            //    comando.Parameters.AddWithValue("@SectorTrabajo", unEmpleado.SectorTrabajo);

            //            //    comando.ExecuteNonQuery();
            //            //}

            //            MessageBox.Show("Datos cargados!", "Datos cargados");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Debe agregar datos primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }

            //    }
            //}
           





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}
