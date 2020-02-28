using RecorderApi.Models;
using RecorderApi.Models.Session;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace RecorderApi.Services
{
    public class SessionService
    {
        private readonly IMongoCollection<Master> _sessions;

        public SessionService(IRecorderDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _sessions = database.GetCollection<Master>(settings.SessionsCollectionName);
        }

        public List<Master> Get() =>
            _sessions.Find(session => true).ToList();

        public Master Get(string id) =>
            _sessions.Find<Master>(session => session.Id == id).FirstOrDefault();

         public Master Create(Master session)
        {
            _sessions.InsertOne(session);
            return session;
        }

        public void Update(string id, Master sessionIn) =>
            _sessions.ReplaceOne(session => session.Id == id, sessionIn);

        public void Remove(Master sessionIn) =>
            _sessions.DeleteOne(session => session.Id == sessionIn.Id);

        public void Remove(string id) => 
            _sessions.DeleteOne(session => session.Id == id); 
    }
}