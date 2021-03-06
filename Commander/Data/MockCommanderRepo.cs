using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
             var commands = new List<Command>
            {
                new Command{Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "kettle and pan"},
                new Command{Id = 0, HowTo="Cut bread", Line="Get knife", Platform="knife and chopping board"},
                new Command{Id = 0, HowTo="Make cup of tea", Line="Plece teabag in cup", Platform="kettle and cup"}
            };

            return commands;
        }
        public Command GetCommandById(int id)
        {
            return new Command{Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "kettle and pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}