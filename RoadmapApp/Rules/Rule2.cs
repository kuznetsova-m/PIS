using System;
using RoadmapApp.Models;

namespace RoadmapApp.Rules
{
    public class Rule2 : IRule
    {
        public string GetMessage(User user)
        {
            DateTime deadline = user.EntryDate.AddDays(90);
            return $"Вам необходимо обратиться в подразделения по вопросам миграции МВД России по вашему месту нахождения либо в ФГУП «ПВС» МВД России в течение 90 календарных дней со дня въезда. (до {deadline.ToShortDateString()}).";
        }
    }
}
