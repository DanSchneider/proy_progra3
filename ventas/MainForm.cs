using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//coment this line !!
namespace ventas
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			
		}
		void BtnAceptarClick(object sender, EventArgs e)
		{
			//accción tempotal para probar conexion
			//conexion.ObtenerConexion();
			
			MySqlCommand codigo = new MySqlCommand();
			MySqlCommand codigoAdmin = new MySqlCommand();
			
			MySqlConnection cn = new MySqlConnection();
			
			codigo.Connection = conexion.ObtenerConexion();
			codigoAdmin.Connection = conexion.ObtenerConexion();
			
			codigo.CommandText = ("select * from usuarios where NICKNAME = '" +
			txtUsuario.Text + "' and PASSWORD = '" + txtContraseña.Text + "' ");
			
			codigoAdmin.CommandText = ("select * from admins where NICKNAME = '" +
			txtUsuario.Text + "' and PASS = '" + txtContraseña.Text + "' ");
			
			MySqlDataReader leer = codigo.ExecuteReader();
			MySqlDataReader leerAdmin = codigoAdmin.ExecuteReader();
			
			if (leer.Read()) {
				MessageBox.Show("Bienvenido al sistema " + txtUsuario.Text + "!");
				MenuUsuario m = new MenuUsuario();
				m.Show();
				this.Hide();
				
			}else if(leerAdmin.Read()){
				Menu ma = new Menu();
				MessageBox.Show("Bienvenido al sistema Administrador!");
				ma.Show();
				this.Hide();
			}
			
			else {
				MessageBox.Show("Usuario o contraseña incorrectos!");
			}
			
			
		}
		void BtnCancelarClick(object sender, EventArgs e)
		{
			//this.Dispose();
			Application.ExitThread();
		}
		
	}
}
