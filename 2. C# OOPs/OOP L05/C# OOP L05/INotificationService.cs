using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_L05
{
    namespace NotificationExample
    {        public interface INotificationService
        {
            void SendNotification(string recipient, string message);
        }
    }
}
