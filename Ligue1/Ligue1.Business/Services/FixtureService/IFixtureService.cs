using Ligue1.Business.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ligue1.Business.Services
{
    internal interface IFixtureService : IService
    {
        /// <summary>
        /// R�cup�rer la liste de matchs d'une journ�e
        /// </summary>
        /// <param name="competitionId">Identifiant de la comp�tition</param>
        /// <param name="matchDay">num�ro de la journ�e</param>
        /// <returns>Liste de <seealso cref="Fixture" /></returns>
        Task<List<Fixture>> GetFixturesAsync(string competitionId, int matchDay);
    }
}