
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas.Forms
{

	public partial class Cobrar : Form
	{
		public Cobrar()
		{

			InitializeComponent();
			

		}
		puntoDeVenta pv = new puntoDeVenta();
		void button1_Click(object sender, EventArgs e)
		{
			if(String.IsNullOrEmpty(txtTelCliente.Text) &&
			   String.IsNullOrEmpty(txtTelCliente.Text)){
				
				MessageBox.Show("Debe llenar todos los campos del cliente!!",
				                "advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			else{
				Clases.SqlClientes.Clientes clClientes = new Clases.SqlClientes.Clientes();
				
				
				clClientes.NOMBRE = txtNomCliente.Text.Trim();
				clClientes.TELEFONO = Convert.ToDouble(txtTelCliente.Text.Trim());
				
				int resultado = Clases.SqlClientes.ClientesSql.Agregar(clClientes);
				if (resultado > 0)
				{
					MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Error al guardar los datos :(", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				Clases.SqlVentas.Ventas clVentas = new ventas.Clases.SqlVentas.Ventas();
				
				clVentas.USUARIO = txtUser.Text.Trim();
				clVentas.CLIENTE = txtNomCliente.Text.Trim();
				clVentas.TOTAL_VENTA = Convert.ToSingle(textBox2.Text.Trim());
				
				int resultado2 = Clases.SqlVentas.SqlVentas.Agregar(clVentas);
				if (resultado2 > 0)
				{
					MessageBox.Show("Venta registrada.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Error al guardar los datos :(", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				this.Dispose();
			}
		}
		
		void textBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
			{
				MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
				return;
			}
		}

	}
}
