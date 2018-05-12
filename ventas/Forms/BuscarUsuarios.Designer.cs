/*
 * Creado por SharpDevelop.
 * Usuario: Luis
 * Fecha: 11/05/2018
 * Hora: 10:47 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ventas.Forms
{
	partial class BuscarUsuarios
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(24, 116);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(631, 264);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnAceptar
			// 
			this.btnAceptar.ForeColor = System.Drawing.Color.Black;
			this.btnAceptar.Location = new System.Drawing.Point(93, 394);
			this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(88, 26);
			this.btnAceptar.TabIndex = 1;
			this.btnAceptar.Text = "&Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			// 
			// btnBuscar
			// 
			this.btnBuscar.ForeColor = System.Drawing.Color.Black;
			this.btnBuscar.Location = new System.Drawing.Point(567, 47);
			this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(88, 26);
			this.btnBuscar.TabIndex = 2;
			this.btnBuscar.Text = "&Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.ForeColor = System.Drawing.Color.Black;
			this.btnCancelar.Location = new System.Drawing.Point(567, 394);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(88, 26);
			this.btnCancelar.TabIndex = 3;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(201, 34);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(186, 21);
			this.txtNombre.TabIndex = 4;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(201, 64);
			this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(186, 21);
			this.txtApellido.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(79, 34);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 26);
			this.label1.TabIndex = 6;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(79, 64);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 26);
			this.label2.TabIndex = 7;
			this.label2.Text = "Primer apellido";
			// 
			// BuscarUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(697, 426);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "BuscarUsuarios";
			this.Text = "BuscarUsuarios";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
