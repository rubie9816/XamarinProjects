using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Libros
{
    class Conexion
    {
        SqlConnection miconexion = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;
        Initial Catalog=ABC_LIBROS;Integrated Security=True;
        Connect Timeout=30;Encrypt=False;
        TrustServerCertificate=False;
        ApplicationIntent=ReadWrite;
        MultiSubnetFailover=False");
        protected void Abrir()
        {
            miconexion.Open();
        }

        protected void Cerrar()
        {
            miconexion.Close();
        }

        public DataTable ConsultaDatosStock()
        {
            Abrir();
            SqlCommand cmd = new SqlCommand("Datos_stock_SP", miconexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable data = new DataTable();
            adaptador.Fill(data);
            Cerrar();
            return data;
        }

        public List<string> ConsultarDatosLibro(int id_stock)
        {
            Abrir();
            List<string> datos = new List<string>();
            SqlCommand cmd = new SqlCommand("Datos_Libro_SP", miconexion);
            cmd.Parameters.AddWithValue("@id_stock", id_stock);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                datos.Add(reader["ISBN"].ToString());
                datos.Add(reader["Titulo"].ToString());
                datos.Add(reader["Autor"].ToString());
                datos.Add(reader["Edicion"].ToString());
                datos.Add(reader["Editorial"].ToString());
                datos.Add(reader["Idioma"].ToString());
                datos.Add(reader["Genero"].ToString());
                datos.Add(reader["Estatus"].ToString());
            }
            Cerrar();
            return datos;
        }

        public List<string> ConsultarEstatusLibro(int id_libro)
        {
            Abrir();
            List<string> datos = new List<string>();
            SqlCommand cmd = new SqlCommand("Cantidades_libros_SP", miconexion);
            cmd.Parameters.AddWithValue("@id_libro", id_libro);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                datos.Add(reader["Cantidad"].ToString());
                datos.Add(reader["Disponible"].ToString());
                datos.Add(reader["Prestamo"].ToString());
                datos.Add(reader["Dañado"].ToString());
                datos.Add(reader["Baja"].ToString());
            }
            Cerrar();
            return datos;
        }

        public void AgregarLibro(List<string> datos)
        {
            Abrir();
            SqlCommand cmd = new SqlCommand("Agregar_Libro_SP", miconexion);
            cmd.Parameters.AddWithValue("@ISBN", datos[0]);
            cmd.Parameters.AddWithValue("@Titulo", datos[1]);
            cmd.Parameters.AddWithValue("@Autor", datos[2]);
            cmd.Parameters.AddWithValue("@Editorial", datos[3]);
            cmd.Parameters.AddWithValue("@Edicion", Convert.ToInt32(datos[4]));
            cmd.Parameters.AddWithValue("@Idioma", Convert.ToInt32(datos[5]));
            cmd.Parameters.AddWithValue("@Genero", Convert.ToInt32(datos[6]));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            Cerrar();
        }

        public void ModificarLibro(List<string> datos, int id_libro)
        {
            Abrir();
            SqlCommand cmd = new SqlCommand("Modificar_Libro_SP", miconexion);
            cmd.Parameters.AddWithValue("@ISBN", datos[0]);
            cmd.Parameters.AddWithValue("@Titulo", datos[1]);
            cmd.Parameters.AddWithValue("@Autor", datos[2]);
            cmd.Parameters.AddWithValue("@Editorial", datos[3]);
            cmd.Parameters.AddWithValue("@Edicion", Convert.ToInt32(datos[4]));
            cmd.Parameters.AddWithValue("@Idioma", Convert.ToInt32(datos[5]));
            cmd.Parameters.AddWithValue("@Genero", Convert.ToInt32(datos[6]));
            cmd.Parameters.AddWithValue("@id_libro", id_libro);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            Cerrar();
        }

        public void EliminarLibro(int id_stock)
        {
            Abrir();
            SqlCommand cmd = new SqlCommand("Eliminar_Libro_SP", miconexion);
            cmd.Parameters.AddWithValue("@id_stock", id_stock);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            Cerrar();
        }

        public void CambiarEstatus(int id_stock, int estatus)
        {
            Abrir();
            SqlCommand cmd = new SqlCommand("Estatus_Libro_SP", miconexion);
            cmd.Parameters.AddWithValue("@id_stock", id_stock);
            cmd.Parameters.AddWithValue("@id_estatus", estatus);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            Cerrar();
        }
    }
       
    
}
