
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas.Forms
{
	/// <summary>
	/// Description of MenuProductos.
	/// </summary>
	public partial class MenuProductos : Form
	{
		public MenuProductos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
	}
}
