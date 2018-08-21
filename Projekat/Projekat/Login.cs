using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projekat
{
    public partial class Login : Form
    {
        string username;
        string password;



		public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

			//**********************************************DATABASE ******************************************************************************************************************************

			//Uspostavljanje konekcije sa bazom
			SqlConnection con = new SqlConnection("Data Source=DESKTOP-4QM5BTL\\SQLEXPRESS;Initial Catalog=pijacadb;Integrated Security=True");// \\za escape
			DataTable DT = new DataTable();


			con.Open();


			SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM adminTable WHERE userAdmin ='" + username + "' AND passAdmin = '" + password + "' ", con);
			SDA.Fill(DT);


			if (username != null || password != null){
				if (DT.Rows.Count == 1)
				{
					this.Hide();//da zatvori ovaj prozor
					administracija administracija = new administracija(); //otvara admin deo 
					administracija.ShowDialog();

				

				}
			}
			else { MessageBox.Show("Unesite odgovarajuce karaktere u polja. "); }

			//SDA.SelectCommand.ExecuteNonQuery();
			con.Close();



			//*****************************************************END DATABASE*********************************************************************



			

			}

        private void buttonExitLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            password = textBoxPassword.Text;
        }
    }
}
