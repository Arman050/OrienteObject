
#region Niveau d'accessibilité

//public : L’accès n’est pas limité.

//protected : L’accès est restreint à la classe conteneur ou à ses types dérivés. (Héritage)

//internal : L’accès est restreint à l’assembly courant.

//protected internal : L’accès est restreint à l’assembly courant ou à aux types dérivées de la classe conteneur. (Héritage)
//private : L’accès est restreint au type conteneur (class ou struct).

//private protected : L’accès est restreint aux types dérivés de la classe conteneur uniquement dans le même assembly. (Héritage) 

#endregion

#region Niveau Par Défaut

//Membre de :             Niveau par défaut :              Niveaux autorisés :

//enum                    public                            /

//class                   private                           tout

//interface               public                            /

//struct                  pirvate                           public / internal / private 

#endregion

#region exercice Compte Bancaire
using Orienté_Object.exercices;


Console.WriteLine("Bienvenu(e) sur ArmBanking");

Console.WriteLine("Création d'un compte bancaire : ");

Console.WriteLine("");

Console.WriteLine("Nom : ");

Banque.Personne titulaire = new()
{
    Nom = Console.ReadLine()
};

Console.WriteLine("Prénom : ");

titulaire.Prenom = Console.ReadLine();

Console.WriteLine("Date de naissance : ");

titulaire.DateNaiss = new DateTime(Console.ReadLine());



#endregion