
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
		
		public Usuarios usuarioActual {set;get;}
		
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
			bu.ShowDialog();
			
			if(bu.usuarioSeleccionado!=null){
				
				usuarioActual = bu.usuarioSeleccionado;
				txtAgregaNombre.Text = bu.usuarioSeleccionado.NOMBRE;
				txtAgregaAP.Text = bu.usuarioSeleccionado.APELLIDO_P;
				txtAgregaAM.Text = bu.usuarioSeleccionado.APELLIDO_M;
				txtAgregaNick.Text = bu.usuarioSeleccionado.NICKNAME;
				txtAgregaPass.Text = bu.usuarioSeleccionado.PASSWORD;
			}
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
		
		void btnActualizar_Click(object sender, EventArgs e)
		{
			Usuarios pUsuarios = new Usuarios();

			pUsuarios.NOMBRE = txtAgregaNombre.Text.Trim();
			pUsuarios.APELLIDO_P = txtAgregaAP.Text.Trim();
			pUsuarios.APELLIDO_M = txtAgregaAM.Text.Trim();
			pUsuarios.NICKNAME = txtAgregaNick.Text.Trim();
			pUsuarios.PASSWORD = txtAgregaPass.Text.Trim();
			pUsuarios.Id = usuarioActual.Id;

			if (UsuariosSql.Actualizar(pUsuarios) > 0)
			{
				MessageBox.Show("Los datos del usuario se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

			}
		}
		void btnEliminar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Esta Seguro que desea eliminar el usuario Actual", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (UsuariosSql.Eliminar(usuarioActual.Id) > 0)
				{
					MessageBox.Show("Usuario Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("No se pudo eliminar el Usuario", "Usuario No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
				MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}
}
