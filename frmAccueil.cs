using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetIAv0
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(txtboxAbsFin.Text!="" && txtboxAbsInit.Text!="" && txtboxDirection.Text!="" && txtboxOrdInit.Text!="" && txtboxOrdFin.Text!="" && txtboxVitesse.Text != "")
            {
                int xo = Convert.ToInt32(txtboxAbsInit.Text);
                int yo = Convert.ToInt32(txtboxOrdInit.Text);
                int xf = Convert.ToInt32(txtboxAbsFin.Text);
                int yf = Convert.ToInt32(txtboxOrdFin.Text);
                int vitesse = Convert.ToInt32(txtboxVitesse.Text);
                int direction = Convert.ToInt32(txtboxDirection.Text);

                frmAffichage newAffiche = new frmAffichage(xo, yo, xf, yf, vitesse, direction);
                newAffiche.Show();
                //Show(newAffiche);
            }  
        }
    }
}
