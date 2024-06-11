namespace DotNetExercise16.Entities
{
    public class Machine
    {
        public required string Name { get; set; }
        public required Guid Id { get; set; }
        public bool IsOnline { get; set; } = true;
        public List<Message> Messages { get; } = new List<Message> { };
    }
}
