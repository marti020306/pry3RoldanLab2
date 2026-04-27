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
    public partial class Pagina_Principal : Form
    {
        public Pagina_Principal()
        {
            InitializeComponent();
        }

        private void agregarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmGestion();
            
            formulario.Show();
        }

        private void listadoDeTodoLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmListarClientes();
          
            formulario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listadoDeTodosLosDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesDeudores frmClientesDeudores = new frmClientesDeudores();
            frmClientesDeudores.Show();
        }

        private void listarOrdenadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmListarClientes frmListarClientes = new frmListarClientes();
           frmListarClientes.Show();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarTodo frmListarTodosClientes = new frmListarTodo();
            frmListarTodosClientes.Show();
        }
    }
}
