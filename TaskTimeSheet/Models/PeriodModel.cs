namespace TaskTimeSheet.Models
{
    // 期間を表すモデル
    public class PeriodModel
    {
        private readonly StartDateTime startDateTime;
        private readonly EndDateTime endDateTime;

        public PeriodModel(in StartDateTime startDateTime)
        {
            this.startDateTime = startDateTime;
            this.endDateTime = new EndDateTime(new DateTime(9999, 12, 31, 0, 0, 0));
        }
    }
}