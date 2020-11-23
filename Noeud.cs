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
        public double time_estimation(double x1, double y1, double x2, double y2, double vitesse, double direction)
        {
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (distance > 10) return 1000000;
            //double windspeed = get_wind_speed((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            //double winddirection = get_wind_direction((x1 + x2) / 2.0, (y1 + y2) / 2.0);

            double windspeed = get_wind_speed(vitesse);
            double winddirection = get_wind_direction(direction);

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

        //public char cas { get; set; } // à modifier en ‘b’ ou ‘c’ selon le choix de l’utilisateur

        //modification des paramètres et des fonctions pour pouvoir faire avec n'importe quel paramètre
        /*public double get_wind_speed(double x, double y)
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
        }*/

        public double get_wind_speed(double vitesse)
        {
            return vitesse;
        }
        public double get_wind_direction(double direction)
        {
            return direction;
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

        public override double GetArcCost(GenericNode N2, double vitesse, double direction)
        {
            return time_estimation(this.absisse,this.ordonnee,N2.absisse,N2.ordonnee,vitesse,direction);
        }
        public override bool EndState(GenericNode endnode)
        {
            if(this.absisse==endnode.absisse && this.ordonnee == endnode.ordonnee) { return true; }
            
            return false;
            /*Rectangle rect2 = new Rectangle(new Point((int)endnode.absisse, (int)endnode.ordonnee), new Size(new Point(3, 3)));
            //Rectangle rect2 = new Rectangle(new Point((int)endnode.absisse, (int)endnode.ordonnee), new Size(new Point(1, 1)));
            if (rect2.Contains(new Point((int)this.absisse, (int)this.ordonnee)))
            {
                return true;
            }
            return false;*/
        }

        public override List<GenericNode> GetListSucc()
        {
            //quadrillage carré
            // les successeurs d’un points(x, y) peuvent être les 8 voisins
            //(x - 1, y -1), (x - 1, y), (x - 1, y + 1), (x, y - 1), (x, y + 1),
            //(x + 1, y - 1), (x + 1, y) et(x + 1, y + 1).
            double x = this.absisse;
            double y = this.ordonnee;
            Noeud voisin1 = new Noeud(x-5,y-5);
            Noeud voisin2 = new Noeud(x -5, y);
            Noeud voisin3 = new Noeud(x - 5, y + 5);
            Noeud voisin4 = new Noeud(x , y - 5);
            Noeud voisin5 = new Noeud(x , y + 5);
            Noeud voisin6 = new Noeud(x + 5, y - 5);
            Noeud voisin7 = new Noeud(x + 5, y);
            Noeud voisin8 = new Noeud(x + 5, y + 5);
            Noeud voisin9 = new Noeud(x - 5, y - 10);
            Noeud voisin10 = new Noeud(x - 10, y - 5);
            Noeud voisin11 = new Noeud(x - 10, y + 5);
            Noeud voisin12 = new Noeud(x - 5, y + 10);
            Noeud voisin13 = new Noeud(x + 5, y + 10);
            Noeud voisin14 = new Noeud(x + 10, y + 5);
            Noeud voisin15 = new Noeud(x + 10, y - 5);
            Noeud voisin16 = new Noeud(x + 5, y - 10);
            //List <GenericNode> ListeNoeud = new List<GenericNode>{voisin1,voisin2, voisin3,voisin4,voisin5,voisin6,voisin7,voisin8};
            List<GenericNode> ListeNoeud = new List<GenericNode> { voisin1, voisin2, voisin3, voisin4, voisin5, voisin6, voisin7, voisin8, voisin9, voisin10, voisin11, voisin12, voisin13, voisin14, voisin15, voisin16 };
            //List<GenericNode> ListeNoeud = new List<GenericNode> { voisin9, voisin10, voisin11, voisin12, voisin13, voisin14, voisin15, voisin16 };


            return ListeNoeud;
        }
        public override double CalculeHCost2()
        {
            //calcul de l'heuristique
            return 0;
        }
        public override List<GenericNode> GetListMeilleursSucc(GenericNode Nf)
        {
            List<GenericNode> ListeNoeud = GetListSucc();
            List<GenericNode> MeilleursVoisins = new List<GenericNode>();
            if (Nf.absisse == this.absisse)
            {
                if (Nf.ordonnee > this.ordonnee)
                {
                    //fleche vers le haut
                    MeilleursVoisins.Add(ListeNoeud[4]);
                }
                else
                {
                    //fleche vers le bas
                    MeilleursVoisins.Add(ListeNoeud[3]);
                }

            }
            else
            {
                if (Nf.ordonnee == this.ordonnee)
                {
                    if (Nf.absisse > this.absisse)
                    {
                        //fleche vers la droite
                        MeilleursVoisins.Add(ListeNoeud[6]);
                    }
                    else
                    {
                        //fleche vers la gauche
                        MeilleursVoisins.Add(ListeNoeud[1]);
                    }

                }
                else
                {
                    if (Nf.absisse > this.absisse && Nf.ordonnee > this.ordonnee)
                    {
                        //fleche droite haute et horizontale et oblique
                        MeilleursVoisins.Add(ListeNoeud[6]);
                        MeilleursVoisins.Add(ListeNoeud[7]);
                        MeilleursVoisins.Add(ListeNoeud[4]);
                    }
                    else
                    {
                        if (Nf.absisse > this.absisse && Nf.ordonnee < this.ordonnee)
                        {
                            //fleche droite basse et horizontale et oblique
                            MeilleursVoisins.Add(ListeNoeud[6]);
                            MeilleursVoisins.Add(ListeNoeud[5]);
                            MeilleursVoisins.Add(ListeNoeud[3]);
                        }
                        else
                        {
                            if (Nf.absisse < this.absisse && Nf.ordonnee > this.ordonnee)
                            {
                                //fleche gauche haute et horizontale et oblique
                                MeilleursVoisins.Add(ListeNoeud[1]);
                                MeilleursVoisins.Add(ListeNoeud[2]);
                                MeilleursVoisins.Add(ListeNoeud[4]);
                            }
                            else
                            {
                                //fleche gauche basse et horizontale et oblique
                                MeilleursVoisins.Add(ListeNoeud[1]);
                                MeilleursVoisins.Add(ListeNoeud[0]);
                                MeilleursVoisins.Add(ListeNoeud[3]);
                            }
                        }
                    }
                }


            }
            return MeilleursVoisins;
        }
        /* public override double CalculeHCost2(GenericNode Nf)
         {
             //calcul de l'heuristique
             //le but est de retourner le temps minimal qu'il est possible d'avoir pour rejoindre le noeud final




             //on sélectionne les meilleurs voisins du noeud en fonction des coordonnées du point final
             double HCostval = 0;

             //calcul tous les trajets possibles tant qu'on arrive pas au noeud final Nf
             GenericNode noeudtest = this;
             List<double> temps_estime = new List<double>();
             List<GenericNode> MeilleursVoisins = noeudtest.GetListMeilleursSucc(Nf);
             int nbpremiervoisins = MeilleursVoisins.Count;
             double testime = 0;

             //avec endstate peut être

             while (EndState(noeudtest)==false && MeilleursVoisins!=null && nbpremiervoisins>0)
             {
                 //on calcule le temps en fonction de chaque direction que prend le bateau et en fonction du sens du vent
                 //correspond au testimation entre deux points avec 3 points possibles qui sont les meilleurs successeurs
                 //par contre il faut connaitre la vitesse du vent -> est ce qu'on arrive à y accéder ou est ce qu'on prend la plus faible/grande
                 //et aussi sa direction
                 //on regarde si l'association des directions horizontale et verticale est plus rapide que celle on diago
                 // on regarde quelle direction est la plus rapide et laquelle est la plus lente
                 testime = time_estimation(noeudtest.absisse, noeudtest.ordonnee, MeilleursVoisins[nbpremiervoisins].absisse, MeilleursVoisins[nbpremiervoisins].ordonnee);
                 noeudtest = MeilleursVoisins[nbpremiervoisins];



                 MeilleursVoisins.Remove(MeilleursVoisins[nbpremiervoisins]);
                 for (int i = 0; i < MeilleursVoisins.Count; i++)
                 {
                     //regarder si deux ou trois noeud on le même parent pour leur associer le bon temps estimé précédent
                     //affecter un indice aux meilleurs noeuds pour pouvoir les retrouver et affecter les bons temps 


                     //calcul du temps estimé entre deux noeuds et mise à jour du nouveau noeud à tester (problématique ici la boucle for, à changer)
                     temps_estime[i] += time_estimation(noeudtest.absisse, noeudtest.ordonnee, MeilleursVoisins[i].absisse, MeilleursVoisins[i].ordonnee);
                     noeudtest = MeilleursVoisins[i];
                 }
                 MeilleursVoisins = noeudtest.GetListMeilleursSucc(Nf);
             }

             //on renvoie une estimation du temps minimal pour arriver à la fin ? (pourquoi on prend pas le max, plus le max est petit mieux c'est et moins on prend de risques ??)
             return HCostval;
         }*/

        public override double CalculeHCost(GenericNode Nf,double vitesse, double direction)
        {
            double x1 = this.absisse; double y1 = this.ordonnee;double x2 = Nf.absisse;double y2 = Nf.ordonnee;
            ////heuristique ou on calcule l'heuristique du temps à vol d'oiseau entre le point étudier et le final
            ////on calcul la distance à vol d'oiseau 
            //double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

            ////on calcule la vitesse max du bateau

            ///* double boatdirection = Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI; // On ramène entre 0 et 360
            // if (boatdirection < 0) boatdirection = boatdirection + 360;
            // double alpha = Math.Abs(boatdirection - direction);

            // double boatspeed = (0.6 + 0.3 * alpha / 45) * vitesse;
            // double boatspeed2 = (0.9 - 0.2 * (alpha - 45) / 45) * vitesse;
            // double boatspeed3 = 0.7 * (1 - (alpha - 90) / 60) * vitesse;
            // double vitbateau = Math.Max(boatspeed, boatspeed2);
            // vitbateau = Math.Max(vitbateau, boatspeed3);*/

            //double vitbateau = 0.9 * 50;
            //// estimation du temps de navigation entre p1 et p2
            //double HCostval =distance / vitbateau;

            ////double HCostval = HCostval = this.time_estimation(this.absisse, this.ordonnee, Nf.absisse, Nf.ordonnee,vitesse,direction);
            //return HCostval;
            ////return 0;

            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            //double windspeed = get_wind_speed((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            //double winddirection = get_wind_direction((x1 + x2) / 2.0, (y1 + y2) / 2.0);

            double windspeed = get_wind_speed(vitesse);
            double winddirection = get_wind_direction(direction);

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
            return (distance / boatspeed) + distance + 100/boatspeed;
        }

        public override string ToString()
        {

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
