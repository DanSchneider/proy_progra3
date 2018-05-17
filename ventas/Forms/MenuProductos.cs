
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas.Forms
{

	public partial class MenuProductos : Form
	{
		public MenuProductos()
		{

			InitializeComponent();

		}
		void button3_Click(object sender, EventArgs e)
		{
			Menu m = new Menu();
			m.Show();
			this.Hide();
		}
		void button1_Click(object sender, EventArgs e)
		{
			AgregarProductos ag = new AgregarProductos();
			ag.Show();
			this.Hide();
		}
		void button2_Click(object sender, EventArgs e)
		{
			BuscarProducto bp = new BuscarProducto();
			bp.ShowDialog();
		}
	}
}
