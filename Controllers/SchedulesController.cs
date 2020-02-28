using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RecorderApi.Models.Schedule;
using RecorderApi.Services;
using Microsoft.Extensions.Logging;

namespace RecorderApi.Controllers
{
    [Route("data/[controller]")]
    [ApiController]
    public class SchedulesController : ControllerBase
    {
       private readonly ILogger<SchedulesController> _logger;
       private readonly ScheduleService _scheduleService;

        public SchedulesController(ILogger<SchedulesController> logger, ScheduleService scheduleService)
        {
            _logger = logger;
            _scheduleService = scheduleService;
        }

       [HttpGet("test", Name = "TestSchedule")]
       public IActionResult TestSchedule()
       {
           _logger.LogInformation("Working fine here");
           return Ok("Working fine here.");
       } 
       
       [HttpGet]
        public ActionResult<List<Schedule>> Get() =>
            _scheduleService.Get();

        [HttpGet("schedule/{id}", Name = "GetSchedule")]
        public ActionResult<Schedule> GetSchedule(string id)
        {
            var schedule = _scheduleService.Get(id);

            if (schedule == null)
            {
                _logger.LogWarning("Schedule id invalid.");
                return NotFound();
            }

            return schedule;
        }
       
        // GET .../schedules/location/{location} : Request Schedules by Location name
        // GET .../schedules/master/{id} : Request Schedules by Master ID
        // GET .../schedules/{year}/{month}/{day} : Request schedules by year, month and day

        [HttpPost]
        public ActionResult<Schedule> Create(Schedule schedule)
        {
            schedule.ScheduleId = Guid.NewGuid().ToString();
            _scheduleService.Create(schedule);

            _logger.LogInformation($"Created schedule: {schedule.ScheduleId}");

            return CreatedAtRoute("GetSchedule", new { id = schedule.ScheduleId.ToString() }, schedule);
        }
    }
}
