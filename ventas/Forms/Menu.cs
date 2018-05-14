using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas
{

	public partial class Menu : Form
	{
		public Menu()
		{

			InitializeComponent();
			

		}
		void Button1Click(object sender, EventArgs e)
		{
			MainForm m = new MainForm();
			m.Show();
			
			
			this.Dispose();
			
		}
		void BtnUsuariosClick(object sender, EventArgs e)
		{
			AgregarUsuarios au = new AgregarUsuarios();
			au.Show();
			this.Hide();
			
		}
		void btnVneta_Click(object sender, EventArgs e)
		{
			//redirección a la ventana de las ventas
		}
		void btnProductos_Click(object sender, EventArgs e)
		{
			Forms.MenuProductos mp = new Forms.MenuProductos();
			mp.Show();
			this.Hide();
		}
	}
}
