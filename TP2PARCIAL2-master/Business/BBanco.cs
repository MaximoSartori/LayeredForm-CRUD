using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Data;
using Business;


namespace Data
{
    public class BBanco
    {
        DBanco dBanco = new DBanco();

        public void Cargar(Banco banco, Moneda moneda) {
            dBanco.CargarBD(banco, moneda);
        }

        public List<Moneda> RetornarListaMonedas() {
            return dBanco.ExtraerMonedasBD();
        }

        public List<Banco> RetornarListaBancos() { 
            return dBanco.LlenarListaBanco();
        }

        public void Eliminar(int id)
        {
            dBanco.EliminarBD(id);
        }

        public void Modificar(int id, string nombre, int tipoCuenta, string detalle, string cbu, int idMoneda) {
            dBanco.ModificarBD(id, nombre, tipoCuenta, detalle, cbu, idMoneda);
        }

    }
}
