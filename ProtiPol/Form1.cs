using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProtiPol
{
    public partial class Form1 : Form 
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        //výpočet protipólu
        private void button1_Click(object sender, EventArgs e) 
        {
            //změna textboxu na protipól-výpočet
            string cmb1;
            if (comboBox1.Text == "North" || comboBox1.Text == "North     ")
            {
                cmb1 = "South";

            }
            else
            {
                cmb1 = "North";
            }
            //změna checkboxu na opak
            string cmb2;
            if (comboBox2.Text == "East" || comboBox2.Text == "East      ")
            {
                cmb2 = "West";
            }
            else
            {
                cmb2 = "East";
            }
            try
            {
                //deklarace proměných
                int stupne;
                int minuty;
                int sekundy;
                //splitování
                var charArray = textBox3.Text.Split('*');
                //splitování
                var charArray1 = textBox1.Text.Split('*');
                //přiřazení
                stupne = Convert.ToInt32(charArray[0]);
                minuty = Convert.ToInt32(charArray[1]);
                sekundy = Convert.ToInt32(charArray[2]);
                //výpočet protiPoledníku
                sekundy = 60 - sekundy;
                minuty = 60 - minuty - 1;
                stupne = 180 - stupne - 1;
                //překonvertování naz5
                Convert.ToString(sekundy);
                Convert.ToString(minuty);
                Convert.ToString(stupne);
               //výpis
                textBox5.Text = stupne + "°" + minuty + "'" + sekundy + "''" + " " + cmb2;
                
                //výpis poledníku. Źůstává stejný mění se pouze north/south
                textBox4.Text = charArray1[0] + "°" + charArray1[1] + "'" + charArray1[2] + "''" + "" + cmb1;
            }
            catch (Exception)
            {
                string title = "Formát Error";
                MessageBox.Show("Musí být zapsáno ve formátu xxx°xx'xx''", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //con to sql
            SqlConnection con = new SqlConnection("Data Source=ASUS-KAREL\\KARLOSSQLSERVER;Initial Catalog=Protipol;Integrated Security=True");
            con.Open();
            string selected;
            selected = comboBox3.Text;
            //query na poledník
            SqlCommand cmd2 = new SqlCommand("SELECT Poledník from Protipol WHERE Mesto ='" + selected + "'",con);
            string str = Convert.ToString(cmd2.ExecuteScalar());
            comboBox1.Text = str;
            //query na rovník
            SqlCommand cmd = new SqlCommand("SELECT Rovník from Protipol WHERE Mesto ='" + selected + "'", con);
            string rovn = Convert.ToString(cmd.ExecuteScalar());
            comboBox2.Text = rovn;
            //query na Poledník data
            SqlCommand cmd1 = new SqlCommand("SELECT PoledníkData from Protipol WHERE Mesto ='" + selected + "'", con);
            string polednikD = Convert.ToString(cmd1.ExecuteScalar());
            textBox1.Text = polednikD;
            //query na rovník data
            SqlCommand cmd3 = new SqlCommand("SELECT RovníkData from Protipol WHERE Mesto ='" + selected + "'", con);
            string rovnikD = Convert.ToString(cmd3.ExecuteScalar());
            textBox3.Text = rovnikD;

        }

        //btn uložit
        //využívá metody ze třídy nazevMesta
        private void save_Click(object sender, EventArgs e)
        {
            NazevMesta nazev = new NazevMesta(textBox1.Text,  comboBox1.Text, comboBox2.Text, textBox3.Text);
            nazev.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            //načtení měst z databáze po spuštění
            try
            {
                SqlConnection con;
                string str;
                str = @"Data Source=ASUS-KAREL\KARLOSSQLSERVER;Initial Catalog=Protipol;Integrated Security=True";
                con = new SqlConnection(str);
                con.Open();
                string qry = "SELECT Mesto from Protipol";
                SqlDataReader dr = new SqlCommand(qry, con).ExecuteReader();
                while (dr.Read())
                {
                    comboBox3.Items.Add(dr.GetValue(0).ToString());
                }
            }
            catch (SqlException x)
            {

                MessageBox.Show(x.Message);
            }
        }
        //btn editace
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 kokos = new Form2();
            kokos.ShowDialog();
        }
    }
}
