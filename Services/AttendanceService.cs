using System;
using System.Collections.Generic;
using System.Linq;
using EventEase.Models;

namespace EventEaseApp.Services
{
    public class AttendanceService
    {
        private readonly List<AttendanceModel> _attendances = new();

        public void RegisterAttendance(int eventId, string userName)
        {
            _attendances.Add(new AttendanceModel
            {
                EventId = eventId,
                UserName = userName,
                RegistrationDate = DateTime.Now
            });
        }

        public List<AttendanceModel> GetAttendances(int eventId)
        {
            return _attendances.Where(a => a.EventId == eventId).ToList();
        }
    }
}