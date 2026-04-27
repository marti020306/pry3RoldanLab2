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
    public partial class frmListarTodo : Form
    {
        public frmListarTodo()
        {
            InitializeComponent();
        }

        private void frmListarTodo_Load(object sender, EventArgs e)
        {

        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            dgvListadoClientes.Rows.Clear();

            // Variables para totales
            decimal totalDeuda = 0m;
            int cantidadClientes = Vector.IND;

            // Agregar filas con los clientes cargados
            for (int i = 0; i < Vector.IND; i++)
            {
                // Orden de columnas según el diseñador: Codigo, Nombre, Limite, Deuda
                dgvListadoClientes.Rows.Add(
                    Vector.Clientes[i].Codigo,
                    Vector.Clientes[i].Nombre,
                    Vector.Clientes[i].Limite,
                    Vector.Clientes[i].Deuda);

                totalDeuda += Vector.Clientes[i].Deuda;
            }

            // Calcular promedio (proteger división por cero)
            decimal promedioDeuda = 0m;
            if (cantidadClientes > 0)
            {
                promedioDeuda = totalDeuda / cantidadClientes;
            }

            // Mostrar resultados en las etiquetas (formato numérico con 2 decimales)
            label4.Text = totalDeuda.ToString("N2");
            label5.Text = cantidadClientes.ToString();
            label6.Text = promedioDeuda.ToString("N2");
        }
    }
}
    

