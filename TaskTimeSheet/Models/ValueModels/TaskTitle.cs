namespace TaskTimeSheet.Models
{
    // タスクのタイトルを表す値モデル
    public class TaskTitle
    {
        private readonly string Title;

        private TaskTitle(in string Title)
        {
            this.Title = Title;
        }

        public string GetTaskTitle()
        {
            return this.Title;
        }
    }
}