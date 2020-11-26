using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ProjetTest
{
    public class Noeud:GenericNode
    {
        public Noeud(double abs, double ord)
        {
            ParentNode = null;
            Enfants = new List<GenericNode>();
            absisse = abs;
            ordonnee = ord;
        }

        //calcul du temps estimé entre deux points
        // Cette fonction prend en paramètres 2 points
        //un point de départ P1(x1,y1) et un point d’arrivée P2(x2,y2)
        // il n’est donc pas possible d’appeler cette fonction pour des distances supérieures à 10 Km
        public double time_estimation(double x1, double y1, double x2, double y2, double vitesse, double direction)
        {
            //modification de la fonction initiale en ajoutant les valeurs de vitesse et direction du vent entrées^par l'utilisateur
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (distance > 10) return 1000000;

            double boatspeed;
            double boatdirection = Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI; // On ramène entre 0 et 360
            if (boatdirection < 0) boatdirection = boatdirection + 360;
            // calcul de la différence angulaire
            double alpha = Math.Abs(boatdirection - direction);
            // On se ramène à une différence entre 0 et 180 :
            if (alpha > 180) alpha = 360 - alpha;
            if (alpha <= 45) { boatspeed = (0.6 + 0.3 * alpha / 45) * vitesse;}
            else if (alpha <= 90) {boatspeed = (0.9 - 0.2 * (alpha - 45) / 45) * vitesse;}
            else if (alpha < 150){ boatspeed = 0.7 * (1 - (alpha - 90) / 60) * vitesse;}
            else
                return 1000000;
            // estimation du temps de navigation entre p1 et p2
            return (distance / boatspeed);
        }

        //A chercher

        public override bool IsEqual(GenericNode N2)
        {
            //recherche si deux noeuds sont égaux
            if (this.absisse == N2.absisse && this.ordonnee==N2.ordonnee) {  return true;}
            else return false;
        }

        public override double GetArcCost(GenericNode N2, double vitesse, double direction)
        {
            //renvoie la valeur du temps estimé
            return time_estimation(this.absisse,this.ordonnee,N2.absisse,N2.ordonnee,vitesse,direction);
        }
        public override bool EndState(GenericNode endnode)
        {
            //Cherche si le noeud possède les mêmes coordonnées que le noeud final
           if(this.absisse==endnode.absisse && this.ordonnee == endnode.ordonnee) { return true; }
            return false;
        }
        public override List<GenericNode> GetListMeilleursSucc(GenericNode Nf)
        {
            //quadrillage carré
            // les successeurs d’un points(x, y) peuvent être les 8 voisins
            //(x - 1, y -1), (x - 1, y), (x - 1, y + 1), (x, y - 1), (x, y + 1),
            //(x + 1, y - 1), (x + 1, y) et(x + 1, y + 1).
            //plus les 8 autres voisins 
            //(x - 1, y -2), (x - 2, y-1), (x - 2, y + 1), (x-2, y + 2), (x+1, y + 2),
            //(x + 2, y + 1), (x + 2, y - 1) et(x + 1, y - 2).
            double x = this.absisse;
            double y = this.ordonnee;
            Noeud voisin1 = new Noeud(x - 1, y - 1);
            Noeud voisin2 = new Noeud(x - 1, y);
            Noeud voisin3 = new Noeud(x - 1, y + 1);
            Noeud voisin4 = new Noeud(x, y - 1);
            Noeud voisin5 = new Noeud(x, y + 1);
            Noeud voisin6 = new Noeud(x + 1, y - 1);
            Noeud voisin7 = new Noeud(x + 1, y);
            Noeud voisin8 = new Noeud(x + 1, y + 1);
            Noeud voisin9 = new Noeud(x - 1, y - 2);
            Noeud voisin10 = new Noeud(x - 2, y - 1);
            Noeud voisin11 = new Noeud(x - 2, y + 1);
            Noeud voisin12 = new Noeud(x - 2, y + 2);
            Noeud voisin13 = new Noeud(x + 1, y + 2);
            Noeud voisin14 = new Noeud(x + 2, y + 1);
            Noeud voisin15 = new Noeud(x + 2, y - 1);
            Noeud voisin16 = new Noeud(x + 1, y - 2);

            //Néanmoins on utilisera cette fonction pour éviter de regarder tous les points possibles
            //au lieu d'évaluer 16 successeurs on en évaluera que 5

            List<GenericNode> MeilleursVoisins = new List<GenericNode>();
            if (Nf.absisse == this.absisse)
            {
                if (Nf.ordonnee > this.ordonnee)
                {
                    //fleche vers le haut
                    MeilleursVoisins.Add(voisin5);
                }
                else
                {
                    //fleche vers le bas
                    MeilleursVoisins.Add(voisin4);
                }

            }
            else
            {
                if (Nf.ordonnee == this.ordonnee)
                {
                    if (Nf.absisse > this.absisse)
                    {
                        //fleche vers la droite
                        MeilleursVoisins.Add(voisin7);
                    }
                    else
                    {
                        //fleche vers la gauche
                        MeilleursVoisins.Add(voisin2);
                    }

                }
                else
                {
                    if (Nf.absisse > this.absisse && Nf.ordonnee > this.ordonnee)
                    {
                        //fleche droite haute et horizontale et oblique
                        MeilleursVoisins.Add(voisin7);
                        MeilleursVoisins.Add(voisin8);
                        MeilleursVoisins.Add(voisin5);
                        //nouveaux voisins vers la droite haute
                        MeilleursVoisins.Add(voisin15);
                        MeilleursVoisins.Add(voisin14);
                    }
                    else
                    {
                        if (Nf.absisse > this.absisse && Nf.ordonnee < this.ordonnee)
                        {
                            //fleche droite basse et horizontale et oblique
                            MeilleursVoisins.Add(voisin7);
                            MeilleursVoisins.Add(voisin6);
                            MeilleursVoisins.Add(voisin4);
                            //nouveaux voisins vers la droite haute
                            MeilleursVoisins.Add(voisin15);
                            MeilleursVoisins.Add(voisin16);
                        }
                        else
                        {
                            if (Nf.absisse < this.absisse && Nf.ordonnee > this.ordonnee)
                            {
                                //fleche gauche haute et horizontale et oblique
                                MeilleursVoisins.Add(voisin2);
                                MeilleursVoisins.Add(voisin3);
                                MeilleursVoisins.Add(voisin5);
                                //nouveaux voisins vers la gauche haute
                                MeilleursVoisins.Add(voisin11);
                                MeilleursVoisins.Add(voisin12);
                            }
                            else
                            {
                                //fleche gauche basse et horizontale et oblique
                                MeilleursVoisins.Add(voisin2);
                                MeilleursVoisins.Add(voisin1);
                                MeilleursVoisins.Add(voisin4);
                                //nouveaux voisins vers la gauche basse
                                MeilleursVoisins.Add(voisin10);
                                MeilleursVoisins.Add(voisin11);
                            }
                        }
                    }
                }


            }
            return MeilleursVoisins;
        }

        public override double CalculeHCost(GenericNode Nf,double vitesse, double direction, GenericNode Nprecedent)
        {
            ////heuristique ou on calcule l'heuristique du temps à vol d'oiseau entre le point étudier et le final
            ////on calcule la distance à vol d'oiseau
            double x1 = this.absisse; double y1 = this.ordonnee;double x2 = Nf.absisse;double y2 = Nf.ordonnee;
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            //on calcule la vitesse max du bateau en fonction de la vitesse du vent
            double boatspeed=0.9*vitesse;
            return distance / boatspeed;
        }

        public override string ToString()
        {
            //affichage des coordonnées pour l'arbre des noeuds
            string coord = ("(" + this.absisse + "," + this.ordonnee + ")");
            return coord;
        }
        public int compare(Noeud n1, Noeud n2,double vitesse,double direction) //on compare les successeurs
        {
            if (this.GetArcCost(n1,vitesse,direction) < this.GetArcCost(n2,vitesse,direction))
                return -1;
            else if (this.GetArcCost(n1,vitesse,direction) > this.GetArcCost(n2,vitesse,direction))
                return 1;
            else return 0;
        }


    }
}
