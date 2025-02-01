using System;

namespace EventEase.Models
{
    public class AttendanceModel
    {
        public int EventId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; }
    }
}