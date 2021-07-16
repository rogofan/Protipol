using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtiPol
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        TestEntites db;
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Opravdu chcete odstranit záznam(y)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                protipolBindingSource.RemoveCurrent();
                db.SaveChanges();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
      
            //načte po otevření okna data z SQL
            db = new TestEntites();
            protipolBindingSource.DataSource = db.Protipols.ToList();
            protipolBindingSource.DataSource = db.Protipols.Local;
        }
        //button update
        private void button2_Click(object sender, EventArgs e)
        {
            
            //deklarace proměných pro přiřazení aby se zobrazili ve formiuláři update
            string mesto, poledik, rovnik, polednikD, rovnikD;
            //přiřazení dat data gridu k proměným a ty jsou pak použýty jako argumenty ve funkci prirazeniTextboxu
            mesto = dataGridView1.SelectedCells[0].Value.ToString();
            poledik = dataGridView1.SelectedCells[1].Value.ToString();
            rovnik = dataGridView1.SelectedCells[2].Value.ToString();
            polednikD = dataGridView1.SelectedCells[3].Value.ToString();
            rovnikD = dataGridView1.SelectedCells[4].Value.ToString();
            

            formUpdate update2 = new formUpdate();
            update2.prirazeniTextboxu(mesto, poledik, rovnik, polednikD, rovnikD);
            update2.ShowDialog();
           
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
