/*
 * Created by SharpDevelop.
 * User: Luis
 * Date: 24/04/2018
 * Time: 11:02 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ventas
{
	partial class Menu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnVneta;
		private System.Windows.Forms.Button btnProductos;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnUsuarios;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
			this.btnVneta = new System.Windows.Forms.Button();
			this.btnProductos = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnUsuarios = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnVneta
			// 
			this.btnVneta.BackColor = System.Drawing.SystemColors.Window;
			this.btnVneta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnVneta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnVneta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVneta.Image = ((System.Drawing.Image)(resources.GetObject("btnVneta.Image")));
			this.btnVneta.Location = new System.Drawing.Point(9, 84);
			this.btnVneta.Name = "btnVneta";
			this.btnVneta.Size = new System.Drawing.Size(130, 169);
			this.btnVneta.TabIndex = 2;
			this.btnVneta.Text = "Venta";
			this.btnVneta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnVneta.UseVisualStyleBackColor = false;
			// 
			// btnProductos
			// 
			this.btnProductos.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
			this.btnProductos.Location = new System.Drawing.Point(296, 84);
			this.btnProductos.Name = "btnProductos";
			this.btnProductos.Size = new System.Drawing.Size(145, 163);
			this.btnProductos.TabIndex = 5;
			this.btnProductos.Text = "Productos";
			this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnProductos.UseVisualStyleBackColor = false;
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
			this.btnBuscar.Location = new System.Drawing.Point(145, 84);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(145, 163);
			this.btnBuscar.TabIndex = 6;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnBuscar.UseVisualStyleBackColor = false;
			// 
			// btnUsuarios
			// 
			this.btnUsuarios.BackColor = System.Drawing.Color.White;
			this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
			this.btnUsuarios.Location = new System.Drawing.Point(447, 84);
			this.btnUsuarios.Name = "btnUsuarios";
			this.btnUsuarios.Size = new System.Drawing.Size(143, 163);
			this.btnUsuarios.TabIndex = 7;
			this.btnUsuarios.Text = "Usuarios";
			this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnUsuarios.UseVisualStyleBackColor = false;
			this.btnUsuarios.Click += new System.EventHandler(this.BtnUsuariosClick);
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Location = new System.Drawing.Point(226, 325);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(146, 54);
			this.button1.TabIndex = 8;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(600, 391);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnUsuarios);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnProductos);
			this.Controls.Add(this.btnVneta);
			this.Name = "Menu";
			this.Text = "Menu Administrador";
			this.ResumeLayout(false);

		}
	}
}
