using Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data.SqlClient;

namespace Data
{
    public class DBanco
    {
        private readonly string conexString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        public void CargarBD(Banco banco, Moneda moneda)
        {
            using (SqlConnection conex = new SqlConnection(conexString)) {
                conex.Open();
                string query = "INSERT INTO Bancos (nombreBanco, codMoneda, tipoCuenta, detalle, cbu) VALUES (@nombreBanco, @codMoneda, " +
                    "@tipoCuenta, @detalle, @cbu)";

                using (SqlCommand comando = new SqlCommand(query, conex)) {
                    comando.Parameters.AddWithValue("@nombreBanco", banco.nombreBanco);
                    comando.Parameters.AddWithValue("@tipoCuenta", banco.tipoCuenta);
                    comando.Parameters.AddWithValue("@detalle", banco.detalle);
                    comando.Parameters.AddWithValue("@cbu", banco.cbu);

                    comando.Parameters.AddWithValue("@codMoneda", moneda.idMoneda);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Moneda> ExtraerMonedasBD()
        {
            List<Moneda> monedas = new List<Moneda>();

            using (SqlConnection conex = new SqlConnection(conexString))
            {
                conex.Open();
                string query = "SELECT idMoneda, codAFIP FROM Monedas";
                using (SqlCommand comando = new SqlCommand(query, conex))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Moneda moneda = new Moneda
                            {
                                idMoneda = (int)reader["idMoneda"],
                                codAFIP = reader["codAFIP"].ToString()
                            };
                            monedas.Add(moneda);
                        }
                    }
                }
            }
            return monedas;
        }

       

        public List<Banco> LlenarListaBanco() {
            List<Banco> bancos = new List<Banco>();

            using (SqlConnection conex = new SqlConnection(conexString)) {
                conex.Open();

                string query = "SELECT * FROM Bancos";
                using (SqlCommand comando = new SqlCommand(query, conex)) {
                    using (SqlDataReader reader = comando.ExecuteReader()) {

                        while (reader.Read()) {
                            Banco banco = new Banco
                            {
                                idBanco = reader.GetInt32(0),
                                nombreBanco = reader.GetString(1),
                                moneda = new Moneda {
                                    idMoneda = reader.GetInt32(2),
                                },
                                tipoCuenta = reader.GetInt32(3),
                                detalle = reader.GetString(4),
                                cbu = reader.GetString(5),
                            };
                            bancos.Add(banco);
                        }
                    }
                }
            }
            return bancos;
        }

        public void EliminarBD(int id) {
            using (SqlConnection conex = new SqlConnection(conexString)) {
                conex.Open();

                string query = "DELETE FROM Bancos WHERE idBanco = @idBanco";
                using (SqlCommand comando = new SqlCommand(query, conex)) {

                    comando.Parameters.AddWithValue("@idBanco", id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void ModificarBD(int id, string nombre, int tipoCuenta, string detalle, string cbu, int idMoneda) {

            using (SqlConnection conex = new SqlConnection(conexString))
            {
                conex.Open();

                // Modificando la consulta SQL para incluir el campo codMoneda
                string query = "UPDATE Bancos SET nombreBanco = @nombreBanco, tipoCuenta = @tipoCuenta, " +
                               "detalle = @detalle, cbu = @cbu, codMoneda = @codMoneda WHERE idBanco = @idBanco";

                using (SqlCommand comando = new SqlCommand(query, conex))
                {
                    // Agregar parámetros para cada campo, incluyendo el nuevo campo codMoneda
                    comando.Parameters.AddWithValue("@idBanco", id);
                    comando.Parameters.AddWithValue("@nombreBanco", nombre);
                    comando.Parameters.AddWithValue("@tipoCuenta", tipoCuenta);
                    comando.Parameters.AddWithValue("@detalle", detalle);
                    comando.Parameters.AddWithValue("@cbu", cbu);
                    comando.Parameters.AddWithValue("@codMoneda", idMoneda); // Agregar el parámetro para la moneda

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
