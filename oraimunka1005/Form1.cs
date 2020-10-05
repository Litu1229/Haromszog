using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oraimunka1005
{
    public partial class frmFo : Form
    {
        private int Aoldal;
        private int Boldal;
        private int Coldal;
        public frmFo()
        {
            Aoldal = 0;
            Boldal = 0;
            Coldal = 0;
            InitializeComponent();
            tbAoldal.Text = Aoldal.ToString();
            tbBoldal.Text = Boldal.ToString();
            tbColdal.Text = Coldal.ToString();
            lbHarmszogLista.Items.Clear();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            Aoldal = Convert.ToInt32(tbAoldal.Text);
            Boldal = Convert.ToInt32(tbBoldal.Text);
            Coldal = Convert.ToInt32(tbColdal.Text);
           
           
            if (Aoldal == 0 || Boldal == 0 || Coldal == 0)
            {
                MessageBox.Show("A háromszög oldala nem lehet 0", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var h = new Haromszog(Aoldal, Boldal, Coldal);
                
                List<string> adatok = h.AdatokSzoveg();
                foreach (var a in adatok)
                {
                    lbHarmszogLista.Items.Add(a);
                }
            }
        }

        private void tbAoldal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (lbHarmszogLista.Items.Count > 0)
            {
                lbHarmszogLista.Items.Clear();
            }
            else
            {
                MessageBox.Show("Nincs mit törölni.");
            }
            
        }
    }
}
