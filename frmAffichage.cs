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
            InitializeComponent();
            _x0 = x0;
            _y0 = y0;
            _xf = xf;
            _yf = yf;
            _speed = speed;
            _direction = direction;
/*
            //Ensuite, pour afficher un segment, vous pouvez appeler le code suivant:
            // soient x1, y1, x2, y2 des double utilisés pour définir les 2 extrémités d’un segment.
            int x1 = 50;
            int x2 = 30;
            int y1 = 50;
            int y2 = 30;

            //pictureBox1
            Pen penwhite = new Pen(Color.Pink); // d’autres couleurs sont disponibles
            Graphics g = this.CreateGraphics();
            g.DrawLine(penwhite, new Point((int)x1, this.Height - (int)y1), new Point((int)x2, this.Height - (int)y2));
            
            Noeud n0 = new Noeud(x0, y0);
           double t = n0.time_estimation(x0, y0, xf, yf,speed,direction);
           // t = 2;
            MessageBox.Show("Temps le plus petit pour aller du point ("+x0+","+y0+") au point ("+xf+","+yf+")"+ " est de : \n" + t.ToString());
            */
        }

        public frmAffichage(int x0, int y0, int xf, int yf, double speed, double direction, double speed2, double direction2,double y)
        {
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

        //private Boolean clicked_once = false;
        /* public void pictureBox1_Click(object sender, EventArgs e)
         { // permet de récupérer le point d'où veut partir l'utilisateur et le point où il veut arriver
             this.Cursor = new Cursor(Cursor.Current.Handle);
             if (clicked_once == false)
             {
                 clicked_once = true;
                 int x0 = Cursor.Position.X;
                 int y0 = Cursor.Position.Y;

             }
             else
             {
                 clicked_once = false;
                 int x1 = Cursor.Position.X;
                 int y1 = Cursor.Position.Y;
             }
         }*/

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        { // affichage d'une grille
          /* int ligneMax = 30;
           int colonneMax = 30;
           int tileHeight = 15; // code à adapter
           int tileWidth = 15;
           for (int ligne = 0; ligne != ligneMax; ligne++)
           {
               int lignePosition = ligne * tileHeight;
               e.Graphics.DrawLine(new Pen(Color.Black), 0, lignePosition, colonneMax * tileWidth, lignePosition);
           }
           for (int colonne = 0; colonne != colonneMax; colonne++)
           {
               int colonnePosition = colonne * tileWidth;
               e.Graphics.DrawLine(new Pen(Color.Black), colonnePosition, 0, colonnePosition, ligneMax * tileHeight);
           }*/

            //test affichage d'un segment du point de départ au point d’arrivée
            // Pen pen = new Pen(Color.Pink); // d’autres couleurs sont disponibles
            // e.Graphics.DrawLine(pen, new Point(_x0, _y0), new Point(_xf, _yf));
            //(x0,y0) = (100, 200) ; (xf,yf) = (200,100) et le vent est constant à 50km/h et souffle dans la direction 30° (vers le nord-est).
            // affichage d'une icône de bateau au point de départ et d’une icône d’ancre au point d’arrivée
            // Rectangle rect = new Rectangle(new Point(_x0, _y0), new Size(new Point(32, 32)));

            //Affichage du bâteau et ancre
            //Rectangle rect = new Rectangle(new Point(_x0, _y0), new Size(new Point(32, 32)));
            /* Rectangle rect = new Rectangle(new Point(_x0, _y0), new Size(new Point(10, 10)));
             Image image1 = Image.FromFile("Bateau.Png");
             e.Graphics.DrawImage(image1, rect);
             //Rectangle rect2 = new Rectangle(new Point(_xf, _yf), new Size(new Point(32, 32)));
             Rectangle rect2 = new Rectangle(new Point(_xf, _yf), new Size(new Point(10, 10)));
             Image image2 = Image.FromFile("Port.Png");
             e.Graphics.DrawImage(image2, rect2);*/

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

            Noeud startnode = new Noeud(_x0, _y0);
            lblInit.Text = "Point initial : (" + _x0 + "," + _y0 + ")";
            lblInit.Visible = true;
            //le programme s'arrête que avec ca pour l'instant
            // Noeud endnode = new Noeud(130, 233);
            Noeud endnode = new Noeud(_xf, _yf);
            lblFin.Text = "Point final : (" + _xf + "," + _yf + ")";
            lblFin.Visible = true;
            SearchTree st = new SearchTree();
            List<GenericNode> chemin = new List<GenericNode>();
            if (_yModifVent > 0)
            {
                chemin = st.RechercheSolutionAEtoile2(startnode, endnode, _speed, _direction,_speed2,_direction2,_yModifVent);
            }
            else
            {
                chemin = st.RechercheSolutionAEtoile(startnode, endnode, _speed, _direction);
            }
            
            TreeView t = new TreeView();
            pboxArbre.Controls.Add(t);
            st.GetSearchTree(t);
            Noeud n0 = startnode;

            double temps = 0;
            foreach (Noeud n in chemin)
            {
                temps = n.GetGCost();
                g.DrawLine(new Pen(Color.Pink), new Point((int)n0.absisse, -((int)n0.ordonnee - pictureBox1.Height)), new Point((int)n.absisse, -((int)n.ordonnee - pictureBox1.Height)));
                n0 = n;
            }
            txtboxNoeud.Text = Convert.ToString(chemin.Count);
            int heures = (int)(temps * 60) / 60;
            double minutes = temps * 60 - heures * 60;
            txtboxTemps.Text = Convert.ToString(heures)+ "h "+ Convert.ToString(Math.Round(minutes))+"min";
            //MessageBox.Show("Temps le plus petit pour aller du point (" + _x0 + "," + _y0 + ") au point (" + _xf + "," + _yf + ")" + " est de : \n" + temps.ToString());

        }
    }
}
