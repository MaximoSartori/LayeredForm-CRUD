using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Data;


namespace Business
{
    public class BMoneda
    {
        DMoneda dMoneda = new DMoneda();

        public void cargar(Moneda moneda) { 
            dMoneda.cargarBD(moneda);
        }

        public List<Moneda> retornarLista() {
            return dMoneda.llenarLista();
        }

        public void Eliminar(int id) {
            dMoneda.eliminarBD(id);
        }

        public void Modificar(int id, string descrip, string cod) {
            dMoneda.modificarBD(id, descrip, cod);
        }
    }
}
