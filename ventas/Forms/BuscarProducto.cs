
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas.Forms
{

	public partial class BuscarProducto : Form
	{
		public BuscarProducto()
		{

			InitializeComponent();
			

		}
		
		public Productos productoSeleccionado{get;set;}
		
		void btnBuscar_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = ProductosSql.Buscar(txtNombre.Text, Convert.ToInt32(txtid.Text));
		}
		
		
		//función para que la casilla del id solo acepte numeros.
		
		void txtid_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
			{
				MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
				return;
			}
		}
		void button1_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = ProductosSql.mostrarProductos();
		}
		
		void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void btnAceptar_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
			{
				int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
				productoSeleccionado = ProductosSql.ObtenerProductos(id);

				this.Close();
			}
			else
				MessageBox.Show("debe de seleccionar una fila");
		}
	}
}
