using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetcoreRabbitmq.Services
{
    public interface INotificationService
    {
        void NotifyUser(int fromId, int toId, string content);
    }
}
