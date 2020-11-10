using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ProjetTest
{
    public class Noeud:GenericNode
    {
        public Noeud(double abs, double ord)
        {
            //test
            ParentNode = null;
            Enfants = new List<GenericNode>();
            absisse = abs;
            ordonnee = ord;
        }

        //surchargeant les fonctions GetArcCost, GetListSucc, EndState, IsEqual et éventuellement celle qui calcule l’heuristique
        //Pour GetArcCost, il faut simplement appeler time_estimation avec les bons paramètres.

        //calcul du temps estimé entre deux points
        // Cette fonction prend en paramètres 2 points
        //un point de départ P1(x1,y1) et un point d’arrivée P2(x2,y2)
        // il n’est donc pas possible d’appeler cette fonction pour des distances supérieures à 10 Km
        public double time_estimation(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (distance > 10) return 1000000;
            double windspeed = get_wind_speed((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double winddirection = get_wind_direction((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double boatspeed;
            double boatdirection = Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI; // On ramène entre 0 et 360
            if (boatdirection < 0) boatdirection = boatdirection + 360;
            // calcul de la différence angulaire
            double alpha = Math.Abs(boatdirection - winddirection);
            // On se ramène à une différence entre 0 et 180 :
            if (alpha > 180) alpha = 360 - alpha;
            if (alpha <= 45)
            {
                /* (0.6 + 0.3α / 45) v_v */
                boatspeed = (0.6 + 0.3 * alpha / 45) * windspeed;
            }
            else if (alpha <= 90)
            {
                /*v_b=(0.9-0.2(α-45)/45) v_v */
                boatspeed = (0.9 - 0.2 * (alpha - 45) / 45) * windspeed;
            }
            else if (alpha < 150)
            {
                /* v_b=0.7(1-(α-90)/60) v_v */
                boatspeed = 0.7 * (1 - (alpha - 90) / 60) * windspeed;
            }
            else
                return 1000000;
            // estimation du temps de navigation entre p1 et p2
            return (distance / boatspeed);
        }

        public char cas { get; set; } // à modifier en ‘b’ ou ‘c’ selon le choix de l’utilisateur
        public double get_wind_speed(double x, double y)
        {
            if (cas == 'a') return 50;
            else if (cas == 'b') if (y > 150)
                    return 50;
                else return 20;
            else if (y > 150) return 50; else return 20;
        }
        public double get_wind_direction(double x, double y)
        {
            if (cas == 'a') return 30;
            else if (cas == 'b') if (y > 150)
                    return 180;
                else return 90;
            else if (y > 150) return 170; else return 65;
        }



        //A chercher

        public override bool IsEqual(GenericNode N2)
        {
            if (this == N2)
            {
                return true;
            }
            else return false;
        }

        public override double GetArcCost(GenericNode N2)
        {
            
            return time_estimation(N2.absisse,N2.ordonnee,this.absisse,this.ordonnee);
        }
        public override bool EndState()
        {
            return true;
        }
        public override List<GenericNode> GetListSucc()
        {
            //quadrillage carré
            // les successeurs d’un points(x, y) peuvent être les 8 voisins
            //(x - 1, y -1), (x - 1, y), (x - 1, y + 1), (x, y - 1), (x, y + 1),
            //(x + 1, y - 1), (x + 1, y) et(x + 1, y + 1).
            double x = this.absisse;
            double y = this.ordonnee;
            Noeud voisin1 = new Noeud(x-1,y-1);
            Noeud voisin2 = new Noeud(x - 1, y);
            Noeud voisin3 = new Noeud(x - 1, y + 1);
            Noeud voisin4 = new Noeud(x , y - 1);
            Noeud voisin5 = new Noeud(x , y + 1);
            Noeud voisin6 = new Noeud(x + 1, y - 1);
            Noeud voisin7 = new Noeud(x + 1, y);
            Noeud voisin8 = new Noeud(x + 1, y + 1);
            List <GenericNode> ListeNoeud = new List<GenericNode>{voisin1,voisin2, voisin3,voisin4,voisin5,voisin6,voisin7,voisin8 };
           
        
            return ListeNoeud;
        }
        public override double CalculeHCost()
        {
            //calcul de l'heuristique
            return 2;
        }
        public override double CalculeHCost2(GenericNode Nf)
        {
            //calcul de l'heuristique
            //on sélectionne les meilleurs voisins du premier point en fonction des coordonnées du point final
            double HCostval = 0;
            string cote;
            string hauteur;
            List<GenericNode> MeilleursVoisins = new List<GenericNode>();
            GenericNode AutreVoisin; //pas utilisé au premier déplacement mais peut être utile par la suite
            List<GenericNode> ListeNoeud = GetListSucc();
            if (Nf.absisse > this.absisse) { cote = "droit"; }
            else { cote = "gauche"; }
            if (Nf.ordonnee > this.ordonnee) { hauteur = "haut"; }
            else { hauteur = "bas"; }
            if (cote == "droit" && hauteur == "haut")
            {
                //fleche droite haute et horizontale
                MeilleursVoisins.Add(ListeNoeud[6]);
                MeilleursVoisins.Add(ListeNoeud[7]);
                AutreVoisin = ListeNoeud[4];
            }
            else
            {
                if (cote == "droit" && hauteur == "bas")
                {
                    //fleche droite basse et horizontale
                    MeilleursVoisins.Add(ListeNoeud[6]);
                    MeilleursVoisins.Add(ListeNoeud[5]);
                    AutreVoisin = ListeNoeud[3];
                }
                else
                {
                    if (cote == "gauche" && hauteur == "haut")
                    {
                        //fleche gauche haute et horizontale
                        MeilleursVoisins.Add(ListeNoeud[1]);
                        MeilleursVoisins.Add(ListeNoeud[2]);
                        AutreVoisin = ListeNoeud[4];
                    }
                    else
                    {
                        //fleche gauche basse et horizontale
                        MeilleursVoisins.Add(ListeNoeud[1]);
                        MeilleursVoisins.Add(ListeNoeud[0]);
                        AutreVoisin = ListeNoeud[3];
                    }
                }
            }

            //testons si ca marche
            // verifier si la somme des vitesstes horizontale et verticale est supérieure ou non à la vitesse en diagonale 

            return HCostval;
        }

        public override string ToString()
        {
            return "a";
        }
        public int compare(Noeud n1, Noeud n2) //on compare les successeurs
        {
            if (this.GetArcCost(n1) < this.GetArcCost(n2))
                return -1;
            else if (this.GetArcCost(n1) > this.GetArcCost(n2))
                return 1;
            else return 0;
        }


    }
}
