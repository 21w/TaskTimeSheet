using System.Collections.ObjectModel;
namespace TaskTimeSheet.Models
{
    // 期間のリストを表すモデル
    public class PeriodModelListModel
    {
        private readonly List<PeriodModel> periodModelList;

        public PeriodModelListModel(in StartDateTime startDateTime)
        {
            // リストの生成
            periodModelList = new List<PeriodModel>();
            // 期間の生成
            PeriodModel newPeriodModel = new PeriodModel(startDateTime);

            // リストに期間を追加
            periodModelList.Add(newPeriodModel);
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