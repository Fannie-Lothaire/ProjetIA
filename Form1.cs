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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

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
            
            int x0 = 100;
            int y0 = 200;
            int xf = 200;
            int yf = 100;
            Noeud n0 = new Noeud(x0, y0);
           double t = n0.time_estimation(x0, y0, xf, yf);
           // t = 2;
            MessageBox.Show("Temps le plus cours pour aller du point ("+x0+","+y0+") au point ("+xf+","+yf+")"+ " est de : \n" + t.ToString());

        }


        private Boolean clicked_once = false;
        public void pictureBox1_Click(object sender, EventArgs e)
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
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        { // affichage d'une grille
            int ligneMax = 30;
            int colonneMax = 30;
            int tileHeight = 32; // code à adapter
            int tileWidth = 32;
            for (int ligne = 0; ligne != ligneMax; ligne++)
            {
                int lignePosition = ligne * tileHeight;
                e.Graphics.DrawLine(new Pen(Color.Black), 0, lignePosition, colonneMax * tileWidth, lignePosition);
            }
            for (int colonne = 0; colonne != colonneMax; colonne++)
            {
                int colonnePosition = colonne * tileWidth;
                e.Graphics.DrawLine(new Pen(Color.Black), colonnePosition, 0, colonnePosition, ligneMax * tileHeight);
            }

            //test affichage d'un segment du point de départ au point d’arrivée
            Pen pen = new Pen(Color.Pink); // d’autres couleurs sont disponibles
            e.Graphics.DrawLine(pen, new Point(100, 200), new Point(200, 100));
            //(x0,y0) = (100, 200) ; (xf,yf) = (200,100) et le vent est constant à 50km/h et souffle dans la direction 30° (vers le nord-est).
            // affichage d'une icône de bateau au point de départ et d’une icône d’ancre au point d’arrivée
            Rectangle rect = new Rectangle(new Point(100, 200), new Size(new Point(32, 32)));

            Image image1 = Image.FromFile("Bateau.Png");
            e.Graphics.DrawImage(image1, rect);
            Rectangle rect2 = new Rectangle(new Point(200, 100), new Size(new Point(32, 32)));
            Image image2 = Image.FromFile("Port.Png");
            e.Graphics.DrawImage(image2, rect2);
            start(e.Graphics);

        }
        private void start(Graphics g)
        {

            Noeud startnode = new Noeud(100, 200);

            Noeud endnode = new Noeud(130, 233);
            SearchTree st = new SearchTree();
            List<GenericNode> chemin = new List<GenericNode>();
            chemin = st.RechercheSolutionAEtoile(startnode, endnode);
            TreeView t = new TreeView();
            pictureBox1.Controls.Add(t);
            st.GetSearchTree(t);
            foreach (Noeud n in chemin)
            {
                g.DrawLine(new Pen(Color.Black), new Point((int)startnode.absisse, (int)startnode.ordonnee), new Point((int)n.absisse, (int)n.ordonnee));
            }

        }

    }
}
