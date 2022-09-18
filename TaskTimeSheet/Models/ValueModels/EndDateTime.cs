namespace TaskTimeSheet.Models
{
    // 終了時間を表す値モデル
    public class EndDateTime
    {
        private readonly DateTime endDateTime;

        public EndDateTime(in DateTime endDateTime)
        {
            this.endDateTime = endDateTime;
        }

        public DateTime GetEndDateTime()
        {
            return endDateTime;
        }
    }
}