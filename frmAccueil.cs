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
            if (rdbtnOui.Checked == true)
            {
                lblYinf.Visible=true;
                txtboxYinf.Visible = true;
                lblDirection1.Visible = true;
                lblVitesse1.Visible = true;
                lblYsup.Visible = true;
                txtboxDirection1.Visible = true;
                txtboxVitesse1.Visible = true;
                txtboxYsup.Visible = true;
                lblDirection2.Visible = true;
                lblVitesse2.Visible = true;
                txtboxDirection2.Visible = true;
                txtboxVitesse2.Visible = true;
            }
            else
            {
                lblDirection1.Visible = true;
                lblVitesse1.Visible = true;
                txtboxDirection1.Visible = true;
                txtboxVitesse1.Visible = true;
            }
            if(txtboxAbsFin.Text!="" && txtboxAbsInit.Text!="" && txtboxDirection1.Text!="" && txtboxOrdInit.Text!="" && txtboxOrdFin.Text!="" && txtboxVitesse1.Text != "")
            {
                int xo = Convert.ToInt32(txtboxAbsInit.Text);
                int yo = Convert.ToInt32(txtboxOrdInit.Text);
                int xf = Convert.ToInt32(txtboxAbsFin.Text);
                int yf = Convert.ToInt32(txtboxOrdFin.Text);
                int vitesse = Convert.ToInt32(txtboxVitesse1.Text);
                int direction = Convert.ToInt32(txtboxDirection1.Text);

                frmAffichage newAffiche = new frmAffichage(xo, yo, xf, yf, vitesse, direction);
                newAffiche.Show();
                //Show(newAffiche);
            }  
        }
    }
}
