using System;
namespace TaskTimeSheet.Models.ValueModels
{
    // 直近日付を表す値モデル
    class Days
    {
        private readonly DateTime days;
        public Days(in DateTime days)
        {
            this.days = days;
        }

        public DateTime GetDateTime()
        {
            return this.days;
        }
    }
}