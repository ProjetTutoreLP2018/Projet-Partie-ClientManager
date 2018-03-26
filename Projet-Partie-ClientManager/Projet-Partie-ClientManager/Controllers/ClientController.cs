using Projet_Partie_ClientManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet_Partie_ClientManager.Controllers
{
    public class ClientController : Controller
    {
        ClientManager clientManager = new ClientManager();

        public bool AjouterClient(Client client)
        {
            return clientManager.AjouterClient(client);
        }

        public List<Client> ConsulterClients()
        {
            return clientManager.ConsulterClients();
        }

        public Client ModifierClient(Client client)
        {
            return clientManager.ModifierClient(client);
        }

        public bool SupprimerClient(Client client)
        {
            return clientManager.SupprimerClient(client);
        }

        public Client RechercherClient(String nom)
        {
            return clientManager.RechercherClient(nom);
        }
    }
}