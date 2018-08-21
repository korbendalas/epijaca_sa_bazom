using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace Projekat
{

    public partial class Form1 : Form
    {

        string name;
        string lastName;
        string address;
        string dobavljac;


        List<Tuple<String, String, double>> listaOdabranihProizvoda = new List<Tuple<String, String, double>>();// pakuje proizvod, br kg i njegovu cenu

        string trenutnaCenaZaRacun;
        List<string> listaPovrca = new List<string>{"Sargarepa", "Kupus","Celer","Persun",
            "Beli Luk","Crni Luk","Praziluk"};
        List<string> listaVoca = new List<string>{"Jagode", "Tresnje","Visnje","Jabuke",
            "Banane","Nar","Grejpfrut"};




        Dictionary<string, int> cenaPovrca = new Dictionary<string, int> { };
        Dictionary<string, int> cenaVoca = new Dictionary<string, int>();

        List<double> krajnjeCene = new List<double>(); //pakujem cena x kolicina 

        

        string selektovaniProizvod;
        string selektovanaVrsta;
        int Value; // cena kad selektuje combobox

        double brojKilograma;
        string brojKilogramaString;
        double trenutnaCena; // suma cena svih dodatih proizvoda

        static public int idRacuna = 0; // kad stisnem kreiraj racun, inkrementuje za 1 da bi svaki racun(txt file) imao svoj id


        static double mnozenje; //mnozi cena x kolicina



        bool imaProizvod = false;    // kada je false, moze da se doda tj upise novi proizvod u listu i ritchTextBox1

		//Uspostavljanje konekcije sa bazom
		SqlConnection con = new SqlConnection("Data Source=DESKTOP-4QM5BTL\\SQLEXPRESS;Initial Catalog=pijacadb;Integrated Security=True");// \\za escape

		public Form1()
        {
            InitializeComponent();

            //comboBoxBlank();


        }

        private void unesiteBrojLabel_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        //BUTTON SACUVAJ
        //Da izbacuje samo naziv filma, na koliko dana ga narucuje i koliko ga kosta 
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {


                //vrsi redom proveru da li su sva polja selektovana (combobox)
                if (!(string.IsNullOrEmpty(comboBoxVrstaProizvoda.Text)))
                {
                    imaProizvod = false;

                    if (!(string.IsNullOrEmpty(comboBox3.Text)))
                    {
                        imaProizvod = false;
                        if (!(string.IsNullOrEmpty(comboBox2.Text)))
                        {
                            imaProizvod = false;

                            //Upisivanje u Listu, a iz liste u richtextBox1

                            //proverava da li sam vec izabrao neki od proizvoda
                            for (int count = 0; count < listaOdabranihProizvoda.Count; count++)
                            {
                                string izabraniProizvodZaRacun = listaOdabranihProizvoda[count].Item1;

                                if (selektovaniProizvod == izabraniProizvodZaRacun)
                                {
                                    MessageBox.Show("Ovaj proizvod ste vec izabrali. ");
                                    imaProizvod = true;
                                    resetComboBoxa();
                                    richTextBox2.Clear();

                                    // break;
                                }
                                imaProizvod = false;
                                continue;

                            }

                            //upisuje odabrani proizvod tj dodaje u listu i ritchtextbox
                            if (imaProizvod == false)
                            {

                                selektovaniProizvod = comboBox3.SelectedItem.ToString(); // prihvata vrednost iz Comboboxa
                                brojKilogramaString = comboBox2.SelectedItem.ToString();//uzima brKg iz Comboboxa u STRINGU

                                brojKilograma = Convert.ToDouble(brojKilogramaString); // konvertuje iz stringa u double 
                                //izabraniValueDouble  = Convert.ToDouble(izabraniValue);//konvertuje iz stringa u double

                                StringBuilder stringBilder = new StringBuilder();
                                StringBuilder stringBilder3 = new StringBuilder();//richtextbox 3

                                listaOdabranihProizvoda.Add(new Tuple<String, String, double>(selektovaniProizvod, brojKilogramaString, Value));


                                for (int count = 0; count < listaOdabranihProizvoda.Count; count++)
                                {
                                    string izabraniProizvodZaRacun = listaOdabranihProizvoda[count].Item1;
                                    string brIzabranihKgZaRacun = listaOdabranihProizvoda[count].Item2;
                                    trenutnaCenaZaRacun = Convert.ToString(listaOdabranihProizvoda[count].Item3);


                                    stringBilder.Append(Convert.ToString(count + 1) + " .");// dodeljuje redni broj Proizvodu
                                    stringBilder.Append(izabraniProizvodZaRacun + "\n" + "Broj kilograma = " + brIzabranihKgZaRacun + "\n"
                                        + "Cena: " + trenutnaCenaZaRacun + " \n");
                                }

                                mnozenje = Value * brojKilograma;// vrsi mnozenje cene i br kilograma  


                                krajnjeCene.Add(mnozenje);//dodaje u listu 
                                richTextBox1.Clear();
                                richTextBox3.Clear();
                                stringBilder3.Append(trenutnaCena += mnozenje); // upisuje trenutnu ukupnu cenu u richtexbox3

                                richTextBox1.AppendText(stringBilder.ToString());
                                richTextBox2.Clear();

                                //resetuje comboBox kada sacuvam 
                                resetComboBoxa();

                                comboBox3.Enabled = false;

                                richTextBox3.AppendText(stringBilder3.ToString());
                            }


                        }
                        else { MessageBox.Show("Niste odabrali kolicinu!!!"); imaProizvod = true; }

                    }
                    else { MessageBox.Show("Niste odabrali proizvod!!!"); imaProizvod = true; }

                }
                else { MessageBox.Show("Niste odabrali vrstu proizvoda!!!"); imaProizvod = true; }



                //proverava da li je u comboBox2 izabrana vrednost 


            }
            catch
            {
                MessageBox.Show("Nedozvoljena radnja");
            }

        }

        //LOAD

        private void Form1_Load(object sender, EventArgs e)
        {



            comboBox3.Enabled = false;
            cenaPovrca.Add("Sargarepa", 30);
            cenaPovrca.Add("Kupus", 40);
            cenaPovrca.Add("Celer", 85);
            cenaPovrca.Add("Persun", 120);
            cenaPovrca.Add("Beli Luk", 400);
            cenaPovrca.Add("Crni Luk", 70);
            cenaPovrca.Add("Praziluk", 100);

            cenaVoca.Add("Jagode", 140);
            cenaVoca.Add("Tresnje", 100);
            cenaVoca.Add("Visnje", 80);
            cenaVoca.Add("Jabuke", 60);
            cenaVoca.Add("Banane", 170);
            cenaVoca.Add("Nar", 270);
            cenaVoca.Add("Grejpfrut", 159);

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Izbacuje ALertBox sa detaljima porudzbine

        //kada porucilac klikne ok, da kreira fajl na sistemu sa svim tim podacima. To ce na kraju se uradi

        //KREIRAJ RACUN 
        //IZBACUJE MessageBox i kreira txt fajl sa podacima sa racuna 


        private void buttonKreirajRacun_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBoxIme.Text)))
            {
                name = name.First().ToString().ToUpper() + name.Substring(1);// Pocetno slovo stavlja da je veliko
                if (!(string.IsNullOrEmpty(textBoxPrezime.Text)))
                {
                    lastName = lastName.First().ToString().ToUpper() + lastName.Substring(1);// Pocetno slovo stavlja da je veliko

                    if (!(string.IsNullOrEmpty(textBoxAdresa.Text)))
                    {
                        if (radioButtonBex.Checked || radioButtonPostExpress.Checked || radioButtonDhl.Checked || radioButtonAks.Checked) //vrsi proveru da li je odabran dostavljac
                        {
                            address = address.First().ToString().ToUpper() + address.Substring(1);// Pocetno slovo stavlja da je veliko

                            double ukupnaCena = trenutnaCena + 270;


                            idRacuna++;// da inkrementuje br racuna svaki pud kad se napravi nova porudzbina
                            StringBuilder stringBuilder = new StringBuilder();

                            for (int count = 0; count < listaOdabranihProizvoda.Count; count++)
                            {
                                string izabraniProizvodZaRacun = listaOdabranihProizvoda[count].Item1;
                                string brIzabranihKgZaRacun = listaOdabranihProizvoda[count].Item2;
                                trenutnaCenaZaRacun = Convert.ToString(listaOdabranihProizvoda[count].Item3);


                                stringBuilder.Append(Convert.ToString(count + 1) + " .");// dodeljuje redni broj Proizvodu
                                stringBuilder.Append(izabraniProizvodZaRacun + "\n" + "Broj kilograma = " + brIzabranihKgZaRacun + ".\n"
                                    + "Cena: " + trenutnaCenaZaRacun + " dinara po kilogramu. \n \n");
                            }






                            DialogResult dialog = MessageBox.Show("Postovani/a, " + name + " " + lastName + "\n Vase porucene stvari:\n \n" + stringBuilder.ToString()

                                    + " Cena bez dostave : " + trenutnaCena + " dinara. \n \n"
                                    + "Ukupno za uplatu : " + ukupnaCena + " dinara. (" +trenutnaCena + " + 270). \n \n"
                                    + "Stvari ce biti dostavljene na adresu : \n" + address + "\n" +
                                    " u toku dana.\n \n" +
                                   "Datum i vreme porudzbine: " + DateTime.Now + "\n \n" +
                                   "Kurirska sluzba za dostavu : " +dobavljac + " \n \n"+ // ovo 
                                        "        ***NAPOMENA***\n" +
                                        "       Placanje se vrsi pouzecem.\n" +
                                        " Cena dostave je 270 dinara."

                                    );


		//**********************************************DATABASE ******************************************************************************************************************************


		con.Open();
                        

							SqlDataAdapter SDA = new SqlDataAdapter("INSERT INTO racunTable(ime,prezime,adresa,dostavljac,artikli,cena,datum) VALUES('" + name + "','" + lastName + "', '" + address + "', '" + dobavljac + "','" + stringBuilder.ToString() + "', '" + ukupnaCena.ToString() + "','" + DateTime.Now.ToString() + "')",con);
							SDA.SelectCommand.ExecuteNonQuery();
							con.Close();
							
						//	MessageBox.Show( "USPESNO!");
							con.Close();
                           
//*****************************************************END DATABASE*********************************************************************


                        
                        }
                        else { MessageBox.Show("Niste odabrali dostavljaca!!!"); }
                    }
                    else { MessageBox.Show("Niste uneli adresu!!!"); }

                }
                else { MessageBox.Show("Niste uneli prezime!!"); }

            }
            else { MessageBox.Show("Niste uneli ime!!!"); }




        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //BIRAJ KG 
        //uzimmam vrednost koliko KG korisnik zeli. 
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }






        //DELETE 
        private void buttonDelete_Click(object sender, EventArgs e)
        {

            try
            {
                StringBuilder stringBilder = new StringBuilder();

                StringBuilder stringBilder4 = new StringBuilder();//richtextbox 3

                listaOdabranihProizvoda.Remove(listaOdabranihProizvoda.Last()); //brise poslednje dodat proizvod

                //vrsi UPDATE
                //ponovo ispisuje vrednosti 
                for (int count = 0; count < listaOdabranihProizvoda.Count; count++)
                {
                    string izabraniProizvodZaRacun = listaOdabranihProizvoda[count].Item1;
                    string brIzabranihKgZaRacun = listaOdabranihProizvoda[count].Item2;
                    trenutnaCenaZaRacun = Convert.ToString(listaOdabranihProizvoda[count].Item3);


                    stringBilder.Append(Convert.ToString(count + 1) + " .");// dodeljuje redni broj Proizvodu
                    stringBilder.Append(izabraniProizvodZaRacun + "\n" + "Broj kilograma = " + brIzabranihKgZaRacun + "\n"
                        + "Cena: " + trenutnaCenaZaRacun + " \n");
                }



                richTextBox1.Clear();

                richTextBox3.Clear();
                trenutnaCena = trenutnaCena - krajnjeCene.Last();// oduzima od ukuone trenutne cene poslednje obrisan proizvod
                krajnjeCene.Remove(krajnjeCene.Last()); // brise poslednji clan liste

                stringBilder4.Append(trenutnaCena);
                richTextBox1.AppendText(stringBilder.ToString());
                richTextBox3.AppendText(stringBilder4.ToString());

                //resetuje comboBox kada sacuvam 
                resetComboBoxa();



                //proverava da li ima u listiOdabranihProizvoda dodatih, ako nema, resetuje sve 
                if (listaOdabranihProizvoda.Count == 0)
                {

                    trenutnaCena = 0;
                    richTextBox3.Clear();
                    listaOdabranihProizvoda.Clear();
                    krajnjeCene.Clear();
                    trenutnaCena = 0;

                    resetComboBoxa(); // resetuje sve comboboxove
                    richTextBox1.Clear();
                    richTextBox3.Clear();
                    imaProizvod = false;

                }

            }
            catch
            {
                MessageBox.Show("Nedozvoljena radnja!!!");
            }


        }


        //OBRISI SVE 
        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {

            listaOdabranihProizvoda.Clear();
            krajnjeCene.Clear();
            trenutnaCena = 0;

            resetComboBoxa(); // resetuje sve comboboxove
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            imaProizvod = false;


        }


        //Izaberite vrstu proizvoda
        private void comboBoxVrstaProizvoda_SelectedIndexChanged(object sender, EventArgs e)
        {
            selektovanaVrsta = comboBoxVrstaProizvoda.SelectedItem.ToString();

            if (selektovanaVrsta == "Voce")
            {
                comboBox3.DataSource = listaVoca;//iz niza ubacuje vrednosti u combobox
                comboBox3.Enabled = true;

                //proba 
                comboBox3.ResetText();
                richTextBox2.Clear();
                //proba     

            }
            else
            {
                comboBox3.DataSource = listaPovrca;//iz niza ubacuje vrednosti u combobox
                comboBox3.Enabled = true;

            }

            comboBox3.ResetText();
            richTextBox2.Clear();




        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //da kad se selektuje Proizvod da izlista i cenu 

            //kad se selektuje povrce
            StringBuilder stringBilder2 = new StringBuilder();

            selektovaniProizvod = comboBox3.SelectedItem.ToString();// kada selektuje "izaberite proizvod' 


            if (selektovanaVrsta == "Povrce")
            {
                for (int count = 0; count < cenaPovrca.Count; count++)
                {
                    var element = cenaPovrca.ElementAt(count);
                    var Key = element.Key;
                    Value = element.Value;

                    if (selektovaniProizvod == Key)
                    {
                        stringBilder2.Append("  " + Value); // upisuje u richtextbox trenutnu cenu 
                        richTextBox2.Clear();


                        break;
                    }
                    else { continue; }

                }
            }
            // richTextBox2.AppendText(stringBilder2.ToString());
            //kad se selektuje voce
            if (selektovanaVrsta == "Voce")
            {
                selektovaniProizvod = comboBox3.SelectedItem.ToString();// kada selektuje "izaberite proizvod' 

                for (int count = 0; count < cenaVoca.Count; count++)
                {
                    var element = cenaVoca.ElementAt(count);
                    var Key = element.Key;
                    Value = element.Value;

                    if (selektovaniProizvod == Key)
                    {
                        stringBilder2.Append("  " + Value); // upisuje u richtextbox trenutnu cenu 
                        richTextBox2.Clear();


                        break;
                    }
                    else { continue; }

                }

            }

            richTextBox2.AppendText(stringBilder2.ToString());
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        //METODE
        private void resetComboBoxa() // resetuje sve ComboBox-ove
        {
            comboBoxVrstaProizvoda.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
        }

        private void labelNameChange_Click(object sender, EventArgs e)
        {

        }

        private void labelPrezimeChange_Click(object sender, EventArgs e)
        {

        }

        private void labelAdresaChange_Click(object sender, EventArgs e)
        {

        }
        //TEXTBOX IME
        private void textBoxIme_TextChanged(object sender, EventArgs e)
        {
            name = textBoxIme.Text;

        }
        //TEXTBOX PREZIME
        private void textBoxPrezime_TextChanged(object sender, EventArgs e)
        {
            lastName = textBoxPrezime.Text;
        }
        //TEXTBOX ADRESA
        private void textBoxAdresa_TextChanged(object sender, EventArgs e)
        {

            address = textBoxAdresa.Text;
        }

        private void radioButtonBex_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBex.Checked)
            {
                dobavljac = "Bex";
                MessageBox.Show("VAZNO!! \n Cena dostave je 270 dinara.");
            }
        }

        private void radioButtonPostExpress_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPostExpress.Checked)
            {
                dobavljac = "Post Express";
                MessageBox.Show("VAZNO!! \n Cena dostave je 270 dinara.");
            }
        }

        private void radioButtonDhl_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDhl.Checked)
            {
                dobavljac = "DHL";
                MessageBox.Show("VAZNO!! \n Cena dostave je 270 dinara.");
            }
        }

        private void radioButtonAks_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAks.Checked)
            {
                dobavljac = "Aks";
                MessageBox.Show("VAZNO!! \n Cena dostave je 270 dinara.");
            }
        }
        //dropdown Admin menu login 
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void izaberiteProizvod_Click(object sender, EventArgs e)
        {

        }
    }
}
 


