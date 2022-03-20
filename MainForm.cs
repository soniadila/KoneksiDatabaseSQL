/*
 * Created by SharpDevelop.
 * User: User
 * Date: 20/03/2022
 * Time: 15:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TugasPertemuan6PV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
 			string host = "localhost";
 			string user = "root";
 			string password = "";
 			string database = "toko_buku";
 			string connstr = "server = "+host+"; user="+user+"; database="+database+"; password="+password+";";
 			MySqlConnection conn = new MySqlConnection(connstr);
 			try
 			{
 				conn.Open();
 				MessageBox.Show("Koneksi database SQL Berhasil!");
 			}
 			catch (Exception ex)
 			{
 				MessageBox.Show("Koneksi Gagal");
 			}
		}
	}
}
