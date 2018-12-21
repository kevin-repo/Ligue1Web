using Ligue1.Business.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ligue1.Business.Services
{
    internal interface IFixtureService : IService
    {
        /// <summary>
        /// Récupérer la liste de matchs d'une journée
        /// </summary>
        /// <param name="competitionId">Identifiant de la compétition</param>
        /// <param name="matchDay">numéro de la journée</param>
        /// <returns>Liste de <seealso cref="Fixture" /></returns>
        Task<List<Fixture>> GetFixturesAsync(string competitionId, int matchDay);
    }
}