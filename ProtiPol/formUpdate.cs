using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtiPol
{
    public partial class formUpdate : Form
    {
        public formUpdate()
        {
            InitializeComponent();
        }

        public formUpdate(string mesto, string poledik, string rovnik, string polednikD, string rovnikD)
        {
            this.mesto = mesto;
            this.poledik = poledik;
            this.rovnik = rovnik;
            this.polednikD = polednikD;
            this.rovnikD = rovnikD;
        }

        private string polednikD;
        private string rovnikD;
        private string mesto;
        private string polednik;
        private string rovnik;
        private string poledik;
        //funkce na poslání do form2 aby při updatu se zobrazili data vybrané položky z datagridu
        public void prirazeniTextboxu(string mestoo, string poledikk, string rovnikk, string polednikDd, string rovnikDd)
        {
            textBox1.Text = mestoo;
            comboBox1.Text = poledikk;
            textBox3.Text = polednikDd;
            comboBox2.Text = rovnikk;
            textBox5.Text = rovnikDd;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string puvodniNazevM = textBox1.Text;
            SqlConnection con = new SqlConnection("Data Source=ASUS-KAREL\\KARLOSSQLSERVER;Initial Catalog=Protipol;Integrated Security=True");
            con.Open();
            SqlCommand cmd =new SqlCommand("UPDATE Protipol SET Mesto=@a1, Poledník=@a2, Rovník=@a3, PoledníkData=@a4, RovníkData=@a5 where Mesto='"+puvodniNazevM+"'", con);
            cmd.Parameters.Add("a1", textBox1.Text);
            cmd.Parameters.Add("a2", comboBox1.Text);
            cmd.Parameters.Add("a3", comboBox2.Text);
            cmd.Parameters.Add("a4", textBox3.Text);
            cmd.Parameters.Add("a5", textBox5.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Úspěšně uloženo :)");
            con.Close();
            //po ok na messagebox uzavře form
            this.Close();
        }
        //Mesto, Poledník, Rovník, PoledníkData, RovníkData
        //cancel btn zavře dialogové okno
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
