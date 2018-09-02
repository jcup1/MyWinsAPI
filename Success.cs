using System.ComponentModel.DataAnnotations;

namespace API
{

    public class Success
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string DateStarted { get; set; }
        public string DateEnded { get; set; }
        public string Importance { get; set; }
    }
}