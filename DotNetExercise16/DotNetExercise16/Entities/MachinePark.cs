namespace DotNetExercise16.Entities
{
    public class MachinePark
    {
        public List<Machine> Machines {init; get;} = new List<Machine>();
        public MachinePark()
        {
            Machines.Add(new Machine()
            {
                Name = "The one by the door",
                Id = Guid.NewGuid()
            });
            Machines.Add(new Machine()
            {
                Name = "The one behind the bookshelf",
                Id = Guid.NewGuid(),
                IsOnline = false
            });
            Machines[1].Messages.Add(
            new Message()
            {
                Time = DateTime.Now,
                Content = "Turned off anonymously with emergency button"
            });
        }
    }
}
