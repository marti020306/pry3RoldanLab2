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
    public partial class frmGestion : Form
    {
        public frmGestion()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (Vector.IND < Vector.Clientes.Length)
            {
                Int32 i = 0;
                while (i < Vector.IND && Vector.Clientes[i].Codigo != Convert.ToInt32(txtCodigo.Text)) //dentro del rango, busca el codigo que ingreso
                {
                    i++;
                }

                if (i == Vector.IND)
                {
                    Vector.Clientes[Vector.IND].Codigo = Convert.ToInt32(txtCodigo.Text);
                    Vector.Clientes[Vector.IND].Nombre = txtUsuario.Text;
                    Vector.Clientes[Vector.IND].Deuda = Convert.ToDecimal(txtDeuda.Text);
                    Vector.Clientes[Vector.IND].Limite = Convert.ToDecimal(txtLimite.Text);
                    Vector.IND++;
                    MessageBox.Show("Cliente cargado correctamente");
                    txtCodigo.Text = "";
                    txtUsuario.Text = "";
                    txtDeuda.Text = "";
                    txtLimite.Text = "";
                }
                else
                {
                    MessageBox.Show("El codigo ingresado ya existe, ingrese otro");
                    txtCodigo.Text = "";
                }
            }
            else
            {
                MessageBox.Show("No se pueden cargar mas clientes");
            }
            Listar();
        }

        private void Limpiar()
        {
            txtCodigo.Clear();
            txtUsuario.Clear();
            txtDeuda.Clear();
            txtLimite.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void frmGestion_Load(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
            precarga();
            Listar();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Listar()
        {
            dgvConsulta.Rows.Clear();
            for (int i = 0; i < Vector.IND; i++)
            {
                dgvConsulta.Rows.Add(Vector.Clientes[i].Codigo, Vector.Clientes[i].Nombre, Vector.Clientes[i].Deuda, Vector.Clientes[i].Limite);
            }
        }

        private void precarga()
        {
            Vector.Clientes[Vector.IND].Codigo = 10;
            Vector.Clientes[Vector.IND].Nombre = "Ana";
            Vector.Clientes[Vector.IND].Deuda = 1000;
            Vector.Clientes[Vector.IND].Limite = 10000;
            Vector.IND++;

            Vector.Clientes[Vector.IND].Codigo = 20;
            Vector.Clientes[Vector.IND].Nombre = "Diego";
            Vector.Clientes[Vector.IND].Deuda = 0;
            Vector.Clientes[Vector.IND].Limite = 20000;
            Vector.IND++;

            Vector.Clientes[Vector.IND].Codigo = 30;
            Vector.Clientes[Vector.IND].Nombre = "Maria";
            Vector.Clientes[Vector.IND].Deuda = 3000;
            Vector.Clientes[Vector.IND].Limite = 30000;
            Vector.IND++;
        }

        private void btnDeudores_Click(object sender, EventArgs e)
        {
            Decimal TotalDeuda = 0;
            dgvConsulta.Rows.Clear();
            for (int i = 0; i < Vector.IND; i++)
            {
                if (Vector.Clientes[i].Deuda > 0)
                {
                    dgvConsulta.Rows.Add(Vector.Clientes[i].Codigo, Vector.Clientes[i].Nombre, Vector.Clientes[i].Limite, Vector.Clientes[i].Deuda);
                    TotalDeuda = TotalDeuda + Vector.Clientes[i].Deuda;
                }
            }
            lblDeudores.Text = TotalDeuda.ToString();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void Comprobar()
        {
            if (txtCodigo.Text != "" && txtUsuario.Text != "" && txtDeuda.Text != "" && txtLimite.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }
        }
    }
}
