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
using Data;


namespace Agron //BANDERA DE PELIGRO NASI
{
    public partial class FormBanco : Form
    {
        BBanco bBanco = new BBanco();

        Moneda moneda = new Moneda();

        public FormBanco()
        {
            InitializeComponent();
        }

        private List<Moneda> monedas;
        private void FormBanco_Load(object sender, EventArgs e)
        {
            dgv1.DataSource = bBanco.RetornarListaBancos();

            monedas = bBanco.RetornarListaMonedas();
            cb1.DataSource = monedas;
            cb1.DisplayMember = "codAFIP"; // Muestra el código AFIP en el ComboBox
            cb1.ValueMember = "idMoneda"; // Mantiene el idMoneda asociado

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco
            {
                nombreBanco = tb1.Text,
                moneda = new Moneda { idMoneda = (int)cb1.SelectedValue }, // Obtener el idMoneda seleccionado
                tipoCuenta = int.Parse(cb2.SelectedItem.ToString()),
                detalle = tb2.Text,
                cbu = tb3.Text
            };

            bBanco.Cargar(banco, banco.moneda);
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgv1.SelectedRows[0];

                var ids = fila.Cells["idBanco"].Value;
                int id = Convert.ToInt32(ids);

                bBanco.Eliminar(id);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = tb1.Text;
            int tipoCuenta = Convert.ToInt32(cb2.SelectedItem.ToString());
            string detalle = tb2.Text;
            string cbu = tb3.Text;
            int idMoneda = (int)cb1.SelectedValue;  // Obtener el idMoneda seleccionado

            if (dgv1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgv1.SelectedRows[0];
                var ids = fila.Cells["idBanco"].Value;
                int id = Convert.ToInt32(ids);

                // Ahora se pasa también el idMoneda al método de negocio
                bBanco.Modificar(id, nombre, tipoCuenta, detalle, cbu, idMoneda);
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
