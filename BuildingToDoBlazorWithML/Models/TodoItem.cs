namespace BuildingToDoBlazorWithML.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string? PredictedCategory { get; set; } // "Home" or "Work"
    }
}
