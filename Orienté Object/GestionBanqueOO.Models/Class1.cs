namespace GestionBanqueOO.Models
{
    public class class1
    {
        public class Personne()
        {
            private string _Nom;

            public string Nom
            {
                get { return _Nom; }
                private set { _Nom = value; }
            }

            private string _Prenom;

            public string Prenom
            {
                get { return _Prenom; }
                private set { _Prenom = value; }
            }

            private DateTime _DateNaiss;

            public DateTime DateNaiss
            {
                get { return _DateNaiss; }
                private set { _DateNaiss = value; }
            }
        }

        public class Courant()
        {
            private Personne _Titulaire;
            public Personne Titulaire
            {
                get { return _Titulaire; }
                private set { _Titulaire = value; }
            }

            public string Numero { get; set; }

            private double _Solde;

            public double Solde
            {
                get { return _Solde; }
                private set { _Solde = value; }
            }

            private double _LigneDeCredit;

            public double LigneDeCredit
            {
                get { return _LigneDeCredit; }
                private set
                {
                    if (value < 0) { value = 0; }
                    _LigneDeCredit = value;
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
