
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas
{

	public partial class AgregarUsuarios : Form
	{
		public AgregarUsuarios()
		{

			InitializeComponent();

		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			Usuarios pUsuarios = new Usuarios();
			pUsuarios.NOMBRE = txtAgregaNombre.Text.Trim();
			pUsuarios.APELLIDO_P = txtAgregaAP.Text.Trim();
			pUsuarios.APELLIDO_M = txtAgregaAM.Text.Trim();
			pUsuarios.NICKNAME = txtAgregaNick.Text.Trim();
			pUsuarios.PASSWORD = txtAgregaPass.Text.Trim();
			
			int resultado = UsuariosSql.Agregar(pUsuarios);
			if (resultado > 0)
			{
				MessageBox.Show("Usuario Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("No se pudo guardar el Usuario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
		}
		void btnVer_Click(object sender, EventArgs e)
		{
	
			Forms.BuscarUsuarios bu = new Forms.BuscarUsuarios();
			bu.Show();
			this.Hide();
		}
		void btnNuevo_Click(object sender, EventArgs e)
		{
			txtAgregaAM.Clear();
			txtAgregaAP.Clear();
			txtAgregaNick.Clear();
			txtAgregaNombre.Clear();
			txtAgregaPass.Clear();
		}
		void btnRegresar_Click(object sender, EventArgs e)
		{
			Menu m = new Menu();
			m.Show();
			this.Close();
		}
	}
}
