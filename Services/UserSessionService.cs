using System;

namespace EventEaseApp.Services
{
    public class UserSessionService
    {
        public string UserName { get; set; } = string.Empty;
        public DateTime SessionStartTime { get; private set; }

        public UserSessionService()
        {
            SessionStartTime = DateTime.Now;
        }

        public void SetUserName(string userName)
        {
            UserName = userName;
        }
    }
}

