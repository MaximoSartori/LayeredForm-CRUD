using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Business;


namespace Presentacion
{
    public partial class FormMoneda : Form
    {
        BMoneda bMoneda = new BMoneda();

        public FormMoneda()
        {
            InitializeComponent();
            imprimirLista();

        }

        public void imprimirLista()
        {
            List<Moneda> monedas = bMoneda.retornarLista();
            dgv1.DataSource = monedas;
        }


        // BOTON DE CARGAR DATOS
        private void button1_Click(object sender, EventArgs e)
        {
            string descrip = tb1.Text;
            string codAFIP = tb2.Text;
            Moneda moneda = new Moneda();
            moneda.descripcion = descrip;
            moneda.codAFIP = codAFIP;
            bMoneda.cargar(moneda);
        }

        private void FormMoneda_Load(object sender, EventArgs e)
        {
            imprimirLista();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgv1.SelectedRows[0];
                var id = fila.Cells["idMoneda"].Value;
                int ids = Convert.ToInt32(id);

                bMoneda.Eliminar(ids);
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string descrip = tb1.Text;
            string cod = tb2.Text;

            if (dgv1.SelectedRows.Count > 0) {

                DataGridViewRow fila = dgv1.SelectedRows[0];
                var id = fila.Cells["idMoneda"].Value;
                int ids = Convert.ToInt32(id);
                bMoneda.Modificar(ids, descrip, cod);
            }
        }
    }
}
