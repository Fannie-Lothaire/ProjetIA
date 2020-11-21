using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetTest
{
    // classe abstraite, il est donc impératif de créer une classe qui en hérite
    // pour résoudre un problème particulier en y ajoutant des infos liées au contexte du problème
    abstract public class GenericNode
    {
        public static double TpsTotal { get; set; }

        protected double GCost;               //coût du chemin du noeud initial jusqu'à ce noeud
        protected double HCost;               //estimation heuristique du coût pour atteindre le noeud final
        protected double TotalCost;           //coût total (g+h)
        protected GenericNode ParentNode;     // noeud parent
        protected List<GenericNode> Enfants;  // noeuds enfants
        //ajout de coordonnées pour les noeuds
        //problème il faut trouver comment les mettres à jour en fonction des points ?
        public double absisse { get; set; }
        public double ordonnee { get; set; }
        public GenericNode()
        {
            ParentNode = null;
            Enfants = new List<GenericNode>();
        }


        public double GetTpsTotal() { return TpsTotal; }
        public double GetGCost() { return GCost;}
        public void SetGCost(double g) { GCost = g;}
        public void SetTpsTotal(double g) { TpsTotal = g; }

        public double Cout_Total
        {
            get { return TotalCost; }
            set { TotalCost = value; }
        }

        public List<GenericNode> GetEnfants() {return Enfants; }
        public GenericNode GetNoeud_Parent(){return ParentNode;}
        public void SetNoeud_Parent(GenericNode g)
        {
            ParentNode = g;
            g.Enfants.Add(this);
        }

        public void Supprime_Liens_Parent()
        {
            if (ParentNode == null) return;
            ParentNode.Enfants.Remove(this);
            ParentNode = null;
        }

        //coût total =coût debut au noeud + coût estimation heuristique pour noeud final
        public void calculCoutTotal2()
        {
            HCost = CalculeHCost2();
            TotalCost = GCost + HCost;
        }
        public void calculCoutTotal(GenericNode Nf, double vitesse, double direction)
        {
            HCost = CalculeHCost(Nf,vitesse,direction);
            TotalCost = GCost + HCost;
        }
        //quelle va être la différence ?
        public void RecalculeCoutTotal(){ TotalCost = GCost + HCost;}

        // Méthodes abstrates, donc à surcharger obligatoirement avec override dans une classe fille
        public abstract bool IsEqual(GenericNode N2);
        public abstract double GetArcCost(GenericNode N2, double vitesse, double direction);
        public abstract bool EndState(GenericNode N2);
        public abstract List<GenericNode> GetListSucc();
        public abstract List<GenericNode> GetListMeilleursSucc(GenericNode Nf);
        public abstract double CalculeHCost2();
        public abstract double CalculeHCost(GenericNode Nf, double vitesse, double direction); //test d'un calcul heuristique
        // On peut aussi penser à surcharger ToString() pour afficher correctement un état
        // c'est utile pour l'affichage du treenode
    }
}
