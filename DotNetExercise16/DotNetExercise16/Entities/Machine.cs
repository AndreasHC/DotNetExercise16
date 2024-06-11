namespace DotNetExercise16.Entities
{
    public class Machine
    {
        public required string Name { get; set; }
        public required Guid Id { get; set; }
        public bool IsOnline { get; set; } = true;
        public List<Message> Messages { get; } = new List<Message> { };

        public void Send(string message)
        {
            string log;
            Random random = new Random();
            if (string.IsNullOrEmpty(message))
            {
                return;
            }
            if (message.ToLower() == "enable")
            {
                if (IsOnline)
                {
                    log = "Enable request rejected, already enabled";
                }
                else if (random.Next(2) == 0)
                {
                    log = "Enable request rejected, impossible";
                }
                else
                {
                    IsOnline = true;
                    log = "Enabled";
                }
            }
            else if(message.ToLower() == "disable")
            {
                if (!IsOnline)
                {
                    log = "Disable request rejected, already disabled";
                }
                else if (random.Next(2) == 0)
                {
                    log = "Disable request rejected, impossible";
                }
                else
                {
                    IsOnline = false;
                    log = "Disabled";
                }

            }
            else
            {
                log = $"Message ignored: {message}";
            }
            Messages.Add(new Message() { Content = log, Time = DateTime.Now});
        }
    }
}
