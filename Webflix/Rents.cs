using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Webflix.Main;
using Webflix.Models;

namespace Webflix
{
    public partial class Rents : Form
    {
        public Rents()
        {
            InitializeComponent();
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            //Serialize all fields
            var province = CB_Province.Text;
            var age = CB_Age.Text;
            var day = CB_Day.Text;
            var month = CB_Month.Text;

            using (var db = new DbWebflix())
            {
                var rents = (from rent in db.ETL_LOCATION
                             join client in db.ETL_CLIENT on rent.IDUTILISATEUR equals client.IDUTILISATEUR
                             join temps in db.ETL_TEMPS on rent.IDTEMPS equals temps.IDTEMPS
                             join film in db.ETL_FILM on rent.IDFILM equals film.IDFILM
                             select new RentDTO(film.TITRE, client.PROVINCE, client.GROUPE_D_AGE, temps.JOUR_DE_LA_SEMAINE, temps.MOIS))
                                        .ToList();

                var filteredRents = rents.
                    Where(r =>
                        (province == "" || r.PROVINCE == province) &&
                        (age == "" || r.GROUPE_D_AGE == age) &&
                        (day == "" || r.JOUR_DE_LA_SEMAINE == day) &&
                        (month == "" || r.MOIS == month)
                    ).ToList();

                //Update DGV
                DGV_RentList.DataSource = filteredRents;
                TB_RentCount.Text = filteredRents.Count.ToString();
            }
        }

        private void DGV_RentList_SelectionChanged(object sender, EventArgs e)
        {
            DGV_RentList.ClearSelection();
        }
    }

    public class RentDTO
    {
        public string TITRE { get; set; }
        public string PROVINCE { get; set; }
        public string GROUPE_D_AGE { get; set; }
        public string JOUR_DE_LA_SEMAINE { get; set; }
        public string MOIS { get; set; }

        public RentDTO(string TITRE, string PROVINCE, string GROUPE_D_AGE, string JOUR_DE_LA_SEMAINE, string MOIS)
        {
            this.TITRE = TITRE;
            this.PROVINCE = PROVINCE;
            this.GROUPE_D_AGE = GROUPE_D_AGE;
            this.JOUR_DE_LA_SEMAINE = JOUR_DE_LA_SEMAINE;
            this.MOIS = MOIS;
        }
    }
}