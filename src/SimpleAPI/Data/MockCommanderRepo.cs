using System.Collections.Generic;
using src.SimpleAPI.Models;

namespace src.SimpleAPI.Data
{
  public class MockCommanderRepo : ICommanderRepo
  {
    public IEnumerable<Command> GetAllCommands()
    {
      var commands = new List<Command>{
          new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
          new Command{Id=1, HowTo="Cut bread", Line="Get a knife", Platform="Knife and chopping board"},
          new Command{Id=2, HowTo="Make a cup of tea", Line="fetch the tea bag", Platform="Kettle & kitchen & cup"}
      };

      return commands;
    }

    public Command GetCommandById(int id)
    {
      return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"};
    }
  }
}