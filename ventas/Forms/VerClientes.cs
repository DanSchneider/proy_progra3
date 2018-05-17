using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas.Forms
{

	public partial class VerClientes : Form
	{
		public VerClientes()
		{

			InitializeComponent();
			

		}
		void button1_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = Clases.SqlClientes.ClientesSql.mostrarClientes();
			
			
		}
		void button2_Click(object sender, EventArgs e)
		{
			Clientes cl = new Clientes();
			cl.Show();
			this.Hide();
		}
	}
}
