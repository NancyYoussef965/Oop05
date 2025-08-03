using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop05
{
    internal class EmailNotificationService:INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending EMAIL to {recipient}: {message}");
        }
    }
}
