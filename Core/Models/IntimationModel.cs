using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class IntimationModel
    {
        public Int64 TemplateId { get; set; }
        public string Templates { get; set; }
        public Int32 ModeId { get; set; }
        public string ModeName { get; set; }
        public Int64 ModuleId { get; set; }
        public string ModuleName { get; set; }
        public Int32 EventId { get; set; }
        public string EventName { get; set; }

    }

    public class IntimationScheduleModel : CommonEntityModel
    {
        public Int64 Id { get; set; }
        public Int64 ModuleId { get; set; }
        public Int64 EventId { get; set; }
        public Int64 ModeID { get; set; }
        public List<int> RoleID { get; set; }
        public Int64 TemplateId { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public string MonthlyRepeatType { get; set; }
        public List<string> clickedWeekButtons { get; set; }
        public Int32 RepeatType { get; set; }
        public Int32 RepeatTypeCustom { get; set; }
        public string RepeatTypeName { get; set; }
        public string RepeatTypeCustomName { get; set; }
        public Int32? RepeatInterval { get; set; }
        public Int16 IsReminderEnd { get; set; }
        public Int32 ReminderOccurance { get; set; }
        public Int32[] UploadRefId { get; set; }
        public string ReminderEndDate { get; set; }
        public Int16 Status { get; set; }
        public Int32 NoOfContacts { get; set; }
        public Int32 ScheduleType { get; set; }
        public Int32 IsExternal { get; set; }
    }
}
