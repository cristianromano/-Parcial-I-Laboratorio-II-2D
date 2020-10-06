namespace ParcialLabII
{
    partial class FormularioHistorialVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioHistorialVentas));
            this.dtgHistorialVentas = new System.Windows.Forms.DataGridView();
            this.tmrFormHistorial = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorialVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgHistorialVentas
            // 
            this.dtgHistorialVentas.AllowUserToAddRows = false;
            this.dtgHistorialVentas.AllowUserToDeleteRows = false;
            this.dtgHistorialVentas.AllowUserToResizeColumns = false;
            this.dtgHistorialVentas.AllowUserToResizeRows = false;
            this.dtgHistorialVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHistorialVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgHistorialVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistorialVentas.Location = new System.Drawing.Point(12, 12);
            this.dtgHistorialVentas.Name = "dtgHistorialVentas";
            this.dtgHistorialVentas.ReadOnly = true;
            this.dtgHistorialVentas.Size = new System.Drawing.Size(424, 212);
            this.dtgHistorialVentas.TabIndex = 0;
            // 
            // tmrFormHistorial
            // 
            this.tmrFormHistorial.Enabled = true;
            this.tmrFormHistorial.Interval = 225;
            this.tmrFormHistorial.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormularioHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(460, 277);
            this.Controls.Add(this.dtgHistorialVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioHistorialVentas";
            this.Text = "FormularioHistorialVentas";
            this.Load += new System.EventHandler(this.FormularioHistorialVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorialVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgHistorialVentas;
        private System.Windows.Forms.Timer tmrFormHistorial;
    }
}