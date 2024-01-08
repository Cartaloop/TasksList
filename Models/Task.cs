using TasksList.Models.Enums;

namespace TasksList.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public EnumStatus Status { get; set; }
    }
}
