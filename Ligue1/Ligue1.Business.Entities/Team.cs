namespace Ligue1.Business.Entities
{
    /// <summary>
    /// Equipe
    /// </summary>
    public class Team
    {
        /// <summary>
        /// Nom de l'équipe
        /// </summary>
        private string _name;

        public Team() { }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

    }
}