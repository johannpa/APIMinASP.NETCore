using SportCoaching.API.Models;
using System.Collections.Generic;

namespace SportCoaching.API
{
    public class AthletesDataStore
    {
        public static AthletesDataStore Current { get;} = new AthletesDataStore();
        public List<Athlete> Athletes { get; set; }
        public AthletesDataStore()
        {
            Athletes = new List<Athlete>()
            {
                new Athlete()
                {
                    Id = 1,
                    Name = "Alice Thomas",
                    Age = 23,
                    Goals = new List<Goal>()
                    { 
                        new Goal() 
                        {
                            Id=1,
                            Name = "Weight loss",
                            Description = "I want to lose weight"
                        },
                        new Goal()
                        {
                            Id = 2,
                            Name = "Endurance",
                            Description = "I want to become more enduring"
                        }
                    }
                },
                new Athlete()
                {
                    Id = 2,
                    Name = "Eric Mars",
                    Age = 25,
                    Goals = new List<Goal>()
                    {
                        new Goal()
                        {
                            Id = 3,
                            Name = "Mobility",
                            Description = "I want to become more flexible"
                        },
                        new Goal()
                        {
                            Id = 4,
                            Name = "weight gain",
                            Description = "I want to gain muscle"
                        }
                    }
                },
                new Athlete()
                {
                    Id = 3,
                    Name = "Bruno Martin",
                    Age = 18,
                    Goals = new List<Goal>()
                    {
                        new Goal()
                        {
                            Id = 5,
                            Name = "Strength",
                            Description = "I want to get stronger"
                        }
                    }
                }
            };
        }
    }
}
