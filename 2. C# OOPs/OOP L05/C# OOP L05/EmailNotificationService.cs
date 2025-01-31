using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__OOP_L05.NotificationExample;

namespace C__OOP_L05
{
    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"📧 Email sent to {recipient}: {message}");
        }
    }
}
