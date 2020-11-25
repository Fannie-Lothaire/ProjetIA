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
            btnValider.Visible = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (rdbtnNon.Checked)
            {
                if (txtboxAbsFin.Text != "" && txtboxAbsInit.Text != "" && txtboxDirection1.Text != "" && txtboxOrdInit.Text != "" && txtboxOrdFin.Text != "" && txtboxVitesse1.Text != "")
                {
                    int xo = Convert.ToInt32(txtboxAbsInit.Text);
                    int yo = Convert.ToInt32(txtboxOrdInit.Text);
                    int xf = Convert.ToInt32(txtboxAbsFin.Text);
                    int yf = Convert.ToInt32(txtboxOrdFin.Text);
                    int vitesse = Convert.ToInt32(txtboxVitesse1.Text);
                    int direction = Convert.ToInt32(txtboxDirection1.Text);

                    if (xo > 300 || xo < -300 || yo > 300 || yo < -300 || xf > 300 || xf < -300 || yf > 300 || yf < -300)
                    {
                        MessageBox.Show("Les coordonnées doivent être comprises entre -300 et 300 ");
                    }
                    else
                    {
                        //Formulaire d'affichage pour un parcours de type 1
                        frmAffichage newAffiche = new frmAffichage(xo, yo, xf, yf, vitesse, direction);
                        newAffiche.Show();
                    }
                }
                if (txtboxVitesse1.Text == "" || txtboxDirection1.Text == "")
                {
                    MessageBox.Show("Tous les champs doivent être saisis");
                }
            }
            else
            {
                if (txtboxAbsFin.Text != "" && txtboxAbsInit.Text != "" && txtboxDirection1.Text != "" && txtboxOrdInit.Text != "" && txtboxOrdFin.Text != "" && txtboxVitesse1.Text != "" && txtboxVitesse2.Text != "" && txtboxDirection1.Text != "" && txtboxY.Text!="")
                {
                    int xo = Convert.ToInt32(txtboxAbsInit.Text);
                    int yo = Convert.ToInt32(txtboxOrdInit.Text);
                    int xf = Convert.ToInt32(txtboxAbsFin.Text);
                    int yf = Convert.ToInt32(txtboxOrdFin.Text);
                    int vitesse = Convert.ToInt32(txtboxVitesse1.Text);
                    int direction = Convert.ToInt32(txtboxDirection1.Text);
                    int vitesse2 = Convert.ToInt32(txtboxVitesse2.Text);
                    int direction2 = Convert.ToInt32(txtboxDirection2.Text);
                    int y= Convert.ToInt32(txtboxY.Text);

                    if (xo > 300 || xo < -300 || yo > 300 || yo < -300 || xf > 300 || xf < -300 || yf > 300 || yf < -300)
                    {
                        MessageBox.Show("Les coordonnées doivent être comprises entre -300 et 300 ");
                    }
                    else
                    {
                        //Formulaire d'affichage pour un parcours de type 2
                        frmAffichage newAffiche = new frmAffichage(xo, yo, xf, yf, vitesse, direction, vitesse2, direction2, y);
                        newAffiche.Show();
                    }
                }
                if (txtboxVitesse1.Text == "" || txtboxDirection1.Text == "" || txtboxVitesse2.Text == "" || txtboxDirection2.Text == "" || txtboxY.Text == "")
                {
                    MessageBox.Show("Tous les champs doivent être saisis");
                }
            }
            }

        //Changement de l'affichage en fonction de l'influence présente ou non de l'ordonnée du noeud
        private void rdbtnOui_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnOui.Checked == true) //le parcours est de type 2
            {
                lblYinf.Visible = true;
                txtboxY.Visible = true;
                lblDirection1.Visible = true;
                lblVitesse1.Visible = true;
                txtboxDirection1.Visible = true;
                txtboxVitesse1.Visible = true;
                lblYsup.Visible = true;
                lblValY.Visible = true;
                lblDirection2.Visible = true;
                lblVitesse2.Visible = true;
                txtboxDirection2.Visible = true;
                txtboxVitesse2.Visible = true;
            }
        }

        private void rdbtnNon_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnNon.Checked == true) //le parcours est de type 1
            {
                lblDirection1.Visible = true;
                lblVitesse1.Visible = true;
                txtboxDirection1.Visible = true;
                txtboxVitesse1.Visible = true;

                lblValY.Visible = false;
                lblYinf.Visible = false;
                txtboxY.Visible = false;
                lblYsup.Visible = false;
                txtboxY.Visible = false;
                lblDirection2.Visible = false;
                lblVitesse2.Visible = false;
                txtboxDirection2.Visible = false;
                txtboxVitesse2.Visible = false;
            }
        }

        private void txtboxAbsInit_TextChanged(object sender, EventArgs e)
        {
            btnValider.Visible = true;
        }
    }
}
