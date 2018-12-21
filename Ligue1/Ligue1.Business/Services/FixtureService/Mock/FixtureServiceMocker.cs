namespace Ligue1.Business.Services
{
    /// <summary>
    /// Mock du service <seealso cref="FixtureService"/>
    /// pour debug sans connexion aux web-services
    /// </summary>
    public class FixtureServiceMocker
    {
        /// <summary>
        /// Singleton
        /// </summary>
        private static FixtureServiceMocker _instance;

        /// <summary>
        /// Tag pour logger
        /// </summary>
        private const string TAG = "CompetitionFixturesServicesMocker";

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="activity"></param>
        //private FixtureServiceMocker(Activity activity)
        //{
        //    _activity = activity;
        //}

        ///// <summary>
        ///// Singleton
        ///// </summary>
        ///// <param name="activity"></param>
        ///// <returns></returns>
        //public static FixtureServiceMocker FixtureServiceMockerSession(Activity activity)
        //{
        //    if (_instance == null)
        //    {
        //        _instance = new FixtureServiceMocker(activity);
        //    }
        //    return _instance;
        //}

        /// <summary>
        /// Mock qui retourne les fixtures
        /// </summary>
        /// <returns></returns>
        //public List<Fixture> GetFixtures()
        //{
        //    Log.Debug(TAG, "GetFixtures");

        //    List<Fixture> result = new List<Fixture>();

        //    try
        //    {
        //        FixturesRootObject ro = new FixturesRootObject();
        //        AssetManager assets = _activity.Assets;

        //        StreamReader sr = new StreamReader(assets.Open("fixtures.json"));
        //        string jsonString = sr.ReadToEnd();
        //        ro = JsonConvert.DeserializeObject<FixturesRootObject>(jsonString);

        //        result = ro.Fixtures;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.Write(e);
        //    }
        //    return result;
        //}

    }
}