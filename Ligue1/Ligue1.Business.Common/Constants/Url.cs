namespace Ligue1.Business.Constants
{
    /// <summary>
    /// Url d'appel aux web-services de l'application
    /// </summary>
    public static class Url
    {
        /// <summary>
        /// Url du web-service
        /// </summary>
        public const string URL_WEB_SERVICE = "http://api.football-data.org/v1/";

        /// <summary>
        /// Url des rencontres
        /// </summary>
        public const string URL_WEB_SERVICE_COMPETITIONS_FIXTURES = URL_WEB_SERVICE + "competitions/{0}/fixtures";

        /// <summary>
        /// Url d'une compétition
        /// </summary>
        public const string URL_WEB_SERVICE_COMPETITION = URL_WEB_SERVICE + "competitions/{0}";

        /// <summary>
        /// Url des rencontre d'une journée 
        /// </summary>
        public const string URL_WEB_SERVICE_COMPETITIONS_FIXTURES_MATCH_DAY = URL_WEB_SERVICE + "competitions/{0}/fixtures?matchday={1}";

        // TODO TO DELETE
        public const string LIGUE_1_COMPETITION_ID = "450";
    }
}