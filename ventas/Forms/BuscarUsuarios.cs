
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas.Forms
{

	public partial class BuscarUsuarios : Form
	{
		public BuscarUsuarios()
		{

			InitializeComponent();
			

		}
		void btnBuscar_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = UsuariosSql.Buscar(txtNombre.Text, txtApellido.Text);
		}
		void btnCancelar_Click(object sender, EventArgs e)
		{
			AgregarUsuarios au = new AgregarUsuarios();
			au.Show();
			this.Close();
			
		}
		void button1_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = UsuariosSql.mostrarUsuarios();
		}
	}
}
