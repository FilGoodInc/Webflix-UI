using NHibernate.Engine;
using System;
using System.Collections; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix
{
    internal class Client : Utilisateur
    {

        private List<Location> locations;
        public Client(string nom, string email, string noTelephone, DateTime dateDeNaissance, string motDePasse, List<Location> locations) : base(nom, email, noTelephone, dateDeNaissance, motDePasse)
        {
            this.locations = locations;
        }
        public List<Location> getLocations() { return this.locations; }
    }
}
