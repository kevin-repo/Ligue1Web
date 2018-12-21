using System;

namespace Ligue1.Business.Entities
{
    /// <summary>
    /// Représente une compétition
    /// </summary>
    public class Competition
    {
        /// <summary>
        /// Identifiant de la compétition
        /// </summary>
        private string _id;

        /// <summary>
        /// Nom de la compétition
        /// </summary>
        private string _caption;

        /// <summary>
        /// Identifiant de la ligue
        /// </summary>
        private string _league;

        /// <summary>
        /// Année de la compétition
        /// </summary>
        private string _year;

        /// <summary>
        /// Journée de compétition
        /// </summary>
        private int _currentMatchday;

        /// <summary>
        /// Nombre total de journée de la compétition
        /// </summary>
        private int _numberOfMatchdays;

        /// <summary>
        /// Nombre d'équipes dans la compétition
        /// </summary>
        private int _numberOfTeams;

        /// <summary>
        /// Nombre total de matchs joués au terme de la compétition
        /// </summary>
        private int _numberOfGames;

        /// <summary>
        /// Date de dernière mise à jour
        /// </summary>
        private DateTime _lastUpdated;

        public string Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Caption
        {
            get
            {
                return _caption;
            }

            set
            {
                _caption = value;
            }
        }

        public string League
        {
            get
            {
                return _league;
            }

            set
            {
                _league = value;
            }
        }

        public string Year
        {
            get
            {
                return _year;
            }

            set
            {
                _year = value;
            }
        }

        public int CurrentMatchday
        {
            get
            {
                return _currentMatchday;
            }

            set
            {
                _currentMatchday = value;
            }
        }

        public int NumberOfMatchdays
        {
            get
            {
                return _numberOfMatchdays;
            }

            set
            {
                _numberOfMatchdays = value;
            }
        }

        public int NumberOfTeams
        {
            get
            {
                return _numberOfTeams;
            }

            set
            {
                _numberOfTeams = value;
            }
        }

        public int NumberOfGames
        {
            get
            {
                return _numberOfGames;
            }

            set
            {
                _numberOfGames = value;
            }
        }

        public DateTime LastUpdated
        {
            get
            {
                return _lastUpdated;
            }

            set
            {
                _lastUpdated = value;
            }
        }
    }
}