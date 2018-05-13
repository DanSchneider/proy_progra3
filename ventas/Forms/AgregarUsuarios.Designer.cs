/*
 * Creado por SharpDevelop.
 * Usuario: Luis
 * Fecha: 27/04/2018
 * Hora: 07:30 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ventas
{
	partial class AgregarUsuarios
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtAgregaAP;
		private System.Windows.Forms.TextBox txtAgregaNick;
		private System.Windows.Forms.TextBox txtAgregaPass;
		private System.Windows.Forms.TextBox txtAgregaAM;
		private System.Windows.Forms.TextBox txtAgregaNombre;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnVer;
		private System.Windows.Forms.Button btnRegresar;
		
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
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtAgregaAP = new System.Windows.Forms.TextBox();
			this.txtAgregaNick = new System.Windows.Forms.TextBox();
			this.txtAgregaPass = new System.Windows.Forms.TextBox();
			this.txtAgregaAM = new System.Windows.Forms.TextBox();
			this.txtAgregaNombre = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnVer = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(55, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(55, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Apellido paterno";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(55, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Apellido Materno";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(55, 187);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Nombre de usuario";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(55, 233);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Contraseña";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtAgregaAP);
			this.groupBox1.Controls.Add(this.txtAgregaNick);
			this.groupBox1.Controls.Add(this.txtAgregaPass);
			this.groupBox1.Controls.Add(this.txtAgregaAM);
			this.groupBox1.Controls.Add(this.txtAgregaNombre);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(12, 83);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(698, 316);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Añadir usuarios";
			// 
			// txtAgregaAP
			// 
			this.txtAgregaAP.Location = new System.Drawing.Point(232, 93);
			this.txtAgregaAP.Name = "txtAgregaAP";
			this.txtAgregaAP.Size = new System.Drawing.Size(373, 26);
			this.txtAgregaAP.TabIndex = 9;
			// 
			// txtAgregaNick
			// 
			this.txtAgregaNick.Location = new System.Drawing.Point(232, 187);
			this.txtAgregaNick.Name = "txtAgregaNick";
			this.txtAgregaNick.Size = new System.Drawing.Size(373, 26);
			this.txtAgregaNick.TabIndex = 8;
			// 
			// txtAgregaPass
			// 
			this.txtAgregaPass.Location = new System.Drawing.Point(232, 233);
			this.txtAgregaPass.Name = "txtAgregaPass";
			this.txtAgregaPass.Size = new System.Drawing.Size(373, 26);
			this.txtAgregaPass.TabIndex = 7;
			// 
			// txtAgregaAM
			// 
			this.txtAgregaAM.Location = new System.Drawing.Point(232, 137);
			this.txtAgregaAM.Name = "txtAgregaAM";
			this.txtAgregaAM.Size = new System.Drawing.Size(373, 26);
			this.txtAgregaAM.TabIndex = 6;
			// 
			// txtAgregaNombre
			// 
			this.txtAgregaNombre.Location = new System.Drawing.Point(232, 43);
			this.txtAgregaNombre.Name = "txtAgregaNombre";
			this.txtAgregaNombre.Size = new System.Drawing.Size(373, 26);
			this.txtAgregaNombre.TabIndex = 5;
			// 
			// btnGuardar
			// 
			this.btnGuardar.ForeColor = System.Drawing.Color.Black;
			this.btnGuardar.Location = new System.Drawing.Point(149, 22);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(144, 28);
			this.btnGuardar.TabIndex = 6;
			this.btnGuardar.Text = "&Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnNuevo
			// 
			this.btnNuevo.ForeColor = System.Drawing.Color.Black;
			this.btnNuevo.Location = new System.Drawing.Point(311, 22);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(144, 28);
			this.btnNuevo.TabIndex = 7;
			this.btnNuevo.Text = "&Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnVer
			// 
			this.btnVer.ForeColor = System.Drawing.Color.Black;
			this.btnVer.Location = new System.Drawing.Point(473, 22);
			this.btnVer.Name = "btnVer";
			this.btnVer.Size = new System.Drawing.Size(144, 28);
			this.btnVer.TabIndex = 8;
			this.btnVer.Text = "&Buscar usuarios";
			this.btnVer.UseVisualStyleBackColor = true;
			this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
			// 
			// btnRegresar
			// 
			this.btnRegresar.ForeColor = System.Drawing.Color.Black;
			this.btnRegresar.Location = new System.Drawing.Point(278, 405);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(144, 28);
			this.btnRegresar.TabIndex = 9;
			this.btnRegresar.Text = "&Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// AgregarUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(732, 444);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnVer);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "AgregarUsuarios";
			this.Text = "AgregarUsuarios";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
