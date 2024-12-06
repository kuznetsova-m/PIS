using System.ComponentModel;

namespace RoadmapApp.Enums
{
    public enum Purpose
    {
        [Description("Нет")]
        None = 0,

        [Description("Работа")]
        Work = 1,

        [Description("Длительное пребывание")]
        LongStay = 2
    }
}
