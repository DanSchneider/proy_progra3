
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
		//propiedades de la clase de usuarios para obtener info:
		public Usuarios usuarioSeleccionado{get;set;}
		
		
		void btnBuscar_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = UsuariosSql.Buscar(txtNombre.Text, txtApellido.Text);
		}
		void btnCancelar_Click(object sender, EventArgs e)
		{
			AgregarUsuarios au = new AgregarUsuarios();
			
			this.Close();
			
		}
		void button1_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = UsuariosSql.mostrarUsuarios();
		}
		void btnAceptar_Click(object sender, EventArgs e)
		{
			
			
			
			if (dataGridView1.SelectedRows.Count == 1)
			{
				int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
				usuarioSeleccionado = UsuariosSql.ObtenerUsuarios(id);

				this.Close();
			}
			else
				MessageBox.Show("debe de seleccionar una fila");
		}
	}
}
