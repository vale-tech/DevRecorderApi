using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RecorderApi.Models.Session;
using RecorderApi.Services;
using Microsoft.Extensions.Logging;

namespace RecorderApi.Controllers
{
    [Route("data/[controller]")]
    [ApiController]
    public class SessionsController : ControllerBase
    {
        private readonly ILogger<SessionsController> _logger;
        private readonly SessionService _sessionService;

        public SessionsController(ILogger<SessionsController> logger, SessionService sessionService)
        {
             _logger = logger;
            _sessionService = sessionService;
        }

       // GET .../test
       [HttpGet("test", Name = "TestSession")]
       public IActionResult TestSession()
       {
           _logger.LogInformation("Working fine here");
           return Ok("Working fine here.");
       } 
       
       // GET .../schedules : Request all Schedules
       [HttpGet]
        public ActionResult<List<Master>> Get() =>
            _sessionService.Get();

        // GET ../schedule/{id} : Get a schedule
        [HttpGet("master/{id}", Name = "GetSession")]
        public ActionResult<Master> GetSession(string id)
        {
            var session = _sessionService.Get(id);

            if (session == null)
            {
                _logger.LogWarning("Session id invalid.");
                return NotFound();
            }

            return session;
        }

        [HttpPost]
        public ActionResult<Master> Create(Master session)
        {
            session.MasterId = Guid.NewGuid().ToString();
            _sessionService.Create(session);

            _logger.LogInformation($"Created session: {session.MasterId}");

            return CreatedAtRoute("GetSession", new { id = session.Id.ToString() }, session);
        }
    }
}
