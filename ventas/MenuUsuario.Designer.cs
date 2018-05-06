/*
 * Creado por SharpDevelop.
 * Usuario: Luis
 * Fecha: 27/04/2018
 * Hora: 12:27 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ventas
{
	partial class MenuUsuario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnVneta;
		private System.Windows.Forms.Button button1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUsuario));
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnVneta = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
			this.btnBuscar.Location = new System.Drawing.Point(279, 69);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(145, 163);
			this.btnBuscar.TabIndex = 8;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnBuscar.UseVisualStyleBackColor = false;
			// 
			// btnVneta
			// 
			this.btnVneta.BackColor = System.Drawing.SystemColors.Window;
			this.btnVneta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnVneta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnVneta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVneta.Image = ((System.Drawing.Image)(resources.GetObject("btnVneta.Image")));
			this.btnVneta.Location = new System.Drawing.Point(119, 69);
			this.btnVneta.Name = "btnVneta";
			this.btnVneta.Size = new System.Drawing.Size(145, 163);
			this.btnVneta.TabIndex = 7;
			this.btnVneta.Text = "Venta";
			this.btnVneta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnVneta.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Location = new System.Drawing.Point(203, 265);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(146, 54);
			this.button1.TabIndex = 9;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MenuUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 346);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnVneta);
			this.Name = "MenuUsuario";
			this.Text = "Menu Empleado";
			this.ResumeLayout(false);

		}
	}
}
