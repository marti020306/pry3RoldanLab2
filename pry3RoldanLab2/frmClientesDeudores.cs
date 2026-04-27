using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry3RoldanLab2
{
    public partial class frmClientesDeudores : Form
    {
        public frmClientesDeudores()
        {
            InitializeComponent();
        }

        private void dgvDeudas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblClientes_Click(object sender, EventArgs e)
        {

        }

        private void lblPromedio_Click(object sender, EventArgs e)
        {

        }

        private void btnListarDeudores_Click(object sender, EventArgs e)
        {
           
            dgvDeudas.Rows.Clear();

            decimal totalDeuda = 0m;
            int cantidadClientes = 0;

           
            for (int i = 0; i < Vector.IND; i++)
            {
                if (Vector.Clientes[i].Deuda > 0)
                {
                    dgvDeudas.Rows.Add(
                        Vector.Clientes[i].Codigo,
                        Vector.Clientes[i].Nombre,
                        Vector.Clientes[i].Limite,
                        Vector.Clientes[i].Deuda);

                    totalDeuda += Vector.Clientes[i].Deuda;
                    cantidadClientes++;
                }
            }
            // Calcular promedio 
            decimal promedio = 0m;
            if (cantidadClientes > 0)
            {
                promedio = totalDeuda / cantidadClientes;
            }

           
            lblTotal.Text = totalDeuda.ToString("N2");
            lblClientes.Text = cantidadClientes.ToString();
            lblPromedio.Text = promedio.ToString("N2");
        }
    }
}
