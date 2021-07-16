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

namespace ProtiPol
{
    public partial class NazevMesta : Form
    {


        

        string polednikData, polednikSmer, Rovnik, rovnikSmer;
        public NazevMesta(string polednikDat, string polednik, string rovnikDat, string rovnikData)
        {
            InitializeComponent();
            //polednik data
            polednikData = polednikDat;
            //polednik
            polednikSmer = polednik;
            //rovnik
            Rovnik = rovnikDat;
            //rovnik data
            rovnikSmer = rovnikData;
            

        }
        //ok button uloží celý záznam do Databáze
        private void button1_Click(object sender, EventArgs e)
        {            
            SqlConnection con = new SqlConnection("Data Source=ASUS-KAREL\\KARLOSSQLSERVER;Initial Catalog=Protipol;Integrated Security=True");
            con.Open();
            //
            if (textBox1.Text == (""))
            {
                con.Close();
                MessageBox.Show("Není vložen název města");
                this.Close();
            }
            //zápis dat
            SqlCommand cmd = new SqlCommand("INSERT INTO Protipol values ('" + textBox1.Text + "', '" + polednikSmer + "', '" + Rovnik + "', '" + polednikData + "', '" + rovnikSmer + "')", con);
            //kontorla uložení
            if (textBox1.Text != (""))
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Úspěšně uloženo");
                con.Close();
                this.Close();
                
            }

            

        }

            
    }

       
}

