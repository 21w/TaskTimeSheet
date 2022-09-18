namespace TaskTimeSheet.Models
{
    public class EndDateTime
    {
        private readonly DateTime endDateTime;

        private EndDateTime(in DateTime endDateTime)
        {
            this.endDateTime = endDateTime;
        }

        public EndDateTime SetEndDateTime(in DateTime endDateTime)
        {
            return new EndDateTime(endDateTime);
        }

        public DateTime GetEndDateTime()
        {
            return endDateTime;
        }
    }
}