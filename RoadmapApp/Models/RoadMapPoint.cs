using System;

namespace RoadmapApp.Models
{
    public class RoadMapPoint
    {
        public string Description { get; set; }
        public DateTime Deadline { get; set; }

        public RoadMapPoint(string description, DateTime deadline)
        {
            Description = description;
            Deadline = deadline;
        }

        public override string ToString()
        {
            return Description; 
        }
    }
}
