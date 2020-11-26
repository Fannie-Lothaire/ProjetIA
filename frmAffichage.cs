using ProjetTest;
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
    public partial class frmAffichage : Form
    {
        private int _x0 { get; set; }
        private int _y0 { get; set; }
        private int _xf { get; set; }
        private int _yf { get; set; }
        private double _speed { get; set; }
        private double _direction { get; set; }
        private double _speed2 { get; set; }
        private double _direction2 { get; set; }
        private double _yModifVent { get; set; }

        public frmAffichage(int x0, int y0, int xf, int yf, double speed, double direction)
        {
            //Initialisation des paramètres du formulaire d'affichage pour un parcours de type 1 rentrés par l'utilisateur
            InitializeComponent();
            _x0 = x0;
            _y0 = y0;
            _xf = xf;
            _yf = yf;
            _speed = speed;
            _direction = direction;
        }

        public frmAffichage(int x0, int y0, int xf, int yf, double speed, double direction, double speed2, double direction2,double y)
        {
            //Initialisation des paramètres du formulaire d'affichage pour un parcours de type 2 rentrés par l'utilisateur
            InitializeComponent();
            _x0 = x0;
            _y0 = y0;
            _xf = xf;
            _yf = yf;
            _speed = speed;
            _direction = direction;
            _speed2 = speed2;
            _direction2 = direction2;
            _yModifVent = y;
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        { 
            //Affichage des points initial et final sur la picturebox
            Pen pen = new Pen(Color.Red);
            Pen penvert = new Pen(Color.Green);
            Rectangle rect = new Rectangle(new Point(_x0, -(_y0 - pictureBox1.Height)), new Size(new Point(3, 3)));
            e.Graphics.DrawEllipse(pen, rect);
            Rectangle rectf = new Rectangle(new Point(_xf, -(_yf - pictureBox1.Height)), new Size(new Point(3, 3)));
            e.Graphics.DrawEllipse(penvert, rectf);
            start(e.Graphics);

        }

        private void start(Graphics g)
        {
            //Lancement du programme
            //Affectation des points rentrés par l'utilisateur
            Noeud startnode = new Noeud(_x0, _y0);
            lblInit.Text = "Point initial : (" + _x0 + "," + _y0 + ")"; 
            lblInit.Visible = true;
            Noeud endnode = new Noeud(_xf, _yf);
            lblFin.Text = "Point final : (" + _xf + "," + _yf + ")";
            lblFin.Visible = true;
            //Création d'un arbre de noeuds
            SearchTree st = new SearchTree();
            List<GenericNode> chemin = new List<GenericNode>();
            //Calcul de la solution A* en fonction du parcours choisi (s'il y a un ou plusieur types de vent)
            if (_yModifVent > 0)
            {
                chemin = st.RechercheSolutionAEtoile2(startnode, endnode, _speed, _direction,_speed2,_direction2,_yModifVent);
            }
            else
            {
                chemin = st.RechercheSolutionAEtoile(startnode, endnode, _speed, _direction);
            }
            
            TreeView t = new TreeView();
            //Affichage de l'arbre à noeuds
            pboxArbre.Controls.Add(t);
            st.GetSearchTree(t);
            Noeud n0 = startnode;
            double temps = 0;
            //Calcul du temps de trajet (idéal) et affichage des segments correspondants au trajet
            foreach (Noeud n in chemin)
            {
                temps = n.GetGCost();
                g.DrawLine(new Pen(Color.Pink), new Point((int)n0.absisse, -((int)n0.ordonnee - pictureBox1.Height)), new Point((int)n.absisse, -((int)n.ordonnee - pictureBox1.Height)));
                n0 = n;
            }
            txtboxNoeudf.Text = Convert.ToString(chemin.Count);
            txtboxNoeudfo.Text = Convert.ToString(t.GetNodeCount(true));
            int heures = (int)(temps * 60) / 60;
            double minutes = temps * 60 - heures * 60;
            txtboxTemps.Text = Convert.ToString(heures)+ "h "+ Convert.ToString(Math.Round(minutes))+"min";

        }
    }
}
