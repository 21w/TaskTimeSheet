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

        public TaskTitle SetTitle(in string Title)
        {
            return new TaskTitle(Title);
        }

        public string GetTaskTitle()
        {
            return this.Title;
        }
    }
}