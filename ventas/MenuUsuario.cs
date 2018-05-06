using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas
{

	public partial class MenuUsuario : Form
	{
		public MenuUsuario()
		{

			InitializeComponent();

		}
		void Button1Click(object sender, EventArgs e)
		{
			MainForm m = new MainForm();
			m.Show();
			
			
			this.Dispose();
		}
	}
}
