using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using Ligue1.Business.Entities;
using Ligue1.Business.Common.Utils;

namespace Ligue1.Business.Services
{
    public class FixtureService : IFixtureService
    {
        /// <summary>
        /// Client Http
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Singleton
        /// </summary>
        private static FixtureService _instance;

        /// <summary>
        /// Tag pour logger
        /// </summary>
        private const string TAG = "CompetitionFixturesService";

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="httpClient">Client Http</param>
        private FixtureService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Singleton
        /// </summary>
        /// <param name="httpClient">Client Http</param>
        /// <returns>Unique instanciation</returns>
        public static FixtureService CompetitionFixturesServiceSession(HttpClient httpClient)
        {
            if (_instance == null)
            {
                _instance = new FixtureService(httpClient);
            }
            return _instance;
        }

        /// <summary>
        /// Récupère les fixtures correspondant à une compétition
        /// </summary>
        /// <param name="competitionId">identifiant de la compétition</param>
        /// <param name="matchDay">numéro de la journée</param>
        /// <returns>Liste de fixtures</returns>
        public async Task<List<Fixture>> GetFixturesAsync(string competitionId, int matchDay)
        {
            //Log.Debug(TAG, "GetFixturesAsync"); // TODO Ajouter Logger

            string url = string.Format(GetUrl(), competitionId, matchDay);

            var result = await HttpClientExtensions.GetAsync<FixturesRootObject>(_httpClient, url);

            return result.Fixtures;
        }

        /// <summary>
        /// Récupère l'url
        /// </summary>
        /// <returns>Url</returns>
        public string GetUrl()
        {
            return Constants.Url.URL_WEB_SERVICE_COMPETITIONS_FIXTURES_MATCH_DAY;
        }

    }
}