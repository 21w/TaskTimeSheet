namespace TaskTimeSheet.Models.ValueModels
{
    // タスクを表すモデル
    public class TaskModel
    {
        private readonly TaskTitle title;
        private readonly PeriodModelListModel periodModelListModel;

        public TaskModel(in TaskTitle title, in StartDateTime startDateTime)
        {
            this.title = title;
            this.periodModelListModel = new PeriodModelListModel(startDateTime);
        }

        // タイトルの取得
        public string getTitle()
        {
            return this.title.GetTaskTitle();
        }


    }
}