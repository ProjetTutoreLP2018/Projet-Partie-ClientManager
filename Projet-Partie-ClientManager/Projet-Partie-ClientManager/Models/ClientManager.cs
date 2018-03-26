using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_Partie_ClientManager.Models
{
    public class ClientManager
    {

        /*
         * Méthode qui permet d'ajouter un 
         * nouveau client dans la base de données.
         * Cette méthode renvoie true si l'insertion
         * a été effectuer correctement sinon elle
         * renvoie false.
         * 
         * */
        public bool AjouterClient(Client client)
        {
            return false;
        }


        /*
         * Méthode qui permet de renvoyer la 
         * liste complète des client de la 
         * base de données
         * 
         * */
        public List<Client> ConsulterClients()
        {
            return null;
        }


        /*
         * Méhtode qui permet de faire la modification 
         * du client.
         * Le client modifié sera renvoyé 
         * */
        public Client ModifierClient(Client client)
        {
            return null;
        }


        /*
         * Méthode qui permet de supprimer un client
         * de la base de données. 
         * Cette méthode renvoie un booléen pour
         * attester de la bonne réussite de la 
         * suppressions
         * */
        public bool SupprimerClient(Client client)
        {
            return false;
        }
        

        /*
         * Méthode qui permet de chercher un client dans la 
         * base de données et de le retourner
         * */
        public Client RechercherClient(String nom)
        {
            return null;
        }
    }
}