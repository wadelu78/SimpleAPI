using System.Collections.Generic;
using src.SimpleAPI.Models;

namespace src.SimpleAPI.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();

        Command GetCommandById(int id);
    }
}