/*
 * Creado por SharpDevelop.
 * Usuario: Luis
 * Fecha: 16/05/2018
 * Hora: 10:54 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ventas.Forms
{
	partial class Cobrar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txtNomCliente;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox txtTelCliente;
		
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
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNomCliente = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTelCliente = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(252, 269);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Aceptar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(201, 119);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(164, 20);
			this.textBox2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(201, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Total de venta:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(201, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Usuario: ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(201, 31);
			this.txtUser.Name = "txtUser";
			this.txtUser.ReadOnly = true;
			this.txtUser.Size = new System.Drawing.Size(164, 20);
			this.txtUser.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(123, 179);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Nombre Cliente";
			// 
			// txtNomCliente
			// 
			this.txtNomCliente.Location = new System.Drawing.Point(123, 205);
			this.txtNomCliente.Name = "txtNomCliente";
			this.txtNomCliente.Size = new System.Drawing.Size(164, 20);
			this.txtNomCliente.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(314, 179);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Teléfono Cliente";
			// 
			// txtTelCliente
			// 
			this.txtTelCliente.Location = new System.Drawing.Point(314, 205);
			this.txtTelCliente.Name = "txtTelCliente";
			this.txtTelCliente.Size = new System.Drawing.Size(164, 20);
			this.txtTelCliente.TabIndex = 8;
			this.txtTelCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			// 
			// Cobrar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 324);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTelCliente);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNomCliente);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button1);
			this.Name = "Cobrar";
			this.Text = "Cobrar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
