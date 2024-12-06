using RoadmapApp.Models;

namespace RoadmapApp.Rules
{
    public interface IRule
    {
        string GetMessage(User user);
    }
}
