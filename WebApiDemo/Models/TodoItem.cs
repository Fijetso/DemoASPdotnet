namespace WebApiDemo.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        // public TodoItem(int id, string name, bool isComplete)
        // {
        //     this.Id = id;
        //     this.Name = name;
        //     this.IsComplete = isComplete;
        // }
    }
}