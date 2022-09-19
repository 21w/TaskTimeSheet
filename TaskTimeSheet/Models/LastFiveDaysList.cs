using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TaskTimeSheet.Models.ValueModels;

namespace TaskTimeSheet.Models
{
    // 直近５日間を表すモデル
    class LastFiveDaysList
    {
        private readonly List<Days> lastFiveDaysList;

        public LastFiveDaysList()
        {
            // 今日
            Days today = new Days(DateTime.Today);
            // 昨日
            Days yesterday = new Days(today.GetDateTime().AddDays(-1));
            // 一昨日
            Days twoDaysBefore = new Days(today.GetDateTime().AddDays(-2));
            // 明日
            Days tomorrow = new Days(today.GetDateTime().AddDays(1));
            // 明後日
            Days twoDaysAfter = new Days(today.GetDateTime().AddDays(2));

            lastFiveDaysList = new List<Days>() { twoDaysBefore, yesterday, today, tomorrow, twoDaysAfter };
        }

        public ReadOnlyCollection<Days> GetLastFiveDaysList()
        {
            return this.lastFiveDaysList.AsReadOnly();
        }
    }
}