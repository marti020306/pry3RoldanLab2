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

        private Int32 Indice = 0;



        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (Indice < Cliente.Length)
            {
                Cliente[Indice].Codigo = Convert.ToInt32(mtbCodigo.Text);
                Cliente[Indice].Usuario = txtUsuario.Text;
                Cliente[Indice].Deuda = Convert.ToDecimal(mtbDeuda.Text);
                Cliente[Indice].Limite = Convert.ToDecimal(mtbLimite.Text);
                MessageBox.Show("Cliente Cargado");
                Indice++;
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pueden cargar mas clientes");
            }

        }

        private void Limpiar()
        {
            mtbCodigo.Clear();
            txtUsuario.Clear();
            mtbDeuda.Clear();
            mtbLimite.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)

        {
            Decimal TotalDeuda = 0;

            for (int i = 0; i < Indice; i++)
            {
                dataGridView1.Rows.Add(Cliente[i].Codigo, Cliente[i].Usuario, Cliente[i].Deuda, Cliente[i].Limite);
                TotalDeuda += Cliente[i].Deuda;
            }
           maskedTextBox1.Text = TotalDeuda.ToString();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmGestion_Load(object sender, EventArgs e)
        {
           
        }

        private void Desbloquear()
        {
            if (mtbCodigo.Text != "" && mtbDeuda.Text != "" && txtUsuario.Text != "" && mtbLimite.Text != "")
            {
                btnCargar.Enabled = true;
                btnListar.Enabled = true;
            }
            else
            {
                btnListar.Enabled = false;
                btnCargar.Enabled = false;
            }
        }

        private void mtbCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Desbloquear();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            Desbloquear();
        }

        private void mtbDeuda_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Desbloquear();
        }

        private void mtbLimite_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Desbloquear();
        }


        private void CargaDatosDePrueba()  // creamos un procedimiento para precargar datos de prueba
        {
            Cliente[Indice].Codigo = 10;
            Cliente[Indice].Usuario = "Nico";
            Cliente[Indice].Deuda = 200;
            Cliente[Indice].Limite = 1500;
            Indice++;
            Cliente[Indice].Codigo = 20;
            Cliente[Indice].Usuario = "Ana";
            Cliente[Indice].Deuda = 300;
            Cliente[Indice].Limite = 4000;
            Indice++;
            Cliente[Indice].Codigo = 30;
            Cliente[Indice].Usuario = "Diego";
            Cliente[Indice].Deuda = 0;
            Cliente[Indice].Limite = 3000;
            Indice++;
            Cliente[Indice].Codigo = 40;
            Cliente[Indice].Usuario = "Seba";
            Cliente[Indice].Deuda = 100;
            Cliente[Indice].Limite = 2000;
            Indice++;
        }
    }
    

}
