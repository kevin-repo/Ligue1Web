using Newtonsoft.Json;
using System;

namespace Ligue1.Business.Entities
{
    /// <summary>
    /// Représente une rencontre de championnat
    /// </summary>
    public class Fixture
    {
        /// <summary>
        /// Nom de l'équipe jouant à domicile
        /// </summary>
        private string _homeTeamName;

        /// <summary>
        /// Identifiant de l'équipe jouant à l'extérieur
        /// </summary>
        private string _awayTeamName;

        /// <summary>
        /// Date de la rencontre
        /// </summary>
        private DateTime _date;

        /// <summary>
        /// Numéro de la journée de championnat
        /// </summary>
        private int _matchday;

        /// <summary>
        /// Résultat de la rencontre
        /// </summary>
        private Score _result;

        public string HomeTeamName
        {
            get
            {
                return _homeTeamName;
            }

            set
            {
                _homeTeamName = value;
            }
        }

        public string AwayTeamName
        {
            get
            {
                return _awayTeamName;
            }

            set
            {
                _awayTeamName = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }

            set
            {
                _date = value;
            }
        }

        [JsonProperty(PropertyName = "result")]
        public Score Score
        {
            get
            {
                return _result;
            }

            set
            {
                _result = value;
            }
        }

        public int Matchday
        {
            get
            {
                return _matchday;
            }

            set
            {
                _matchday = value;
            }
        }

    }
}