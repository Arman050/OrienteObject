using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orienté_Object.exercices
{
    internal class Banque
    {
        public class Personne
        {
            private string _nom;

            public string Nom
            {
                get { return _nom; }
                set { _nom = value; }
            }

            private string _prenom;

            public string Prenom
            {
                get { return _prenom; }
                set { _prenom = value; }
            }
            
            private DateTime _dateNaiss;

            public DateTime DateNaiss
            {
                get { return _dateNaiss; }
                set { _dateNaiss = value;}
            }
        }

        public class Courant
        {
            private Personne _titulaire;
            public Personne Titulaire 
            {
                get { return _titulaire; }
                private set { _titulaire = value;}
            }

            public string Numero { get; set; }

            private double _solde;

            public double Solde
            {
                get { return _solde; }
                private set { _solde = value; }
            }

            private double _ligneDeCredit;

            public double LigneDeCredit
            {
                get { return _ligneDeCredit; }
                private set
                {
                    if (value < 0) { value = 0; }
                    _ligneDeCredit = value;
                }
            }
            public void Retrait(double montant)
            {
                Solde = Solde - montant;
            }

            public void Depot(double montant)
            {
                Solde = Solde + montant;
            }

        }

    }   
}
