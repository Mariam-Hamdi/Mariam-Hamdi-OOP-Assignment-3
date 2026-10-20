using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ass_oop3.t1._1
{
    public interface INotification { void Send(string to, string message); }
    public class EmailNotification : INotification
    {
        public void Send(string to, string message) =>
            Console.WriteLine($"[email] {to}: {message}");
    }
    public class SmsNotification : INotification
    {
        public void Send(string to, string message) =>
            Console.WriteLine($"[sms] {to}: {message}");
    }
    // R6 New Notification 
    public class MassengerNotification : INotification
    {
        public void Send(string to, string message) =>
                 Console.WriteLine($"[massenger] {to}: {message}");
    }
    public class NotificationSender
    {
        private readonly INotification _notification;

        public NotificationSender(INotification notification)
        {
            _notification = notification;
        }
        public void Send(string to, string message)
        {
            _notification.Send(to, message);
        }
        public void SendUrgent(string to, string message)
        {
            _notification.Send(to, $"[URGENT] {message}");
        }
        public void SendScheduled(string to, string message, DateTime sendAt)
        {
            _notification.Send(to, $"[scheduled {sendAt:g}] {message}");
        }
        public void SendUrgentScheduled(string to, string message, DateTime sendAt)
        {
            _notification.Send(to, $"[URGENT scheduled {sendAt:g}] {message}");
        }

    }
}
