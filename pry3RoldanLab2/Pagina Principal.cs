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
    }
}
