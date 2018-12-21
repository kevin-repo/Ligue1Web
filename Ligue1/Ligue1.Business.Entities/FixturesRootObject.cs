using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ligue1.Business.Entities
{
    /// <summary>
    /// Représente un objet JSON conteneur des fixtures
    /// </summary>
    public class FixturesRootObject
    {
        [JsonProperty(PropertyName = "_links")]
        public object Links { get; set; }

        [JsonProperty(PropertyName = "fixtures")]
        public List<Fixture> Fixtures { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }
    }
}