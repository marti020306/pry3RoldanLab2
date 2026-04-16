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

        //Declarar Registro Cliente
        private struct RegCliente
        {
            public Int32 Codigo;
            public string Usuario;
            public Decimal Deuda;
            public Decimal Limite;
        }

        //Declarar Vector

       private RegCliente[] Cliente = new RegCliente[10];

        //Declarar Indice

        private Int32 IND = 0;



        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (Vector.IND < Vector.Clientes.Length)
            {
                Int32 i = 0;
                while (Vector.Clientes[i].Codigo != Convert.ToInt32(txtCodigo.Text) && i < IND)//dentro del rango, busca el codigo que ingreso
                {
                    i++;
                }

                if (i == Vector.IND)
                {
                    Vector.Clientes[IND].Codigo = Convert.ToInt32(txtCodigo.Text);
                    Vector.Clientes[IND].Usuario = txtUsuario.Text;
                    Vector.Clientes[IND].Deuda = Convert.ToDecimal(txtDeuda.Text);
                    Vector.Clientes[IND].Limite = Convert.ToDecimal(txtLimite.Text);
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
                dgvConsulta.Rows.Add(Vector.Clientes[i].Codigo, Vector.Clientes[i].Usuario, Vector.Clientes[i].Deuda, Vector.Clientes[i].Limite);
            }
        }

        private void precarga()
        {
            Vector.Clientes[IND].Codigo = 10;
            Vector.Clientes[IND].Usuario = "Ana";
            Vector.Clientes[IND].Deuda = 1000;
            Vector.Clientes[IND].Limite = 10000;
            Vector.IND++;
            Vector.Clientes[IND].Codigo = 20;
            Vector.Clientes[IND].Usuario = "Diego";
            Vector.Clientes[IND].Deuda = 0;
            Vector.Clientes[IND].Limite = 20000;
            Vector.IND++;
            Vector.Clientes[IND].Codigo = 30;
            Vector.Clientes[IND].Usuario = "Maria";
            Vector.Clientes[IND].Deuda = 3000;
            Vector.Clientes[IND].Limite = 30000;
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
                    dgvConsulta.Rows.Add(Vector.Clientes[i].Codigo, Vector.Clientes[i].Usuario, Vector.Clientes[i].Limite, Vector.Clientes[i].Deuda);
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
