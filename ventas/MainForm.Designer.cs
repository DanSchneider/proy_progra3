/*
 * Creado por SharpDevelop.
 * Usuario: Luis
 * Fecha: 21/04/2018
 * Hora: 08:25 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ventas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lblUSER_NAME;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.Label lblPASSWORD;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label label1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblUSER_NAME = new System.Windows.Forms.Label();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.lblPASSWORD = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.txtUsuario);
			this.groupBox1.Controls.Add(this.lblUSER_NAME);
			this.groupBox1.Controls.Add(this.txtContraseña);
			this.groupBox1.Controls.Add(this.lblPASSWORD);
			this.groupBox1.Controls.Add(this.btnCancelar);
			this.groupBox1.Controls.Add(this.btnAceptar);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(35, 29);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(592, 381);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(279, 52);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(134, 26);
			this.txtUsuario.TabIndex = 8;
			// 
			// lblUSER_NAME
			// 
			this.lblUSER_NAME.AutoSize = true;
			this.lblUSER_NAME.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.lblUSER_NAME.ForeColor = System.Drawing.Color.Transparent;
			this.lblUSER_NAME.Location = new System.Drawing.Point(167, 53);
			this.lblUSER_NAME.Name = "lblUSER_NAME";
			this.lblUSER_NAME.Size = new System.Drawing.Size(54, 16);
			this.lblUSER_NAME.TabIndex = 6;
			this.lblUSER_NAME.Text = "Usuario:";
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(279, 88);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(134, 26);
			this.txtContraseña.TabIndex = 9;
			this.txtContraseña.UseSystemPasswordChar = true;
			// 
			// lblPASSWORD
			// 
			this.lblPASSWORD.AutoSize = true;
			this.lblPASSWORD.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.lblPASSWORD.ForeColor = System.Drawing.Color.Transparent;
			this.lblPASSWORD.Location = new System.Drawing.Point(140, 89);
			this.lblPASSWORD.Name = "lblPASSWORD";
			this.lblPASSWORD.Size = new System.Drawing.Size(78, 16);
			this.lblPASSWORD.TabIndex = 7;
			this.lblPASSWORD.Text = "Contraseña:";
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.Maroon;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.Location = new System.Drawing.Point(319, 331);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(107, 32);
			this.btnCancelar.TabIndex = 3;
			this.btnCancelar.Text = "&Salir";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnAceptar
			// 
			this.btnAceptar.BackColor = System.Drawing.Color.DarkSlateGray;
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.Location = new System.Drawing.Point(168, 331);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(104, 32);
			this.btnAceptar.TabIndex = 2;
			this.btnAceptar.Text = "&Acceder";
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(138, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(422, 18);
			this.label1.TabIndex = 11;
			this.label1.Text = "Ingrese su usuario y contraseña para acceder al sistema";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(663, 422);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Inicio de sesión";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
