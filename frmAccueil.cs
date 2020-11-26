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
            //Bouton valide non visible pour éviter que l'utilisateur ne clique sans avoir rempli les champs
            InitializeComponent();
            btnValider.Visible = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //Vérification si on se trouve dans un parcours de type 1 : sans changement de vent
            if (rdbtnNon.Checked)
            {
                //Vérification que tous les champs des textboxs sont remplis
                if (txtboxAbsFin.Text != "" && txtboxAbsInit.Text != "" && txtboxDirection1.Text != "" && txtboxOrdInit.Text != "" && txtboxOrdFin.Text != "" && txtboxVitesse1.Text != "")
                {
                    int xo = Convert.ToInt32(txtboxAbsInit.Text);
                    int yo = Convert.ToInt32(txtboxOrdInit.Text);
                    int xf = Convert.ToInt32(txtboxAbsFin.Text);
                    int yf = Convert.ToInt32(txtboxOrdFin.Text);
                    int vitesse = Convert.ToInt32(txtboxVitesse1.Text);
                    int direction = Convert.ToInt32(txtboxDirection1.Text);
                    //Vérification que les coordonnées appartiennent bien au domaine défini
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
                //Cas d'un parcours de type 2 : le vent change à partir d'une certaine ordonnée
                //mêmes vérifications que pour le parcours de type 1
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

        //Changement de l'affichage en fonction du type de parcours
        private void rdbtnOui_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnOui.Checked == true) //le parcours est de type 2
            {
                //On affiche le choix de l'ordonnées et des deux types de vent
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
                //On affiche le choix du vent
                lblDirection1.Visible = true;
                lblVitesse1.Visible = true;
                txtboxDirection1.Visible = true;
                txtboxVitesse1.Visible = true;
                //On cache le choix de l'ordonnée et du deuxième vent
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
        {//Affichage du bouton lorsque des caractères sont entrés
            btnValider.Visible = true;
        }
    }
}
