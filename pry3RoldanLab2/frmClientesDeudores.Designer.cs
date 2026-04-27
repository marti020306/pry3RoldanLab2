namespace pry3RoldanLab2
{
    partial class frmClientesDeudores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDeudas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.btnListarDeudores = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDeudas);
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta De Datos";
            // 
            // dgvDeudas
            // 
            this.dgvDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDeudas.Location = new System.Drawing.Point(31, 38);
            this.dgvDeudas.Name = "dgvDeudas";
            this.dgvDeudas.RowHeadersWidth = 51;
            this.dgvDeudas.RowTemplate.Height = 24;
            this.dgvDeudas.Size = new System.Drawing.Size(698, 284);
            this.dgvDeudas.TabIndex = 1;
            this.dgvDeudas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeudas_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre y Apellido";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Limite De Credito ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total De Deuda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Promedio de Deuda";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(637, 416);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 4;
            // 
            // lblClientes
            // 
            this.lblClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClientes.Location = new System.Drawing.Point(637, 472);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(100, 23);
            this.lblClientes.TabIndex = 5;
            this.lblClientes.Click += new System.EventHandler(this.lblClientes_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.Location = new System.Drawing.Point(637, 524);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(100, 23);
            this.lblPromedio.TabIndex = 6;
            this.lblPromedio.Click += new System.EventHandler(this.lblPromedio_Click);
            // 
            // btnListarDeudores
            // 
            this.btnListarDeudores.Location = new System.Drawing.Point(38, 528);
            this.btnListarDeudores.Name = "btnListarDeudores";
            this.btnListarDeudores.Size = new System.Drawing.Size(143, 23);
            this.btnListarDeudores.TabIndex = 2;
            this.btnListarDeudores.Text = "Listar Deudores";
            this.btnListarDeudores.UseVisualStyleBackColor = true;
            this.btnListarDeudores.Click += new System.EventHandler(this.btnListarDeudores_Click);
            // 
            // frmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 583);
            this.Controls.Add(this.btnListarDeudores);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmClientesDeudores";
            this.Text = "frmClientesDeudores";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDeudas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Button btnListarDeudores;
    }
}