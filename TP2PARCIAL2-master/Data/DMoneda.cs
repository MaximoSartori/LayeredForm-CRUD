using Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    public class DMoneda
    {
        private readonly string conexString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        List<Moneda> listaMonedas = new List<Moneda>();


        // CARGAR DATOS EN LA BASE DE DATOS
        public void cargarBD(Moneda moneda) {
            string cod = moneda.codAFIP;
            string descrip = moneda.descripcion;

            using (SqlConnection conexion = new SqlConnection(conexString)) {
                conexion.Open();
                string query = "INSERT INTO  Monedas (descripcion, codAFIP) VALUES (@descripcion, @codAFIP)";
                using (SqlCommand comando = new SqlCommand(query, conexion)) {
                    comando.Parameters.AddWithValue("@descripcion", descrip);
                    comando.Parameters.AddWithValue("@codAFIP", cod);
                    comando.ExecuteNonQuery();

                }
            }
        }

        public List<Moneda> llenarLista() {

            using (SqlConnection conex = new SqlConnection(conexString)) {
                conex.Open();
                string query = "SELECT * FROM Monedas";
                using (SqlCommand comando = new SqlCommand(query, conex)) {
                    using (SqlDataReader reader = comando.ExecuteReader()) {
                        while (reader.Read()) { 
                            Moneda moneda = new Moneda();
                            moneda.idMoneda = reader.GetInt32(0);
                            moneda.descripcion = reader.GetString(1);
                            moneda.codAFIP = reader.GetString(2);
                            listaMonedas.Add(moneda);
                        }
                    }
                }
            }
            return listaMonedas;
        }

        public void eliminarBD(int id) {
            using (SqlConnection conex = new SqlConnection(conexString)) {
                conex.Open();
                string query = "DELETE FROM Monedas WHERE idMoneda = @id";
                using (SqlCommand comando = new SqlCommand(query, conex)) {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void modificarBD(int id, string descrip, string cod) {

            using (SqlConnection conex = new SqlConnection(conexString)) {
                conex.Open();
                string query = "UPDATE Monedas SET descripcion = @descripcion, codAFIP = @codAFIP WHERE idMoneda = @idMoneda";
                using (SqlCommand comando = new SqlCommand(query, conex)) {

                    comando.Parameters.AddWithValue("@idMoneda", id);
                    comando.Parameters.AddWithValue("@descripcion", descrip);
                    comando.Parameters.AddWithValue("@codAFIP", cod);
                    comando.ExecuteNonQuery();
                }
            }
            
        }
    }
}
