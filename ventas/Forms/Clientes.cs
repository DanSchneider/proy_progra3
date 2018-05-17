
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas.Forms
{

	public partial class Clientes : Form
	{
		public Clientes()
		{

			InitializeComponent();
			

		}
		void button2_Click(object sender, EventArgs e)
		{
			VerClientes vc = new VerClientes();
			vc.Show();
			this.Hide();
		}
		void button3_Click(object sender, EventArgs e)
		{
			EcClientes ec = new EcClientes();
			ec.Show();
			this.Hide();
			
				
		}
		void button1_Click(object sender, EventArgs e)
		{
			Menu m = new Menu();
			m.Show();
			this.Hide();
			
		}
	}
}
