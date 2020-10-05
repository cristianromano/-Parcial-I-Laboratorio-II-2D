namespace PaginaPrincipal
{
    partial class PaginaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipal));
            this.dtgvProductos = new System.Windows.Forms.DataGridView();
            this.btnNuevosProductos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnHistorialVentas = new System.Windows.Forms.Button();
            this.btnBajoStock = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.picbLogo = new System.Windows.Forms.PictureBox();
            this.lbIventanrio = new System.Windows.Forms.Label();
            this.tmrLogeo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvProductos
            // 
            this.dtgvProductos.AllowUserToAddRows = false;
            this.dtgvProductos.AllowUserToDeleteRows = false;
            this.dtgvProductos.AllowUserToResizeColumns = false;
            this.dtgvProductos.AllowUserToResizeRows = false;
            this.dtgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvProductos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductos.Location = new System.Drawing.Point(167, 82);
            this.dtgvProductos.Name = "dtgvProductos";
            this.dtgvProductos.ReadOnly = true;
            this.dtgvProductos.RowHeadersWidth = 40;
            this.dtgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvProductos.Size = new System.Drawing.Size(442, 240);
            this.dtgvProductos.TabIndex = 0;
            // 
            // btnNuevosProductos
            // 
            this.btnNuevosProductos.Location = new System.Drawing.Point(167, 362);
            this.btnNuevosProductos.Name = "btnNuevosProductos";
            this.btnNuevosProductos.Size = new System.Drawing.Size(121, 22);
            this.btnNuevosProductos.TabIndex = 1;
            this.btnNuevosProductos.Text = "Ingresar Productos";
            this.btnNuevosProductos.UseVisualStyleBackColor = true;
            this.btnNuevosProductos.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(332, 361);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(121, 22);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Realizar Venta";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnHistorialVentas
            // 
            this.btnHistorialVentas.Location = new System.Drawing.Point(488, 361);
            this.btnHistorialVentas.Name = "btnHistorialVentas";
            this.btnHistorialVentas.Size = new System.Drawing.Size(121, 23);
            this.btnHistorialVentas.TabIndex = 3;
            this.btnHistorialVentas.Text = "Historial Ventas";
            this.btnHistorialVentas.UseVisualStyleBackColor = true;
            this.btnHistorialVentas.Click += new System.EventHandler(this.btnHistorialVentas_Click);
            // 
            // btnBajoStock
            // 
            this.btnBajoStock.Location = new System.Drawing.Point(488, 398);
            this.btnBajoStock.Name = "btnBajoStock";
            this.btnBajoStock.Size = new System.Drawing.Size(121, 23);
            this.btnBajoStock.TabIndex = 4;
            this.btnBajoStock.Text = "Bajo Stock";
            this.btnBajoStock.UseVisualStyleBackColor = true;
            this.btnBajoStock.Click += new System.EventHandler(this.btnBajoStock_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(167, 398);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refrescar DataGrid";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // picbLogo
            // 
            this.picbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbLogo.Image = ((System.Drawing.Image)(resources.GetObject("picbLogo.Image")));
            this.picbLogo.Location = new System.Drawing.Point(0, 0);
            this.picbLogo.Name = "picbLogo";
            this.picbLogo.Size = new System.Drawing.Size(800, 449);
            this.picbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbLogo.TabIndex = 6;
            this.picbLogo.TabStop = false;
            // 
            // lbIventanrio
            // 
            this.lbIventanrio.AutoSize = true;
            this.lbIventanrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIventanrio.Location = new System.Drawing.Point(241, 41);
            this.lbIventanrio.Name = "lbIventanrio";
            this.lbIventanrio.Size = new System.Drawing.Size(305, 25);
            this.lbIventanrio.TabIndex = 7;
            this.lbIventanrio.Text = "KWIK E MART INVENTARIO";
            // 
            // tmrLogeo
            // 
            this.tmrLogeo.Enabled = true;
            this.tmrLogeo.Tick += new System.EventHandler(this.tmrLogeo_Tick);
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.lbIventanrio);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBajoStock);
            this.Controls.Add(this.btnHistorialVentas);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnNuevosProductos);
            this.Controls.Add(this.dtgvProductos);
            this.Controls.Add(this.picbLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOBBY";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaginaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvProductos;
        private System.Windows.Forms.Button btnNuevosProductos;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnHistorialVentas;
        private System.Windows.Forms.Button btnBajoStock;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox picbLogo;
        private System.Windows.Forms.Label lbIventanrio;
        private System.Windows.Forms.Timer tmrLogeo;
    }
}

