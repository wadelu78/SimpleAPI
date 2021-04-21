using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using src.SimpleAPI.Data;
using src.SimpleAPI.Models;

namespace src.SimpleAPI.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAllCommands()
        {
            var allCommands = _repository.GetAllCommands();
            //return Ok(allCommands);
            return new string[] {"value1", "value2"};
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<string> GetCommandById (int id)
        {
            var commandItem = _repository.GetCommandById(id);
            //return Ok(commandItem);
            return "Something else";
        }
    }
}