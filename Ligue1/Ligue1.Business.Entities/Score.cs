namespace Ligue1.Business.Entities
{
    /// <summary>
    /// Représente le score d'une rencontre
    /// </summary>
    public class Score
    {
        /// <summary>
        /// Nombre de buts marqués par l'équipe jouant à domicile
        /// </summary>
        private string _goalsHomeTeam;

        /// <summary>
        /// Nombre de buts marqués par l'équipe jouant à l'extérieur
        /// </summary>
        private string _goalsAwayTeam;

        /// <summary>
        /// Score à la mi-temps
        /// </summary>
        private HalfTime _halfTime;

        public string GoalsHomeTeam
        {
            get
            {
                return _goalsHomeTeam;
            }

            set
            {
                _goalsHomeTeam = value;
            }
        }

        public string GoalsAwayTeam
        {
            get
            {
                return _goalsAwayTeam;
            }

            set
            {
                _goalsAwayTeam = value;
            }
        }

        public HalfTime HalfTime
        {
            get
            {
                return _halfTime;
            }

            set
            {
                _halfTime = value;
            }
        }
    }
}