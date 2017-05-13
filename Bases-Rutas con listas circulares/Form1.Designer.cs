namespace Bases_Rutas_con_listas_circulares
{
    partial class frmPrincipal
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
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblTiempo = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtMinutos = new System.Windows.Forms.TextBox();
			this.txtAgregar = new System.Windows.Forms.Button();
			this.bntBuscar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.txtConsola = new System.Windows.Forms.TextBox();
			this.btnReporte = new System.Windows.Forms.Button();
			this.btnEliminarPrimero = new System.Windows.Forms.Button();
			this.btnBorrarUltimo = new System.Windows.Forms.Button();
			this.lblInsertar = new System.Windows.Forms.Label();
			this.txtInsertar = new System.Windows.Forms.TextBox();
			this.btnInsertar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(12, 22);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(84, 24);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "Nombre:";
			// 
			// lblTiempo
			// 
			this.lblTiempo.AutoSize = true;
			this.lblTiempo.Location = new System.Drawing.Point(15, 56);
			this.lblTiempo.Name = "lblTiempo";
			this.lblTiempo.Size = new System.Drawing.Size(81, 24);
			this.lblTiempo.TabIndex = 1;
			this.lblTiempo.Text = "Minutos:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(102, 22);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(130, 29);
			this.txtNombre.TabIndex = 2;
			// 
			// txtMinutos
			// 
			this.txtMinutos.Location = new System.Drawing.Point(102, 57);
			this.txtMinutos.Name = "txtMinutos";
			this.txtMinutos.Size = new System.Drawing.Size(130, 29);
			this.txtMinutos.TabIndex = 3;
			// 
			// txtAgregar
			// 
			this.txtAgregar.Location = new System.Drawing.Point(19, 92);
			this.txtAgregar.Name = "txtAgregar";
			this.txtAgregar.Size = new System.Drawing.Size(213, 32);
			this.txtAgregar.TabIndex = 4;
			this.txtAgregar.Text = "Agregar base al final";
			this.txtAgregar.UseVisualStyleBackColor = true;
			this.txtAgregar.Click += new System.EventHandler(this.txtAgregar_Click);
			// 
			// bntBuscar
			// 
			this.bntBuscar.Location = new System.Drawing.Point(249, 23);
			this.bntBuscar.Name = "bntBuscar";
			this.bntBuscar.Size = new System.Drawing.Size(78, 29);
			this.bntBuscar.TabIndex = 5;
			this.bntBuscar.Text = "Buscar";
			this.bntBuscar.UseVisualStyleBackColor = true;
			this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(333, 23);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(88, 29);
			this.btnEliminar.TabIndex = 6;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// txtConsola
			// 
			this.txtConsola.Location = new System.Drawing.Point(19, 181);
			this.txtConsola.Multiline = true;
			this.txtConsola.Name = "txtConsola";
			this.txtConsola.Size = new System.Drawing.Size(490, 304);
			this.txtConsola.TabIndex = 7;
			// 
			// btnReporte
			// 
			this.btnReporte.Location = new System.Drawing.Point(421, 142);
			this.btnReporte.Name = "btnReporte";
			this.btnReporte.Size = new System.Drawing.Size(88, 29);
			this.btnReporte.TabIndex = 8;
			this.btnReporte.Text = "Reporte";
			this.btnReporte.UseVisualStyleBackColor = true;
			this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
			// 
			// btnEliminarPrimero
			// 
			this.btnEliminarPrimero.Location = new System.Drawing.Point(421, 22);
			this.btnEliminarPrimero.Name = "btnEliminarPrimero";
			this.btnEliminarPrimero.Size = new System.Drawing.Size(88, 57);
			this.btnEliminarPrimero.TabIndex = 9;
			this.btnEliminarPrimero.Text = "Borrar primero";
			this.btnEliminarPrimero.UseVisualStyleBackColor = true;
			this.btnEliminarPrimero.Click += new System.EventHandler(this.btnEliminarPrimero_Click);
			// 
			// btnBorrarUltimo
			// 
			this.btnBorrarUltimo.Location = new System.Drawing.Point(421, 79);
			this.btnBorrarUltimo.Name = "btnBorrarUltimo";
			this.btnBorrarUltimo.Size = new System.Drawing.Size(88, 57);
			this.btnBorrarUltimo.TabIndex = 10;
			this.btnBorrarUltimo.Text = "Borrar Ultimo";
			this.btnBorrarUltimo.UseVisualStyleBackColor = true;
			this.btnBorrarUltimo.Click += new System.EventHandler(this.btnBorrarUltimo_Click);
			// 
			// lblInsertar
			// 
			this.lblInsertar.AutoSize = true;
			this.lblInsertar.Location = new System.Drawing.Point(15, 142);
			this.lblInsertar.Name = "lblInsertar";
			this.lblInsertar.Size = new System.Drawing.Size(181, 24);
			this.lblInsertar.TabIndex = 11;
			this.lblInsertar.Text = "Insertar despues de:";
			// 
			// txtInsertar
			// 
			this.txtInsertar.Location = new System.Drawing.Point(197, 141);
			this.txtInsertar.Name = "txtInsertar";
			this.txtInsertar.Size = new System.Drawing.Size(120, 29);
			this.txtInsertar.TabIndex = 12;
			// 
			// btnInsertar
			// 
			this.btnInsertar.Location = new System.Drawing.Point(323, 140);
			this.btnInsertar.Name = "btnInsertar";
			this.btnInsertar.Size = new System.Drawing.Size(88, 29);
			this.btnInsertar.TabIndex = 13;
			this.btnInsertar.Text = "Insertar";
			this.btnInsertar.UseVisualStyleBackColor = true;
			this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 497);
			this.Controls.Add(this.btnInsertar);
			this.Controls.Add(this.txtInsertar);
			this.Controls.Add(this.lblInsertar);
			this.Controls.Add(this.btnBorrarUltimo);
			this.Controls.Add(this.btnEliminarPrimero);
			this.Controls.Add(this.btnReporte);
			this.Controls.Add(this.txtConsola);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.bntBuscar);
			this.Controls.Add(this.txtAgregar);
			this.Controls.Add(this.txtMinutos);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblTiempo);
			this.Controls.Add(this.lblNombre);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "frmPrincipal";
			this.Text = "Rutas";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.Button txtAgregar;
		private System.Windows.Forms.Button bntBuscar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.TextBox txtConsola;
		private System.Windows.Forms.Button btnReporte;
		private System.Windows.Forms.Button btnEliminarPrimero;
		private System.Windows.Forms.Button btnBorrarUltimo;
		private System.Windows.Forms.Label lblInsertar;
		private System.Windows.Forms.TextBox txtInsertar;
		private System.Windows.Forms.Button btnInsertar;
	}
}

