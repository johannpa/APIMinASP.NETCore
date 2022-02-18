using System.Collections.Generic;

namespace SportCoaching.API.Models
{
    public class Athlete
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int NumberOfGoals { get { return Goals.Count; } }

        public ICollection<Goal> Goals { get; set; } = new List<Goal>();
    }
}
