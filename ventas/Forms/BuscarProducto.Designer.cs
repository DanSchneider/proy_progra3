/*
 * Creado por SharpDevelop.
 * Usuario: Luis
 * Fecha: 14/05/2018
 * Hora: 01:50 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ventas.Forms
{
	partial class BuscarProducto
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.DataGridView dataGridView1;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtid = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(327, 364);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 26);
			this.button1.TabIndex = 17;
			this.button1.Text = "&Ver todo";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(117, 37);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 26);
			this.label2.TabIndex = 16;
			this.label2.Text = "ID del producto";
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(227, 34);
			this.txtid.Margin = new System.Windows.Forms.Padding(4);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(186, 20);
			this.txtid.TabIndex = 14;
			this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
			// 
			// btnCancelar
			// 
			this.btnCancelar.ForeColor = System.Drawing.Color.Black;
			this.btnCancelar.Location = new System.Drawing.Point(593, 364);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(88, 26);
			this.btnCancelar.TabIndex = 12;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.ForeColor = System.Drawing.Color.Black;
			this.btnBuscar.Location = new System.Drawing.Point(593, 17);
			this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(88, 26);
			this.btnBuscar.TabIndex = 11;
			this.btnBuscar.Text = "&Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnAceptar
			// 
			this.btnAceptar.ForeColor = System.Drawing.Color.Black;
			this.btnAceptar.Location = new System.Drawing.Point(50, 364);
			this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(88, 26);
			this.btnAceptar.TabIndex = 10;
			this.btnAceptar.Text = "&Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(50, 86);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(631, 264);
			this.dataGridView1.TabIndex = 9;
			// 
			// BuscarProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(718, 414);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.dataGridView1);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "BuscarProducto";
			this.Text = "BuscarProducto";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
