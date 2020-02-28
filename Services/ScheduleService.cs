using RecorderApi.Models;
using RecorderApi.Models.Schedule;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace RecorderApi.Services
{
    public class ScheduleService
    {
        private readonly IMongoCollection<Schedule> _schedules;

        public ScheduleService(IRecorderDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _schedules = database.GetCollection<Schedule>(settings.SchedulesCollectionName);
        }

        public List<Schedule> Get() =>
            _schedules.Find(schedule => true).ToList();

        public Schedule Get(string id) =>
            _schedules.Find<Schedule>(schedule => schedule.ScheduleId == id).FirstOrDefault();

        public Schedule Create(Schedule schedule)
        {
            _schedules.InsertOne(schedule);
            return schedule;
        }

        public void Update(string id, Schedule scheduleIn) =>
            _schedules.ReplaceOne(schedule => schedule.ScheduleId == id, scheduleIn);

        public void Remove(Schedule scheduleIn) =>
            _schedules.DeleteOne(schedule => schedule.ScheduleId == scheduleIn.ScheduleId);

        public void Remove(string id) => 
            _schedules.DeleteOne(schedule => schedule.ScheduleId == id);
    }
}