using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas.Forms
{

	public partial class AgregarProductos : Form
	{
		public AgregarProductos()
		{

			InitializeComponent();

		}
		public Productos productoActual {set;get;}
		
		
		void btnGuardar_Click(object sender, EventArgs e)
		{
			
			Productos prProductos = new Productos();
			prProductos.NOMBRE = txtnom.Text.Trim();
			prProductos.EXISTENCIA = Convert.ToInt32(txtexis.Text.Trim());
			prProductos.PRECIO_N = Convert.ToInt32(txtpn.Text.Trim());
			prProductos.PRECIO_V = Convert.ToInt32(txtpv.Text.Trim());
			
			
			int resultado = ProductosSql.Agregar(prProductos);
			if (resultado > 0)
			{
				MessageBox.Show("Producto Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("No se pudo guardar el Producto", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		void btnNuevo_Click(object sender, EventArgs e)
		{
			txtpn.Clear();
			txtexis.Clear();
			txtpv.Clear();
			txtnom.Clear();
			
		}
		void btnRegresar_Click(object sender, EventArgs e)
		{
			MenuProductos mp = new MenuProductos();
			mp.Show();
			this.Hide();
		}
		
		void txtpn_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
			{
				MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
				return;
			}
		}
		void txtpv_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
			{
				MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
				return;
			}
		}
		
		void txtexis_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
			{
				MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
				return;
			}
		}
		void btnVer_Click(object sender, EventArgs e)
		{
			BuscarProducto bp = new BuscarProducto();
			bp.ShowDialog();
			
			if(bp.productoSeleccionado!=null){
				
				productoActual = bp.productoSeleccionado;
				txtnom.Text = bp.productoSeleccionado.NOMBRE;
				txtexis.Text = Convert.ToString(bp.productoSeleccionado.EXISTENCIA);
				txtpn.Text = Convert.ToString(bp.productoSeleccionado.PRECIO_N);
				txtpv.Text = Convert.ToString(bp.productoSeleccionado.PRECIO_V);
				
			}
			
		}
		void btnActualizar_Click(object sender, EventArgs e)
		{
			Productos prProductos = new Productos();

			prProductos.NOMBRE = txtnom.Text.Trim();
			prProductos.EXISTENCIA = Convert.ToInt32(txtexis.Text.Trim());
			prProductos.PRECIO_N = Convert.ToInt32(txtpn.Text.Trim());
			prProductos.PRECIO_V = Convert.ToInt32(txtpv.Text.Trim());
			prProductos.Id = productoActual.Id;

			if (ProductosSql.Actualizar(prProductos) > 0)
			{
				MessageBox.Show("Los datos del producto se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

			}
		}
		void btnEliminar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Esta Seguro que desea eliminar el producto Actual?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (ProductosSql.Eliminar(productoActual.Id) > 0)
				{
					MessageBox.Show("Producto Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtpn.Clear();
					txtexis.Clear();
					txtpv.Clear();
					txtnom.Clear();
				}
				else
				{
					MessageBox.Show("No se pudo eliminar el Producto", "Usuario No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
				MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			
			
		}
		
	}
}
