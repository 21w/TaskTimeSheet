namespace TaskTimeSheet.Models
{
    // 開始時間を表す値モデル
    public class StartDateTime
    {
        private readonly DateTime startDateTime;

        private StartDateTime(in DateTime startDateTime)
        {
            this.startDateTime = startDateTime;
        }

        public StartDateTime SetStartDateTime(in DateTime startDateTime)
        {
            return new StartDateTime(startDateTime);
        }

        public DateTime GetStartDateTime()
        {
            return startDateTime;
        }
    }
}