using System.Threading.Tasks;
using Ligue1.Business.Entities;

namespace Ligue1.Business.Services
{
    interface ICompetitionService : IService
    {
        /// <summary>
        /// R�cup�re une comp�tition par son identifiant
        /// </summary>
        /// <param name="id">Identifiant de la comp�tition</param>
        /// <returns>Comp�tition correspondante � l'identifiant</returns>
        Task<CompetitionRootObject> GetCompetition(string id);
    }
}