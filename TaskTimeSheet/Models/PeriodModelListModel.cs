using System.Collections.ObjectModel;
namespace TaskTimeSheet.Models
{
    // 期間のリストを表すモデル
    public class PeriodModelListModel
    {
        private List<PeriodModel> periodModelList;

        private PeriodModelListModel()
        {
            if (this.periodModelList == null)
            {
                this.periodModelList = new List<PeriodModel>();
            }
        }

        public List<PeriodModel> AddPeriodModel(in PeriodModel periodModel)
        {
            periodModelList.Add(periodModel);

            return periodModelList;
        }

        public ReadOnlyCollection<PeriodModel> GetPeriodModelList()
        {
            return this.periodModelList.AsReadOnly();
        }
    }
}