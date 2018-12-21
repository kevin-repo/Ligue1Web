using System.Collections.Generic;

namespace Ligue1.Business.Entities
{
    /// <summary>
    /// Informations sur la ligue
    /// </summary>
    public class LeagueTable
    {
        /// <summary>
        /// Nom de la compétition
        /// </summary>
        private string _leagueCaption;

        /// <summary>
        /// Numéro de la journée
        /// </summary>
        private int _matchDay;

        /// <summary>
        /// Liste des équipes participantes à la compétition
        /// </summary>
        private List<Team> _teams;

        public string LeagueCaption
        {
            get
            {
                return _leagueCaption;
            }

            set
            {
                _leagueCaption = value;
            }
        }

        public int MatchDay
        {
            get
            {
                return _matchDay;
            }

            set
            {
                _matchDay = value;
            }
        }

        public List<Team> Teams
        {
            get
            {
                return _teams;
            }

            set
            {
                _teams = value;
            }
        }
    }
}