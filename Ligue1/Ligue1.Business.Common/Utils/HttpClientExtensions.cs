using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Ligue1.Business.Common.Utils
{
    public static class HttpClientExtensions
    {
        /// <summary>
        /// Libellé méthode de type GET
        /// </summary>
        public const string GET_METHOD = "GET";

        /// <summary>
        /// Récupère une liste d'objets selon une requête exécutée en mode asynchrone
        /// </summary>
        /// <typeparam name="T">type de l'objet souhaité</typeparam>
        /// <param name="client">client http</param>
        /// <param name="url">url du web service</param>
        /// <returns>Liste d'objets</returns>
        public static async Task<T> GetAsync<T>(this HttpClient client, string url)
        {
            var httpRequest = new HttpRequestMessage(new HttpMethod(GET_METHOD), url);

            client.Timeout = TimeSpan.FromSeconds(30);
            
            var response = await client.SendAsync(httpRequest);

            var jsonString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<T>(jsonString);

            return result;
        }

        /// <summary>
        /// Récupère en convertissant en chaine de caractères le JSON retourné
        /// </summary>
        /// <param name="client">client http</param>
        /// <param name="url">url du web service</param>
        /// <returns>Chaine de caractères représentant le résultat de la requête</returns>
        public static async Task<string> GetStringAsync(this HttpClient client, string url)
        {
            var httpRequest = new HttpRequestMessage(new HttpMethod(GET_METHOD), url);
 
            var response = client.SendAsync(httpRequest).Result;

            var jsonString = await response.Content.ReadAsStringAsync();

            return jsonString;
        }

    }
}