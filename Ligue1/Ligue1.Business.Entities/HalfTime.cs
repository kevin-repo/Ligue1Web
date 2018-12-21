namespace Ligue1.Business.Entities
{
    /// <summary>
    /// Représente le score d'une rencontre à la mi-temps
    /// </summary>
    public class HalfTime
    {
        /// <summary>
        /// Nombre de buts marqués par l'équipe jouant à domicile
        /// </summary>
        private int _goalsHomeTeam;

        /// <summary>
        /// Nombre de buts marqués par l'équipe jouant à l'extérieur
        /// </summary>
        private int _goalsAwayTeam;

        public int GoalsHomeTeam
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

        public int GoalsAwayTeam
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

    }
}