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
    public partial class administracija : Form
    {
        public administracija()
        {
            InitializeComponent();

            
        }

        private void administracija_Load(object sender, EventArgs e)
        {
			// TODO: This line of code loads data into the 'pijacadbDataSet1.racunTable' table. You can move, or remove it, as needed.
			this.racunTableTableAdapter.Fill(this.pijacadbDataSet1.racunTable);
	
			dataGridViewPorudzbine.Columns[0].Visible = false; // da ne prikaze id kolonu



        }

        private void dataGridViewPorudzbine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            racunTableTableAdapter.Update(pijacadbDataSet1.racunTable); //dodaje polja
        }

       

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            Application.Exit(); //zatvara app skroz  
        }

        private void dataGridViewPorudzbine_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Unesite validne podatke!!!!");
            e.Cancel = true;
        }

      
        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Da li zelite da obrisete porudzbinu?",
                            "Brisanje porudzbine", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                string idString = Convert.ToString(dataGridViewPorudzbine.SelectedRows[0].Cells[0].Value);
             //   MessageBox.Show(idString);
                int idInt = Convert.ToInt32(idString);
                racunTableTableAdapter.DeleteQuery(idInt);
                racunTableTableAdapter.Fill(pijacadbDataSet1.racunTable);
            }
        }
    }       
    }

