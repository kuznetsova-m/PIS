using System;
using RoadmapApp.Models;

namespace RoadmapApp.Rules
{
    public class Rule1 : IRule
    {
        public string GetMessage(User user)
        {
            DateTime baseDate = user.PatentDate.HasValue && user.PatentDate.Value > user.EntryDate
                ? user.PatentDate.Value
                : user.EntryDate;

            DateTime deadline = baseDate.AddDays(30);

            return $"Вам необходимо обратиться в подразделения по вопросам миграции МВД России по вашему месту нахождения либо в ФГУП «ПВС» МВД России в течение 30 календарных дней со дня въезда или при обращении за патентом/разрешением на работу. (до {deadline.ToShortDateString()}).";
        }
    }
}
