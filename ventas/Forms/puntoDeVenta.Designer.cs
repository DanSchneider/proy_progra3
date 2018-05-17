/*
 * Creado por SharpDevelop.
 * Usuario: jldg0
 * Fecha: 08/05/2018
 * Hora: 03:46 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ventas
{
	partial class puntoDeVenta
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxCantidadProduct;
		private System.Windows.Forms.TextBox textBoxDescribeProducto;
		private System.Windows.Forms.TextBox textBoxPrecioUnit;
		public  System.Windows.Forms.TextBox textBoxSubTotal;
		private System.Windows.Forms.ListBox listProductos;
		private System.Windows.Forms.Button buttonBuscaProducto;
		private System.Windows.Forms.Button buttonAddToOrder;
		private System.Windows.Forms.Button buttonCerrarCuenta;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label lblUser;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxCantidadProduct = new System.Windows.Forms.TextBox();
			this.textBoxDescribeProducto = new System.Windows.Forms.TextBox();
			this.textBoxPrecioUnit = new System.Windows.Forms.TextBox();
			this.textBoxSubTotal = new System.Windows.Forms.TextBox();
			this.listProductos = new System.Windows.Forms.ListBox();
			this.buttonBuscaProducto = new System.Windows.Forms.Button();
			this.buttonAddToOrder = new System.Windows.Forms.Button();
			this.buttonCerrarCuenta = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(33, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Disponible";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(168, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Descripción";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(455, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Precio Unitario";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(644, 227);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Sub total $";
			// 
			// textBoxCantidadProduct
			// 
			this.textBoxCantidadProduct.Location = new System.Drawing.Point(12, 68);
			this.textBoxCantidadProduct.Name = "textBoxCantidadProduct";
			this.textBoxCantidadProduct.ReadOnly = true;
			this.textBoxCantidadProduct.Size = new System.Drawing.Size(88, 20);
			this.textBoxCantidadProduct.TabIndex = 6;
			// 
			// textBoxDescribeProducto
			// 
			this.textBoxDescribeProducto.Location = new System.Drawing.Point(130, 68);
			this.textBoxDescribeProducto.Name = "textBoxDescribeProducto";
			this.textBoxDescribeProducto.ReadOnly = true;
			this.textBoxDescribeProducto.Size = new System.Drawing.Size(302, 20);
			this.textBoxDescribeProducto.TabIndex = 7;
			// 
			// textBoxPrecioUnit
			// 
			this.textBoxPrecioUnit.Location = new System.Drawing.Point(455, 68);
			this.textBoxPrecioUnit.Name = "textBoxPrecioUnit";
			this.textBoxPrecioUnit.ReadOnly = true;
			this.textBoxPrecioUnit.Size = new System.Drawing.Size(100, 20);
			this.textBoxPrecioUnit.TabIndex = 8;
			// 
			// textBoxSubTotal
			// 
			this.textBoxSubTotal.Location = new System.Drawing.Point(714, 227);
			this.textBoxSubTotal.Name = "textBoxSubTotal";
			this.textBoxSubTotal.ReadOnly = true;
			this.textBoxSubTotal.Size = new System.Drawing.Size(100, 20);
			this.textBoxSubTotal.TabIndex = 9;
			// 
			// listProductos
			// 
			this.listProductos.FormattingEnabled = true;
			this.listProductos.Location = new System.Drawing.Point(12, 103);
			this.listProductos.MultiColumn = true;
			this.listProductos.Name = "listProductos";
			this.listProductos.Size = new System.Drawing.Size(617, 290);
			this.listProductos.TabIndex = 10;
			// 
			// buttonBuscaProducto
			// 
			this.buttonBuscaProducto.Location = new System.Drawing.Point(721, 68);
			this.buttonBuscaProducto.Name = "buttonBuscaProducto";
			this.buttonBuscaProducto.Size = new System.Drawing.Size(75, 35);
			this.buttonBuscaProducto.TabIndex = 11;
			this.buttonBuscaProducto.Text = "Buscar producto";
			this.buttonBuscaProducto.UseVisualStyleBackColor = true;
			this.buttonBuscaProducto.Click += new System.EventHandler(this.ButtonBuscaProductoClick);
			// 
			// buttonAddToOrder
			// 
			this.buttonAddToOrder.Location = new System.Drawing.Point(635, 67);
			this.buttonAddToOrder.Name = "buttonAddToOrder";
			this.buttonAddToOrder.Size = new System.Drawing.Size(75, 36);
			this.buttonAddToOrder.TabIndex = 13;
			this.buttonAddToOrder.Text = "Agregar a orden";
			this.buttonAddToOrder.UseVisualStyleBackColor = true;
			this.buttonAddToOrder.Click += new System.EventHandler(this.buttonAddToOrder_Click);
			// 
			// buttonCerrarCuenta
			// 
			this.buttonCerrarCuenta.Location = new System.Drawing.Point(721, 301);
			this.buttonCerrarCuenta.Name = "buttonCerrarCuenta";
			this.buttonCerrarCuenta.Size = new System.Drawing.Size(75, 40);
			this.buttonCerrarCuenta.TabIndex = 14;
			this.buttonCerrarCuenta.Text = "Cerrar cuenta";
			this.buttonCerrarCuenta.UseVisualStyleBackColor = true;
			this.buttonCerrarCuenta.Click += new System.EventHandler(this.buttonCerrarCuenta_Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(572, 42);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "Cantidad";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"10"});
			this.comboBox1.Location = new System.Drawing.Point(572, 67);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(43, 21);
			this.comboBox1.TabIndex = 17;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(281, 399);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 40);
			this.button1.TabIndex = 19;
			this.button1.Text = "Regresar al menú";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(254, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 20;
			this.label5.Text = "Sesión actual: ";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblUser
			// 
			this.lblUser.Location = new System.Drawing.Point(360, 9);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(139, 23);
			this.lblUser.TabIndex = 21;
			// 
			// puntoDeVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(826, 444);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.buttonCerrarCuenta);
			this.Controls.Add(this.buttonAddToOrder);
			this.Controls.Add(this.buttonBuscaProducto);
			this.Controls.Add(this.listProductos);
			this.Controls.Add(this.textBoxSubTotal);
			this.Controls.Add(this.textBoxPrecioUnit);
			this.Controls.Add(this.textBoxDescribeProducto);
			this.Controls.Add(this.textBoxCantidadProduct);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "puntoDeVenta";
			this.Text = "Punto de venta";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
