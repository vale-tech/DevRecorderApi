namespace RecorderApi.Models
{
    public class RecorderDatabaseSettings : IRecorderDatabaseSettings
    {
        public string SchedulesCollectionName { get; set; }

        public string SessionsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IRecorderDatabaseSettings
    {
        string SchedulesCollectionName { get; set; }

        string SessionsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}