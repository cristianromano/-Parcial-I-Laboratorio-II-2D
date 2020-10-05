namespace PaginaPrincipal
{
    partial class FormularioVentas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioVentas));
            this.lbNombreVenta = new System.Windows.Forms.Label();
            this.lbApellidoVenta = new System.Windows.Forms.Label();
            this.lbProductoVenta = new System.Windows.Forms.Label();
            this.btnAceptarVentas = new System.Windows.Forms.Button();
            this.txtNombreVentas = new System.Windows.Forms.TextBox();
            this.txtApellidoVentas = new System.Windows.Forms.TextBox();
            this.cmbProductosVenta = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.dtgVentas = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.txtApellidoVendedor = new System.Windows.Forms.TextBox();
            this.lbApellidoVendedor = new System.Windows.Forms.Label();
            this.lbNombreVendedor = new System.Windows.Forms.Label();
            this.lbID_Empleado = new System.Windows.Forms.Label();
            this.txtIDVendedor = new System.Windows.Forms.TextBox();
            this.lbCartelCompra = new System.Windows.Forms.Label();
            this.lbCartelRegistrarVenta = new System.Windows.Forms.Label();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.dtgEmpleado = new System.Windows.Forms.DataGridView();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.lbIDCliente = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.lbCartelClientes = new System.Windows.Forms.Label();
            this.lbCartelEmpleados = new System.Windows.Forms.Label();
            this.pctbLogoVentas = new System.Windows.Forms.PictureBox();
            this.lbStock = new System.Windows.Forms.Label();
            this.tmrFormVenta = new System.Windows.Forms.Timer(this.components);
            this.btnTicket = new System.Windows.Forms.Button();
            this.txtPrecioItem = new System.Windows.Forms.TextBox();
            this.lbPrecioItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbLogoVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombreVenta
            // 
            this.lbNombreVenta.AutoSize = true;
            this.lbNombreVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreVenta.Location = new System.Drawing.Point(34, 449);
            this.lbNombreVenta.Name = "lbNombreVenta";
            this.lbNombreVenta.Size = new System.Drawing.Size(71, 20);
            this.lbNombreVenta.TabIndex = 0;
            this.lbNombreVenta.Text = "Nombre";
            // 
            // lbApellidoVenta
            // 
            this.lbApellidoVenta.AutoSize = true;
            this.lbApellidoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidoVenta.Location = new System.Drawing.Point(34, 484);
            this.lbApellidoVenta.Name = "lbApellidoVenta";
            this.lbApellidoVenta.Size = new System.Drawing.Size(73, 20);
            this.lbApellidoVenta.TabIndex = 1;
            this.lbApellidoVenta.Text = "Apellido";
            // 
            // lbProductoVenta
            // 
            this.lbProductoVenta.AutoSize = true;
            this.lbProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductoVenta.Location = new System.Drawing.Point(17, 527);
            this.lbProductoVenta.Name = "lbProductoVenta";
            this.lbProductoVenta.Size = new System.Drawing.Size(90, 20);
            this.lbProductoVenta.TabIndex = 2;
            this.lbProductoVenta.Text = "Productos";
            // 
            // btnAceptarVentas
            // 
            this.btnAceptarVentas.Location = new System.Drawing.Point(485, 565);
            this.btnAceptarVentas.Name = "btnAceptarVentas";
            this.btnAceptarVentas.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarVentas.TabIndex = 3;
            this.btnAceptarVentas.Text = "Aceptar";
            this.btnAceptarVentas.UseVisualStyleBackColor = true;
            this.btnAceptarVentas.Click += new System.EventHandler(this.btnAceptarVentas_Click);
            // 
            // txtNombreVentas
            // 
            this.txtNombreVentas.Location = new System.Drawing.Point(115, 449);
            this.txtNombreVentas.Name = "txtNombreVentas";
            this.txtNombreVentas.Size = new System.Drawing.Size(111, 20);
            this.txtNombreVentas.TabIndex = 4;
            // 
            // txtApellidoVentas
            // 
            this.txtApellidoVentas.Location = new System.Drawing.Point(115, 484);
            this.txtApellidoVentas.Name = "txtApellidoVentas";
            this.txtApellidoVentas.Size = new System.Drawing.Size(111, 20);
            this.txtApellidoVentas.TabIndex = 5;
            // 
            // cmbProductosVenta
            // 
            this.cmbProductosVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductosVenta.FormattingEnabled = true;
            this.cmbProductosVenta.Location = new System.Drawing.Point(113, 526);
            this.cmbProductosVenta.Name = "cmbProductosVenta";
            this.cmbProductosVenta.Size = new System.Drawing.Size(113, 21);
            this.cmbProductosVenta.TabIndex = 6;
            this.cmbProductosVenta.SelectedIndexChanged += new System.EventHandler(this.cmbProductosVenta_SelectedIndexChanged);
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(296, 526);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(28, 21);
            this.txtStock.TabIndex = 7;
            // 
            // dtgVentas
            // 
            this.dtgVentas.AllowUserToAddRows = false;
            this.dtgVentas.AllowUserToDeleteRows = false;
            this.dtgVentas.AllowUserToResizeColumns = false;
            this.dtgVentas.AllowUserToResizeRows = false;
            this.dtgVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentas.Location = new System.Drawing.Point(146, 12);
            this.dtgVentas.Name = "dtgVentas";
            this.dtgVentas.ReadOnly = true;
            this.dtgVentas.Size = new System.Drawing.Size(439, 150);
            this.dtgVentas.TabIndex = 8;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(113, 610);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProducto.TabIndex = 9;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(485, 443);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreVendedor.TabIndex = 10;
            // 
            // txtApellidoVendedor
            // 
            this.txtApellidoVendedor.Location = new System.Drawing.Point(485, 480);
            this.txtApellidoVendedor.Name = "txtApellidoVendedor";
            this.txtApellidoVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoVendedor.TabIndex = 11;
            // 
            // lbApellidoVendedor
            // 
            this.lbApellidoVendedor.AutoSize = true;
            this.lbApellidoVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidoVendedor.Location = new System.Drawing.Point(406, 478);
            this.lbApellidoVendedor.Name = "lbApellidoVendedor";
            this.lbApellidoVendedor.Size = new System.Drawing.Size(73, 20);
            this.lbApellidoVendedor.TabIndex = 12;
            this.lbApellidoVendedor.Text = "Apellido";
            // 
            // lbNombreVendedor
            // 
            this.lbNombreVendedor.AutoSize = true;
            this.lbNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreVendedor.Location = new System.Drawing.Point(408, 443);
            this.lbNombreVendedor.Name = "lbNombreVendedor";
            this.lbNombreVendedor.Size = new System.Drawing.Size(71, 20);
            this.lbNombreVendedor.TabIndex = 13;
            this.lbNombreVendedor.Text = "Nombre";
            // 
            // lbID_Empleado
            // 
            this.lbID_Empleado.AutoSize = true;
            this.lbID_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID_Empleado.Location = new System.Drawing.Point(451, 521);
            this.lbID_Empleado.Name = "lbID_Empleado";
            this.lbID_Empleado.Size = new System.Drawing.Size(28, 20);
            this.lbID_Empleado.TabIndex = 14;
            this.lbID_Empleado.Text = "ID";
            // 
            // txtIDVendedor
            // 
            this.txtIDVendedor.Location = new System.Drawing.Point(485, 521);
            this.txtIDVendedor.Name = "txtIDVendedor";
            this.txtIDVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtIDVendedor.TabIndex = 15;
            // 
            // lbCartelCompra
            // 
            this.lbCartelCompra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCartelCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCartelCompra.Location = new System.Drawing.Point(122, 411);
            this.lbCartelCompra.Name = "lbCartelCompra";
            this.lbCartelCompra.Size = new System.Drawing.Size(104, 20);
            this.lbCartelCompra.TabIndex = 16;
            this.lbCartelCompra.Text = "COMPRA";
            // 
            // lbCartelRegistrarVenta
            // 
            this.lbCartelRegistrarVenta.AutoSize = true;
            this.lbCartelRegistrarVenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCartelRegistrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCartelRegistrarVenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCartelRegistrarVenta.Location = new System.Drawing.Point(415, 411);
            this.lbCartelRegistrarVenta.Name = "lbCartelRegistrarVenta";
            this.lbCartelRegistrarVenta.Size = new System.Drawing.Size(202, 24);
            this.lbCartelRegistrarVenta.TabIndex = 17;
            this.lbCartelRegistrarVenta.Text = "REGISTRAR VENTA";
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.AllowUserToResizeColumns = false;
            this.dtgClientes.AllowUserToResizeRows = false;
            this.dtgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Location = new System.Drawing.Point(15, 230);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.Size = new System.Drawing.Size(331, 150);
            this.dtgClientes.TabIndex = 18;
            this.dtgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellContentClick);
            // 
            // dtgEmpleado
            // 
            this.dtgEmpleado.AllowUserToAddRows = false;
            this.dtgEmpleado.AllowUserToDeleteRows = false;
            this.dtgEmpleado.AllowUserToResizeColumns = false;
            this.dtgEmpleado.AllowUserToResizeRows = false;
            this.dtgEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleado.Location = new System.Drawing.Point(376, 230);
            this.dtgEmpleado.Name = "dtgEmpleado";
            this.dtgEmpleado.ReadOnly = true;
            this.dtgEmpleado.Size = new System.Drawing.Size(331, 150);
            this.dtgEmpleado.TabIndex = 19;
            this.dtgEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmpleado_CellContentClick);
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(4, 579);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(103, 20);
            this.lbPrecio.TabIndex = 20;
            this.lbPrecio.Text = "Monto Final";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Location = new System.Drawing.Point(113, 579);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.ReadOnly = true;
            this.txtPrecioTotal.Size = new System.Drawing.Size(113, 20);
            this.txtPrecioTotal.TabIndex = 21;
            // 
            // lbIDCliente
            // 
            this.lbIDCliente.AutoSize = true;
            this.lbIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDCliente.Location = new System.Drawing.Point(27, 411);
            this.lbIDCliente.Name = "lbIDCliente";
            this.lbIDCliente.Size = new System.Drawing.Size(28, 20);
            this.lbIDCliente.TabIndex = 22;
            this.lbIDCliente.Text = "ID";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCliente.ForeColor = System.Drawing.Color.Red;
            this.txtIDCliente.Location = new System.Drawing.Point(61, 411);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.ReadOnly = true;
            this.txtIDCliente.Size = new System.Drawing.Size(44, 20);
            this.txtIDCliente.TabIndex = 23;
            // 
            // lbCartelClientes
            // 
            this.lbCartelClientes.AutoSize = true;
            this.lbCartelClientes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCartelClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCartelClientes.Location = new System.Drawing.Point(27, 199);
            this.lbCartelClientes.Name = "lbCartelClientes";
            this.lbCartelClientes.Size = new System.Drawing.Size(205, 24);
            this.lbCartelClientes.TabIndex = 24;
            this.lbCartelClientes.Text = "LISTA DE CLIENTES";
            // 
            // lbCartelEmpleados
            // 
            this.lbCartelEmpleados.AutoSize = true;
            this.lbCartelEmpleados.BackColor = System.Drawing.Color.White;
            this.lbCartelEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCartelEmpleados.Location = new System.Drawing.Point(385, 199);
            this.lbCartelEmpleados.Name = "lbCartelEmpleados";
            this.lbCartelEmpleados.Size = new System.Drawing.Size(232, 24);
            this.lbCartelEmpleados.TabIndex = 25;
            this.lbCartelEmpleados.Text = "LISTA DE EMPLEADOS";
            // 
            // pctbLogoVentas
            // 
            this.pctbLogoVentas.BackColor = System.Drawing.Color.Transparent;
            this.pctbLogoVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctbLogoVentas.BackgroundImage")));
            this.pctbLogoVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctbLogoVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctbLogoVentas.Location = new System.Drawing.Point(0, 0);
            this.pctbLogoVentas.Name = "pctbLogoVentas";
            this.pctbLogoVentas.Size = new System.Drawing.Size(779, 645);
            this.pctbLogoVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbLogoVentas.TabIndex = 26;
            this.pctbLogoVentas.TabStop = false;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.Location = new System.Drawing.Point(232, 528);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(58, 16);
            this.lbStock.TabIndex = 27;
            this.lbStock.Text = "STOCK";
            // 
            // tmrFormVenta
            // 
            this.tmrFormVenta.Enabled = true;
            this.tmrFormVenta.Interval = 600;
            this.tmrFormVenta.Tick += new System.EventHandler(this.tmrFormVenta_Tick);
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(591, 565);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(75, 23);
            this.btnTicket.TabIndex = 28;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // txtPrecioItem
            // 
            this.txtPrecioItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioItem.Location = new System.Drawing.Point(296, 553);
            this.txtPrecioItem.Name = "txtPrecioItem";
            this.txtPrecioItem.ReadOnly = true;
            this.txtPrecioItem.Size = new System.Drawing.Size(50, 21);
            this.txtPrecioItem.TabIndex = 29;
            // 
            // lbPrecioItem
            // 
            this.lbPrecioItem.AutoSize = true;
            this.lbPrecioItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioItem.Location = new System.Drawing.Point(231, 553);
            this.lbPrecioItem.Name = "lbPrecioItem";
            this.lbPrecioItem.Size = new System.Drawing.Size(59, 20);
            this.lbPrecioItem.TabIndex = 30;
            this.lbPrecioItem.Text = "Precio";
            // 
            // FormularioVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 645);
            this.Controls.Add(this.lbPrecioItem);
            this.Controls.Add(this.txtPrecioItem);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lbCartelEmpleados);
            this.Controls.Add(this.lbCartelClientes);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.lbIDCliente);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.dtgEmpleado);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.lbCartelRegistrarVenta);
            this.Controls.Add(this.lbCartelCompra);
            this.Controls.Add(this.txtIDVendedor);
            this.Controls.Add(this.lbID_Empleado);
            this.Controls.Add(this.lbNombreVendedor);
            this.Controls.Add(this.lbApellidoVendedor);
            this.Controls.Add(this.txtApellidoVendedor);
            this.Controls.Add(this.txtNombreVendedor);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dtgVentas);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.cmbProductosVenta);
            this.Controls.Add(this.txtApellidoVentas);
            this.Controls.Add(this.txtNombreVentas);
            this.Controls.Add(this.btnAceptarVentas);
            this.Controls.Add(this.lbProductoVenta);
            this.Controls.Add(this.lbApellidoVenta);
            this.Controls.Add(this.lbNombreVenta);
            this.Controls.Add(this.pctbLogoVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioVentas";
            this.Text = "FormularioVentas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioVentas_FormClosing);
            this.Load += new System.EventHandler(this.FormularioVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbLogoVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombreVenta;
        private System.Windows.Forms.Label lbApellidoVenta;
        private System.Windows.Forms.Label lbProductoVenta;
        private System.Windows.Forms.Button btnAceptarVentas;
        private System.Windows.Forms.TextBox txtNombreVentas;
        private System.Windows.Forms.TextBox txtApellidoVentas;
        private System.Windows.Forms.ComboBox cmbProductosVenta;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.DataGridView dtgVentas;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.TextBox txtApellidoVendedor;
        private System.Windows.Forms.Label lbApellidoVendedor;
        private System.Windows.Forms.Label lbNombreVendedor;
        private System.Windows.Forms.Label lbID_Empleado;
        private System.Windows.Forms.TextBox txtIDVendedor;
        private System.Windows.Forms.Label lbCartelCompra;
        private System.Windows.Forms.Label lbCartelRegistrarVenta;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.DataGridView dtgEmpleado;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.Label lbIDCliente;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label lbCartelClientes;
        private System.Windows.Forms.Label lbCartelEmpleados;
        private System.Windows.Forms.PictureBox pctbLogoVentas;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Timer tmrFormVenta;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.TextBox txtPrecioItem;
        private System.Windows.Forms.Label lbPrecioItem;
    }
}