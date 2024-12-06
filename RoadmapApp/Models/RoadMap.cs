using System.Collections.Generic;

namespace RoadmapApp.Models
{
    public class RoadMap
    {
        public List<RoadMapPoint> Points { get; set; } = new List<RoadMapPoint>();

        public RoadMap() { }

        public override string ToString()
        {
            if (Points.Count == 0) return "Дорожная карта пуста.";
            string result = "Дорожная карта:\r\n";
            foreach (var p in Points)
            {
                result += "- " + p.ToString() + "\r\n";
            }
            return result;
        }
    }
}
