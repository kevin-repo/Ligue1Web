using Ligue1.Business.Entities;
using System.Collections.Generic;

namespace Ligue1.Business.Services
{
    interface IFixtureServiceMocker
    {
        /// <summary>
        /// Récupère les fixtures
        /// </summary>
        /// <returns></returns>
        List<Fixture> GetFixtures();
    }
}