using System;
using RoadmapApp.Enums;

namespace RoadmapApp.Rules
{
    public static class RuleFactory
    {
        public static IRule GetRule(Purpose purpose)
        {
            switch (purpose)
            {
                case Purpose.Work:
                    return new Rule1();
                case Purpose.LongStay:
                    return new Rule2();
                default:
                    throw new ArgumentException("Неизвестная цель визита");
            }
        }
    }
}
