using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix
{
     public class Location
    {
        private DateTime dateDebut;
        private DateTime dateFin;
        private Exemplaire exemplaire;
        private Client client;

        public Location(DateTime dateDebut, DateTime dateFin, Exemplaire exemplaire, Client client)
        {
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.exemplaire = exemplaire;
            this.client = client;
        }
        public DateTime getDateDebut() { return this.dateDebut; }
        public DateTime getDateFin() { return this.dateFin; }
        public Exemplaire getExemplaire() { return this.exemplaire; }
        public Client getClient() { return this.client; }

    }
}
