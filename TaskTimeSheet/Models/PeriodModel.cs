namespace TaskTimeSheet.Models
{
    // 期間を表すモデル
    public class PeriodModel
    {
        private readonly StartDateTime startDateTime;
        private readonly EndDateTime endDateTime;

        public PeriodModel(in StartDateTime startDateTime, in EndDateTime endDateTime)
        {
            this.startDateTime = startDateTime;
            this.endDateTime = endDateTime;
        }

        public StartDateTime GetStartDateTime()
        {
            return this.startDateTime;
        }

        public EndDateTime GetEndDateTime()
        {
            return this.endDateTime;
        }
    }
}