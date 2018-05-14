/*
 * Creado por SharpDevelop.
 * Usuario: Luis
 * Fecha: 14/05/2018
 * Hora: 11:54 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ventas.Forms
{
	partial class AgregarProductos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnVer;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtexis;
		private System.Windows.Forms.TextBox txtpv;
		private System.Windows.Forms.TextBox txtpn;
		private System.Windows.Forms.TextBox txtnom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnVer = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtexis = new System.Windows.Forms.TextBox();
			this.txtpv = new System.Windows.Forms.TextBox();
			this.txtpn = new System.Windows.Forms.TextBox();
			this.txtnom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnActualizar
			// 
			this.btnActualizar.ForeColor = System.Drawing.Color.Black;
			this.btnActualizar.Location = new System.Drawing.Point(239, 376);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(144, 28);
			this.btnActualizar.TabIndex = 18;
			this.btnActualizar.Text = "&Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.ForeColor = System.Drawing.Color.Black;
			this.btnEliminar.Location = new System.Drawing.Point(401, 376);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(144, 28);
			this.btnEliminar.TabIndex = 17;
			this.btnEliminar.Text = "&Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnRegresar
			// 
			this.btnRegresar.ForeColor = System.Drawing.Color.Black;
			this.btnRegresar.Location = new System.Drawing.Point(77, 376);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(144, 28);
			this.btnRegresar.TabIndex = 16;
			this.btnRegresar.Text = "&Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// btnVer
			// 
			this.btnVer.ForeColor = System.Drawing.Color.Black;
			this.btnVer.Location = new System.Drawing.Point(401, 12);
			this.btnVer.Name = "btnVer";
			this.btnVer.Size = new System.Drawing.Size(144, 28);
			this.btnVer.TabIndex = 15;
			this.btnVer.Text = "&Buscar producto";
			this.btnVer.UseVisualStyleBackColor = true;
			this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.ForeColor = System.Drawing.Color.Black;
			this.btnNuevo.Location = new System.Drawing.Point(239, 12);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(144, 28);
			this.btnNuevo.TabIndex = 14;
			this.btnNuevo.Text = "&Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.ForeColor = System.Drawing.Color.Black;
			this.btnGuardar.Location = new System.Drawing.Point(77, 12);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(144, 28);
			this.btnGuardar.TabIndex = 13;
			this.btnGuardar.Text = "&Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.txtexis);
			this.groupBox1.Controls.Add(this.txtpv);
			this.groupBox1.Controls.Add(this.txtpn);
			this.groupBox1.Controls.Add(this.txtnom);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(21, 54);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(698, 316);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Añadir usuarios";
			// 
			// txtexis
			// 
			this.txtexis.Location = new System.Drawing.Point(232, 93);
			this.txtexis.Name = "txtexis";
			this.txtexis.Size = new System.Drawing.Size(373, 20);
			this.txtexis.TabIndex = 9;
			this.txtexis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtexis_KeyPress);
			// 
			// txtpv
			// 
			this.txtpv.Location = new System.Drawing.Point(232, 187);
			this.txtpv.Name = "txtpv";
			this.txtpv.Size = new System.Drawing.Size(373, 20);
			this.txtpv.TabIndex = 8;
			this.txtpv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpv_KeyPress);
			// 
			// txtpn
			// 
			this.txtpn.Location = new System.Drawing.Point(232, 137);
			this.txtpn.Name = "txtpn";
			this.txtpn.Size = new System.Drawing.Size(373, 20);
			this.txtpn.TabIndex = 6;
			this.txtpn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpn_KeyPress);
			// 
			// txtnom
			// 
			this.txtnom.Location = new System.Drawing.Point(232, 43);
			this.txtnom.Name = "txtnom";
			this.txtnom.Size = new System.Drawing.Size(373, 20);
			this.txtnom.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(55, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Existencia";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(55, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(55, 187);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Precio para venta";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(55, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Precio neto";
			// 
			// AgregarProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(743, 416);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnVer);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.groupBox1);
			this.Name = "AgregarProductos";
			this.Text = "AgregarProductos";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
