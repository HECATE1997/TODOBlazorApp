namespace TodoAppBlazorServer.Services
{
    public class TodoService : ITodoService
    {
        private readonly IList<TodoItem> _todoItems = new List<TodoItem>();
        public TodoService()
        {
            _todoItems = new List<TodoItem>
            {
                new TodoItem("Learn Blazor"),
                new TodoItem("Build a Blazor app"),
                new TodoItem("Deploy the app")
            };
        }
        public void Add(TodoItem item)
        {
            _todoItems.Add(item);
        }
        public IEnumerable<TodoItem> GetAll()
        {
            return _todoItems.ToList();
        }
        public void Delete(TodoItem item)
        {
            _todoItems.Remove(item);
        }

        public void Complete(TodoItem item)
        {
            item.Completed = true;
        }

        public void Uncomplete(TodoItem item)
        {
            item.Completed = false;
        }
    }
}
