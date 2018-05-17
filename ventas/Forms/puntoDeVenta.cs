
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas
{

	public partial class puntoDeVenta : Form
	{
		public puntoDeVenta()
		{
			InitializeComponent();
			
		}
		public static double total =0;
		int cantidad = 0;
		Forms.BuscarProducto vb = new Forms.BuscarProducto();
		
		void ButtonBuscaProductoClick(object sender, EventArgs e)
		{
			
			
			vb.ShowDialog();
			
			if(vb.productoSeleccionado!=null){
				
				
				textBoxDescribeProducto.Text = vb.productoSeleccionado.NOMBRE;
				textBoxCantidadProduct.Text = Convert.ToString(vb.productoSeleccionado.EXISTENCIA);
				
				textBoxPrecioUnit.Text = Convert.ToString(vb.productoSeleccionado.PRECIO_V);
				
			}else{
				MessageBox.Show("No se pudo cargar el producto!");
			}
			
		}
		void buttonAddToOrder_Click(object sender, EventArgs e)
		{
			if(Convert.ToInt32(textBoxCantidadProduct.Text)<=0){
				MessageBox.Show("El producto seleccionado no está disponible en existencia!","Aviso",MessageBoxButtons.OK,
				                MessageBoxIcon.Exclamation);
			}else{
				if(string.IsNullOrEmpty(comboBox1.Text)){
					MessageBox.Show("Debe introducir la cantidad del producto!","Aviso",MessageBoxButtons.OK,
					                MessageBoxIcon.Exclamation);
				}else{
					listProductos.Items.Add(vb.productoSeleccionado.NOMBRE);
					cantidad=Convert.ToInt32(comboBox1.Text);
				}
			}
			
			
			
			
			 total = total + (Convert.ToSingle(textBoxPrecioUnit.Text)*cantidad);
			
			textBoxSubTotal.Text = Convert.ToString(total);
			
		}
		void buttonCerrarCuenta_Click(object sender, EventArgs e)
		{
			Forms.Cobrar co = new Forms.Cobrar();
			co.textBox2.Text =textBoxSubTotal.Text;
			co.txtUser.Text = lblUser.Text;
			co.ShowDialog();
		}

		void button1_Click(object sender, EventArgs e)
		{
			Menu mf = new Menu();
			this.Hide();
			
			mf.Show();
		}

		
	}
}
